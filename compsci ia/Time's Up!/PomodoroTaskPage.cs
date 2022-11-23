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

        //Create the timer
        private void createTaskButton_Click(object sender, EventArgs e)
        {

            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("taskid")
                .AddText("Your task has started!")
                .AddText($@"Your task {taskName} has started!")
                .Show();

            pomTask.segTime = float.Parse(segmentTimeInput.Text);

            //Catches expection if the description is returned as null
            try
            {
                pomTask.InitializePomTimer(float.Parse(segmentTimeInput.Text), float.Parse(breakTimeInput.Text), int.Parse(segmentAmountInput.Text), taskName.Text, descriptionInput.Text, segmentTimeSelector.Text, breakTimeSelector.Text);
            }catch(Exception ex)
            {
                pomTask.description = "";
            }

            var mainMenuPage = new MainMenu();
            mainMenuPage.Show();

            this.Hide();
        }   
    }

    public partial class PomodoroTask : Task
    {
        //Timers
        Timer segmentTimer = new Timer();
        Timer breakTimer = new Timer();

        //Events for handling the timers
        public EventHandler<int> BreakStarted;
        public EventHandler<int> SegmentStarted;

        //Variables for controlling the loop
        int segmentAmount;
        int segmentCounter;

        //Initializing the timer
        public void InitializePomTimer(float segTimeInput, float breakTimeInput, int segAmount, string taskNameInput, string taskDescription, string segTimeSelector, string breakTimeSelector) 
        {
            //Giving values to properties
            segTime = convertTimerTime((int)segTimeInput, segTimeSelector);
            breakTime = convertTimerTime((int)breakTimeInput, breakTimeSelector);
            taskName = taskNameInput;
            segmentAmount = (segAmount);
            segmentCounter = 0;

            //Starting the timers
            segmentTimer.Interval = (int)segTime;
            segmentTimer.Start();

            breakTimer.Interval = (int)breakTime;
            
            //Setting the timer events
            segmentTimer.Tick += new EventHandler(OnTimerTick);
            BreakStarted += OnBreakStarted;
            SegmentStarted += OnSegmentStarted;
            breakTimer.Tick += new EventHandler(OnBreakEnd);
        }

        //Telling the program to begin the process of starting the break timer
        protected virtual void OnTimerTick(object sender, EventArgs e)
        {
            Console.WriteLine("the break tick is working");

            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("taskid")
                .AddText("Your break has Started!")
                .AddText($@"Your break for {taskName} has started! Take a rest!")
                .Show();

            segmentTimer.Stop();
            segmentTimer.Enabled = false;
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
            breakTimer.Start();
            breakTimer.Enabled = true;
        }

        //Telling the program to restart the segment timer once the break timer ends
        protected virtual void OnBreakEnd(object sender, EventArgs e)
        {
            Console.WriteLine(segmentCounter);
            Console.WriteLine(segmentAmount);

            //Testing to see if the task is done
            if (segmentCounter <= segmentAmount)
            {
                new ToastContentBuilder()
                    .AddArgument("action", "viewConversation")
                    .AddArgument("taskid")
                    .AddText("Your break has ended!")
                    .AddText($@"Your break for {taskName} has ended! Time to get back to work!")
                    .Show();

                pomBreakEnd((int)segTime);

                segmentCounter++;
            }
            else
            {
                new ToastContentBuilder()
                   .AddArgument("action", "viewConversation")
                   .AddArgument("taskid")
                   .AddText("Your task is complete!")
                   .AddText($@"You have completed your task! Good job!")
                   .Show();

                breakTimer.Stop();
                segmentTimer.Stop();
            }

        }
        
        //Invoking the SegmentStarted event
        protected virtual void pomBreakEnd(int segTime)
        {
            SegmentStarted?.Invoke(this, segTime);

        }

        //Starting the segment timer
        protected virtual void OnSegmentStarted(object sender, int segTime)
        {
            segmentTimer.Enabled = true;
            segmentTimer.Start();
        }

        


    }
}
