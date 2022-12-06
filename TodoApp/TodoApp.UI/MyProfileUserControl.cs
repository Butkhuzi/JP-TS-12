using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo.Library;
using TodoApp.Services;

namespace TodoApp.UI
{
    public partial class MyProfileUserControl : UserControl
    {
        private readonly UserModel _logedInUser = new();

        public MyProfileUserControl(UserModel logedInUser)
        {
            InitializeComponent();
            _logedInUser = logedInUser;
        }

        private async void MyProfileUserControl_Load(object sender, EventArgs e)
        {
            var user = await GlobalConfig.DataConnection.GetSingleUserAsync(_logedInUser);

            firstNameValue.Text = user.FirstName;
            lastNameValue.Text = user.LastName;
            emailValue.Text = user.Email;
        }

        private async void editUserBtn_Click(object sender, EventArgs e)
        {
            if (FieldsAreNotEmpty() && EmailIsValid() && FieldsAreText())
            {
                UserModel userToEdit = new()
                {
                    UserId = _logedInUser.UserId,
                    FirstName = firstNameValue.Text,
                    LastName = lastNameValue.Text,
                    Email = emailValue.Text
                };

                await GlobalConfig.DataConnection.EditUseAsync(userToEdit);
                await GlobalConfig.DataConnection.GetSingleUserAsync(_logedInUser);

                DashboardForm dashboardForm = new(userToEdit);

                MessageBox.Show("თქვენს მიერ შემოყვანილი მონაცემები წარმატებით შეიცვალა", "მონაცემები წარმატებით დარედაქტირდა", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("თქვენს მიერ შემოყვანილი მონაცემები არასწორია", "მონაცემები არასწორია", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool FieldsAreNotEmpty() => !string.IsNullOrWhiteSpace(firstNameValue.Text) && !string.IsNullOrWhiteSpace(lastNameValue.Text) && !string.IsNullOrWhiteSpace(emailValue.Text);
        private bool EmailIsValid() => emailValue.Text.Contains('@') && emailValue.Text.Contains('.');
        private bool FieldsAreText() => firstNameValue.Text.All(x => char.IsLetter(x)) && lastNameValue.Text.All(x => char.IsLetter(x));

    }
}
