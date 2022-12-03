namespace TodoApp.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.registerLink = new System.Windows.Forms.LinkLabel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(12, 143);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(328, 27);
            this.emailValue.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.ForeColor = System.Drawing.Color.Black;
            this.emailLabel.Location = new System.Drawing.Point(12, 120);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(89, 20);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "ელ-ფოსტა";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.Coral;
            this.headerLabel.Location = new System.Drawing.Point(65, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(229, 31);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "სისტემაში შესვლა";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Coral;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Sienna;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(0, 254);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(348, 56);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "ავტორიზაცია";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // registerLink
            // 
            this.registerLink.AutoSize = true;
            this.registerLink.LinkColor = System.Drawing.Color.Coral;
            this.registerLink.Location = new System.Drawing.Point(232, 120);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(108, 20);
            this.registerLink.TabIndex = 3;
            this.registerLink.TabStop = true;
            this.registerLink.Text = "რეგისტრაცია";
            this.registerLink.Click += new System.EventHandler(this.registerLink_Click);
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Red;
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLabel.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitLabel.ForeColor = System.Drawing.Color.White;
            this.exitLabel.Location = new System.Drawing.Point(326, 2);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(21, 23);
            this.exitLabel.TabIndex = 4;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(348, 310);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.registerLink);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ავტორიზაცია";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox emailValue;
        private Label emailLabel;
        private Label headerLabel;
        private Button loginBtn;
        private LinkLabel registerLink;
        private Label exitLabel;
    }
}