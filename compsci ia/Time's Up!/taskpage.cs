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

            newTask.Initialize();

            switch (timeSelector.Text)
            {

                case "Seconds":
                    try
                    {
                        newTask.timer.Interval = (int)float.Parse(timeInput.Text) * 1000;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Please put in a timer length.");
                        return;
                    }

                    Console.WriteLine("This is working");

                    break;

                case "Minutes":
                    try
                    {
                        newTask.timer.Interval = (int)(float.Parse(timeInput.Text) * 1000) * 60;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Please put in a timer length.");
                        return;
                    }

                    Console.WriteLine("This is working");

                    break;

                case "Hours":
                    try
                    {
                        newTask.timer.Interval = (int)((float.Parse(timeInput.Text) * 1000) * 60) * 60;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Please put in a timer length.");
                        return;
                    }

                    Console.WriteLine("This is working");

                    break;

            }



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

    //    while(timer.Interval != 0)
    //        {

    //            if(timer.Interval == ((2000) * 60) * 60))
    //            {
                    
    //                new ToastContentBuilder()
    //                    .AddArgument("action", "viewConversation")
    //                    .AddArgument("taskid", i)
    //                    .AddText("Your timer is up!")
    //                    .AddText($@"Your task, {taskName}, is now completed! Great job!")
    //                    .Show();
    //            }

    //         }


    //        private void taskNameInput_TextChanged(object sender, EventArgs e)
    //                {
    //                    taskName.Text = taskNameInput.Text;
    //                }

    //}

    public class Task
    {

        //Public variables for task
        public float timerTime { get; set; }
        public bool isChecked { get; set; }
        public int importance { get; set; }
        public string taskName { get; set; }
        public string description { get; set; }

        //Private variable for notifications
        int i = 0;

        //Task timer
        public Timer timer = new Timer();

        //Setting event for timer
        public void Initialize()
        {

            timer.Tick += new System.EventHandler(Timer_Tick);
            i++;
        }

        //Timer event
        private void Timer_Tick(object sender, EventArgs e)
        {

            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("taskid", i)
                .AddText("Your timer is up!")
                .AddText($@"Your task, {taskName}, is now completed! Great job!")
                .Show();

            timer.Enabled = false;
        }

        
    
    
    }           

           



    public class TimerTask : Task
            {





            }

    public class PomodoroTask : Task
        {

            public int loopTime { get; set; }
            public float breakTime { get; set; }


        }




    }

    
}
