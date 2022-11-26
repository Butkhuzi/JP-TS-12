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
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.welcomeLabel.Location = new System.Drawing.Point(773, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(27, 20);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "***";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label welcomeLabel;
    }
}