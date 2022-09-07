namespace Time_s_Up_.Task_Tester
{
    partial class PomodoroTaskPage
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
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.taskNameInputLabel = new System.Windows.Forms.Label();
            this.taskNameInput = new System.Windows.Forms.TextBox();
            this.taskName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.segmentTimeInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.breakTimeInput = new System.Windows.Forms.TextBox();
            this.segmentTimeSelector = new System.Windows.Forms.DomainUpDown();
            this.breakTimeSelector = new System.Windows.Forms.DomainUpDown();
            this.segmentAmountInput = new System.Windows.Forms.DomainUpDown();
            this.segmentAmountLabel = new System.Windows.Forms.Label();
            this.createTaskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(291, 349);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.descriptionLabel.TabIndex = 18;
            this.descriptionLabel.Text = "Description";
            this.descriptionLabel.Click += new System.EventHandler(this.descriptionLabel_Click);
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(409, 349);
            this.descriptionInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descriptionInput.Multiline = true;
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(338, 152);
            this.descriptionInput.TabIndex = 17;
            this.descriptionInput.TextChanged += new System.EventHandler(this.descriptionInput_TextChanged);
            // 
            // taskNameInputLabel
            // 
            this.taskNameInputLabel.AutoSize = true;
            this.taskNameInputLabel.Location = new System.Drawing.Point(291, 152);
            this.taskNameInputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taskNameInputLabel.Name = "taskNameInputLabel";
            this.taskNameInputLabel.Size = new System.Drawing.Size(89, 20);
            this.taskNameInputLabel.TabIndex = 13;
            this.taskNameInputLabel.Text = "Task Name";
            // 
            // taskNameInput
            // 
            this.taskNameInput.Location = new System.Drawing.Point(412, 152);
            this.taskNameInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.taskNameInput.Name = "taskNameInput";
            this.taskNameInput.Size = new System.Drawing.Size(264, 26);
            this.taskNameInput.TabIndex = 12;
            this.taskNameInput.TextChanged += new System.EventHandler(this.taskNameInput_TextChanged);
            // 
            // taskName
            // 
            this.taskName.AutoSize = true;
            this.taskName.Location = new System.Drawing.Point(42, 34);
            this.taskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taskName.MaximumSize = new System.Drawing.Size(122, 0);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(108, 60);
            this.taskName.TabIndex = 11;
            this.taskName.Text = "NEW POMODORO TASK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Segment Time";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // segmentTimeInput
            // 
            this.segmentTimeInput.Location = new System.Drawing.Point(412, 197);
            this.segmentTimeInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.segmentTimeInput.Name = "segmentTimeInput";
            this.segmentTimeInput.Size = new System.Drawing.Size(148, 26);
            this.segmentTimeInput.TabIndex = 20;
            this.segmentTimeInput.TextChanged += new System.EventHandler(this.segmentTimeInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Break Time";
            // 
            // breakTimeInput
            // 
            this.breakTimeInput.Location = new System.Drawing.Point(412, 250);
            this.breakTimeInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.breakTimeInput.Name = "breakTimeInput";
            this.breakTimeInput.Size = new System.Drawing.Size(148, 26);
            this.breakTimeInput.TabIndex = 22;
            // 
            // segmentTimeSelector
            // 
            this.segmentTimeSelector.Items.Add("Seconds");
            this.segmentTimeSelector.Items.Add("Minutes");
            this.segmentTimeSelector.Items.Add("Hours");
            this.segmentTimeSelector.Location = new System.Drawing.Point(573, 197);
            this.segmentTimeSelector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.segmentTimeSelector.Name = "segmentTimeSelector";
            this.segmentTimeSelector.Size = new System.Drawing.Size(180, 26);
            this.segmentTimeSelector.TabIndex = 23;
            this.segmentTimeSelector.Text = "Minutes";
            this.segmentTimeSelector.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // breakTimeSelector
            // 
            this.breakTimeSelector.Items.Add("Seconds");
            this.breakTimeSelector.Items.Add("Minutes");
            this.breakTimeSelector.Items.Add("Hours");
            this.breakTimeSelector.Location = new System.Drawing.Point(571, 247);
            this.breakTimeSelector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.breakTimeSelector.Name = "breakTimeSelector";
            this.breakTimeSelector.Size = new System.Drawing.Size(180, 26);
            this.breakTimeSelector.TabIndex = 24;
            this.breakTimeSelector.Text = "Minutes";
            // 
            // segmentAmountInput
            // 
            this.segmentAmountInput.Items.Add("1");
            this.segmentAmountInput.Items.Add("2");
            this.segmentAmountInput.Items.Add("3");
            this.segmentAmountInput.Items.Add("4");
            this.segmentAmountInput.Items.Add("5 ");
            this.segmentAmountInput.Items.Add("6");
            this.segmentAmountInput.Items.Add("7");
            this.segmentAmountInput.Items.Add("8");
            this.segmentAmountInput.Location = new System.Drawing.Point(410, 298);
            this.segmentAmountInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.segmentAmountInput.Name = "segmentAmountInput";
            this.segmentAmountInput.Size = new System.Drawing.Size(152, 26);
            this.segmentAmountInput.TabIndex = 27;
            this.segmentAmountInput.Text = "Minutes";
            // 
            // segmentAmountLabel
            // 
            this.segmentAmountLabel.AutoSize = true;
            this.segmentAmountLabel.Location = new System.Drawing.Point(250, 298);
            this.segmentAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.segmentAmountLabel.Name = "segmentAmountLabel";
            this.segmentAmountLabel.Size = new System.Drawing.Size(134, 20);
            this.segmentAmountLabel.TabIndex = 25;
            this.segmentAmountLabel.Text = "Segment Amount";
            // 
            // createTaskButton
            // 
            this.createTaskButton.Location = new System.Drawing.Point(635, 536);
            this.createTaskButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createTaskButton.Name = "createTaskButton";
            this.createTaskButton.Size = new System.Drawing.Size(112, 42);
            this.createTaskButton.TabIndex = 28;
            this.createTaskButton.Text = "Create Task";
            this.createTaskButton.UseVisualStyleBackColor = true;
            this.createTaskButton.Click += new System.EventHandler(this.createTaskButton_Click);
            // 
            // PomodoroTaskPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 607);
            this.Controls.Add(this.createTaskButton);
            this.Controls.Add(this.segmentAmountInput);
            this.Controls.Add(this.segmentAmountLabel);
            this.Controls.Add(this.breakTimeSelector);
            this.Controls.Add(this.segmentTimeSelector);
            this.Controls.Add(this.breakTimeInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.segmentTimeInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.taskNameInputLabel);
            this.Controls.Add(this.taskNameInput);
            this.Controls.Add(this.taskName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PomodoroTaskPage";
            this.Text = "New Pomodoro Task";
            this.Load += new System.EventHandler(this.PomodoroTaskPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionInput;
        private System.Windows.Forms.Label taskNameInputLabel;
        private System.Windows.Forms.TextBox taskNameInput;
        private System.Windows.Forms.Label taskName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox segmentTimeInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox breakTimeInput;
        public System.Windows.Forms.DomainUpDown segmentTimeSelector;
        public System.Windows.Forms.DomainUpDown breakTimeSelector;
        public System.Windows.Forms.DomainUpDown segmentAmountInput;
        private System.Windows.Forms.Label segmentAmountLabel;
        private System.Windows.Forms.Button createTaskButton;
    }
}