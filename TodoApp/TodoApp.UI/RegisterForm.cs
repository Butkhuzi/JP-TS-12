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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private async void registerBtn_Click(object sender, EventArgs e)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            UserModel newUser = new()
            {
                FirstName = firstNameValue.Text,
                LastName = lastNameValue.Text,
                Email = emailValue.Text
            };

            if (FieldsAreNotEmpty() && EmailIsValid() && FieldsAreText())
            {
                if (await EmailIsUnique())
                {
                    await GlobalConfig.DataConnection.RegisterUserAsync(newUser);
                    MessageBox.Show("მომხმარებელი წარმატებით დარეგისტრირდა", "მომხმარებელი დარეგისტრირდა", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                else
                {
                    MessageBox.Show("თქვენს მიერ შემოყვანილი ელ-ფოსტა უკვე რეგისტრირებულია", "მომხმარებელი არ არის უნიკალური", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("თქვენს მიერ შემოყვანილი მონაცემები არასწორია", "მონაცემები არასწორია", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference. 
        }
        private async Task<bool> EmailIsUnique()
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.

            var allUsers = await GlobalConfig.DataConnection.GetAllUsersAsync();

            if(allUsers.Any(user => user.Email.Equals(emailValue.Text,StringComparison.OrdinalIgnoreCase)))
            {
                return false;
            }
            return true;

#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
        private bool FieldsAreNotEmpty() => !string.IsNullOrWhiteSpace(firstNameValue.Text) && !string.IsNullOrWhiteSpace(lastNameValue.Text) && !string.IsNullOrWhiteSpace(emailValue.Text);
        private bool EmailIsValid() => emailValue.Text.Contains('@') && emailValue.Text.Contains('.');
        private bool FieldsAreText() => firstNameValue.Text.All(x => char.IsLetter(x)) && lastNameValue.Text.All(x => char.IsLetter(x));
    }
}
