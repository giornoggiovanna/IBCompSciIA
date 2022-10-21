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


        string[,] pasttasks;
        int i = 1;


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
           
            try
            {
                newTask.timerTime = float.Parse(timeInput.Text);
                newTask.taskName = taskNameInput.Text;

            } catch (Exception ex)
            {
                Console.WriteLine("Please fill in the required boxes!");
            }
            try
            {
                newTask.description = descriptionInput.Text;
            } catch (Exception ex)
            {
                newTask.description = "Not specified";
            }


            //Initializing timer

            newTask.InitializeTimer(timeSelector.Text, float.Parse(timeInput.Text), taskName.Text, descriptionInput.Text);


            newTask.timer.Enabled = true;

            //Saving it to memory

            //pasttasks[i, 1] = newTask.taskName;
            //pasttasks[i, 2] = newTask.description;
            //pasttasks[i, 3] = timeInput.Text;
            //pasttasks[i, 4] = timeSelector.Text;

            //Console.WriteLine(pasttasks[i, 2]);

            i++;

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


        //Private variable for notifications
        int i = 0;

        //Task timer
        public Timer timer = new Timer();



        //Setting event for timer
        public void InitializeTimer(string timeSelector, float timeInput, string taskName, string taskDescription)
        {

            timer.Tick += new System.EventHandler(Timer_Tick);
            i++;

        }

        //Timer event
        protected void Timer_Tick(object sender, EventArgs e)
        {

            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("taskid", i)
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
