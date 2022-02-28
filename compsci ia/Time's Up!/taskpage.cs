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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void createTaskButton_Click(object sender, EventArgs e)
        {
            //Sending the 
            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("taskid", 1)
                .AddText("You've created a new task!")
                .AddText($@"{taskName.Text}. Time remaining: {timeInput.Text} {timeSelector.Text}
                {descriptionInput.Text}                                             ")
                .Show();

            //Initializing the new task
            Task newTask = new Task();
            newTask.timerTime = float.Parse(timeInput.Text);
            newTask.taskName = taskName.Text;
            newTask.description = descriptionInput.Text;

            //Saving it to memory
            pasttasks[i, 1] = newTask.taskName;
            pasttasks[i, 2] = newTask.description;
            if (newTask.description == null)
            {
                pasttasks[i, 2] = "no description";
            }
            pasttasks[i, 3] = timeInput.Text;
            pasttasks[i, 4] = timeSelector.Text;

            i++;
        }

        private void taskNameInput_TextChanged(object sender, EventArgs e)
        {
            taskName.Text = taskNameInput.Text;
        }
    }

    public class Task
    {

        public float timerTime;
        public bool isChecked;
        public int importance;
        public string taskName;
        public string description;

        public class TimerTask : Task
        {





        }

        public class PomodoroTask : Task
        {

            int loopTime;
            float breakTime;







        }




    }

    
}
