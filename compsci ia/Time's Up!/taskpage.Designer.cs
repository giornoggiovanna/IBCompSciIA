namespace Time_s_Up_.Task_Tester
{
    public partial class taskpage
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
            this.taskName = new System.Windows.Forms.Label();
            this.taskNameInput = new System.Windows.Forms.TextBox();
            this.taskNameInputLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeInput = new System.Windows.Forms.TextBox();
            this.timeSelector = new System.Windows.Forms.DomainUpDown();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.createTaskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskName
            // 
            this.taskName.AutoSize = true;
            this.taskName.Location = new System.Drawing.Point(13, 13);
            this.taskName.MaximumSize = new System.Drawing.Size(81, 0);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(56, 50);
            this.taskName.TabIndex = 0;
            this.taskName.Text = "NEW TASK";
            this.taskName.Click += new System.EventHandler(this.label1_Click);
            // 
            // taskNameInput
            // 
            this.taskNameInput.Location = new System.Drawing.Point(260, 90);
            this.taskNameInput.Name = "taskNameInput";
            this.taskNameInput.Size = new System.Drawing.Size(177, 31);
            this.taskNameInput.TabIndex = 1;
            this.taskNameInput.TextChanged += new System.EventHandler(this.taskNameInput_TextChanged);
            // 
            // taskNameInputLabel
            // 
            this.taskNameInputLabel.AutoSize = true;
            this.taskNameInputLabel.Location = new System.Drawing.Point(157, 90);
            this.taskNameInputLabel.Name = "taskNameInputLabel";
            this.taskNameInputLabel.Size = new System.Drawing.Size(97, 25);
            this.taskNameInputLabel.TabIndex = 2;
            this.taskNameInputLabel.Text = "Task Name";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(211, 137);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(50, 25);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Time";
            // 
            // timeInput
            // 
            this.timeInput.Location = new System.Drawing.Point(260, 134);
            this.timeInput.Name = "timeInput";
            this.timeInput.Size = new System.Drawing.Size(100, 31);
            this.timeInput.TabIndex = 4;
            this.timeInput.TextChanged += new System.EventHandler(this.timeInput_TextChanged);
            // 
            // timeSelector
            // 
            this.timeSelector.Items.Add("Seconds");
            this.timeSelector.Items.Add("Minutes");
            this.timeSelector.Items.Add("Hours");
            this.timeSelector.Location = new System.Drawing.Point(367, 134);
            this.timeSelector.Name = "timeSelector";
            this.timeSelector.Size = new System.Drawing.Size(120, 31);
            this.timeSelector.TabIndex = 5;
            this.timeSelector.Text = "Minutes";
            this.timeSelector.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(260, 179);
            this.descriptionInput.Multiline = true;
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(227, 100);
            this.descriptionInput.TabIndex = 6;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(152, 182);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(102, 25);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "Description";
            this.descriptionLabel.Click += new System.EventHandler(this.descriptionLabel_Click);
            // 
            // createTaskButton
            // 
            this.createTaskButton.Location = new System.Drawing.Point(412, 325);
            this.createTaskButton.Name = "createTaskButton";
            this.createTaskButton.Size = new System.Drawing.Size(75, 34);
            this.createTaskButton.TabIndex = 8;
            this.createTaskButton.Text = "Create Task";
            this.createTaskButton.UseVisualStyleBackColor = true;
            this.createTaskButton.Click += new System.EventHandler(this.createTaskButton_Click);
            // 
            // taskpage
            // 
            this.ClientSize = new System.Drawing.Size(677, 389);
            this.Controls.Add(this.createTaskButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.timeSelector);
            this.Controls.Add(this.timeInput);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.taskNameInputLabel);
            this.Controls.Add(this.taskNameInput);
            this.Controls.Add(this.taskName);
            this.Name = "taskpage";
            this.Text = "New Task";
            this.Load += new System.EventHandler(this.taskpage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskName;
        private System.Windows.Forms.TextBox taskNameInput;
        private System.Windows.Forms.Label taskNameInputLabel;
        private System.Windows.Forms.Label timeLabel;
        public System.Windows.Forms.TextBox timeInput;
        public System.Windows.Forms.DomainUpDown timeSelector;
        private System.Windows.Forms.TextBox descriptionInput;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button createTaskButton;
    }
}