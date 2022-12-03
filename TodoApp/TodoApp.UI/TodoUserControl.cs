using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo.Library;
using TodoApp.Services;

namespace TodoApp.UI
{
    public partial class TodoUserControl : UserControl
    {
        private UserModel _loggedInUser = new();
        private List<TodoModel> allTodos = new();

        public TodoUserControl(UserModel loggedInUser)
        {
            InitializeComponent();
            _loggedInUser = loggedInUser;
        }

        private async void TodoUserControl_Load(object sender, EventArgs e)
        {
            try
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.

                allTodos = await GlobalConfig.DataConnection.GetAllTodosPerUserAsync(_loggedInUser);

                todoListBox.DataSource = allTodos;
                titleValue.Text = allTodos[todoListBox.SelectedIndex].Title;
                descriptionValue.Text = allTodos[todoListBox.SelectedIndex].Description;
                startDateValue.Value = allTodos[todoListBox.SelectedIndex].StartDate;
                dueDateValue.Value = allTodos[todoListBox.SelectedIndex].DueDate;
                statusValue.Text = allTodos[todoListBox.SelectedIndex].Status;
                priorityValue.Text = allTodos[todoListBox.SelectedIndex].Priority;

#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
            catch
            {
            }
        }

        private void todoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                titleValue.Text = allTodos[todoListBox.SelectedIndex].Title;
                descriptionValue.Text = allTodos[todoListBox.SelectedIndex].Description;
                startDateValue.Value = allTodos[todoListBox.SelectedIndex].StartDate;
                dueDateValue.Value = allTodos[todoListBox.SelectedIndex].DueDate;
                statusValue.Text = allTodos[todoListBox.SelectedIndex].Status;
                priorityValue.Text = allTodos[todoListBox.SelectedIndex].Priority;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearFormBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            titleValue.Text = string.Empty;
            descriptionValue.Text = string.Empty;
            startDateValue.Value = DateTime.Now;
            dueDateValue.Value = DateTime.Now;
            statusValue.Text = string.Empty;
            priorityValue.Text = string.Empty;
        }

        private async void editTodoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxesAreValid() && DateTimesAreValid() && StatusIsValid() && PriorityIsValid())
                {

                    DialogResult editDialog = MessageBox.Show("ნამდვილად გსურთ მონაცემების რედაქტირება?", "მონაცემების რედაქტირება", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (editDialog == DialogResult.Yes)
                    {
                        TodoModel todoToEdit = new()
                        {
                            TodoId = allTodos[todoListBox.SelectedIndex].TodoId,
                            Title = titleValue.Text,
                            Description = descriptionValue.Text,
                            StartDate = startDateValue.Value,
                            DueDate = dueDateValue.Value,
                            Status = statusValue.Text,
                            Priority = priorityValue.Text
                        };

                        await GlobalConfig.DataConnection.EditTodoAsync(todoToEdit);
                        //Real time data refresh
                        allTodos = await GlobalConfig.DataConnection.GetAllTodosPerUserAsync(_loggedInUser);
                        todoListBox.DataSource = allTodos;

                        MessageBox.Show("თქვენს მიერ შემოყვანილი მონაცემები წარმატებით შეიცვალა", "მონაცემები დარედაქტირდა", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    }
                }
                else
                {
                    MessageBox.Show("თქვენს მიერ შემოყვანილი მონაცემები არასწორია", "მონაცემები არასწორია", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool TextBoxesAreValid()
        {
            bool result = true;

            if (string.IsNullOrWhiteSpace(titleValue.Text) || string.IsNullOrWhiteSpace(descriptionValue.Text))
            {
                result = false;
            }

            return result;
        }

        private bool DateTimesAreValid()
        {
            bool result = false;
            if (startDateValue.Value <= dueDateValue.Value)
            {
                result = true;
            }

            return result;
        }

        private bool StatusIsValid()
        {
            bool result = false;

            if (string.IsNullOrWhiteSpace(statusValue.Text))
            {
                return result;
            }

            if (statusValue.Text == "შესასრულებელი" || statusValue.Text == "მიმდინარე" || statusValue.Text == "შესრულებული")
            {
                result = true; 
            }

            return result;
        }

        private bool PriorityIsValid()
        {
            bool result = false;

            if (string.IsNullOrWhiteSpace(priorityValue.Text))
            {
                return result;
            }

            if (priorityValue.Text == "დაბალი" || priorityValue.Text == "საშუალო" || priorityValue.Text == "მაღალი" || priorityValue.Text == "გადაუდებელი")
            {
                result = true;
            }

            return result;
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxesAreValid() && DateTimesAreValid() && StatusIsValid() && PriorityIsValid())
                {

                    DialogResult addDialog = MessageBox.Show("ნამდვილად გსურთ მონაცემების დამატება?", "მონაცემების დამატება", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (addDialog == DialogResult.Yes)
                    {
                        TodoModel todoToAdd = new()
                        {
                            Title = titleValue.Text,
                            Description = descriptionValue.Text,
                            StartDate = startDateValue.Value,
                            DueDate = dueDateValue.Value,
                            Status = statusValue.Text,
                            Priority = priorityValue.Text,
                            UserId = _loggedInUser.UserId
                        };

                        //Real time data refresh
                        await GlobalConfig.DataConnection.AddTodoAsync(todoToAdd);
                        allTodos = await GlobalConfig.DataConnection.GetAllTodosPerUserAsync(_loggedInUser);
                        todoListBox.DataSource = allTodos;

                        MessageBox.Show("თქვენს მიერ შემოყვანილი მონაცემები წარმატებით დაემატა", "მონაცემების დამატება", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("თქვენს მიერ შემოყვანილი მონაცემები არასწორია", "მონაცემები არასწორია", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void deletePicture_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult deleteDialog = MessageBox.Show("ნამდვილად გსურთ საქმის წაშლა?", "საქმის წაშლა", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (deleteDialog == DialogResult.Yes)
                {
                    TodoModel todoToDelete = new()
                    {
                        TodoId = allTodos[todoListBox.SelectedIndex].TodoId,
                        Title = titleValue.Text,
                        Description = descriptionValue.Text,
                        StartDate = startDateValue.Value,
                        DueDate = dueDateValue.Value,
                        Status = statusValue.Text,
                        Priority = priorityValue.Text
                    };

                    await GlobalConfig.DataConnection.DeleteTodoAsync(todoToDelete);
                    //Real time data refresh

                    allTodos = await GlobalConfig.DataConnection.GetAllTodosPerUserAsync(_loggedInUser);
                    todoListBox.DataSource = allTodos;
                    ClearForm();
                    MessageBox.Show("თქვენს მიერ არჩეული საქმე წარმატებით წაიშალა", "მონაცემები წაიშალა", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
            }
        }
    }
}
