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
    public partial class DashboardForm : Form
    {
        private UserModel _loggedInUser = new();
        public DashboardForm(UserModel loggedInUser)
        {
            InitializeComponent();
            _loggedInUser = loggedInUser;
            mainPanel.Controls.Add(new TodoUserControl(_loggedInUser));
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void myProfileLabel_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new MyProfileUserControl(_loggedInUser));
        }

        private void homeLabel_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new TodoUserControl(_loggedInUser));
        }

        private async void DashboardForm_Activated(object sender, EventArgs e)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            UserModel? editedUser = await GlobalConfig.DataConnection.GetSingleUserAsync(_loggedInUser);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            welcomeLabel.Text = $"გამარჯობა {editedUser.FirstName}";
        }
    }
}
