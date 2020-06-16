using System;
using System.Windows.Forms;
using SP = Microsoft.SharePoint.Client;


namespace CSOMSample
{
    public partial class CSOM : Form
    {
        private readonly string INITIAL_URL = @"http://sp2019vm/";
        private string CurrentURL { get => siteUrlTextbox.Text; set => siteUrlTextbox.Text = value; }
        private SP.ClientContext Context { get; set; }


        public CSOM()
        {
            InitializeComponent();
            CurrentURL = INITIAL_URL;
            Context = new SP.ClientContext(INITIAL_URL);
        }

        #region Event Handlers

        private void CSOM_Load(object sender, EventArgs e)
        {
            LoadSite();
        }

        private void createNewSiteButton_Click(object sender, EventArgs e)
        {
            var newWeb = AddSite(newSiteUrlTextbox.Text, newSiteTitleTextbox.Text, "STS#0");

            newSiteUrlTextbox.Text = "";
            newSiteTitleTextbox.Text = "";
        }

        private void loadSiteButton_Click(object sender, EventArgs e)
        {
            LoadSite();
        }

        private void loadListsButton_Click(object sender, EventArgs e)
        {
            LoadSiteLists();
        }

        private void newListAddButton_Click(object sender, EventArgs e)
        {
            AddSiteList(newListNameTextbox.Text, SP.ListTemplateType.GenericList);
            newListNameTextbox.Text = "";
            LoadSiteLists();
        }

        private void listDeletebyNameButton_Click(object sender, EventArgs e)
        {
            DeleteSiteList(listNameToDeleteTextbox.Text);
            listNameToDeleteTextbox.Text = "";
            LoadSiteLists();
        }

        /// <summary>
        /// Initializes and loads the list items for the selected list.
        /// </summary>
        private void siteListsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedListTitle = (string)siteListsListbox.SelectedItem;

            var fields = GetListFields(selectedListTitle);

            selecteListListView.Items.Clear();
            selecteListListView.Columns.Clear();

            // init list header
            foreach (SP.Field field in fields)
            {
                if (!field.FromBaseType)
                {
                    selecteListListView.Columns.Add(field.InternalName);
                }
            }


            // loand and add list items to list view
            var items = GetListItems(selectedListTitle);
            foreach (SP.ListItem item in items)
            {
                Context.Load(item.FieldValuesAsText);
                Context.ExecuteQuery();

                ListViewItem lvItem = new ListViewItem
                {
                    Tag = item
                };

                bool firstColumnSet = false;  // the "Text" property of the list item is subitems[0]
                foreach (var field in fields)
                {
                    if (!field.FromBaseType)
                    {
                        string value = "";

                        if (item.FieldValues.ContainsKey(field.InternalName))
                        {
                            if (item.FieldValues[field.InternalName] != null)
                                value = item.FieldValues[field.InternalName].ToString();
                        }

                        if (!firstColumnSet)
                        {
                            lvItem.Text = value;
                            firstColumnSet = true;
                        }
                        else
                        {
                            lvItem.SubItems.Add(value);
                        }
                    }
                }

                selecteListListView.Items.Add(lvItem);
            }
        }

        #endregion


        #region Helper Methods

        /// <summary>
        /// Loads the current site and updates the title label.
        /// </summary>
        private void LoadSite()
        {
            Context = new SP.ClientContext(CurrentURL);
            var web = GetCurrentSite();
            siteTitle.Text = web.Title;
            LoadSiteLists();
        }

        private SP.Web GetCurrentSite()
        {
            var web = Context.Web;

            Context.Load(web, w => w.Title, w => w.Description);
            Context.ExecuteQuery();

            return web;
        }

        /// <summary>
        /// Loads the lists in the current site from SP and adds them to the list box.
        /// </summary>
        private void LoadSiteLists()
        {
            SP.ListCollection lists = GetSiteLists();
            siteListsListbox.Items.Clear();
            foreach (var list in lists)
            {
                siteListsListbox.Items.Add(list.Title);
            }
        }

        private SP.ListCollection GetSiteLists()
        {
            var web = Context.Web;

            Context.Load(
                web.Lists,
                lists => SP.ClientObjectQueryableExtension.Include(lists,
                    l => l.Title,
                    l => l.Id
                )
            );
            Context.ExecuteQuery();

            return web.Lists;
        }

        /// <summary>
        /// Adds a new site collection to the current site.
        /// </summary>
        private SP.Web AddSite(string url, string title, string template)
        {
            var creationInfo = new SP.WebCreationInformation
            {
                Url = url,
                Title = title,
                WebTemplate = template
            };

            var newWeb = Context.Web.Webs.Add(creationInfo);

            Context.Load(newWeb, w => w.Title, w => w.Description);
            Context.ExecuteQuery();

            return newWeb;
        }

        /// <summary>
        /// Adds a new list to the current site.
        /// </summary>
        private SP.List AddSiteList(string title, SP.ListTemplateType listTemplateType)
        {
            var web = Context.Web;

            var creationInfo = new SP.ListCreationInformation
            {
                Title = title,
                TemplateType = (int)listTemplateType
            };

            var list = web.Lists.Add(creationInfo);
            Context.ExecuteQuery();

            return list;
        }

        /// <summary>
        /// Deletes a list (by title) from the current site.
        /// </summary>
        /// <param name="title"></param>
        private void DeleteSiteList(string title)
        {
            var web = Context.Web;

            var list = web.Lists.GetByTitle(title);
            list.DeleteObject();

            Context.ExecuteQuery();
        }

        /// <summary>
        /// Loads and returns the list items from a given list.
        /// </summary>
        private SP.ListItemCollection GetListItems(string title)
        {
            var list = Context.Web.Lists.GetByTitle(title);
            var query = SP.CamlQuery.CreateAllItemsQuery();

            SP.ListItemCollection items = list.GetItems(query);

            Context.Load(items);
            Context.ExecuteQuery();

            return items;
        }

        /// <summary>
        /// Loads and returns the fields of a given list.
        /// </summary>
        private SP.FieldCollection GetListFields(string title)
        {
            var list = Context.Web.Lists.GetByTitle(title);

            Context.Load(list.Fields);
            Context.ExecuteQuery();

            return list.Fields;
        }

        #endregion
    }
}
