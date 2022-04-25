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
    public partial class Recipes : Form
    {
        public Recipes()
        {
            InitializeComponent();
        }

        //Initializing array for the recipes
        public List<string> recipes = new List<string>();
        public List<string> recipeNames = new List<string>();

        public List<string> GetRecipes()
        {
            return recipes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // All Recipes
            AllRecipesPanel.Visible = true;
            Recipe1.Visible = true;
            
            AddRecipePanel.Visible = false;
            addRecipeTextBox.Visible = false;
            recipeNameLabel.Visible = false;
            textBox1.Visible = false;
            saveNewRecipe.Visible = false;

            searchPanel.Visible = false;
            RecipeSearchPanel.Visible = false;
            searchBarLabelRecipe.Visible = false;
            searchBarRecipes.Visible = false;
            searchListBox.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Add Recipe
            AllRecipesPanel.Visible = false;
            Recipe1.Visible = false;
            
            addRecipeTextBox.Visible = true;
            recipeNameLabel.Visible = true;
            textBox1.Visible = true;
            AddRecipePanel.Visible = true;
            saveNewRecipe.Visible = true;

            searchPanel.Visible = false;
            RecipeSearchPanel.Visible = false;
            searchBarLabelRecipe.Visible = false;
            searchBarRecipes.Visible = false;
            searchListBox.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Search Recipes
            AllRecipesPanel.Visible = false;
            Recipe1.Visible = false;

            addRecipeTextBox.Visible = false;
            recipeNameLabel.Visible = false;
            textBox1.Visible = false;
            AddRecipePanel.Visible = false;
            saveNewRecipe.Visible = false;

            searchPanel.Visible = true;
            RecipeSearchPanel.Visible = true;
            searchBarLabelRecipe.Visible = true;
            searchBarRecipes.Visible = true;
            searchListBox.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Favorites
            AllRecipesPanel.Visible = false;
            Recipe1.Visible = false;

            addRecipeTextBox.Visible = false;
            recipeNameLabel.Visible = false;
            textBox1.Visible = false;
            AddRecipePanel.Visible = false;
            saveNewRecipe.Visible = false;

            searchPanel.Visible = false;
            RecipeSearchPanel.Visible = false;
            searchBarLabelRecipe.Visible = false;
            searchBarRecipes.Visible = false;
            searchListBox.Visible = false;
        }

        private void recipeNameLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBarRecipes_TextChanged(object sender, EventArgs e)
        {
            string searchVal = searchBarRecipes.Text;
            if (string.IsNullOrEmpty(searchBarRecipes.Text) == false)
            {
                searchListBox.Items.Clear();
                //foreach (string str in recipes)
                //{
                //    if (str.StartsWith(searchVal))
                //    {
                //        searchListBox.Items.Add(str);
                //    }
                //    
                //}
                int count = -1;
                foreach (string strng in recipeNames)
                {
                    count++;
                    if (strng.StartsWith(searchVal))
                    {
                        
                        searchListBox.Items.Add(strng + ": \r\n" + recipes[count]);
                    }
                }
            }
            else if (searchBarRecipes.Text == "")
            {
                searchListBox.Items.Clear();
                foreach (string str in recipeNames)
                {
                    searchListBox.Items.Add(str);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string newEntry = textBox1.Text;
            //recipeNames.Add(newEntry);
        }

        public void saveNewRecipe_Click(object sender, EventArgs e)
        {
            string newEntry = addRecipeTextBox.Text;
            recipes.Add(newEntry);
            string newName = textBox1.Text;
            recipeNames.Add(newName);
            addRecipeTextBox.Clear();
            textBox1.Clear();
            DisplayRecipes(recipes, recipeNames);
        }

        private void Recipe1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DisplayRecipes(List<string> recipes, List<string> recipeNames)
        {
            int count = -1;
            Recipe1.Clear();
            foreach (string r in recipeNames)
            {
                count++;
                Recipe1.Text += "\r\n\r\n" + r.ToString() + ": \r\n" + recipes[count];
            }
        }

        private void searchListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitBttn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to leave the Recipe Book?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
