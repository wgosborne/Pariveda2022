namespace Paveida2
{
    partial class ToDoList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.CalendarGroupBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ToDoCloseButton = new System.Windows.Forms.Button();
            this.CalendarGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 87);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(657, 831);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "To Do List:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(958, 38);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(222, 43);
            this.DateBox.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(106, 81);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // CalendarGroupBox
            // 
            this.CalendarGroupBox.Controls.Add(this.button2);
            this.CalendarGroupBox.Controls.Add(this.button3);
            this.CalendarGroupBox.Controls.Add(this.monthCalendar1);
            this.CalendarGroupBox.Location = new System.Drawing.Point(732, 87);
            this.CalendarGroupBox.Name = "CalendarGroupBox";
            this.CalendarGroupBox.Size = new System.Drawing.Size(662, 556);
            this.CalendarGroupBox.TabIndex = 4;
            this.CalendarGroupBox.TabStop = false;
            this.CalendarGroupBox.Text = "Calendar";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 52);
            this.button2.TabIndex = 6;
            this.button2.Text = "Hide";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(413, 451);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 52);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(770, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ToDoCloseButton
            // 
            this.ToDoCloseButton.Location = new System.Drawing.Point(1206, 829);
            this.ToDoCloseButton.Name = "ToDoCloseButton";
            this.ToDoCloseButton.Size = new System.Drawing.Size(169, 52);
            this.ToDoCloseButton.TabIndex = 6;
            this.ToDoCloseButton.Text = "Close";
            this.ToDoCloseButton.UseVisualStyleBackColor = true;
            this.ToDoCloseButton.Click += new System.EventHandler(this.ToDoCloseButton_Click);
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 955);
            this.Controls.Add(this.ToDoCloseButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CalendarGroupBox);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "ToDoList";
            this.Text = "ToDoList";
            this.Load += new System.EventHandler(this.ToDoList_Load);
            this.CalendarGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox DateBox;
        private MonthCalendar monthCalendar1;
        private GroupBox CalendarGroupBox;
        private Button button2;
        private Button button3;
        private Button button1;
        private Button ToDoCloseButton;
    }
}