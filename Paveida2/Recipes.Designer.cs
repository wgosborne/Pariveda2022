namespace Paveida2
{
    partial class Recipes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recipes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitBttn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.recipeNameLabel = new System.Windows.Forms.Label();
            this.addRecipeTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AllRecipesPanel = new System.Windows.Forms.Panel();
            this.Recipe1 = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.RecipeSearchPanel = new System.Windows.Forms.Panel();
            this.searchListBox = new System.Windows.Forms.ListBox();
            this.searchBarLabelRecipe = new System.Windows.Forms.Label();
            this.searchBarRecipes = new System.Windows.Forms.TextBox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.AddRecipePanel = new System.Windows.Forms.Panel();
            this.saveNewRecipe = new System.Windows.Forms.Button();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.AllRecipesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.RecipeSearchPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.AddRecipePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exitBttn);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-4, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 1137);
            this.panel1.TabIndex = 0;
            // 
            // exitBttn
            // 
            this.exitBttn.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBttn.Location = new System.Drawing.Point(75, 758);
            this.exitBttn.Name = "exitBttn";
            this.exitBttn.Size = new System.Drawing.Size(280, 143);
            this.exitBttn.TabIndex = 5;
            this.exitBttn.Text = "Exit";
            this.exitBttn.UseVisualStyleBackColor = true;
            this.exitBttn.Click += new System.EventHandler(this.exitBttn_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(75, 526);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(280, 143);
            this.button4.TabIndex = 4;
            this.button4.Text = "Add Recipe";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(75, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(280, 131);
            this.button3.TabIndex = 3;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(75, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 142);
            this.button1.TabIndex = 1;
            this.button1.Text = "All Recipes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // recipeNameLabel
            // 
            this.recipeNameLabel.AutoSize = true;
            this.recipeNameLabel.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.recipeNameLabel.Location = new System.Drawing.Point(78, 37);
            this.recipeNameLabel.Name = "recipeNameLabel";
            this.recipeNameLabel.Size = new System.Drawing.Size(286, 37);
            this.recipeNameLabel.TabIndex = 1;
            this.recipeNameLabel.Text = "Name of the Recipe:";
            this.recipeNameLabel.Visible = false;
            this.recipeNameLabel.Click += new System.EventHandler(this.recipeNameLabel_Click);
            // 
            // addRecipeTextBox
            // 
            this.addRecipeTextBox.Location = new System.Drawing.Point(78, 101);
            this.addRecipeTextBox.Multiline = true;
            this.addRecipeTextBox.Name = "addRecipeTextBox";
            this.addRecipeTextBox.PlaceholderText = "Enter Recipe Here...";
            this.addRecipeTextBox.Size = new System.Drawing.Size(858, 868);
            this.addRecipeTextBox.TabIndex = 2;
            this.addRecipeTextBox.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(572, 43);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AllRecipesPanel
            // 
            this.AllRecipesPanel.Controls.Add(this.Recipe1);
            this.AllRecipesPanel.Location = new System.Drawing.Point(564, 13);
            this.AllRecipesPanel.Name = "AllRecipesPanel";
            this.AllRecipesPanel.Size = new System.Drawing.Size(867, 1076);
            this.AllRecipesPanel.TabIndex = 4;
            this.AllRecipesPanel.Visible = false;
            // 
            // Recipe1
            // 
            this.Recipe1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Recipe1.Location = new System.Drawing.Point(15, 16);
            this.Recipe1.Multiline = true;
            this.Recipe1.Name = "Recipe1";
            this.Recipe1.PlaceholderText = "No Recipes Yet...";
            this.Recipe1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Recipe1.Size = new System.Drawing.Size(843, 940);
            this.Recipe1.TabIndex = 0;
            this.Recipe1.TextChanged += new System.EventHandler(this.Recipe1_TextChanged);
            // 
            // RecipeSearchPanel
            // 
            this.RecipeSearchPanel.Controls.Add(this.searchListBox);
            this.RecipeSearchPanel.Controls.Add(this.searchBarLabelRecipe);
            this.RecipeSearchPanel.Controls.Add(this.searchBarRecipes);
            this.RecipeSearchPanel.Location = new System.Drawing.Point(72, 135);
            this.RecipeSearchPanel.Name = "RecipeSearchPanel";
            this.RecipeSearchPanel.Size = new System.Drawing.Size(776, 764);
            this.RecipeSearchPanel.TabIndex = 12;
            this.RecipeSearchPanel.Visible = false;
            // 
            // searchListBox
            // 
            this.searchListBox.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchListBox.FormattingEnabled = true;
            this.searchListBox.ItemHeight = 37;
            this.searchListBox.Location = new System.Drawing.Point(31, 171);
            this.searchListBox.Name = "searchListBox";
            this.searchListBox.Size = new System.Drawing.Size(707, 559);
            this.searchListBox.TabIndex = 0;
            this.searchListBox.Visible = false;
            this.searchListBox.SelectedIndexChanged += new System.EventHandler(this.searchListBox_SelectedIndexChanged);
            // 
            // searchBarLabelRecipe
            // 
            this.searchBarLabelRecipe.AutoSize = true;
            this.searchBarLabelRecipe.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchBarLabelRecipe.Location = new System.Drawing.Point(69, 65);
            this.searchBarLabelRecipe.Name = "searchBarLabelRecipe";
            this.searchBarLabelRecipe.Size = new System.Drawing.Size(167, 37);
            this.searchBarLabelRecipe.TabIndex = 10;
            this.searchBarLabelRecipe.Text = "Search Bar:";
            this.searchBarLabelRecipe.Visible = false;
            // 
            // searchBarRecipes
            // 
            this.searchBarRecipes.Location = new System.Drawing.Point(246, 65);
            this.searchBarRecipes.Name = "searchBarRecipes";
            this.searchBarRecipes.Size = new System.Drawing.Size(427, 43);
            this.searchBarRecipes.TabIndex = 11;
            this.searchBarRecipes.Visible = false;
            this.searchBarRecipes.TextChanged += new System.EventHandler(this.searchBarRecipes_TextChanged);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.RecipeSearchPanel);
            this.searchPanel.Location = new System.Drawing.Point(504, 46);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(937, 1040);
            this.searchPanel.TabIndex = 6;
            this.searchPanel.Visible = false;
            // 
            // AddRecipePanel
            // 
            this.AddRecipePanel.Controls.Add(this.saveNewRecipe);
            this.AddRecipePanel.Controls.Add(this.addRecipeTextBox);
            this.AddRecipePanel.Controls.Add(this.textBox1);
            this.AddRecipePanel.Controls.Add(this.recipeNameLabel);
            this.AddRecipePanel.Location = new System.Drawing.Point(460, 60);
            this.AddRecipePanel.Name = "AddRecipePanel";
            this.AddRecipePanel.Size = new System.Drawing.Size(1016, 1045);
            this.AddRecipePanel.TabIndex = 7;
            // 
            // saveNewRecipe
            // 
            this.saveNewRecipe.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveNewRecipe.Location = new System.Drawing.Point(817, 990);
            this.saveNewRecipe.Name = "saveNewRecipe";
            this.saveNewRecipe.Size = new System.Drawing.Size(169, 52);
            this.saveNewRecipe.TabIndex = 4;
            this.saveNewRecipe.Text = "Save";
            this.saveNewRecipe.UseVisualStyleBackColor = true;
            this.saveNewRecipe.Visible = false;
            this.saveNewRecipe.Click += new System.EventHandler(this.saveNewRecipe_Click);
            // 
            // Recipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1745, 1183);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.AddRecipePanel);
            this.Controls.Add(this.AllRecipesPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Recipes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recipes";
            this.panel1.ResumeLayout(false);
            this.AllRecipesPanel.ResumeLayout(false);
            this.AllRecipesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.RecipeSearchPanel.ResumeLayout(false);
            this.RecipeSearchPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.AddRecipePanel.ResumeLayout(false);
            this.AddRecipePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button1;
        private Label recipeNameLabel;
        private TextBox addRecipeTextBox;
        private TextBox textBox1;
        private Panel AllRecipesPanel;
        private TextBox Recipe1;
        private BindingSource bindingSource1;
        private Panel RecipeSearchPanel;
        private ListBox searchListBox;
        private Label searchBarLabelRecipe;
        private TextBox searchBarRecipes;
        private Panel searchPanel;
        private Panel AddRecipePanel;
        private Button saveNewRecipe;
        private BindingSource bindingSource2;
        private Button exitBttn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}