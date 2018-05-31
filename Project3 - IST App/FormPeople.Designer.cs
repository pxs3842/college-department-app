namespace Project3___IST_App
{
    partial class FormPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPeople));
            this.tabControlPeople = new System.Windows.Forms.TabControl();
            this.tabPageFaculty = new System.Windows.Forms.TabPage();
            this.flowLayoutPeople = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageStaff = new System.Windows.Forms.TabPage();
            this.flowLayoutStaff = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnDegrees = new System.Windows.Forms.Button();
            this.btnPeople = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnResearch = new System.Windows.Forms.Button();
            this.btnNews = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnResources = new System.Windows.Forms.Button();
            this.tabControlPeople.SuspendLayout();
            this.tabPageFaculty.SuspendLayout();
            this.tabPageStaff.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPeople
            // 
            this.tabControlPeople.Controls.Add(this.tabPageFaculty);
            this.tabControlPeople.Controls.Add(this.tabPageStaff);
            this.tabControlPeople.Location = new System.Drawing.Point(120, 50);
            this.tabControlPeople.Name = "tabControlPeople";
            this.tabControlPeople.SelectedIndex = 0;
            this.tabControlPeople.Size = new System.Drawing.Size(1000, 650);
            this.tabControlPeople.TabIndex = 16;
            // 
            // tabPageFaculty
            // 
            this.tabPageFaculty.Controls.Add(this.flowLayoutPeople);
            this.tabPageFaculty.Location = new System.Drawing.Point(4, 22);
            this.tabPageFaculty.Name = "tabPageFaculty";
            this.tabPageFaculty.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFaculty.Size = new System.Drawing.Size(992, 624);
            this.tabPageFaculty.TabIndex = 0;
            this.tabPageFaculty.Text = "Faculty";
            this.tabPageFaculty.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPeople
            // 
            this.flowLayoutPeople.AutoScroll = true;
            this.flowLayoutPeople.Location = new System.Drawing.Point(72, 31);
            this.flowLayoutPeople.Name = "flowLayoutPeople";
            this.flowLayoutPeople.Size = new System.Drawing.Size(848, 558);
            this.flowLayoutPeople.TabIndex = 0;
            // 
            // tabPageStaff
            // 
            this.tabPageStaff.Controls.Add(this.flowLayoutStaff);
            this.tabPageStaff.Location = new System.Drawing.Point(4, 22);
            this.tabPageStaff.Name = "tabPageStaff";
            this.tabPageStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStaff.Size = new System.Drawing.Size(992, 624);
            this.tabPageStaff.TabIndex = 1;
            this.tabPageStaff.Text = "Staff";
            this.tabPageStaff.UseVisualStyleBackColor = true;
            // 
            // flowLayoutStaff
            // 
            this.flowLayoutStaff.AutoScroll = true;
            this.flowLayoutStaff.Location = new System.Drawing.Point(72, 31);
            this.flowLayoutStaff.Name = "flowLayoutStaff";
            this.flowLayoutStaff.Size = new System.Drawing.Size(848, 558);
            this.flowLayoutStaff.TabIndex = 1;
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
            this.flowLayoutPanel1.TabIndex = 14;
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
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(245, 6);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(781, 39);
            this.lblHeader.TabIndex = 15;
            this.lblHeader.Text = "INFORMATION SCIENCES AND TECHNOLOGY @ RIT";
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
            // FormPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 762);
            this.Controls.Add(this.tabControlPeople);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPeople";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPeople_FormClosed);
            this.Load += new System.EventHandler(this.FormPeople_Load);
            this.tabControlPeople.ResumeLayout(false);
            this.tabPageFaculty.ResumeLayout(false);
            this.tabPageStaff.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnDegrees;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TabControl tabControlPeople;
        private System.Windows.Forms.TabPage tabPageFaculty;
        private System.Windows.Forms.TabPage tabPageStaff;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPeople;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutStaff;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnNews;
        private System.Windows.Forms.Button btnResearch;
        private System.Windows.Forms.Button btnResources;
    }
}