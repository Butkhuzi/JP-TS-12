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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            titleValue.Text = string.Empty;
            descriptionValue.Text = string.Empty;
            startDateValue.Value = DateTime.Now;
            dueDateValue.Value = DateTime.Now;
            statusValue.Text = string.Empty;
            priorityValue.Text = string.Empty;
        }

        private void editTodoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxesAreValid() && DateTimesAreValid() && StatusIsValid() && PriorityIsValid())
                {
                    MessageBox.Show("EDIT");
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
    }
}
