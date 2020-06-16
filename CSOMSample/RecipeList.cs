using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SP = Microsoft.SharePoint.Client;

namespace CSOMSample
{
    public partial class RecipeList : Form
    {
        private SP.ClientContext Context { get; set; }
        private SP.List RecipesList { get; set; }

        public RecipeList()
        {
            InitializeComponent();
            RecipesListView.MultiSelect = false;

            Context = new SP.ClientContext("http://sp2019vm/");
            RecipesList = Context.Web.Lists.GetByTitle("Recipe List");
        }

        #region Event Handlers

        /// <summary>
        /// Initializes the list view and inputs, and then loads the recipes from SP.
        /// </summary>
        private void RecipeList_Load(object sender, EventArgs e)
        {
            InitUI();
            LoadRecipes();
        }

        /// <summary>
        /// Populates input fields with data of the selected item in the list view.
        /// </summary>
        private void RecipesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RecipesListView.SelectedItems.Count != 0)
            {
                // get the selected item
                var selectedRecipe = RecipesListView.SelectedItems[0];  // multiselect is disabled. there is only one selected item

                // populate inputs
                RecipeTitleTextBox.Text = selectedRecipe.SubItems[0].Text;
                TimeNumericUpDown.Value = int.Parse(selectedRecipe.SubItems[1].Text);
                DifficultyComboBox.SelectedItem = selectedRecipe.SubItems[2].Text;

                CategoryCheckedListBox.ClearSelected();
                string[] selectedCategories = selectedRecipe.SubItems[3].Text.Split(new string[] { ", " }, StringSplitOptions.None);
                foreach (string selectedCategory in selectedCategories)
                {
                    int choiceIndex = CategoryCheckedListBox.Items.IndexOf(selectedCategory);
                    if (choiceIndex != -1)
                    {
                        CategoryCheckedListBox.SetItemChecked(choiceIndex, true);
                    }
                }
            }
        }


        /// <summary>
        /// Adds a new item, then reloads the data.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            var creationInfo = new SP.ListItemCreationInformation();
            SP.ListItem newRecipe = RecipesList.AddItem(creationInfo);

            // get values from input fields
            newRecipe["Title"] = RecipeTitleTextBox.Text;
            newRecipe["Required_x0020_Time"] = TimeNumericUpDown.Value.ToString();
            newRecipe["Difficulty"] = DifficultyComboBox.SelectedItem.ToString();

            var categories = new List<string>();
            foreach (var checkedCategory in CategoryCheckedListBox.CheckedItems)
            {
                categories.Add(checkedCategory.ToString());
            }

            newRecipe["Category"] = categories.ToArray();

            newRecipe.Update();
            Context.ExecuteQuery();

            LoadRecipes();
        }


        /// <summary>
        /// Updates the selected item in the list view, then reloads the data.
        /// </summary>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (RecipesListView.SelectedItems.Count != 0)
            {
                var selectedRecipe = RecipesListView.SelectedItems[0];

                Guid uniqueId = Guid.Parse(selectedRecipe.Tag.ToString());
                SP.ListItem listItem = RecipesList.GetItemByUniqueId(uniqueId);

                // get updated values from input fields
                listItem["Title"] = RecipeTitleTextBox.Text;
                listItem["Required_x0020_Time"] = TimeNumericUpDown.Value.ToString();
                listItem["Difficulty"] = DifficultyComboBox.SelectedItem.ToString();

                var categories = new List<string>();
                foreach (var checkedCategory in CategoryCheckedListBox.CheckedItems)
                {
                    categories.Add(checkedCategory.ToString());
                }

                listItem["Category"] = categories.ToArray();

                listItem.Update();
                Context.ExecuteQuery();

                LoadRecipes();
            }
        }

        /// <summary>
        /// Deletes the selected item in the list view, then reloads the data.
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (RecipesListView.SelectedItems.Count != 0)
            {
                var selectedRecipe = RecipesListView.SelectedItems[0];

                Guid uniqueId = Guid.Parse(selectedRecipe.Tag.ToString());
                SP.ListItem listItem = RecipesList.GetItemByUniqueId(uniqueId);

                listItem.DeleteObject();
                Context.ExecuteQuery();

                LoadRecipes();
            }
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Sets the headers/columns for the list view, and populates combo box 
        /// and checked list box with field values loaded from SP.
        /// </summary>
        private void InitUI()
        {
            // init listview header
            RecipesListView.Columns.Add("Title", 500);
            RecipesListView.Columns.Add("Time (h)", 50);
            RecipesListView.Columns.Add("Difficulty", 75);
            RecipesListView.Columns.Add("Category", 200);

            // load the choice fields
            SP.Field difficultyField = RecipesList.Fields.GetByInternalNameOrTitle("Difficulty");
            SP.FieldChoice difficultyFieldChoice = Context.CastTo<SP.FieldChoice>(difficultyField);
            SP.Field categoryField = RecipesList.Fields.GetByInternalNameOrTitle("Category");
            SP.FieldMultiChoice categoryFieldChoice = Context.CastTo<SP.FieldMultiChoice>(categoryField);

            Context.Load(difficultyFieldChoice, d => d.Choices);
            Context.Load(categoryFieldChoice, c => c.Choices);
            Context.ExecuteQuery();

            // init combo box items
            foreach (string choice in difficultyFieldChoice.Choices)
            {
                DifficultyComboBox.Items.Add(choice);
            }

            // init checked list box items
            foreach (string choice in categoryFieldChoice.Choices)
            {
                CategoryCheckedListBox.Items.Add(choice);
            }
        }

        /// <summary>
        /// Loads recipes from SP and adds the list items to the list view.
        /// </summary>
        private void LoadRecipes()
        {
            var query = SP.CamlQuery.CreateAllItemsQuery();
            SP.ListItemCollection recipes = RecipesList.GetItems(query);

            Context.Load(recipes);
            Context.ExecuteQuery();

            // add recipes to list view
            RecipesListView.Items.Clear();
            foreach (SP.ListItem recipe in recipes)
            {
                ListViewItem listViewItem = new ListViewItem
                {
                    Text = recipe["Title"].ToString(),
                    Tag = recipe["UniqueId"].ToString()
                };

                listViewItem.SubItems.Add(recipe["Required_x0020_Time"].ToString());
                listViewItem.SubItems.Add(recipe["Difficulty"].ToString());
                listViewItem.SubItems.Add(string.Join(", ", (string[])recipe["Category"]));

                RecipesListView.Items.Add(listViewItem);
            }
        }

        #endregion

    }
}
