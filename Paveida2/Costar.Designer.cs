namespace Paveida2
{
    partial class Costar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Costar));
            this.zodiacPanel = new System.Windows.Forms.Panel();
            this.go = new System.Windows.Forms.Button();
            this.zodiacInfo = new System.Windows.Forms.TextBox();
            this.birthDay = new System.Windows.Forms.TextBox();
            this.enterBirthDay = new System.Windows.Forms.Label();
            this.enterBirthMonth = new System.Windows.Forms.Label();
            this.birthMonth = new System.Windows.Forms.TextBox();
            this.exitBttn = new System.Windows.Forms.Button();
            this.zodiacPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // zodiacPanel
            // 
            this.zodiacPanel.BackColor = System.Drawing.Color.Transparent;
            this.zodiacPanel.Controls.Add(this.exitBttn);
            this.zodiacPanel.Controls.Add(this.go);
            this.zodiacPanel.Controls.Add(this.zodiacInfo);
            this.zodiacPanel.Controls.Add(this.birthDay);
            this.zodiacPanel.Controls.Add(this.enterBirthDay);
            this.zodiacPanel.Controls.Add(this.enterBirthMonth);
            this.zodiacPanel.Controls.Add(this.birthMonth);
            this.zodiacPanel.Location = new System.Drawing.Point(161, 55);
            this.zodiacPanel.Name = "zodiacPanel";
            this.zodiacPanel.Size = new System.Drawing.Size(999, 773);
            this.zodiacPanel.TabIndex = 0;
            this.zodiacPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.zodiacPanel_Paint);
            // 
            // go
            // 
            this.go.BackColor = System.Drawing.Color.SlateBlue;
            this.go.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.go.ForeColor = System.Drawing.Color.White;
            this.go.Location = new System.Drawing.Point(161, 235);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(153, 52);
            this.go.TabIndex = 1;
            this.go.Text = "Go";
            this.go.UseVisualStyleBackColor = false;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // zodiacInfo
            // 
            this.zodiacInfo.Location = new System.Drawing.Point(154, 303);
            this.zodiacInfo.Multiline = true;
            this.zodiacInfo.Name = "zodiacInfo";
            this.zodiacInfo.Size = new System.Drawing.Size(700, 443);
            this.zodiacInfo.TabIndex = 4;
            // 
            // birthDay
            // 
            this.birthDay.Location = new System.Drawing.Point(358, 164);
            this.birthDay.Name = "birthDay";
            this.birthDay.Size = new System.Drawing.Size(491, 43);
            this.birthDay.TabIndex = 3;
            // 
            // enterBirthDay
            // 
            this.enterBirthDay.AutoSize = true;
            this.enterBirthDay.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterBirthDay.ForeColor = System.Drawing.Color.White;
            this.enterBirthDay.Location = new System.Drawing.Point(154, 164);
            this.enterBirthDay.Name = "enterBirthDay";
            this.enterBirthDay.Size = new System.Drawing.Size(160, 37);
            this.enterBirthDay.TabIndex = 2;
            this.enterBirthDay.Text = "Birth Day: ";
            // 
            // enterBirthMonth
            // 
            this.enterBirthMonth.AutoSize = true;
            this.enterBirthMonth.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterBirthMonth.ForeColor = System.Drawing.Color.White;
            this.enterBirthMonth.Location = new System.Drawing.Point(154, 76);
            this.enterBirthMonth.Name = "enterBirthMonth";
            this.enterBirthMonth.Size = new System.Drawing.Size(198, 37);
            this.enterBirthMonth.TabIndex = 1;
            this.enterBirthMonth.Text = "Birth Month: ";
            // 
            // birthMonth
            // 
            this.birthMonth.Location = new System.Drawing.Point(358, 76);
            this.birthMonth.Name = "birthMonth";
            this.birthMonth.Size = new System.Drawing.Size(491, 43);
            this.birthMonth.TabIndex = 0;
            // 
            // exitBttn
            // 
            this.exitBttn.BackColor = System.Drawing.Color.SlateBlue;
            this.exitBttn.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBttn.ForeColor = System.Drawing.Color.White;
            this.exitBttn.Location = new System.Drawing.Point(696, 235);
            this.exitBttn.Name = "exitBttn";
            this.exitBttn.Size = new System.Drawing.Size(153, 52);
            this.exitBttn.TabIndex = 5;
            this.exitBttn.Text = "Exit";
            this.exitBttn.UseVisualStyleBackColor = false;
            this.exitBttn.Click += new System.EventHandler(this.exitBttn_Click);
            // 
            // Costar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1462, 953);
            this.Controls.Add(this.zodiacPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Costar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Costar";
            this.Load += new System.EventHandler(this.Costar_Load);
            this.zodiacPanel.ResumeLayout(false);
            this.zodiacPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel zodiacPanel;
        private TextBox birthDay;
        private Label enterBirthDay;
        private Label enterBirthMonth;
        private TextBox birthMonth;
        private TextBox zodiacInfo;
        private Button go;
        private Button exitBttn;
    }
}