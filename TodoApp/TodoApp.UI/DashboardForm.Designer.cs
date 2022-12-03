namespace TodoApp.UI
{
    partial class DashboardForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.sideNavPanel = new System.Windows.Forms.Panel();
            this.myProfileLabel = new System.Windows.Forms.Label();
            this.undoneLabel = new System.Windows.Forms.Label();
            this.favoriteLabel = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.Label();
            this.myProfilePciture = new System.Windows.Forms.PictureBox();
            this.undonePicture = new System.Windows.Forms.PictureBox();
            this.favoriteIcon = new System.Windows.Forms.PictureBox();
            this.mainPicture = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.exitLabel = new System.Windows.Forms.Label();
            this.sideNavPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myProfilePciture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.undonePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.ForeColor = System.Drawing.Color.Coral;
            this.welcomeLabel.Location = new System.Drawing.Point(1161, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(36, 28);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "***";
            // 
            // sideNavPanel
            // 
            this.sideNavPanel.BackColor = System.Drawing.SystemColors.Control;
            this.sideNavPanel.Controls.Add(this.myProfileLabel);
            this.sideNavPanel.Controls.Add(this.undoneLabel);
            this.sideNavPanel.Controls.Add(this.favoriteLabel);
            this.sideNavPanel.Controls.Add(this.homeLabel);
            this.sideNavPanel.Controls.Add(this.myProfilePciture);
            this.sideNavPanel.Controls.Add(this.undonePicture);
            this.sideNavPanel.Controls.Add(this.favoriteIcon);
            this.sideNavPanel.Controls.Add(this.mainPicture);
            this.sideNavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideNavPanel.Location = new System.Drawing.Point(0, 0);
            this.sideNavPanel.Name = "sideNavPanel";
            this.sideNavPanel.Size = new System.Drawing.Size(271, 744);
            this.sideNavPanel.TabIndex = 1;
            // 
            // myProfileLabel
            // 
            this.myProfileLabel.AutoSize = true;
            this.myProfileLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myProfileLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myProfileLabel.ForeColor = System.Drawing.Color.Coral;
            this.myProfileLabel.Location = new System.Drawing.Point(50, 701);
            this.myProfileLabel.Name = "myProfileLabel";
            this.myProfileLabel.Size = new System.Drawing.Size(189, 31);
            this.myProfileLabel.TabIndex = 2;
            this.myProfileLabel.Text = "ჩემი პროფილი";
            // 
            // undoneLabel
            // 
            this.undoneLabel.AutoSize = true;
            this.undoneLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.undoneLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.undoneLabel.ForeColor = System.Drawing.Color.Coral;
            this.undoneLabel.Location = new System.Drawing.Point(50, 174);
            this.undoneLabel.Name = "undoneLabel";
            this.undoneLabel.Size = new System.Drawing.Size(213, 31);
            this.undoneLabel.TabIndex = 2;
            this.undoneLabel.Text = "შესასრულებელი";
            // 
            // favoriteLabel
            // 
            this.favoriteLabel.AutoSize = true;
            this.favoriteLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.favoriteLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.favoriteLabel.ForeColor = System.Drawing.Color.Coral;
            this.favoriteLabel.Location = new System.Drawing.Point(50, 104);
            this.favoriteLabel.Name = "favoriteLabel";
            this.favoriteLabel.Size = new System.Drawing.Size(112, 31);
            this.favoriteLabel.TabIndex = 2;
            this.favoriteLabel.Text = "რჩეული";
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeLabel.ForeColor = System.Drawing.Color.Coral;
            this.homeLabel.Location = new System.Drawing.Point(50, 36);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(113, 31);
            this.homeLabel.TabIndex = 2;
            this.homeLabel.Text = "მთავარი";
            // 
            // myProfilePciture
            // 
            this.myProfilePciture.Image = global::TodoApp.UI.Properties.Resources.profile;
            this.myProfilePciture.Location = new System.Drawing.Point(12, 700);
            this.myProfilePciture.Name = "myProfilePciture";
            this.myProfilePciture.Size = new System.Drawing.Size(32, 32);
            this.myProfilePciture.TabIndex = 1;
            this.myProfilePciture.TabStop = false;
            // 
            // undonePicture
            // 
            this.undonePicture.Image = global::TodoApp.UI.Properties.Resources.planned;
            this.undonePicture.Location = new System.Drawing.Point(12, 173);
            this.undonePicture.Name = "undonePicture";
            this.undonePicture.Size = new System.Drawing.Size(32, 32);
            this.undonePicture.TabIndex = 1;
            this.undonePicture.TabStop = false;
            // 
            // favoriteIcon
            // 
            this.favoriteIcon.Image = global::TodoApp.UI.Properties.Resources.staroutline_81125;
            this.favoriteIcon.Location = new System.Drawing.Point(12, 103);
            this.favoriteIcon.Name = "favoriteIcon";
            this.favoriteIcon.Size = new System.Drawing.Size(32, 32);
            this.favoriteIcon.TabIndex = 1;
            this.favoriteIcon.TabStop = false;
            // 
            // mainPicture
            // 
            this.mainPicture.Image = global::TodoApp.UI.Properties.Resources.home;
            this.mainPicture.Location = new System.Drawing.Point(12, 35);
            this.mainPicture.Name = "mainPicture";
            this.mainPicture.Size = new System.Drawing.Size(32, 32);
            this.mainPicture.TabIndex = 1;
            this.mainPicture.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(269, 35);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(928, 709);
            this.mainPanel.TabIndex = 2;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Red;
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLabel.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitLabel.ForeColor = System.Drawing.Color.White;
            this.exitLabel.Location = new System.Drawing.Point(277, 5);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(21, 23);
            this.exitLabel.TabIndex = 5;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1197, 744);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sideNavPanel);
            this.Controls.Add(this.welcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "მთავარი";
            this.sideNavPanel.ResumeLayout(false);
            this.sideNavPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myProfilePciture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.undonePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label welcomeLabel;
        private Panel sideNavPanel;
        private PictureBox mainPicture;
        private Label homeLabel;
        private Label myProfileLabel;
        private PictureBox myProfilePciture;
        private Label favoriteLabel;
        private PictureBox favoriteIcon;
        private Label undoneLabel;
        private PictureBox undonePicture;
        private Panel mainPanel;
        private Label exitLabel;
    }
}