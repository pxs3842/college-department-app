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
    public partial class FormStatistics : FormBase
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        public void Populate()
        {
            Employment employment = _dataService.GetEmploymentInformation();

            lblEmpTable.Text = employment.employmentTable.Title;

            // create the headers for the List View
            listViewEmployment.View = View.Details;
            listViewEmployment.GridLines = true;
            listViewEmployment.FullRowSelect = true;

            listViewEmployment.Columns.Add("Employer", 180);
            listViewEmployment.Columns.Add("Degree", 180);
            listViewEmployment.Columns.Add("City", 180);
            listViewEmployment.Columns.Add("Title", 180);
            listViewEmployment.Columns.Add("Start Date", 158);

            for (var i = 0; i < employment.employmentTable.ProfessionalEmploymentInformation.Count; i++)
            {
                // create an object to add information into the List View
                ListViewItem item = new ListViewItem(new String[]
                {
                    employment.employmentTable.ProfessionalEmploymentInformation[i].Employer,
                    employment.employmentTable.ProfessionalEmploymentInformation[i].Degree,
                    employment.employmentTable.ProfessionalEmploymentInformation[i].City,
                    employment.employmentTable.ProfessionalEmploymentInformation[i].Title,
                    employment.employmentTable.ProfessionalEmploymentInformation[i].StartDate
                }
                );
                listViewEmployment.Items.Add(item);
            } // end for

            lblCoopTable.Text = employment.coopTable.Title;

            // create the headers for the List View
            listViewCoop.View = View.Details;
            listViewCoop.GridLines = true;
            listViewCoop.FullRowSelect = true;

            listViewCoop.Columns.Add("Employer", 225);
            listViewCoop.Columns.Add("Degree", 225);
            listViewCoop.Columns.Add("City", 225);
            listViewCoop.Columns.Add("Term", 204);

            for (var i = 0; i < employment.coopTable.CoopInformation.Count; i++)
            {
                // create an object to add information into the List View
                ListViewItem item = new ListViewItem(new String[]
                {
                    employment.coopTable.CoopInformation[i].Employer,
                    employment.coopTable.CoopInformation[i].Degree,
                    employment.coopTable.CoopInformation[i].City,
                    employment.coopTable.CoopInformation[i].Term
                }
                );
                listViewCoop.Items.Add(item);
            } // end for

        }

        private void FormStatistics_Load(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            FormEmployment frmEmployment = new FormEmployment();
            this.Hide();
            frmEmployment.Show();
        }

        private void FormStatistics_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void button6_Click(object sender, EventArgs e)
        {
            FormContact frmContact = new FormContact();
            this.Hide();
            frmContact.Show();
        }
    }
}
