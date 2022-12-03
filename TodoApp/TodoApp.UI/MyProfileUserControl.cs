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

        private void MyProfileUserControl_Load(object sender, EventArgs e)
        {
            firstNameValue.Text = _logedInUser.FirstName;
            lastNameValue.Text = _logedInUser.LastName;
            emailValue.Text = _logedInUser.Email;

            //TODO -- Write GetSingleUser funcionality...
        }

        private void editUserBtn_Click(object sender, EventArgs e)
        {
            if (FieldsAreNotEmpty() && EmailIsValid() && FieldsAreText())
            {
                MessageBox.Show("EDIT");
                //TODO -- User edit functionality...
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
