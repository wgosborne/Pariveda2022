using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Paveida2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Loads the images for outerwear
            //button1_load();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Random Outerwear
            
            //Show the open file dialogue
            //If user clicks OK, load the pic that the user chose
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    pictureBox1.Load(openFileDialog1.FileName);
            //}
            Random rnd = new Random();
            int num = rnd.Next(3,7);
            string o;
            o = Application.StartupPath + "\\ClothesPics\\OuterWear\\" + num.ToString() + ".jpg";
            pictureBox1.ImageLocation = o;
            pictureBox1.Visible = true;

        }
        
        //Gives the pics to the outerwear button
        //Dont need this anymore
        public void button1_load()
        {
            Random rnd = new Random();
            int num = rnd.Next(2);
            string fn;
            fn = Application.StartupPath + "\\ClothesPics\\OuterWear\\" + num.ToString() +".jpg";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Displaying Random Top
            Random rnd = new Random();
        //    int num = rnd.Next(3,13);
        //    string t;
            //string fileName = @"C:\Users\wgosb\source\repos\Paveida2\ClothesPics\tops\";
        //    t = Application.StartupPath + "\\ClothesPics\\tops\\" + num.ToString() + ".jpg";
            //t = Application.StartupPath + fileName + num.ToString() + ".jpg";
        //    topPic.ImageLocation = t;
        //    topPic.Visible = true;

        //}

        public void button2_load()
        {
            Random rnd = new Random();
            int num = rnd.Next(2);
            string fn;
            fn = Application.StartupPath + "\\ClothesPics\\tops\\" + num.ToString() + ".jpg";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Displaying random bottoms
            Random rnd = new Random();
            int num = rnd.Next(3,10);
            string b;
            b = Application.StartupPath + "\\ClothesPics\\bottoms\\" + num.ToString() + ".jpg";
            pictureBox3.ImageLocation = b;
            pictureBox3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Displaying Random Shoes
            Random rnd = new Random();
            int num = rnd.Next(3,8);
            string s;
            s = Application.StartupPath + "\\ClothesPics\\shoes\\" + num.ToString() + ".jpg";
            pictureBox2.ImageLocation = s;
            pictureBox2.Visible = true;
        }

        private void OutfitsCloseButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to leave the Outfit Maker?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
