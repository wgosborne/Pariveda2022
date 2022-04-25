namespace Paveida2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            todayTB.Text = "";
            todayTB.Text += "\r\n\r\n\r\nWorkout:";
            todayTB.Text += "\r\n\r\n\r\nEAT DOWN<3";
            //recipesHere = Recipes.GetRecipes();

            //textBox1.Text = 
            //textBox2.Text =
            //textBox3.Text =
            //textBox4.Text =
            //textBox5.Text =
            //textBox6.Text =
            //textBox7.Text =
        }
        //List<string> recipesHere = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void outfitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            //this.Close();
        }

        private void journalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            //this.Close();
        }

        private void recipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recipes f4 = new Recipes();
            f4.ShowDialog();
            //this.Close();
        }

        private void toDoListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToDoList f5 = new ToDoList();
            f5.ShowDialog();
            //this.Close();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to leave the Productivity Slayurr TM?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Today Text box
            //todayTB.Text = "Whats up";
        }

        private void workoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Workouts page
            Workouts f6 = new Workouts();
            f6.ShowDialog();
            //this.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void calendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Zodiac Page
            Costar f7 = new Costar();
            f7.ShowDialog();

        }

        private void entryBttn_Click(object sender, EventArgs e)
        {
            writeTo.Text += "\r\n• " + entryBox.Text;
        }

        private void entryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void writeToLabel_Click(object sender, EventArgs e)
        {

        }

        private void writeTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void todayTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void weekAdd_Click(object sender, EventArgs e)
        {
            if (weekDate.Text.ToLower() == "monday")
            {
                textBox1.Text += "\r\n• " + weekTask.Text;
            }
            else if (weekDate.Text.ToLower() == "tuesday")
            {
                textBox2.Text += "\r\n• " + weekTask.Text;
            }
            else if (weekDate.Text.ToLower() == "wednesday")
            {
                textBox3.Text += "\r\n• " + weekTask.Text;
            }
            else if (weekDate.Text.ToLower() == "thursday")
            {
                textBox4.Text += "\r\n• " + weekTask.Text;
            }
            else if (weekDate.Text.ToLower() == "friday")
            {
                textBox5.Text += "\r\n• " + weekTask.Text;
            }
            else if (weekDate.Text.ToLower() == "saturday")
            {
                textBox6.Text += "\r\n• " + weekTask.Text;
            }
            else if (weekDate.Text.ToLower() == "sunday")
            {
                textBox7.Text += "\r\n• " + weekTask.Text;
            }

            weekTask.Clear();
            weekDate.Clear();
        }
    }
}