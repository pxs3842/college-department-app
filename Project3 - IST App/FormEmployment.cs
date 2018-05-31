using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3___IST_App
{
    public partial class FormEmployment : FormBase
    {
        public FormEmployment()
        {
            InitializeComponent();
        }

        public void Populate()
        {
            Employment employment = _dataService.GetEmploymentInformation();

                lblEmploymentTitle.Text = employment.introduction.Title;

                foreach(Content content in employment.introduction.Content)
                {
                    if (content.Title == "Employment")
                    {
                        lblEmployment.Text = content.Title;
                        textBoxEmp.Text = content.Description;
                    }
                    
                    if(content.Title == "Cooperative Education")
                    {
                        lblCoop.Text = content.Title;
                        textBoxCoop.Text = content.Description;
                    }
                }

            lblDegStats.Text = employment.degreeStatistics.Title;

            foreach(Statistics statistics in employment.degreeStatistics.Statistics)
            {
                if(statistics.Value == "$80,000")
                {
                    lblGlassdoor.Text = statistics.Value;
                    textBoxGlassdoor.Text = statistics.Description;
                }
                if(statistics.Value == "36th")
                {
                    lblInsider.Text = statistics.Value;
                    textBoxInsider.Text = statistics.Description;
                }
                if(statistics.Value == "35")
                {
                    lblNextWeb.Text = statistics.Value;
                    textBoxNextWeb.Text = statistics.Description;
                }
                if(statistics.Value == "1.11 Billion GB")
                {
                    lblMBAOnline.Text = statistics.Value;
                    textBoxMBAOnline.Text = statistics.Description;
                }
            }

            lblEmployers.Text = employment.employers.Title;

            foreach(var employerName in employment.employers.EmployerNames)
            {
                listBoxEmployers.Items.Add(employerName);
                listBoxEmployers.Items.Add("\r\n");
            }

            lblCareers.Text = employment.careers.Title;

            foreach(var CareerName in employment.careers.CareerNames)
            {
                listBoxCareers.Items.Add(CareerName);
                listBoxCareers.Items.Add("\r\n");
            }

        }

        private void lblEmploymentTitle_Click(object sender, EventArgs e)
        {

        }

        private void FormEmployment_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            Populate();
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

        private void FormEmployment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
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
