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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        //Initializing array for the entries
        List<string> journal = new List<string>();
        List<string> dates = new List<string>();
        List<string> QOTDJournal = new List<string>();
        List<string> QOTDs = new List<string>();


        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Would you like to leave the journal?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            // Old Entries
            dateLabel1.Visible = false;
            dateTextBox1.Visible = false;
            SaveButton3.Visible = false;
            EntryPanel1.Visible = false;
            newEntryTextBox.Visible = false;
      
            textBox2.Visible = false;
            QOTDpanel.Visible = false;
            QOTDsave.Visible = false;
            QOTD.Visible = false;
            label2.Visible = false;
            oldQOTD.Visible = false;

            OldEntryPanel.Visible = true;
            oldEntryTextBox.Visible = true;
            label1.Visible = true;

            panel.Visible = false;
            searchBar1.Visible = false;
            searchBarTB1.Visible = false;
            SBListBox1.Visible = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // New Entry
            dateLabel1.Visible = true;
            dateTextBox1.Visible = true;
            SaveButton3.Visible = true;
            EntryPanel1.Visible = true;
            newEntryTextBox.Visible = true;

            textBox2.Visible = false;
            QOTDpanel.Visible = false;
            QOTDsave.Visible = false;
            QOTD.Visible = false;
            label2.Visible = false;
            oldQOTD.Visible = false;

            OldEntryPanel.Visible = false;
            oldEntryTextBox.Visible = false;
            label1.Visible = false;

            panel.Visible = false;
            searchBar1.Visible = false;
            searchBarTB1.Visible = false;
            SBListBox1.Visible = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // QOTD
            dateLabel1.Visible = false;
            dateTextBox1.Visible = false;
            SaveButton3.Visible = false;
            EntryPanel1.Visible = false;
            newEntryTextBox.Visible = false;

            textBox2.Visible = true;
            QOTDpanel.Visible = true;
            QOTDsave.Visible = true;
            QOTD.Visible = true;
            QOTD.Text = GetQOTD(QOTDmasterList);
            label2.Visible = true;
            oldQOTD.Visible = true;

            OldEntryPanel.Visible = false;
            oldEntryTextBox.Visible = false;
            label1.Visible = false;

            panel.Visible = false;
            searchBar1.Visible = false;
            searchBarTB1.Visible = false;
            SBListBox1.Visible = false;

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            // Year Ago Today
            dateLabel1.Visible = false;
            dateTextBox1.Visible = false;
            SaveButton3.Visible = false;
            EntryPanel1.Visible = false;
            newEntryTextBox.Visible = false;

            textBox2.Visible = false;
            QOTDpanel.Visible = false;
            QOTDsave.Visible = false;
            QOTD.Visible = false;
            label2.Visible = false;
            oldQOTD.Visible = false;

            OldEntryPanel.Visible = false;
            oldEntryTextBox.Visible = false;
            label1.Visible = false;

            panel.Visible = false;
            searchBar1.Visible = false;
            searchBarTB1.Visible = false;
            SBListBox1.Visible = false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            // Search
            dateLabel1.Visible = false;
            dateTextBox1.Visible = false;
            SaveButton3.Visible = false;
            EntryPanel1.Visible = false;
            newEntryTextBox.Visible = false;

            textBox2.Visible = false;
            QOTDpanel.Visible = false;
            QOTDsave.Visible = false;
            QOTD.Visible = false;
            label2.Visible = false;
            oldQOTD.Visible = false;


            OldEntryPanel.Visible = false;
            oldEntryTextBox.Visible = false;
            label1.Visible = false;

            panel.Visible = true;
            searchBar1.Visible = true;
            searchBarTB1.Visible = true;
            SBListBox1.Visible = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Lets the user save their entry
            //var dialogResult = sfdSaveValuesAsFile.ShowDialog();
            //if (dialogResult == System.Windows.Forms.DialogResult.OK)
            //{
            //    System.IO.File.WriteAllText(sfdSaveValuesAsFile.FileName, txtValues.Text);
            //}
            string newEntry = newEntryTextBox.Text;
            journal.Add(newEntry);
            newEntryTextBox.Clear();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // new entry
            // string newEntry = textBox1.Text;
        }

        private void searchBarTB_TextChanged(object sender, EventArgs e)
        {
            string searchVal = searchBarTB1.Text;
            if (string.IsNullOrEmpty(searchBarTB1.Text) == false)
            {
                SBListBox1.Items.Clear();
                foreach (string str in journal)
                {
                    if (str.StartsWith(searchVal))
                    {
                        SBListBox1.Items.Add(str);
                    }
                }
            }
            else if (searchBarTB1.Text == "")
            {
                SBListBox1.Items.Clear();
                foreach (string str in journal)
                {
                    SBListBox1.Items.Add(str);
                }
            }
        }

        private void searchBarTB_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OldEntryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void oldEntryTextBox_TextChanged(object sender, EventArgs e)
        {
             //DisplayOldEntries(journal, dates);
        }

        private void DisplayOldEntries(List<string> journal, List<string> dates)
        {
            int count = -1;
            oldEntryTextBox.Clear();
            foreach (string d in dates)
            {
                count++;
                oldEntryTextBox.Text += "\r\n\r\n" + d.ToString() + ": " + journal[count];
            }
            //return null;
        }

        private void oldQOTD_TextChanged(object sender, EventArgs e)
        {
            //DisplayOldQOTD(QOTDJournal, QOTDs);
        }

        private void DisplayOldQOTD(List<string> QOTDJournal, List<string> QOTDs)
        {
            int count = -1;
            oldQOTD.Clear();
            foreach (string q in QOTDs)
            {
                count++;
                oldQOTD.Text += "\r\n" + q.ToString() + "\r\n " + QOTDJournal[count];
            }
        }

        private void SaveButton2_Click(object sender, EventArgs e)
        {
            string newEntry = newEntryTextBox.Text;
            journal.Add(newEntry);
            string newDate = dateTextBox1.Text;
            dates.Add(newDate);
            newEntryTextBox.Clear();
            dateTextBox1.Clear();
            DisplayOldEntries(journal, dates);
        }

        private void searchBarTB_TextChanged_1(object sender, EventArgs e)
        {
            string searchVal = searchBarTB1.Text;
            if (string.IsNullOrEmpty(searchBarTB1.Text) == false)
            {
                SBListBox1.Items.Clear();
                foreach (string str in journal)
                {
                    if (str.StartsWith(searchVal))
                    {
                        SBListBox1.Items.Add(str);
                    }
                }
            }
            else if (searchBarTB1.Text == "")
            {
                SBListBox1.Items.Clear();
                foreach (string str in journal)
                {
                    SBListBox1.Items.Add(str);
                }
            }
        }

        private void dateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QOTDsave_Click(object sender, EventArgs e)
        {
            string newEntry = textBox2.Text;
            QOTDJournal.Add(newEntry);
            string newQOTD = QOTD.Text;
            QOTDs.Add(newQOTD);
            textBox2.Clear();
            //dateTextBox.Clear();
            DisplayOldQOTD(QOTDJournal, QOTDs);
            newQOTD = GetQOTD(QOTDmasterList);
            QOTD.Text = newQOTD;

        }

        List<string> QOTDmasterList = new List<string>
        {
            "If You Had Three Wishes, What Would You Wish For?",
            "What Would You Rather Throw Away: Love Or Money?",
            "What Would You Rather Throw Away: Love Or Money?", 
            "If you were a Super Hero what would your catch-phrase be?",
            "What do you think Adam Sandler is doing RIGHT NOW?",
            "What's the weirdest thing in your fridge?",
            "What song was or do you want to be the your first dance at your wedding?",
            "If you had to title this chapter of your life what would it be?",
            "What do you think your purpose is?",
            "Who is your favorite person?",
            "Whats your biggest fear?",
            "Tell me a secret you have never told anyone?",
            "Was Karlie Kloss really looking camp right in the eye?",
            "Micheal Jackson has 3 kids all named Blanket, how does that make you feel?"
        };
        
        public string GetQOTD(List<string> list)
        {
            string newQOTD;
            int count = -1;
            foreach (string str in list)
            {
                count++;
            }
            Random r = new Random();
            int random = r.Next(count);
            newQOTD = list[random];
            return newQOTD;
        }

        private void SaveButton3_Click(object sender, EventArgs e)
        {
            string newEntry = newEntryTextBox.Text;
            journal.Add(newEntry);
            string newDate = dateTextBox1.Text;
            dates.Add(newDate);
            newEntryTextBox.Clear();
            dateTextBox1.Clear();
            DisplayOldEntries(journal, dates);
        }

        private void SBListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to leave the journal?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void searchBarTB1_TextChanged(object sender, EventArgs e)
        {
            string searchVal = searchBarTB1.Text;
            if (string.IsNullOrEmpty(searchBarTB1.Text) == false)
            {
                SBListBox1.Items.Clear();
                //foreach (string str in recipes)
                //{
                //    if (str.StartsWith(searchVal))
                //    {
                //        searchListBox.Items.Add(str);
                //    }
                //    
                //}
                int count = -1;
                foreach (string strng in dates)
                {
                    count++;
                    if (strng.StartsWith(searchVal))
                    {

                        SBListBox1.Items.Add(strng + ": \r\n" + journal[count]);
                    }
                }
            }
            else if (searchBarTB1.Text == "")
            {
                SBListBox1.Items.Clear();
                foreach (string str in dates)
                {
                    SBListBox1.Items.Add(str);
                }
            }
        }
    }
}
