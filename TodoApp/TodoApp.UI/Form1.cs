using Todo.Library;
using TodoApp.Services;

namespace TodoApp.UI
{
    public partial class Form1 : Form
    {
        private UserModel _loggedInUser = new();
        public Form1()
        {
            InitializeComponent();
        }
        private void registerLink_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.

            if (FieldsAreNotEmpty() && EmailIsValid())
            {
                if (await UserExists())
                {
                    _loggedInUser = await GlobalConfig.DataConnection.LoginUserAsync(emailValue.Text);
                    DashboardForm dashboardForm = new(_loggedInUser);
                    dashboardForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("თქვენს მიერ შემოყვანილი მონაცემები არასწორია", "მომხმარებელი ვერ მოიძებნა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("თქვენს მიერ შემოყვანილი მონაცემები არასწორია", "მომხმარებელი არასწორია", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
        private async Task<bool> UserExists()
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            var allUsers = await GlobalConfig.DataConnection.GetAllUsersAsync();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            return allUsers.Any(user => user.Email.Equals(emailValue.Text, StringComparison.OrdinalIgnoreCase));
        }
        private bool FieldsAreNotEmpty() => !string.IsNullOrWhiteSpace(emailValue.Text);
        private bool EmailIsValid() => emailValue.Text.Contains('@') && emailValue.Text.Contains('.');

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}