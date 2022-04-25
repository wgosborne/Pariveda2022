using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Paveida2
{
    public partial class Workouts : Form
    {
        public Workouts()
        {
            InitializeComponent();
        }

        List<string> cardio = new List<string>
        {
            "30 min run",
            "60 min walk",
            "90 min run",
            "45 min run",
            "30 min stairmaster",
            "60 min run",
            "Hill workout",
            "Flying 30s"
        };
        List<string> abs = new List<string>
        {
            "Front Plank",
            "Side Planks",
            "L Ups",
            "Side Crunches",
            "Bicycle",
            "Dead Bug",
           "Penguin",
           "Russian Twists"

        };
        List<string> legDay = new List<string>
        {
            "Back Squats",
            "Barbell Hip Thrusts",
            "Deadlift",
            "Calf Raises",
            "Bulgarian Split Squat",
            "Leg Extension",
            "Hip Abduction/Adduction"
        };
        List<string> backBicep = new List<string>
        {
            "Seated Curls",
            "Cross Chest Flip Curl",
            "Static Hold Curl",
            "Lat Pull Down",
            "Wide Low Row",
            "Narrow Low Row",
            "Whole Lat Pull Down",

        };
        List<string> chestShoulders = new List<string>
        {
            "Seated Dumbell Press",
            "Cable Face Pull Down",
            "Side Delt Raises",
            "Bench Press",
            "Incline Press",
            "Cable Cross",
            "25lbs Superset"
        };
        List<string> workouts = new List<string>
        {
            "Leg Day",
            "Back and Biceip",
            "Chest and Shoulders",
            "Cardio",
            "abs"
        };

        private void Workouts_Load(object sender, EventArgs e)
        {

        }


        private void liftingBttn_Click(object sender, EventArgs e)
        {
            DisplayLifts(legDay, backBicep, chestShoulders);
        }

        private void DisplayLifts(List<string> legDay, List<string> backBicep, List<string> chestShoulders)
        {
            int count = -1;
            allWorkoutsTB.Clear();
            foreach (string w in legDay)
            {
                count++;
                allWorkoutsTB.Text += "\r\n" + w.ToString() + "\r\n";
                allWorkoutsTB.Text += "\r\n" + backBicep[count] + "\r\n";
                allWorkoutsTB.Text += "\r\n" + chestShoulders[count] + "\r\n";
            }
        }

        private void DisplayAllWorkouts(List<string> cardio, List<string> abs, List<string> legDay, List<string> backBicep, List<string> chestShoulders)
        {
            int count = -1;
            allWorkoutsTB.Clear();
            foreach (string w in legDay)
            {
                count++;
                allWorkoutsTB.Text += "\r\n" + w.ToString() + "\r\n";
                allWorkoutsTB.Text += "\r\n" + cardio[count] + "\r\n";
                allWorkoutsTB.Text += "\r\n" + backBicep[count] + "\r\n";
                allWorkoutsTB.Text += "\r\n" + abs[count] + "\r\n";
                allWorkoutsTB.Text += "\r\n" + chestShoulders[count] + "\r\n";
            }
        }

        private void allBttn_Click(object sender, EventArgs e)
        {
            DisplayAllWorkouts(cardio, abs, legDay, backBicep, chestShoulders);
        }

        private void cardioBttn_Click(object sender, EventArgs e)
        {
            DisplayCardio(cardio);
        }

        private void DisplayCardio(List<string> cardio)
        {
            int count = -1;
            allWorkoutsTB.Clear();
            foreach (string r in cardio)
            {
                count++;
                allWorkoutsTB.Text += "\r\n" + r.ToString() + "\r\n";
            }
        }

        private void allWorkoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allWorkoutsPanel.Visible = true;
            liftingBttn.Visible = true;
            cardioBttn.Visible = true;
            allBttn.Visible = true;
            allWorkoutsTB.Visible = true;

            thisWeekPanel.Visible = false;
            tableLayoutPanel1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;

            marathonTrainingPanel.Visible = false;
            tableLayoutPanel2.Visible = false;
            week1.Visible = false;
            week2.Visible = false;
            week3.Visible = false;
            week4.Visible = false;
            week5.Visible = false;
            week6.Visible = false;
            week7.Visible = false;
            week8.Visible = false;
            week9.Visible = false;
            week10.Visible = false;
            week11.Visible = false;
            week12.Visible = false;
            week1TB.Visible = false;
            week2TB.Visible = false;
            week3TB.Visible = false;
            week4TB.Visible = false;
            week5TB.Visible = false;
            week6TB.Visible = false;
            week7TB.Visible = false;
            week8TB.Visible = false;
            week9TB.Visible = false;
            week10TB.Visible = false;
            week11TB.Visible = false;
            week12TB.Visible = false;



        }
        private void thisWeekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int rand = GetRandom();
            allWorkoutsPanel.Visible = false;
            liftingBttn.Visible = false;
            cardioBttn.Visible = false;
            allBttn.Visible = false;
            allWorkoutsTB.Visible = false;

            thisWeekPanel.Visible = true;
            tableLayoutPanel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            textBox1.Visible = true;
            textBox1.Text = workouts[GetRandom()];
            //GetWorkouts(textBox1.Text);
            textBox2.Visible = true;
            textBox2.Text = workouts[GetRandom()];
            //GetWorkouts(textBox2.Text);
            textBox3.Visible = true;
            textBox3.Text = workouts[GetRandom()];
            //GetWorkouts(textBox3.Text);
            textBox4.Visible = true;
            textBox4.Text = workouts[GetRandom()];
            //GetWorkouts(textBox4.Text);
            textBox5.Visible = true;
            textBox5.Text = workouts[GetRandom()];
            //GetWorkouts(textBox5.Text);
            textBox6.Visible = true;
            textBox6.Text = workouts[GetRandom()];
            //GetWorkouts(textBox6.Text);
            textBox7.Visible = true;
            textBox7.Text = workouts[GetRandom()];
            //GetWorkouts(textBox7.Text);
            checkedListBox1.Text += "Drink Water";
            checkedListBox1.Text += "\r\nTake Rest Days";
            checkedListBox1.Text += "\r\nEat Down<3";


            marathonTrainingPanel.Visible = false;
            tableLayoutPanel2.Visible = false;
            week1.Visible = false;
            week2.Visible = false;
            week3.Visible = false;
            week4.Visible = false;
            week5.Visible = false;
            week6.Visible = false;
            week7.Visible = false;
            week8.Visible = false;
            week9.Visible = false;
            week10.Visible = false;
            week11.Visible = false;
            week12.Visible = false;
            week1TB.Visible = false;
            week2TB.Visible = false;
            week3TB.Visible = false;
            week4TB.Visible = false;
            week5TB.Visible = false;
            week6TB.Visible = false;
            week7TB.Visible = false;
            week8TB.Visible = false;
            week9TB.Visible = false;
            week10TB.Visible = false;
            week11TB.Visible = false;
            week12TB.Visible = false;
        }

        private void marathonTrainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int miles = 10;

            allWorkoutsPanel.Visible = false;
            liftingBttn.Visible = false;
            cardioBttn.Visible = false;
            allBttn.Visible = false;
            allWorkoutsTB.Visible = false;

            thisWeekPanel.Visible = false;
            tableLayoutPanel1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;

            marathonTrainingPanel.Visible = true;
            tableLayoutPanel2.Visible = true;
            week1.Visible = true;
            week2.Visible = true;
            week3.Visible = true;
            week4.Visible = true;
            week5.Visible = true;
            week6.Visible = true;
            week7.Visible = true;
            week8.Visible = true;
            week9.Visible = true;
            week10.Visible = true;
            week11.Visible = true;
            week12.Visible = true;
            week1TB.Visible = true;
            week1TB.Text = miles + " miles";
            week2TB.Visible = true;
            week2TB.Text = (miles+2) + " miles";
            week3TB.Visible = true;
            week3TB.Text = (miles + 4) + " miles";
            week4TB.Visible = true;
            week4TB.Text = (miles) + " miles";
            week5TB.Visible = true;
            week5TB.Text = (miles + 4) + " miles";
            week6TB.Visible = true;
            week6TB.Text = (miles + 6) + " miles";
            week7TB.Visible = true;
            week7TB.Text = (miles + 8) + " miles";
            week8TB.Visible = true;
            week8TB.Text = (miles + 2) + " miles";
            week9TB.Visible = true;
            week9TB.Text = (miles + 8) + " miles";
            week10TB.Visible = true;
            week10TB.Text = (miles + 10) + " miles";
            week11TB.Visible = true;
            week11TB.Text = (miles + 12) + " miles";
            week12TB.Visible = true;
            week12TB.Text = (miles + 14) + " miles";
        }

        private void crossCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void thisWeekPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public int GetRandom()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 5);
            return num;
        }

        private void GetWorkouts(string day)
        {
            if (day == "Leg Day")
            {
                foreach (string w in legDay)
                {
                    checkedListBox1.Items.Add(w.ToString());
                }
            }
            else if (day == "Chest and Shoulders")
            {
                foreach (string w in chestShoulders)
                {
                    checkedListBox1.Items.Add(w.ToString());
                }
            }
            else if (day == "Back and Biceip")
            {
                foreach (string w in backBicep)
                {
                    checkedListBox1.Items.Add(w.ToString());
                }
            }
            else if (day == "abs")
            {
                foreach (string w in abs)
                {
                    checkedListBox1.Items.Add(w.ToString());
                }
            }
            else if (day == "Cardio")
            {
                Random rnd = new Random();
                int num = rnd.Next(0, 6);
                checkedListBox1.Items.Add(cardio[num]);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

            checkedListBox1.Items.Clear();

            GetWorkouts(textBox1.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            GetWorkouts(textBox2.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            GetWorkouts(textBox3.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            GetWorkouts(textBox4.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            GetWorkouts(textBox5.Text);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            GetWorkouts(textBox6.Text);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            GetWorkouts(textBox7.Text);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to leave the Workout Planner?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void week10_Click(object sender, EventArgs e)
        {

        }

        private void week8_Click(object sender, EventArgs e)
        {

        }

        private void week10TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void internetButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.halhigdon.com/training-programs/marathon-training/novice-2-marathon/#training-schedule");
        }

        private void reminderButton_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(reminders.Text);
            reminders.Clear();
        }
    }
}
