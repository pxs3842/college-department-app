using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Project3___IST_App
{
    public partial class FormContact : FormBase
    {
        Footer footer;
        public FormContact()
        {
            InitializeComponent();
            webBrowserContact.Navigate("http://ist.rit.edu/api/contactForm/");
        }

        public void Populate()
        {
            footer = _dataService.GetFooterInformation();

            lblTitle.Text = footer.social.Title;
            lblTweet.Text = "'" + footer.social.Tweet + "'";
            lblBy.Text = "- " + footer.social.By;

            foreach (QuickLinks quicklink in footer.quickLinks)
            {
                if(quicklink.Title == "Apply Now")
                {
                    btnApplyNow.Text = quicklink.Title;
                }

                if(quicklink.Title == "About This Site")
                {
                    btnAboutThisSite.Text = quicklink.Title;
                }

                if(quicklink.Title == "Support IST")
                {
                    btnSupportIST.Text = quicklink.Title;
                }

                if(quicklink.Title == "Lab Hours")
                {
                    btnLabHours.Text = quicklink.Title;
                }
            }

            string temp = footer.copyright.html.Replace("&nbsp;", String.Empty).Replace("|","| ");
            lblCopyright.Text = Regex.Replace(temp,"<.*?>", String.Empty);
            
        }

        private void FormContact_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            Populate();
        }

        private void FormContact_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ISTapplication frmHome = new ISTapplication();
            this.Hide();
            frmHome.Show();
        }

        private void btnDegrees_Click(object sender, EventArgs e)
        {
            FormDegrees frmDegrees = new FormDegrees();
            this.Hide();
            frmDegrees.Show();
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            FormPeople frmPeople = new FormPeople();
            this.Hide();
            frmPeople.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormEmployment frmEmployment = new FormEmployment();
            this.Hide();
            frmEmployment.Show();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            FormMap frmMap = new FormMap();
            this.Hide();
            frmMap.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormStatistics frmStatistics = new FormStatistics();
            this.Hide();
            frmStatistics.Show();
        }

        private void btnNews_Click(object sender, EventArgs e)
        {
            FormNews frmNews = new FormNews();
            this.Hide();
            frmNews.Show();
        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
            FormResearch frmResearch = new FormResearch();
            this.Hide();
            frmResearch.Show();
        }

        private void pictureBoxFacebook_Click(object sender, EventArgs e)
        {
            Process.Start('"' + footer.social.Facebook + '"' );
        }

        private void pictureBoxTwitter_Click(object sender, EventArgs e)
        {
            Process.Start('"' + footer.social.Twitter + '"');
        }

        private void btnApplyNow_Click(object sender, EventArgs e)
        {
            foreach (QuickLinks quicklink in footer.quickLinks)
            {
                if (quicklink.Title == "Apply Now")
                {
                    Process.Start('"' + quicklink.Href + '"');
                }
            }
        }

        private void btnAboutThisSite_Click(object sender, EventArgs e)
        {
            foreach (QuickLinks quicklink in footer.quickLinks)
            {
                if (quicklink.Title == "About This Site")
                {
                    Process.Start('"' + quicklink.Href + '"');
                }
            }
        }

        private void btnSupportIST_Click(object sender, EventArgs e)
        {
            foreach (QuickLinks quicklink in footer.quickLinks)
            {
                if (quicklink.Title == "Support IST")
                {
                    Process.Start('"' + quicklink.Href + '"');
                }
            }
        }

        private void btnLabHours_Click(object sender, EventArgs e)
        {
            foreach (QuickLinks quicklink in footer.quickLinks)
            {
                if (quicklink.Title == "Lab Hours")
                {
                    Process.Start('"' + quicklink.Href + '"');
                }
            }
        }

        private void btnResources_Click(object sender, EventArgs e)
        {
            FormResources frmResources = new FormResources();
            this.Hide();
            frmResources.Show();
        }

        private void buttonNews_Click(object sender, EventArgs e)
        {
            Process.Start('"' + footer.news + '"');
        }
    }
}
