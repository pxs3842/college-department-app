using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3___IST_App
{
    public partial class ISTapplication : FormBase
    {
        public ISTapplication()
        {
            InitializeComponent();
        }

        private void Populate()
        {
            About about = _dataService.GetAboutInformation();

            // start displaying the About object information on the screen
            aboutTitle.Text = about.Title;
            aboutDescription.Text = "\r\n" + about.Description;
            authorInfo.Text = "\r\n" + about.Quote + "\r\n" + "\r\n";
            authorName.Text = about.QuoteAuthor;
        }

        private void btnDegrees_Click(object sender, EventArgs e)
        {            
            FormDegrees frmDegrees = new FormDegrees();
            this.Hide();
            frmDegrees.Show();
        }

        private void ISTapplication_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            Populate();
        }

        private void ISTapplication_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            FormPeople frmPeople = new FormPeople();
            this.Hide();
            frmPeople.Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEmployment_Click(object sender, EventArgs e)
        {
            FormEmployment frmEmployment = new FormEmployment();
            this.Hide();
            frmEmployment.Show();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            FormStatistics frmStatistics = new FormStatistics();
            this.Hide();
            frmStatistics.Show();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            FormMap frmMap = new FormMap();
            this.Hide();
            frmMap.Show();
        }

        private void btnNews_Click(object sender, EventArgs e)
        {
            FormNews frmNews = new FormNews();
            this.Hide();
            frmNews.Show();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            FormContact frmContact = new FormContact();
            this.Hide();
            frmContact.Show();
        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
            FormResearch frmResearch = new FormResearch();
            this.Hide();
            frmResearch.Show();
        }

        private void btnResources_Click(object sender, EventArgs e)
        {
            FormResources frmResources = new FormResources();
            this.Hide();
            frmResources.Show();
        }
    }
}
