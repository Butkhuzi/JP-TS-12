namespace TodoApp.UI
{
    partial class MyProfileUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.editUserBtn = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameValue
            // 
            this.firstNameValue.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameValue.Location = new System.Drawing.Point(6, 190);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(922, 43);
            this.firstNameValue.TabIndex = 1;
            // 
            // lastNameValue
            // 
            this.lastNameValue.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameValue.Location = new System.Drawing.Point(6, 318);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(922, 43);
            this.lastNameValue.TabIndex = 2;
            // 
            // emailValue
            // 
            this.emailValue.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailValue.Location = new System.Drawing.Point(6, 448);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(922, 43);
            this.emailValue.TabIndex = 3;
            // 
            // editUserBtn
            // 
            this.editUserBtn.BackColor = System.Drawing.Color.Coral;
            this.editUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editUserBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.editUserBtn.FlatAppearance.BorderSize = 0;
            this.editUserBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Sienna;
            this.editUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUserBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editUserBtn.ForeColor = System.Drawing.Color.White;
            this.editUserBtn.Location = new System.Drawing.Point(0, 654);
            this.editUserBtn.Name = "editUserBtn";
            this.editUserBtn.Size = new System.Drawing.Size(928, 55);
            this.editUserBtn.TabIndex = 4;
            this.editUserBtn.Text = "რედაქტირება";
            this.editUserBtn.UseVisualStyleBackColor = false;
            this.editUserBtn.Click += new System.EventHandler(this.editUserBtn_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.ForeColor = System.Drawing.Color.Coral;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 149);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(125, 38);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "სახელი";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.ForeColor = System.Drawing.Color.Coral;
            this.lastNameLabel.Location = new System.Drawing.Point(6, 277);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(100, 38);
            this.lastNameLabel.TabIndex = 9;
            this.lastNameLabel.Text = "გვარი";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.Color.Coral;
            this.emailLabel.Location = new System.Drawing.Point(6, 407);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(168, 38);
            this.emailLabel.TabIndex = 9;
            this.emailLabel.Text = "ელ-ფოსტა";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.Coral;
            this.headerLabel.Location = new System.Drawing.Point(212, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(490, 38);
            this.headerLabel.TabIndex = 9;
            this.headerLabel.Text = "პირადი ინფორმაციის ცვლილება";
            // 
            // MyProfileUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.editUserBtn);
            this.Controls.Add(this.emailValue);
            this.Controls.Add(this.lastNameValue);
            this.Controls.Add(this.firstNameValue);
            this.Name = "MyProfileUserControl";
            this.Size = new System.Drawing.Size(928, 709);
            this.Load += new System.EventHandler(this.MyProfileUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox firstNameValue;
        private TextBox lastNameValue;
        private TextBox emailValue;
        private Button editUserBtn;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label emailLabel;
        private Label headerLabel;
    }
}
