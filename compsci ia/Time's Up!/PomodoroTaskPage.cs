    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;

namespace Time_s_Up_.Task_Tester
{
    public partial class PomodoroTaskPage : Form
    {
        public PomodoroTaskPage()
        {
            InitializeComponent();
        }


        //Object logic, most not needed but unable to delete
        private void descriptionInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
            
        private void taskNameInput_TextChanged(object sender, EventArgs e)
        {
            taskName.Text = taskNameInput.Text;
        }

        private void timeInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void timeSelector_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void PomodoroTaskPage_Load(object sender, EventArgs e)
        {

        }

        private void segmentTimeInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        //Begining of program
        PomodoroTask pomTask = new PomodoroTask();


        private void createTaskButton_Click(object sender, EventArgs e)
        {
            pomTask.segTime = float.Parse(segmentTimeInput.Text);

            pomTask.InitializePomTimer(float.Parse(segmentTimeInput.Text), float.Parse(breakTimeInput.Text), int.Parse(segmentAmountInput.Text), taskName.Text, descriptionInput.Text, segmentTimeSelector.Text, breakTimeSelector.Text);

            var mainMenuPage = new MainMenu();
            mainMenuPage.Show();

            this.Hide();
        }   
    }

    public partial class PomodoroTask : Task
    {
        
        //Events for handling the timers
        public EventHandler<int> BreakStarted;
        public EventHandler<int> SegmentStarted;

        int segmentCounter;
        int segmentAmount;

        //Initializing the timer
        public void InitializePomTimer(float segTimeInput, float breakTimeInput, int segAmount, string taskNameInput, string taskDescription, string segTimeSelector, string breakTimeSelector) 
        {
            Timer timer = new Timer();

            //Giving values to properties
            segTime = convertTimerTime((int)segTimeInput, segTimeSelector);
            breakTime = convertTimerTime((int)breakTimeInput, breakTimeSelector);
            taskName = taskNameInput;
            segmentAmount = (segAmount);
            segmentCounter = 0;

            //Starting timer
            timer.Interval = (int)segTime;
            timer.Start();

            //Setting the timer events
            timer.Tick += new EventHandler(OnTimerTick);
            BreakStarted += OnBreakStarted;
        }

        //Telling the program to begin the process of starting the break timer
        protected virtual void OnTimerTick(object sender, EventArgs e)
        {
            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("taskid")
                .AddText("Your break has Started!")
                .AddText($@"Your break for {taskName} has started! Take a rest!")
                .Show();

            timer.Enabled = false;
            pomBreakStart(breakTime);
        }

        //Invoking the BreakStarted event
        protected virtual void pomBreakStart(float breakTime)
        {
            BreakStarted?.Invoke(this, (int)breakTime);
        }

        //Starting the break timer
        public void OnBreakStarted(object sender, int breakTime)
        {
            Timer breakTimer = new Timer();
            breakTimer.Interval = breakTime;

            breakTimer.Tick += new EventHandler(OnBreakEnd);
        }

        //Telling the program to restart the segment timer once the break timer ends
        protected virtual void OnBreakEnd(object sender, EventArgs e)
        {
            if (segmentCounter <= segmentAmount)
            {
                new ToastContentBuilder()
                    .AddArgument("action", "viewConversation")
                    .AddArgument("taskid")
                    .AddText("Your break has ended!")
                    .AddText($@"Your break for {taskName} has end! Time to get back to work!")
                    .Show();

                pomBreakEnd((int)segTime);

            }
            else return;
            
        }
        
        //Invoking the SegmentStarted event
        protected virtual void pomBreakEnd(int segTime)
        {
            SegmentStarted?.Invoke(this, segTime);

        }

        //Starting the segment timer
        protected virtual void OnSegmentStarted(object sender, int segTime)
        {
            
            Timer segTimer = new Timer();
            segTimer.Interval = segTime;

            segTimer.Tick += Timer_Tick;
        }

        


    }
}
