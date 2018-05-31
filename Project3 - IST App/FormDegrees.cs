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
    public partial class FormDegrees : FormBase
    {
        Degrees degree;
        Minors minor;
        public FormDegrees()
        {
            InitializeComponent();
        }

        private void Populate()
        { 
            degree = _dataService.GetDegreeInformation();
            minor = _dataService.GetMinorsInformation();


            foreach (Undergraduate undergrad in degree.Undergraduate)
            {
                if (undergrad.DegreeName == "wmc")
                {
                    lblWMC.Text = undergrad.Title;
                    txtBoxWMC.Text = undergrad.Description;

                    foreach (var concentration in undergrad.Concentrations)
                    {
                        listBoxWMC.Items.Add(concentration);
                    }
                    continue;    
                }
            
                if (undergrad.DegreeName == "hcc")
                {
                    lblHCC.Text = undergrad.Title;
                    txtBoxHCC.Text = undergrad.Description;

                    foreach (var concentration in undergrad.Concentrations)
                    {
                        listBoxHCC.Items.Add(concentration);
                    }
                    continue;
                }
           
                if (undergrad.DegreeName == "cit")
                {
                    lblCIT.Text = undergrad.Title;
                    txtBoxCIT.Text = undergrad.Description;

                    foreach (var concentration in undergrad.Concentrations)
                    {
                        listBoxCIT.Items.Add(concentration);
                    }
                    continue;
                }
            } // end of Undergraduate data

            foreach (Graduate gradDegree in degree.Graduate)
            {
                if (gradDegree.DegreeName == "ist")
                {
                    lblIST.Text = gradDegree.Title;
                    txtBoxIST.Text = gradDegree.Description;

                    foreach (var concentration in gradDegree.Concentrations)
                    {
                        listBoxIST.Items.Add(concentration);
                    }
                }

                if (gradDegree.DegreeName == "hci")
                {
                    lblHCI.Text = gradDegree.Title;
                    txtBoxHCI.Text = gradDegree.Description;

                    foreach (var concentration in gradDegree.Concentrations)
                    {
                        listBoxHCI.Items.Add(concentration);
                    }
                }

                if (gradDegree.DegreeName == "nsa")
                {
                    lblNSA.Text = gradDegree.Title;
                    txtBoxNSA.Text = gradDegree.Description;

                    foreach (var concentration in gradDegree.Concentrations)
                    {
                        listBoxNSA.Items.Add(concentration);
                    }
                }

                if (gradDegree.DegreeName == "graduate advanced certificates")
                {
                    lblGAC.Text = gradDegree.DegreeName;

                    foreach (var availableCertificates in gradDegree.AvailableCertificates)
                    {
                        listBoxGAC.Items.Add(availableCertificates);
                    }
                }
            } // end of Graduate data

            foreach (UGMinors undergraduateMinor in minor.UGMinors)
            {
                if(undergraduateMinor.Name == "DBDDI-MN")
                {
                    lblDBDDI.Text = undergraduateMinor.Title;
                    txtBoxDBDDI.Text = undergraduateMinor.Description;
                    txtBoxNoteDBDDI.Text = "NOTE : " + undergraduateMinor.Note;

                    foreach (var course in undergraduateMinor.Courses)
                    {
                        listBoxDBDDI.Items.Add(course);
                    }
                }

                if (undergraduateMinor.Name == "GIS-MN")
                {
                    lblGIS.Text = undergraduateMinor.Title;
                    txtBoxGIS.Text = undergraduateMinor.Description;
                    txtBoxNoteGIS.Text = "NOTE : " + undergraduateMinor.Note;

                    foreach (var course in undergraduateMinor.Courses)
                    {
                        listBoxGIS.Items.Add(course);
                    }
                }

                if (undergraduateMinor.Name == "MEDINFO-MN")
                {
                    lblMEDINFO.Text = undergraduateMinor.Title;
                    txtBoxMEDINFO.Text = undergraduateMinor.Description;
                    txtBoxNoteMEDINFO.Text = "NOTE : " + undergraduateMinor.Note;

                    foreach (var course in undergraduateMinor.Courses)
                    {
                        listBoxMEDINFO.Items.Add(course);
                    }
                }

                if (undergraduateMinor.Name == "MDDEV-MN")
                {
                    lblMDDEV.Text = undergraduateMinor.Title;
                    txtBoxMDDEV.Text = undergraduateMinor.Description;
                    txtBoxNoteMDDEV.Text = "NOTE : " + undergraduateMinor.Note;

                    foreach (var course in undergraduateMinor.Courses)
                    {
                        listBoxMDDEV.Items.Add(course);
                    }
                }

                if (undergraduateMinor.Name == "MDEV-MN")
                {
                    lblMDEV.Text = undergraduateMinor.Title;
                    txtBoxMDEV.Text = undergraduateMinor.Description;
                    txtBoxNoteMDEV.Text = "NOTE : " + undergraduateMinor.Note;

                    foreach (var course in undergraduateMinor.Courses)
                    {
                        listBoxMDEV.Items.Add(course);
                    }
                }

                if (undergraduateMinor.Name == "NETSYS-MN")
                {
                    lblNETSYS.Text = undergraduateMinor.Title;
                    txtBoxNETSYS.Text = undergraduateMinor.Description;
                    txtBoxNoteNETSYS.Text = "NOTE : " + undergraduateMinor.Note;

                    foreach (var course in undergraduateMinor.Courses)
                    {
                        listBoxNETSYS.Items.Add(course);
                    }
                }

                if (undergraduateMinor.Name == "WEBDD-MN")
                {
                    lblWEBDD.Text = undergraduateMinor.Title;
                    txtBoxWEBDD.Text = undergraduateMinor.Description;
                    txtBoxNoteWEBDD.Text = "NOTE : " + undergraduateMinor.Note;

                    foreach (var course in undergraduateMinor.Courses)
                    {
                        listBoxWEBDD.Items.Add(course);
                    }
                }

                if (undergraduateMinor.Name == "WEBD-MN")
                {
                    lblWEBD.Text = undergraduateMinor.Title;
                    txtBoxWEBD.Text = undergraduateMinor.Description;
                    txtBoxNoteWEBD.Text = "NOTE : " + undergraduateMinor.Note;

                    foreach (var course in undergraduateMinor.Courses)
                    {
                        listBoxWEBD.Items.Add(course);
                    }
                }
            }
        }

        private void tabMinors_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void FormDegrees_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            Populate();
        }

        private void tabGrads_Click(object sender, EventArgs e)
        {

        }

        private void FormDegrees_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tabUndergrads_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ISTapplication frmHome = new ISTapplication();
            this.Hide();
            frmHome.Show();
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
