namespace Project3___IST_App
{
    partial class FormMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMap));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnDegrees = new System.Windows.Forms.Button();
            this.btnPeople = new System.Windows.Forms.Button();
            this.btnEmployment = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnResearch = new System.Windows.Forms.Button();
            this.btnNews = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.webBrowserMap = new System.Windows.Forms.WebBrowser();
            this.textBoxMap = new System.Windows.Forms.TextBox();
            this.btnResources = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnHome);
            this.flowLayoutPanel1.Controls.Add(this.btnDegrees);
            this.flowLayoutPanel1.Controls.Add(this.btnPeople);
            this.flowLayoutPanel1.Controls.Add(this.btnEmployment);
            this.flowLayoutPanel1.Controls.Add(this.btnMap);
            this.flowLayoutPanel1.Controls.Add(this.btnStatistics);
            this.flowLayoutPanel1.Controls.Add(this.btnResearch);
            this.flowLayoutPanel1.Controls.Add(this.btnResources);
            this.flowLayoutPanel1.Controls.Add(this.btnNews);
            this.flowLayoutPanel1.Controls.Add(this.btnContact);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(114, 712);
            this.flowLayoutPanel1.TabIndex = 16;
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
            // btnEmployment
            // 
            this.btnEmployment.Image = global::Project3___IST_App.Properties.Resources.emp_favicon;
            this.btnEmployment.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmployment.Location = new System.Drawing.Point(3, 183);
            this.btnEmployment.Name = "btnEmployment";
            this.btnEmployment.Size = new System.Drawing.Size(108, 54);
            this.btnEmployment.TabIndex = 9;
            this.btnEmployment.Text = "EMPLOYMENT";
            this.btnEmployment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployment.UseVisualStyleBackColor = true;
            this.btnEmployment.Click += new System.EventHandler(this.btnEmployment_Click);
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
            // 
            // btnStatistics
            // 
            this.btnStatistics.Image = global::Project3___IST_App.Properties.Resources.table;
            this.btnStatistics.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStatistics.Location = new System.Drawing.Point(3, 303);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(108, 54);
            this.btnStatistics.TabIndex = 10;
            this.btnStatistics.Text = "TABLES";
            this.btnStatistics.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
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
            // btnContact
            // 
            this.btnContact.Image = global::Project3___IST_App.Properties.Resources.form_favicon;
            this.btnContact.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnContact.Location = new System.Drawing.Point(3, 543);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(108, 54);
            this.btnContact.TabIndex = 11;
            this.btnContact.Text = "CONTACT FORM";
            this.btnContact.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(254, 6);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(781, 39);
            this.lblHeader.TabIndex = 17;
            this.lblHeader.Text = "INFORMATION SCIENCES AND TECHNOLOGY @ RIT";
            // 
            // webBrowserMap
            // 
            this.webBrowserMap.Location = new System.Drawing.Point(120, 96);
            this.webBrowserMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMap.Name = "webBrowserMap";
            this.webBrowserMap.Size = new System.Drawing.Size(1000, 601);
            this.webBrowserMap.TabIndex = 18;
            // 
            // textBoxMap
            // 
            this.textBoxMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxMap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMap.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMap.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxMap.Location = new System.Drawing.Point(120, 57);
            this.textBoxMap.Name = "textBoxMap";
            this.textBoxMap.Size = new System.Drawing.Size(999, 33);
            this.textBoxMap.TabIndex = 20;
            this.textBoxMap.Text = "Where Our Students Work";
            this.textBoxMap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // FormMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 762);
            this.Controls.Add(this.textBoxMap);
            this.Controls.Add(this.webBrowserMap);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMap_FormClosed);
            this.Load += new System.EventHandler(this.FormMap_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnDegrees;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.Button btnEmployment;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.WebBrowser webBrowserMap;
        private System.Windows.Forms.TextBox textBoxMap;
        private System.Windows.Forms.Button btnNews;
        private System.Windows.Forms.Button btnResearch;
        private System.Windows.Forms.Button btnResources;
    }
}