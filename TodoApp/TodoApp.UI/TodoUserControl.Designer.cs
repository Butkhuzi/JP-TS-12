namespace TodoApp.UI
{
    partial class TodoUserControl
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
            this.todoListBox = new System.Windows.Forms.ListBox();
            this.titleValue = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionValue = new System.Windows.Forms.RichTextBox();
            this.startDateValue = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.dueDateValue = new System.Windows.Forms.DateTimePicker();
            this.statusValue = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.priorityValue = new System.Windows.Forms.ComboBox();
            this.editTodoBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.clearFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // todoListBox
            // 
            this.todoListBox.BackColor = System.Drawing.SystemColors.Control;
            this.todoListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.todoListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.todoListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.todoListBox.ForeColor = System.Drawing.Color.Coral;
            this.todoListBox.FormattingEnabled = true;
            this.todoListBox.ItemHeight = 20;
            this.todoListBox.Location = new System.Drawing.Point(663, 0);
            this.todoListBox.Name = "todoListBox";
            this.todoListBox.Size = new System.Drawing.Size(265, 709);
            this.todoListBox.TabIndex = 0;
            this.todoListBox.SelectedIndexChanged += new System.EventHandler(this.todoListBox_SelectedIndexChanged);
            // 
            // titleValue
            // 
            this.titleValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleValue.ForeColor = System.Drawing.Color.Coral;
            this.titleValue.Location = new System.Drawing.Point(3, 50);
            this.titleValue.Name = "titleValue";
            this.titleValue.Size = new System.Drawing.Size(654, 34);
            this.titleValue.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.Coral;
            this.titleLabel.Location = new System.Drawing.Point(3, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(104, 28);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "სათაური";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.ForeColor = System.Drawing.Color.Coral;
            this.descriptionLabel.Location = new System.Drawing.Point(3, 99);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(86, 28);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "აღწერა";
            // 
            // descriptionValue
            // 
            this.descriptionValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionValue.ForeColor = System.Drawing.Color.Coral;
            this.descriptionValue.Location = new System.Drawing.Point(3, 130);
            this.descriptionValue.Name = "descriptionValue";
            this.descriptionValue.Size = new System.Drawing.Size(654, 204);
            this.descriptionValue.TabIndex = 2;
            this.descriptionValue.Text = "";
            // 
            // startDateValue
            // 
            this.startDateValue.CalendarForeColor = System.Drawing.Color.Coral;
            this.startDateValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startDateValue.CustomFormat = "yyyy-MM-dd HH:mm";
            this.startDateValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startDateValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateValue.Location = new System.Drawing.Point(0, 368);
            this.startDateValue.Name = "startDateValue";
            this.startDateValue.Size = new System.Drawing.Size(228, 34);
            this.startDateValue.TabIndex = 3;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startDateLabel.ForeColor = System.Drawing.Color.Coral;
            this.startDateLabel.Location = new System.Drawing.Point(0, 337);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(97, 28);
            this.startDateLabel.TabIndex = 2;
            this.startDateLabel.Text = "დაწყება";
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dueDateLabel.ForeColor = System.Drawing.Color.Coral;
            this.dueDateLabel.Location = new System.Drawing.Point(521, 337);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(136, 28);
            this.dueDateLabel.TabIndex = 2;
            this.dueDateLabel.Text = "დასრულება";
            // 
            // dueDateValue
            // 
            this.dueDateValue.CalendarForeColor = System.Drawing.Color.Coral;
            this.dueDateValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dueDateValue.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dueDateValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dueDateValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dueDateValue.Location = new System.Drawing.Point(429, 368);
            this.dueDateValue.Name = "dueDateValue";
            this.dueDateValue.Size = new System.Drawing.Size(228, 34);
            this.dueDateValue.TabIndex = 4;
            // 
            // statusValue
            // 
            this.statusValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusValue.ForeColor = System.Drawing.Color.Coral;
            this.statusValue.FormattingEnabled = true;
            this.statusValue.Items.AddRange(new object[] {
            "შესასრულებელი",
            "მიმდინარე",
            "შესრულებული"});
            this.statusValue.Location = new System.Drawing.Point(3, 470);
            this.statusValue.Name = "statusValue";
            this.statusValue.Size = new System.Drawing.Size(225, 36);
            this.statusValue.TabIndex = 5;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.ForeColor = System.Drawing.Color.Coral;
            this.statusLabel.Location = new System.Drawing.Point(3, 439);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(102, 28);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "სტატუსი";
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priorityLabel.ForeColor = System.Drawing.Color.Coral;
            this.priorityLabel.Location = new System.Drawing.Point(512, 439);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(145, 28);
            this.priorityLabel.TabIndex = 2;
            this.priorityLabel.Text = "პრიორიტეტი";
            // 
            // priorityValue
            // 
            this.priorityValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.priorityValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priorityValue.ForeColor = System.Drawing.Color.Coral;
            this.priorityValue.FormattingEnabled = true;
            this.priorityValue.Items.AddRange(new object[] {
            "დაბალი",
            "საშუალო",
            "მაღალი",
            "გადაუდებელი"});
            this.priorityValue.Location = new System.Drawing.Point(429, 470);
            this.priorityValue.Name = "priorityValue";
            this.priorityValue.Size = new System.Drawing.Size(225, 36);
            this.priorityValue.TabIndex = 6;
            // 
            // editTodoBtn
            // 
            this.editTodoBtn.BackColor = System.Drawing.Color.Coral;
            this.editTodoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editTodoBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.editTodoBtn.FlatAppearance.BorderSize = 0;
            this.editTodoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Sienna;
            this.editTodoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTodoBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editTodoBtn.ForeColor = System.Drawing.Color.White;
            this.editTodoBtn.Location = new System.Drawing.Point(0, 653);
            this.editTodoBtn.Name = "editTodoBtn";
            this.editTodoBtn.Size = new System.Drawing.Size(663, 56);
            this.editTodoBtn.TabIndex = 7;
            this.editTodoBtn.Text = "რედაქტირება";
            this.editTodoBtn.UseVisualStyleBackColor = false;
            this.editTodoBtn.Click += new System.EventHandler(this.editTodoBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(525, 5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(132, 39);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "დამატება";
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // clearFormBtn
            // 
            this.clearFormBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearFormBtn.Location = new System.Drawing.Point(397, 13);
            this.clearFormBtn.Name = "clearFormBtn";
            this.clearFormBtn.Size = new System.Drawing.Size(122, 29);
            this.clearFormBtn.TabIndex = 9;
            this.clearFormBtn.Text = "გასუფთავება";
            this.clearFormBtn.UseVisualStyleBackColor = true;
            this.clearFormBtn.Click += new System.EventHandler(this.clearFormBtn_Click);
            // 
            // TodoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.clearFormBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.editTodoBtn);
            this.Controls.Add(this.priorityValue);
            this.Controls.Add(this.statusValue);
            this.Controls.Add(this.dueDateValue);
            this.Controls.Add(this.startDateValue);
            this.Controls.Add(this.descriptionValue);
            this.Controls.Add(this.dueDateLabel);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleValue);
            this.Controls.Add(this.todoListBox);
            this.Name = "TodoUserControl";
            this.Size = new System.Drawing.Size(928, 709);
            this.Load += new System.EventHandler(this.TodoUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox todoListBox;
        private TextBox titleValue;
        private Label titleLabel;
        private Label descriptionLabel;
        private RichTextBox descriptionValue;
        private DateTimePicker startDateValue;
        private Label startDateLabel;
        private Label dueDateLabel;
        private DateTimePicker dueDateValue;
        private ComboBox statusValue;
        private Label statusLabel;
        private Label priorityLabel;
        private ComboBox priorityValue;
        private Button editTodoBtn;
        private Button addBtn;
        private Button clearFormBtn;
    }
}
