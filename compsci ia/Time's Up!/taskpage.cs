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



    public partial class taskpage : Form
    {


        


        public taskpage()
        {
            InitializeComponent();
        }


        private void taskNameInput_TextChanged(object sender, EventArgs e)
        {
            taskName.Text = taskNameInput.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void createTaskButton_Click(object sender, EventArgs e)
        {

            bool isNull = true;

            //Sending the initial notification
            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("taskid", 1)
                .AddText("You've created a new task!")
                .AddText($@"{taskNameInput.Text}. Time remaining: {timeInput.Text} {timeSelector.Text}
                {descriptionInput.Text}                                             ")
                .Show();

            //Initializing the new task

                Task newTask = new Task();

            //newTask.timerTime ?? isNull = true;


            try
            {
                newTask.taskName = taskNameInput.Text;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Please fill in the required boxes!");
            }
            try
            {
                newTask.description = descriptionInput.Text;
            }
            catch (Exception ex)
            {
                newTask.description = "";
            }


            //Initializing timer

            newTask.InitializeTimer(timeSelector.Text, float.Parse(timeInput.Text), taskName.Text, descriptionInput.Text);


            newTask.timer.Enabled = true;

            //Saving it to memory




            var mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {



        }

        private void taskpage_Load(object sender, EventArgs e)
        {

        }

        private void timeInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }
    }

    public class Task
    {

        //Public variables for task
        public float timerTime { get; set; }
        public int importance { get; set; }
        public string taskName { get; set; }
        public string description { get; set; }


     
        //Task timer
        public Timer timer = new Timer();



        //Setting event for timer
        public void InitializeTimer(string timeSelector, float timeInput, string taskName, string taskDescription)
        {

            timer.Interval = convertTimerTime((int)timeInput, timeSelector);
            timer.Tick += new System.EventHandler(Timer_Tick);
      

        }

        //Timer event
        protected void Timer_Tick(object sender, EventArgs e)
        {

            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("taskid")
                .AddText("Your timer is up!")
                .AddText($@"Your task, {taskName}, is now completed! Great job!")
                .Show();

            timer.Enabled = false;
        }

        //A method that converts the string of inputs to integers
        protected int convertTimerTime(int timeInput, string timeSelector) => timeSelector switch
        {
            "Seconds" => (int)(timeInput) * 1000,
            "Minutes" => (int)((timeInput) * 1000) * 60,
            "Hours" => (int)((timeInput * 1000) * 60) * 60,
            _ => (int)0
        };
    }

    public class TimerTask : Task
    {





    }

    public partial class PomodoroTask : Task
    {

        public float segTime { get; set; }
        public float breakTime { get; set; }

        public string segTimeSelector { get; set; }
        public string breakTimeSelector { get; set; }
        
        public int segAmount { get; set; }

    }
}
