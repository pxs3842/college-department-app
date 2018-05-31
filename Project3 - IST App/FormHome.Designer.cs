namespace Project3___IST_App
{
    partial class ISTapplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ISTapplication));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnDegrees = new System.Windows.Forms.Button();
            this.btnPeople = new System.Windows.Forms.Button();
            this.btnEmployment = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnResearch = new System.Windows.Forms.Button();
            this.btnResources = new System.Windows.Forms.Button();
            this.btnNews = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblHeader = new System.Windows.Forms.Label();
            this.aboutTitle = new System.Windows.Forms.Label();
            this.aboutDescription = new System.Windows.Forms.Label();
            this.aboutPictureBox = new System.Windows.Forms.PictureBox();
            this.authorName = new System.Windows.Forms.Label();
            this.authorInfo = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnHome);
            this.flowLayoutPanel1.Controls.Add(this.btnDegrees);
            this.flowLayoutPanel1.Controls.Add(this.btnPeople);
            this.flowLayoutPanel1.Controls.Add(this.btnEmployment);
            this.flowLayoutPanel1.Controls.Add(this.btnMap);
            this.flowLayoutPanel1.Controls.Add(this.btnStats);
            this.flowLayoutPanel1.Controls.Add(this.btnResearch);
            this.flowLayoutPanel1.Controls.Add(this.btnResources);
            this.flowLayoutPanel1.Controls.Add(this.btnNews);
            this.flowLayoutPanel1.Controls.Add(this.btnContact);
            this.flowLayoutPanel1.Controls.Add(this.splitContainer1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1184, 762);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::Project3___IST_App.Properties.Resources.home_favicon;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHome.Location = new System.Drawing.Point(3, 50);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(108, 54);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "HOME";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnDegrees
            // 
            this.btnDegrees.Image = global::Project3___IST_App.Properties.Resources.degree_favicon;
            this.btnDegrees.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDegrees.Location = new System.Drawing.Point(3, 110);
            this.btnDegrees.Name = "btnDegrees";
            this.btnDegrees.Size = new System.Drawing.Size(108, 54);
            this.btnDegrees.TabIndex = 1;
            this.btnDegrees.Text = "DEGREES";
            this.btnDegrees.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDegrees.UseVisualStyleBackColor = true;
            this.btnDegrees.Click += new System.EventHandler(this.btnDegrees_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.Image = global::Project3___IST_App.Properties.Resources.people_favicon;
            this.btnPeople.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPeople.Location = new System.Drawing.Point(3, 170);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(108, 54);
            this.btnPeople.TabIndex = 2;
            this.btnPeople.Text = "PEOPLE";
            this.btnPeople.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPeople.UseVisualStyleBackColor = true;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnEmployment
            // 
            this.btnEmployment.Image = global::Project3___IST_App.Properties.Resources.emp_favicon;
            this.btnEmployment.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmployment.Location = new System.Drawing.Point(3, 230);
            this.btnEmployment.Name = "btnEmployment";
            this.btnEmployment.Size = new System.Drawing.Size(108, 54);
            this.btnEmployment.TabIndex = 3;
            this.btnEmployment.Text = "EMPLOYMENT";
            this.btnEmployment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployment.UseVisualStyleBackColor = true;
            this.btnEmployment.Click += new System.EventHandler(this.btnEmployment_Click);
            // 
            // btnMap
            // 
            this.btnMap.Image = global::Project3___IST_App.Properties.Resources.map;
            this.btnMap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMap.Location = new System.Drawing.Point(3, 290);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(108, 54);
            this.btnMap.TabIndex = 7;
            this.btnMap.Text = "MAP";
            this.btnMap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnStats
            // 
            this.btnStats.Image = global::Project3___IST_App.Properties.Resources.table;
            this.btnStats.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStats.Location = new System.Drawing.Point(3, 350);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(108, 54);
            this.btnStats.TabIndex = 4;
            this.btnStats.Text = "TABLES";
            this.btnStats.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnResearch
            // 
            this.btnResearch.Image = global::Project3___IST_App.Properties.Resources.chart_favicon;
            this.btnResearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnResearch.Location = new System.Drawing.Point(3, 410);
            this.btnResearch.Name = "btnResearch";
            this.btnResearch.Size = new System.Drawing.Size(108, 54);
            this.btnResearch.TabIndex = 9;
            this.btnResearch.Text = "RESEARCH";
            this.btnResearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnResearch.UseVisualStyleBackColor = true;
            this.btnResearch.Click += new System.EventHandler(this.btnResearch_Click);
            // 
            // btnResources
            // 
            this.btnResources.Image = global::Project3___IST_App.Properties.Resources.resources;
            this.btnResources.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnResources.Location = new System.Drawing.Point(3, 470);
            this.btnResources.Name = "btnResources";
            this.btnResources.Size = new System.Drawing.Size(108, 54);
            this.btnResources.TabIndex = 10;
            this.btnResources.Text = "RESOURCES";
            this.btnResources.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnResources.UseVisualStyleBackColor = true;
            this.btnResources.Click += new System.EventHandler(this.btnResources_Click);
            // 
            // btnNews
            // 
            this.btnNews.Image = global::Project3___IST_App.Properties.Resources.news;
            this.btnNews.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNews.Location = new System.Drawing.Point(3, 530);
            this.btnNews.Name = "btnNews";
            this.btnNews.Size = new System.Drawing.Size(108, 54);
            this.btnNews.TabIndex = 8;
            this.btnNews.Text = "NEWS";
            this.btnNews.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNews.UseVisualStyleBackColor = true;
            this.btnNews.Click += new System.EventHandler(this.btnNews_Click);
            // 
            // btnContact
            // 
            this.btnContact.Image = global::Project3___IST_App.Properties.Resources.form_favicon;
            this.btnContact.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnContact.Location = new System.Drawing.Point(3, 590);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(108, 54);
            this.btnContact.TabIndex = 5;
            this.btnContact.Text = "CONTACT FORM";
            this.btnContact.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(117, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblHeader);
            this.splitContainer1.Panel1.Controls.Add(this.aboutTitle);
            this.splitContainer1.Panel1.Controls.Add(this.aboutDescription);
            this.splitContainer1.Panel1.Controls.Add(this.aboutPictureBox);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.authorName);
            this.splitContainer1.Panel2.Controls.Add(this.authorInfo);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 700);
            this.splitContainer1.SplitterDistance = 518;
            this.splitContainer1.TabIndex = 6;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(128, 6);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(781, 39);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "INFORMATION SCIENCES AND TECHNOLOGY @ RIT";
            // 
            // aboutTitle
            // 
            this.aboutTitle.AutoSize = true;
            this.aboutTitle.BackColor = System.Drawing.Color.Black;
            this.aboutTitle.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.aboutTitle.Location = new System.Drawing.Point(6, 307);
            this.aboutTitle.Name = "aboutTitle";
            this.aboutTitle.Size = new System.Drawing.Size(68, 54);
            this.aboutTitle.TabIndex = 2;
            this.aboutTitle.Text = "Title";
            // 
            // aboutDescription
            // 
            this.aboutDescription.BackColor = System.Drawing.SystemColors.MenuText;
            this.aboutDescription.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aboutDescription.Location = new System.Drawing.Point(3, 358);
            this.aboutDescription.Name = "aboutDescription";
            this.aboutDescription.Padding = new System.Windows.Forms.Padding(5);
            this.aboutDescription.Size = new System.Drawing.Size(997, 160);
            this.aboutDescription.TabIndex = 1;
            this.aboutDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aboutPictureBox
            // 
            this.aboutPictureBox.Image = global::Project3___IST_App.Properties.Resources.image_slider;
            this.aboutPictureBox.Location = new System.Drawing.Point(0, 49);
            this.aboutPictureBox.Name = "aboutPictureBox";
            this.aboutPictureBox.Size = new System.Drawing.Size(1000, 470);
            this.aboutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aboutPictureBox.TabIndex = 0;
            this.aboutPictureBox.TabStop = false;
            // 
            // authorName
            // 
            this.authorName.AutoSize = true;
            this.authorName.BackColor = System.Drawing.Color.White;
            this.authorName.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.authorName.Location = new System.Drawing.Point(4, 139);
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(146, 31);
            this.authorName.TabIndex = 1;
            this.authorName.Text = "AuthorName";
            // 
            // authorInfo
            // 
            this.authorInfo.BackColor = System.Drawing.Color.White;
            this.authorInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authorInfo.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorInfo.Location = new System.Drawing.Point(0, 3);
            this.authorInfo.Name = "authorInfo";
            this.authorInfo.Size = new System.Drawing.Size(1000, 171);
            this.authorInfo.TabIndex = 0;
            this.authorInfo.Text = "";
            // 
            // ISTapplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 762);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ISTapplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IST Application - Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ISTapplication_FormClosed);
            this.Load += new System.EventHandler(this.ISTapplication_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aboutPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnDegrees;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.Button btnEmployment;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox aboutPictureBox;
        private System.Windows.Forms.RichTextBox authorInfo;
        private System.Windows.Forms.Label aboutDescription;
        private System.Windows.Forms.Label aboutTitle;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label authorName;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnNews;
        private System.Windows.Forms.Button btnResearch;
        private System.Windows.Forms.Button btnResources;
    }
}

