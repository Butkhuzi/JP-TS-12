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
    public partial class DashboardForm : Form
    {
        private UserModel _loggedInUser = new();
        public DashboardForm(UserModel loggedInUser)
        {
            InitializeComponent();
            _loggedInUser = loggedInUser;
            welcomeLabel.Text = $"გამარჯობა {_loggedInUser.FirstName}";
            mainPanel.Controls.Add(new TodoUserControl(_loggedInUser));
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
