namespace Project3___IST_App
{
    partial class FormContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContact));
            this.webBrowserContact = new System.Windows.Forms.WebBrowser();
            this.lblHeader = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnDegrees = new System.Windows.Forms.Button();
            this.btnPeople = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnResearch = new System.Windows.Forms.Button();
            this.btnResources = new System.Windows.Forms.Button();
            this.btnNews = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBoxFooter = new System.Windows.Forms.GroupBox();
            this.pictureBoxFacebook = new System.Windows.Forms.PictureBox();
            this.pictureBoxTwitter = new System.Windows.Forms.PictureBox();
            this.lblBy = new System.Windows.Forms.Label();
            this.lblTweet = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSupportIST = new System.Windows.Forms.Button();
            this.btnLabHours = new System.Windows.Forms.Button();
            this.btnAboutThisSite = new System.Windows.Forms.Button();
            this.labelQuickLinks = new System.Windows.Forms.Label();
            this.btnApplyNow = new System.Windows.Forms.Button();
            this.buttonNews = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTwitter)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowserContact
            // 
            this.webBrowserContact.Location = new System.Drawing.Point(120, 53);
            this.webBrowserContact.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserContact.Name = "webBrowserContact";
            this.webBrowserContact.ScriptErrorsSuppressed = true;
            this.webBrowserContact.Size = new System.Drawing.Size(1000, 534);
            this.webBrowserContact.TabIndex = 22;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(254, 6);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(781, 39);
            this.lblHeader.TabIndex = 14;
            this.lblHeader.Text = "INFORMATION SCIENCES AND TECHNOLOGY @ RIT";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnHome);
            this.flowLayoutPanel1.Controls.Add(this.btnDegrees);
            this.flowLayoutPanel1.Controls.Add(this.btnPeople);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.btnMap);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.btnResearch);
            this.flowLayoutPanel1.Controls.Add(this.btnResources);
            this.flowLayoutPanel1.Controls.Add(this.btnNews);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(114, 712);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::Project3___IST_App.Properties.Resources.home_favicon;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(108, 54);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "HOME";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnDegrees
            // 
            this.btnDegrees.Image = global::Project3___IST_App.Properties.Resources.degree_favicon;
            this.btnDegrees.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDegrees.Location = new System.Drawing.Point(3, 63);
            this.btnDegrees.Name = "btnDegrees";
            this.btnDegrees.Size = new System.Drawing.Size(108, 54);
            this.btnDegrees.TabIndex = 7;
            this.btnDegrees.Text = "DEGREES";
            this.btnDegrees.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDegrees.UseVisualStyleBackColor = true;
            this.btnDegrees.Click += new System.EventHandler(this.btnDegrees_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.Image = global::Project3___IST_App.Properties.Resources.people_favicon;
            this.btnPeople.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPeople.Location = new System.Drawing.Point(3, 123);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(108, 54);
            this.btnPeople.TabIndex = 8;
            this.btnPeople.Text = "PEOPLE";
            this.btnPeople.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPeople.UseVisualStyleBackColor = true;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // button4
            // 
            this.button4.Image = global::Project3___IST_App.Properties.Resources.emp_favicon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(3, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 54);
            this.button4.TabIndex = 9;
            this.button4.Text = "EMPLOYMENT";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMap
            // 
            this.btnMap.Image = global::Project3___IST_App.Properties.Resources.map;
            this.btnMap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMap.Location = new System.Drawing.Point(3, 243);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(108, 54);
            this.btnMap.TabIndex = 12;
            this.btnMap.Text = "MAP";
            this.btnMap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // button5
            // 
            this.button5.Image = global::Project3___IST_App.Properties.Resources.table;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(3, 303);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 54);
            this.button5.TabIndex = 10;
            this.button5.Text = "TABLES";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnResearch
            // 
            this.btnResearch.Image = global::Project3___IST_App.Properties.Resources.chart_favicon;
            this.btnResearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnResearch.Location = new System.Drawing.Point(3, 363);
            this.btnResearch.Name = "btnResearch";
            this.btnResearch.Size = new System.Drawing.Size(108, 54);
            this.btnResearch.TabIndex = 14;
            this.btnResearch.Text = "RESEARCH";
            this.btnResearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnResearch.UseVisualStyleBackColor = true;
            this.btnResearch.Click += new System.EventHandler(this.btnResearch_Click);
            // 
            // btnResources
            // 
            this.btnResources.Image = global::Project3___IST_App.Properties.Resources.resources;
            this.btnResources.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnResources.Location = new System.Drawing.Point(3, 423);
            this.btnResources.Name = "btnResources";
            this.btnResources.Size = new System.Drawing.Size(108, 54);
            this.btnResources.TabIndex = 15;
            this.btnResources.Text = "RESOURCES";
            this.btnResources.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnResources.UseVisualStyleBackColor = true;
            this.btnResources.Click += new System.EventHandler(this.btnResources_Click);
            // 
            // btnNews
            // 
            this.btnNews.Image = global::Project3___IST_App.Properties.Resources.news;
            this.btnNews.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNews.Location = new System.Drawing.Point(3, 483);
            this.btnNews.Name = "btnNews";
            this.btnNews.Size = new System.Drawing.Size(108, 54);
            this.btnNews.TabIndex = 13;
            this.btnNews.Text = "NEWS";
            this.btnNews.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNews.UseVisualStyleBackColor = true;
            this.btnNews.Click += new System.EventHandler(this.btnNews_Click);
            // 
            // button6
            // 
            this.button6.Image = global::Project3___IST_App.Properties.Resources.form_favicon;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(3, 543);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 54);
            this.button6.TabIndex = 11;
            this.button6.Text = "CONTACT FORM";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBoxFooter
            // 
            this.groupBoxFooter.Controls.Add(this.lblCopyright);
            this.groupBoxFooter.Controls.Add(this.buttonNews);
            this.groupBoxFooter.Controls.Add(this.pictureBoxFacebook);
            this.groupBoxFooter.Controls.Add(this.pictureBoxTwitter);
            this.groupBoxFooter.Controls.Add(this.lblBy);
            this.groupBoxFooter.Controls.Add(this.lblTweet);
            this.groupBoxFooter.Controls.Add(this.lblTitle);
            this.groupBoxFooter.Controls.Add(this.btnSupportIST);
            this.groupBoxFooter.Controls.Add(this.btnLabHours);
            this.groupBoxFooter.Controls.Add(this.btnAboutThisSite);
            this.groupBoxFooter.Controls.Add(this.labelQuickLinks);
            this.groupBoxFooter.Controls.Add(this.btnApplyNow);
            this.groupBoxFooter.Location = new System.Drawing.Point(120, 593);
            this.groupBoxFooter.Name = "groupBoxFooter";
            this.groupBoxFooter.Size = new System.Drawing.Size(1000, 115);
            this.groupBoxFooter.TabIndex = 23;
            this.groupBoxFooter.TabStop = false;
            this.groupBoxFooter.Text = "Footer";
            // 
            // pictureBoxFacebook
            // 
            this.pictureBoxFacebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBoxFacebook.Image = global::Project3___IST_App.Properties.Resources.facebook;
            this.pictureBoxFacebook.Location = new System.Drawing.Point(117, 80);
            this.pictureBoxFacebook.Name = "pictureBoxFacebook";
            this.pictureBoxFacebook.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxFacebook.TabIndex = 9;
            this.pictureBoxFacebook.TabStop = false;
            this.pictureBoxFacebook.Click += new System.EventHandler(this.pictureBoxFacebook_Click);
            // 
            // pictureBoxTwitter
            // 
            this.pictureBoxTwitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBoxTwitter.Image = global::Project3___IST_App.Properties.Resources.twitter;
            this.pictureBoxTwitter.Location = new System.Drawing.Point(170, 80);
            this.pictureBoxTwitter.Name = "pictureBoxTwitter";
            this.pictureBoxTwitter.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxTwitter.TabIndex = 8;
            this.pictureBoxTwitter.TabStop = false;
            this.pictureBoxTwitter.Click += new System.EventHandler(this.pictureBoxTwitter_Click);
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBy.ForeColor = System.Drawing.Color.White;
            this.lblBy.Location = new System.Drawing.Point(215, 54);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(24, 16);
            this.lblBy.TabIndex = 7;
            this.lblBy.Text = "By";
            // 
            // lblTweet
            // 
            this.lblTweet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTweet.ForeColor = System.Drawing.Color.White;
            this.lblTweet.Location = new System.Drawing.Point(215, 31);
            this.lblTweet.Name = "lblTweet";
            this.lblTweet.Size = new System.Drawing.Size(779, 23);
            this.lblTweet.TabIndex = 6;
            this.lblTweet.Text = "Tweet";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(430, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 16);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Title";
            // 
            // btnSupportIST
            // 
            this.btnSupportIST.Location = new System.Drawing.Point(8, 52);
            this.btnSupportIST.Name = "btnSupportIST";
            this.btnSupportIST.Size = new System.Drawing.Size(100, 27);
            this.btnSupportIST.TabIndex = 4;
            this.btnSupportIST.UseVisualStyleBackColor = true;
            this.btnSupportIST.Click += new System.EventHandler(this.btnSupportIST_Click);
            // 
            // btnLabHours
            // 
            this.btnLabHours.Location = new System.Drawing.Point(109, 52);
            this.btnLabHours.Name = "btnLabHours";
            this.btnLabHours.Size = new System.Drawing.Size(100, 27);
            this.btnLabHours.TabIndex = 3;
            this.btnLabHours.UseVisualStyleBackColor = true;
            this.btnLabHours.Click += new System.EventHandler(this.btnLabHours_Click);
            // 
            // btnAboutThisSite
            // 
            this.btnAboutThisSite.Location = new System.Drawing.Point(109, 23);
            this.btnAboutThisSite.Name = "btnAboutThisSite";
            this.btnAboutThisSite.Size = new System.Drawing.Size(100, 27);
            this.btnAboutThisSite.TabIndex = 2;
            this.btnAboutThisSite.UseVisualStyleBackColor = true;
            this.btnAboutThisSite.Click += new System.EventHandler(this.btnAboutThisSite_Click);
            // 
            // labelQuickLinks
            // 
            this.labelQuickLinks.AutoSize = true;
            this.labelQuickLinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuickLinks.ForeColor = System.Drawing.Color.White;
            this.labelQuickLinks.Location = new System.Drawing.Point(70, 10);
            this.labelQuickLinks.Name = "labelQuickLinks";
            this.labelQuickLinks.Size = new System.Drawing.Size(74, 13);
            this.labelQuickLinks.TabIndex = 1;
            this.labelQuickLinks.Text = "Quick Links";
            // 
            // btnApplyNow
            // 
            this.btnApplyNow.Location = new System.Drawing.Point(8, 23);
            this.btnApplyNow.Name = "btnApplyNow";
            this.btnApplyNow.Size = new System.Drawing.Size(100, 27);
            this.btnApplyNow.TabIndex = 0;
            this.btnApplyNow.UseVisualStyleBackColor = true;
            this.btnApplyNow.Click += new System.EventHandler(this.btnApplyNow_Click);
            // 
            // buttonNews
            // 
            this.buttonNews.Location = new System.Drawing.Point(8, 80);
            this.buttonNews.Name = "buttonNews";
            this.buttonNews.Size = new System.Drawing.Size(100, 27);
            this.buttonNews.TabIndex = 10;
            this.buttonNews.Text = "NEWS";
            this.buttonNews.UseVisualStyleBackColor = true;
            this.buttonNews.Click += new System.EventHandler(this.buttonNews_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Location = new System.Drawing.Point(216, 80);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(778, 23);
            this.lblCopyright.TabIndex = 11;
            this.lblCopyright.Text = "Copyright";
            // 
            // FormContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 762);
            this.Controls.Add(this.groupBoxFooter);
            this.Controls.Add(this.webBrowserContact);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormContact";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormContact_FormClosed);
            this.Load += new System.EventHandler(this.FormContact_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBoxFooter.ResumeLayout(false);
            this.groupBoxFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTwitter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnDegrees;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnNews;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.WebBrowser webBrowserContact;
        private System.Windows.Forms.Button btnResearch;
        private System.Windows.Forms.GroupBox groupBoxFooter;
        private System.Windows.Forms.PictureBox pictureBoxFacebook;
        private System.Windows.Forms.PictureBox pictureBoxTwitter;
        private System.Windows.Forms.Label lblBy;
        private System.Windows.Forms.Label lblTweet;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSupportIST;
        private System.Windows.Forms.Button btnLabHours;
        private System.Windows.Forms.Button btnAboutThisSite;
        private System.Windows.Forms.Label labelQuickLinks;
        private System.Windows.Forms.Button btnApplyNow;
        private System.Windows.Forms.Button btnResources;
        private System.Windows.Forms.Button buttonNews;
        private System.Windows.Forms.Label lblCopyright;
    }
}