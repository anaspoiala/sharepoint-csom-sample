namespace CSOMSample
{
    partial class CSOM
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
            this.siteTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.createNewSiteButton = new System.Windows.Forms.Button();
            this.newSiteTitleTextbox = new System.Windows.Forms.TextBox();
            this.newSiteUrlTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.loadSiteButton = new System.Windows.Forms.Button();
            this.siteUrlTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newListAddButton = new System.Windows.Forms.Button();
            this.newListNameTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listDeletebyNameButton = new System.Windows.Forms.Button();
            this.listNameToDeleteTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.loadListsButton = new System.Windows.Forms.Button();
            this.siteListsListbox = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.selecteListListView = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // siteTitle
            // 
            this.siteTitle.AutoSize = true;
            this.siteTitle.Location = new System.Drawing.Point(89, 60);
            this.siteTitle.Name = "siteTitle";
            this.siteTitle.Size = new System.Drawing.Size(58, 17);
            this.siteTitle.TabIndex = 0;
            this.siteTitle.Text = "Site title";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.createNewSiteButton);
            this.panel1.Controls.Add(this.newSiteTitleTextbox);
            this.panel1.Controls.Add(this.newSiteUrlTextbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 123);
            this.panel1.TabIndex = 2;
            // 
            // createNewSiteButton
            // 
            this.createNewSiteButton.Location = new System.Drawing.Point(92, 91);
            this.createNewSiteButton.Name = "createNewSiteButton";
            this.createNewSiteButton.Size = new System.Drawing.Size(220, 23);
            this.createNewSiteButton.TabIndex = 5;
            this.createNewSiteButton.Text = "Create";
            this.createNewSiteButton.UseVisualStyleBackColor = true;
            this.createNewSiteButton.Click += new System.EventHandler(this.createNewSiteButton_Click);
            // 
            // newSiteTitleTextbox
            // 
            this.newSiteTitleTextbox.Location = new System.Drawing.Point(92, 63);
            this.newSiteTitleTextbox.Name = "newSiteTitleTextbox";
            this.newSiteTitleTextbox.Size = new System.Drawing.Size(220, 22);
            this.newSiteTitleTextbox.TabIndex = 4;
            // 
            // newSiteUrlTextbox
            // 
            this.newSiteUrlTextbox.Location = new System.Drawing.Point(92, 35);
            this.newSiteUrlTextbox.Name = "newSiteUrlTextbox";
            this.newSiteUrlTextbox.Size = new System.Drawing.Size(220, 22);
            this.newSiteUrlTextbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "New site title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "New site url";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create a new SharePoint website";
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.loadSiteButton);
            this.panel2.Controls.Add(this.siteUrlTextbox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.siteTitle);
            this.panel2.Location = new System.Drawing.Point(8, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 105);
            this.panel2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "URL";
            // 
            // loadSiteButton
            // 
            this.loadSiteButton.Location = new System.Drawing.Point(238, 33);
            this.loadSiteButton.Margin = new System.Windows.Forms.Padding(0);
            this.loadSiteButton.Name = "loadSiteButton";
            this.loadSiteButton.Size = new System.Drawing.Size(74, 26);
            this.loadSiteButton.TabIndex = 10;
            this.loadSiteButton.Text = "Load";
            this.loadSiteButton.UseVisualStyleBackColor = true;
            this.loadSiteButton.Click += new System.EventHandler(this.loadSiteButton_Click);
            // 
            // siteUrlTextbox
            // 
            this.siteUrlTextbox.Location = new System.Drawing.Point(92, 35);
            this.siteUrlTextbox.Name = "siteUrlTextbox";
            this.siteUrlTextbox.Size = new System.Drawing.Size(143, 22);
            this.siteUrlTextbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Site title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Currently loaded site";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(333, 922);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 248);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Lists in loaded website";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.newListAddButton);
            this.groupBox1.Controls.Add(this.newListNameTextbox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(8, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 91);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a new list";
            // 
            // newListAddButton
            // 
            this.newListAddButton.Location = new System.Drawing.Point(92, 47);
            this.newListAddButton.Name = "newListAddButton";
            this.newListAddButton.Size = new System.Drawing.Size(220, 23);
            this.newListAddButton.TabIndex = 4;
            this.newListAddButton.Text = "Create";
            this.newListAddButton.UseVisualStyleBackColor = true;
            this.newListAddButton.Click += new System.EventHandler(this.newListAddButton_Click);
            // 
            // newListNameTextbox
            // 
            this.newListNameTextbox.Location = new System.Drawing.Point(92, 19);
            this.newListNameTextbox.Name = "newListNameTextbox";
            this.newListNameTextbox.Size = new System.Drawing.Size(221, 22);
            this.newListNameTextbox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.listDeletebyNameButton);
            this.groupBox3.Controls.Add(this.listNameToDeleteTextbox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(8, 370);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 92);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete list by name";
            // 
            // listDeletebyNameButton
            // 
            this.listDeletebyNameButton.Location = new System.Drawing.Point(92, 48);
            this.listDeletebyNameButton.Name = "listDeletebyNameButton";
            this.listDeletebyNameButton.Size = new System.Drawing.Size(220, 23);
            this.listDeletebyNameButton.TabIndex = 7;
            this.listDeletebyNameButton.Text = "Delete";
            this.listDeletebyNameButton.UseVisualStyleBackColor = true;
            this.listDeletebyNameButton.Click += new System.EventHandler(this.listDeletebyNameButton_Click);
            // 
            // listNameToDeleteTextbox
            // 
            this.listNameToDeleteTextbox.Location = new System.Drawing.Point(92, 21);
            this.listNameToDeleteTextbox.Name = "listNameToDeleteTextbox";
            this.listNameToDeleteTextbox.Size = new System.Drawing.Size(220, 22);
            this.listNameToDeleteTextbox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.loadListsButton);
            this.groupBox2.Controls.Add(this.siteListsListbox);
            this.groupBox2.Location = new System.Drawing.Point(8, 468);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 443);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "All lists";
            // 
            // loadListsButton
            // 
            this.loadListsButton.Location = new System.Drawing.Point(9, 21);
            this.loadListsButton.Name = "loadListsButton";
            this.loadListsButton.Size = new System.Drawing.Size(303, 23);
            this.loadListsButton.TabIndex = 8;
            this.loadListsButton.Text = "Load lists";
            this.loadListsButton.UseVisualStyleBackColor = true;
            this.loadListsButton.Click += new System.EventHandler(this.loadListsButton_Click);
            // 
            // siteListsListbox
            // 
            this.siteListsListbox.FormattingEnabled = true;
            this.siteListsListbox.ItemHeight = 16;
            this.siteListsListbox.Location = new System.Drawing.Point(9, 50);
            this.siteListsListbox.Name = "siteListsListbox";
            this.siteListsListbox.Size = new System.Drawing.Size(303, 372);
            this.siteListsListbox.TabIndex = 14;
            this.siteListsListbox.SelectedIndexChanged += new System.EventHandler(this.siteListsListbox_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.selecteListListView);
            this.groupBox4.Location = new System.Drawing.Point(352, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1291, 922);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Selected list";
            // 
            // selecteListListView
            // 
            this.selecteListListView.Location = new System.Drawing.Point(6, 21);
            this.selecteListListView.Name = "selecteListListView";
            this.selecteListListView.Size = new System.Drawing.Size(1279, 441);
            this.selecteListListView.TabIndex = 0;
            this.selecteListListView.UseCompatibleStateImageBehavior = false;
            this.selecteListListView.View = System.Windows.Forms.View.Details;
            // 
            // CSOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1655, 946);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "CSOM";
            this.Text = "CSOM Sample";
            this.Load += new System.EventHandler(this.CSOM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label siteTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button createNewSiteButton;
        private System.Windows.Forms.TextBox newSiteTitleTextbox;
        private System.Windows.Forms.TextBox newSiteUrlTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loadSiteButton;
        private System.Windows.Forms.TextBox siteUrlTextbox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button loadListsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox newListNameTextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button newListAddButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button listDeletebyNameButton;
        private System.Windows.Forms.TextBox listNameToDeleteTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox siteListsListbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView selecteListListView;
    }
}

