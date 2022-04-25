namespace Paveida2
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.OldEntryPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.oldEntryTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.QOTDpanel = new System.Windows.Forms.Panel();
            this.QOTD = new System.Windows.Forms.TextBox();
            this.QOTDsave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.oldQOTD = new System.Windows.Forms.TextBox();
            this.EntryPanel1 = new System.Windows.Forms.Panel();
            this.newEntryTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton3 = new System.Windows.Forms.Button();
            this.dateTextBox1 = new System.Windows.Forms.TextBox();
            this.dateLabel1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.SBListBox1 = new System.Windows.Forms.ListBox();
            this.searchBar1 = new System.Windows.Forms.Label();
            this.searchBarTB1 = new System.Windows.Forms.TextBox();
            this.EntryPanel = new System.Windows.Forms.Panel();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton2 = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OldEntryPanel.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.QOTDpanel.SuspendLayout();
            this.EntryPanel1.SuspendLayout();
            this.panel.SuspendLayout();
            this.EntryPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OldEntryPanel
            // 
            this.OldEntryPanel.Controls.Add(this.label1);
            this.OldEntryPanel.Controls.Add(this.oldEntryTextBox);
            this.OldEntryPanel.Location = new System.Drawing.Point(264, 96);
            this.OldEntryPanel.Name = "OldEntryPanel";
            this.OldEntryPanel.Size = new System.Drawing.Size(1025, 896);
            this.OldEntryPanel.TabIndex = 8;
            this.OldEntryPanel.Visible = false;
            this.OldEntryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OldEntryPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Old Entries";
            this.label1.Visible = false;
            // 
            // oldEntryTextBox
            // 
            this.oldEntryTextBox.Location = new System.Drawing.Point(35, 101);
            this.oldEntryTextBox.Multiline = true;
            this.oldEntryTextBox.Name = "oldEntryTextBox";
            this.oldEntryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.oldEntryTextBox.Size = new System.Drawing.Size(762, 660);
            this.oldEntryTextBox.TabIndex = 0;
            this.oldEntryTextBox.TextChanged += new System.EventHandler(this.oldEntryTextBox_TextChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip2.Location = new System.Drawing.Point(230, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1365, 85);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(178, 79);
            this.toolStripButton1.Text = "New Entry";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(129, 79);
            this.toolStripButton2.Text = "QOTD";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(186, 79);
            this.toolStripButton3.Text = "Old Entries";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(240, 79);
            this.toolStripButton4.Text = "Year Ago Today";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(135, 79);
            this.toolStripButton5.Text = "Search";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(99, 79);
            this.toolStripButton6.Text = "Exit";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 140);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Enter Your Response Here...";
            this.textBox2.Size = new System.Drawing.Size(850, 320);
            this.textBox2.TabIndex = 6;
            this.textBox2.Visible = false;
            // 
            // QOTDpanel
            // 
            this.QOTDpanel.Controls.Add(this.QOTD);
            this.QOTDpanel.Controls.Add(this.QOTDsave);
            this.QOTDpanel.Controls.Add(this.label2);
            this.QOTDpanel.Controls.Add(this.oldQOTD);
            this.QOTDpanel.Controls.Add(this.textBox2);
            this.QOTDpanel.Location = new System.Drawing.Point(261, 156);
            this.QOTDpanel.Name = "QOTDpanel";
            this.QOTDpanel.Size = new System.Drawing.Size(885, 903);
            this.QOTDpanel.TabIndex = 10;
            // 
            // QOTD
            // 
            this.QOTD.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QOTD.Location = new System.Drawing.Point(16, 31);
            this.QOTD.Multiline = true;
            this.QOTD.Name = "QOTD";
            this.QOTD.Size = new System.Drawing.Size(612, 83);
            this.QOTD.TabIndex = 11;
            this.QOTD.Text = "QOTD goes here";
            this.QOTD.Visible = false;
            // 
            // QOTDsave
            // 
            this.QOTDsave.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QOTDsave.Location = new System.Drawing.Point(697, 66);
            this.QOTDsave.Name = "QOTDsave";
            this.QOTDsave.Size = new System.Drawing.Size(169, 52);
            this.QOTDsave.TabIndex = 10;
            this.QOTDsave.Text = "Save";
            this.QOTDsave.UseVisualStyleBackColor = true;
            this.QOTDsave.Visible = false;
            this.QOTDsave.Click += new System.EventHandler(this.QOTDsave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Old QOTDs:";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // oldQOTD
            // 
            this.oldQOTD.Location = new System.Drawing.Point(16, 529);
            this.oldQOTD.Multiline = true;
            this.oldQOTD.Name = "oldQOTD";
            this.oldQOTD.Size = new System.Drawing.Size(850, 357);
            this.oldQOTD.TabIndex = 8;
            this.oldQOTD.Visible = false;
            this.oldQOTD.TextChanged += new System.EventHandler(this.oldQOTD_TextChanged);
            // 
            // EntryPanel1
            // 
            this.EntryPanel1.Controls.Add(this.newEntryTextBox);
            this.EntryPanel1.Controls.Add(this.SaveButton3);
            this.EntryPanel1.Controls.Add(this.dateTextBox1);
            this.EntryPanel1.Controls.Add(this.dateLabel1);
            this.EntryPanel1.Location = new System.Drawing.Point(277, 127);
            this.EntryPanel1.Name = "EntryPanel1";
            this.EntryPanel1.Size = new System.Drawing.Size(862, 880);
            this.EntryPanel1.TabIndex = 11;
            this.EntryPanel1.Visible = false;
            // 
            // newEntryTextBox
            // 
            this.newEntryTextBox.Location = new System.Drawing.Point(19, 116);
            this.newEntryTextBox.Multiline = true;
            this.newEntryTextBox.Name = "newEntryTextBox";
            this.newEntryTextBox.Size = new System.Drawing.Size(818, 691);
            this.newEntryTextBox.TabIndex = 2;
            this.newEntryTextBox.Visible = false;
            // 
            // SaveButton3
            // 
            this.SaveButton3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveButton3.Location = new System.Drawing.Point(657, 813);
            this.SaveButton3.Name = "SaveButton3";
            this.SaveButton3.Size = new System.Drawing.Size(169, 52);
            this.SaveButton3.TabIndex = 3;
            this.SaveButton3.Text = "Save";
            this.SaveButton3.UseVisualStyleBackColor = true;
            this.SaveButton3.Visible = false;
            this.SaveButton3.Click += new System.EventHandler(this.SaveButton3_Click);
            // 
            // dateTextBox1
            // 
            this.dateTextBox1.Location = new System.Drawing.Point(228, 37);
            this.dateTextBox1.Name = "dateTextBox1";
            this.dateTextBox1.Size = new System.Drawing.Size(511, 43);
            this.dateTextBox1.TabIndex = 1;
            this.dateTextBox1.Visible = false;
            // 
            // dateLabel1
            // 
            this.dateLabel1.AutoSize = true;
            this.dateLabel1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateLabel1.Location = new System.Drawing.Point(63, 40);
            this.dateLabel1.Name = "dateLabel1";
            this.dateLabel1.Size = new System.Drawing.Size(159, 37);
            this.dateLabel1.TabIndex = 0;
            this.dateLabel1.Text = "Date/Title:";
            this.dateLabel1.Visible = false;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.SBListBox1);
            this.panel.Controls.Add(this.searchBar1);
            this.panel.Controls.Add(this.searchBarTB1);
            this.panel.Location = new System.Drawing.Point(238, 127);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1051, 900);
            this.panel.TabIndex = 12;
            this.panel.Visible = false;
            // 
            // SBListBox1
            // 
            this.SBListBox1.FormattingEnabled = true;
            this.SBListBox1.ItemHeight = 37;
            this.SBListBox1.Location = new System.Drawing.Point(134, 171);
            this.SBListBox1.Name = "SBListBox1";
            this.SBListBox1.Size = new System.Drawing.Size(653, 559);
            this.SBListBox1.TabIndex = 2;
            this.SBListBox1.Visible = false;
            // 
            // searchBar1
            // 
            this.searchBar1.AutoSize = true;
            this.searchBar1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchBar1.Location = new System.Drawing.Point(145, 110);
            this.searchBar1.Name = "searchBar1";
            this.searchBar1.Size = new System.Drawing.Size(113, 37);
            this.searchBar1.TabIndex = 1;
            this.searchBar1.Text = "Search:";
            this.searchBar1.Visible = false;
            // 
            // searchBarTB1
            // 
            this.searchBarTB1.Location = new System.Drawing.Point(271, 107);
            this.searchBarTB1.Name = "searchBarTB1";
            this.searchBarTB1.Size = new System.Drawing.Size(516, 43);
            this.searchBarTB1.TabIndex = 0;
            this.searchBarTB1.TextChanged += new System.EventHandler(this.searchBarTB1_TextChanged);
            // 
            // EntryPanel
            // 
            this.EntryPanel.Controls.Add(this.dateTextBox);
            this.EntryPanel.Controls.Add(this.SaveButton2);
            this.EntryPanel.Controls.Add(this.dateLabel);
            this.EntryPanel.Controls.Add(this.textBox1);
            this.EntryPanel.Location = new System.Drawing.Point(382, 155);
            this.EntryPanel.Name = "EntryPanel";
            this.EntryPanel.Size = new System.Drawing.Size(1096, 927);
            this.EntryPanel.TabIndex = 11;
            this.EntryPanel.Visible = false;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(280, 58);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(607, 43);
            this.dateTextBox.TabIndex = 3;
            this.dateTextBox.Visible = false;
            this.dateTextBox.TextChanged += new System.EventHandler(this.dateTextBox_TextChanged);
            // 
            // SaveButton2
            // 
            this.SaveButton2.Location = new System.Drawing.Point(769, 855);
            this.SaveButton2.Name = "SaveButton2";
            this.SaveButton2.Size = new System.Drawing.Size(169, 52);
            this.SaveButton2.TabIndex = 11;
            this.SaveButton2.Text = "Save";
            this.SaveButton2.UseVisualStyleBackColor = true;
            this.SaveButton2.Visible = false;
            this.SaveButton2.Click += new System.EventHandler(this.SaveButton2_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(57, 53);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(141, 37);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Date/Title:";
            this.dateLabel.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 130);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(836, 697);
            this.textBox1.TabIndex = 5;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.EntryPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 1281);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1595, 1281);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.EntryPanel1);
            this.Controls.Add(this.OldEntryPanel);
            this.Controls.Add(this.QOTDpanel);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Journal";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.OldEntryPanel.ResumeLayout(false);
            this.OldEntryPanel.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.QOTDpanel.ResumeLayout(false);
            this.QOTDpanel.PerformLayout();
            this.EntryPanel1.ResumeLayout(false);
            this.EntryPanel1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.EntryPanel.ResumeLayout(false);
            this.EntryPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ToolStrip toolStrip2;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ContextMenuStrip contextMenuStrip1;
        private Panel OldEntryPanel;
        private SaveFileDialog saveFileDialog1;
        private TextBox textBox2;
        private Label label1;
        private TextBox oldEntryTextBox;
        private Panel QOTDpanel;
        private Label label2;
        private TextBox oldQOTD;
        private Button QOTDsave;
        private TextBox QOTD;
        private Panel EntryPanel1;
        private Label dateLabel1;
        private TextBox dateTextBox1;
        private TextBox newEntryTextBox;
        private Button SaveButton3;
        private ToolStripButton toolStripButton6;
        private Panel EntryPanel;
        private TextBox dateTextBox;
        private Button SaveButton2;
        private Label dateLabel;
        private TextBox textBox1;
        private Panel panel2;
        private Panel panel;
        private ListBox SBListBox1;
        private Label searchBar1;
        private TextBox searchBarTB1;
    }
}