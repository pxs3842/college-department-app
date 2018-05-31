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
    public partial class FormResearch : FormBase
    {
        Research research;
        public FormResearch()
        {
            InitializeComponent();
        }

        public void Populate()
        {
            research = _dataService.GetResearchInformation();

            foreach (ByInterestArea interestArea in research.byInterestArea)
            {
                if (interestArea.AreaName == "HCI")
                {
                    groupBoxHCI.Text = interestArea.AreaName;
                    textBoxHCI.Text = "Citations : " + "\r\n";

                    foreach (var citation in interestArea.Citations)
                    {
                        textBoxHCI.Text += "* " + citation + "\r\n";
                    }
                }

                if (interestArea.AreaName == "Analytics")
                {
                    groupBoxAnalytics.Text = interestArea.AreaName;
                    textBoxAnalytics.Text = "Citations : " + "\r\n";

                    foreach (var citation in interestArea.Citations)
                    {
                        textBoxAnalytics.Text += "* " + citation + "\r\n";
                    }
                }

                if (interestArea.AreaName == "Database")
                {
                    groupBoxDatabase.Text = interestArea.AreaName;
                    textBoxDatabase.Text = "Citations : " + "\r\n";

                    foreach (var citation in interestArea.Citations)
                    {
                        textBoxDatabase.Text += "* " + citation + "\r\n";
                    }
                }

                if (interestArea.AreaName == "Education")
                {
                    groupBoxEducation.Text = interestArea.AreaName;
                    textBoxEducation.Text = "Citations : " + "\r\n";

                    foreach (var citation in interestArea.Citations)
                    {
                        textBoxEducation.Text += "* " + citation + "\r\n";
                    }
                }

                if (interestArea.AreaName == "Geo")
                {
                    groupBoxGeo.Text = interestArea.AreaName;
                    textBoxGeo.Text = "Citations : " + "\r\n";

                    foreach (var citation in interestArea.Citations)
                    {
                        textBoxGeo.Text += "* " + citation + "\r\n";
                    }
                }

                if (interestArea.AreaName == "Health Informatics")
                {
                    groupBoxHealthInformatics.Text = interestArea.AreaName;
                    textBoxHealthInformatics.Text = "Citations : " + "\r\n";

                    foreach (var citation in interestArea.Citations)
                    {
                        textBoxHealthInformatics.Text += "* " + citation + "\r\n";
                    }
                }

                if (interestArea.AreaName == "Mobile")
                {
                    groupBoxMobile.Text = interestArea.AreaName;
                    textBoxMobile.Text = "Citations : " + "\r\n";

                    foreach (var citation in interestArea.Citations)
                    {
                        textBoxMobile.Text += "* " + citation + "\r\n";
                    }
                }

                if (interestArea.AreaName == "Networking")
                {
                    groupBoxNetworking.Text = interestArea.AreaName;
                    textBoxNetworking.Text = "Citations : " + "\r\n";

                    foreach (var citation in interestArea.Citations)
                    {
                        textBoxNetworking.Text += "* " + citation + "\r\n";
                    }
                }

                if (interestArea.AreaName == "Programming")
                {
                    groupBoxProgramming.Text = interestArea.AreaName;
                    textBoxProgramming.Text = "Citations : " + "\r\n";

                    foreach (var citation in interestArea.Citations)
                    {
                        textBoxProgramming.Text += "* " + citation + "\r\n";
                    }
                }

                if (interestArea.AreaName == "System Administration")
                {
                    groupBoxSystemAdmin.Text = interestArea.AreaName;
                    textBoxSystemAdmin.Text = "Citations : " + "\r\n";

                    foreach (var citation in interestArea.Citations)
                    {
                        textBoxSystemAdmin.Text += "* " + citation + "\r\n";
                    }
                }

                if (interestArea.AreaName == "Ubiquitous Computing")
                {
                    groupBoxUbiquitous.Text = interestArea.AreaName;
                    textBoxUbiquitous.Text = "Citations : " + "\r\n";

                    foreach (var citation in interestArea.Citations)
                    {
                        textBoxUbiquitous.Text += "* " + citation + "\r\n";
                    }
                }

                if (interestArea.AreaName == "Web")
                {
                    groupBoxWeb.Text = interestArea.AreaName;
                    textBoxWeb.Text = "Citations : " + "\r\n";

                    foreach (var citation in interestArea.Citations)
                    {
                        textBoxWeb.Text += "* " + citation + "\r\n";
                    }
                }
            }

            foreach (ByFaculty byFaculty in research.byFaculty)
            {
                if (byFaculty.FacultyName == "Deborah Gears")
                {
                    groupBoxDG.Text = byFaculty.FacultyName;
                    labelDG.Text = "Username : " + byFaculty.Username;
                    textBoxDG.Text = "Citations : " + "\r\n";

                    foreach (var citation in byFaculty.Citations)
                    {
                        textBoxDG.Text += "* " + citation + "\r\n";
                    }
                }

                if (byFaculty.FacultyName == "Brian Tomaszewski")
                {
                    groupBoxBT.Text = byFaculty.FacultyName;
                    labelBT.Text = "Username : " + byFaculty.Username;
                    textBoxBT.Text = "Citations : " + "\r\n";

                    foreach (var citation in byFaculty.Citations)
                    {
                        textBoxBT.Text += "* " + citation + "\r\n";
                    }
                }

                if (byFaculty.FacultyName == "Elissa Weeden")
                {
                    groupBoxEW.Text = byFaculty.FacultyName;
                    labelEW.Text = "Username : " + byFaculty.Username;
                    textBoxEW.Text = "Citations : " + "\r\n";

                    foreach (var citation in byFaculty.Citations)
                    {
                        textBoxEW.Text += "* " + citation + "\r\n";
                    }
                }

                if (byFaculty.FacultyName == "Qi Yu")
                {
                    groupBoxQY.Text = byFaculty.FacultyName;
                    labelQY.Text = "Username : " + byFaculty.Username;
                    textBoxQY.Text = "Citations : " + "\r\n";

                    foreach (var citation in byFaculty.Citations)
                    {
                        textBoxQY.Text += "* " + citation + "\r\n";
                    }
                }

                if (byFaculty.FacultyName == "Steve Zilora")
                {
                    groupBoxSZ.Text = byFaculty.FacultyName;
                    labelSZ.Text = "Username : " + byFaculty.Username;
                    textBoxSZ.Text = "Citations : " + "\r\n";

                    foreach (var citation in byFaculty.Citations)
                    {
                        textBoxSZ.Text += "* " + citation + "\r\n";
                    }
                }

                if (byFaculty.FacultyName == "Catherine Beaton")
                {
                    groupBoxCB.Text = byFaculty.FacultyName;
                    labelCB.Text = "Username : " + byFaculty.Username;
                    textBoxCB.Text = "Citations : " + "\r\n";

                    foreach (var citation in byFaculty.Citations)
                    {
                        textBoxCB.Text += "* " + citation + "\r\n";
                    }
                }

                if (byFaculty.FacultyName == "Bruce Hartpence")
                {
                    groupBoxBH.Text = byFaculty.FacultyName;
                    labelBH.Text = "Username : " + byFaculty.Username;
                    textBoxBH.Text = "Citations : " + "\r\n";

                    foreach (var citation in byFaculty.Citations)
                    {
                        textBoxBH.Text += "* " + citation + "\r\n";
                    }
                }

                if (byFaculty.FacultyName == "Sharon Mason")
                {
                    groupBoxSM.Text = byFaculty.FacultyName;
                    labelSM.Text = "Username : " + byFaculty.Username;
                    textBoxSM.Text = "Citations : " + "\r\n";

                    foreach (var citation in byFaculty.Citations)
                    {
                        textBoxSM.Text += "* " + citation + "\r\n";
                    }
                }

                if (byFaculty.FacultyName == "Tae (Tom) Oh")
                {
                    groupBoxTO.Text = byFaculty.FacultyName;
                    labelTO.Text = "Username : " + byFaculty.Username;
                    textBoxTO.Text = "Citations : " + "\r\n";

                    foreach (var citation in byFaculty.Citations)
                    {
                        textBoxTO.Text += "* " + citation + "\r\n";
                    }
                }

                if (byFaculty.FacultyName == "Nirmala Shenoy")
                {
                    groupBoxNS.Text = byFaculty.FacultyName;
                    labelNS.Text = "Username : " + byFaculty.Username;
                    textBoxNS.Text = "Citations : " + "\r\n";

                    foreach (var citation in byFaculty.Citations)
                    {
                        textBoxNS.Text += "* " + citation + "\r\n";
                    }
                }

                if (byFaculty.FacultyName == "Ed Holden")
                {
                    groupBoxEH.Text = byFaculty.FacultyName;
                    labelEH.Text = "Username : " + byFaculty.Username;
                    textBoxEH.Text = "Citations : " + "\r\n";

                    foreach (var citation in byFaculty.Citations)
                    {
                        textBoxEH.Text += "* " + citation + "\r\n";
                    }
                }

                if (byFaculty.FacultyName == "Michael Floeser")
                {
                    groupBoxMF.Text = byFaculty.FacultyName;
                    labelMF.Text = "Username : " + byFaculty.Username;
                    textBoxMF.Text = "Citations : " + "\r\n";

                    foreach (var citation in byFaculty.Citations)
                    {
                        textBoxMF.Text += "* " + citation + "\r\n";
                    }
                }

                if (byFaculty.FacultyName == "Vicki Hanson")
                {
                    groupBoxVH.Text = byFaculty.FacultyName;
                    labelVH.Text = "Username : " + byFaculty.Username;
                    textBoxVH.Text = "Citations : " + "\r\n";

                    foreach (var citation in byFaculty.Citations)
                    {
                        textBoxVH.Text += "* " + citation + "\r\n";
                    }
                }

                if (byFaculty.FacultyName == "Larry Hill")
                {
                    groupBoxLH.Text = byFaculty.FacultyName;
                    labelLH.Text = "Username : " + byFaculty.Username;
                    textBoxLH.Text = "Citations : " + "\r\n";

                    foreach (var citation in byFaculty.Citations)
                    {
                        textBoxLH.Text += "* " + citation + "\r\n";
                    }
                }

                if (byFaculty.FacultyName == "Deborah LaBelle")
                {
                    groupBoxDL.Text = byFaculty.FacultyName;
                    labelDL.Text = "Username : " + byFaculty.Username;
                    textBoxDL.Text = "Citations : " + "\r\n";

                    foreach (var citation in byFaculty.Citations)
                    {
                        textBoxDL.Text += "* " + citation + "\r\n";
                    }
                }

                if (byFaculty.FacultyName == "Ronald Vullo")
                {
                    groupBoxRV.Text = byFaculty.FacultyName;
                    labelRV.Text = "Username : " + byFaculty.Username;
                    textBoxRV.Text = "Citations : " + "\r\n";

                    foreach (var citation in byFaculty.Citations)
                    {
                        textBoxRV.Text += "* " + citation + "\r\n";
                    }
                }

                if (byFaculty.FacultyName == "Matt Huenerfauth")
                {
                    groupBoxMH.Text = byFaculty.FacultyName;
                    labelMH.Text = "Username : " + byFaculty.Username;
                    textBoxMH.Text = "Citations : " + "\r\n";

                    foreach (var citation in byFaculty.Citations)
                    {
                        textBoxMH.Text += "* " + citation + "\r\n";
                    }
                }

                if (byFaculty.FacultyName == "Charlie Border")
                {
                    groupBoxChB.Text = byFaculty.FacultyName;
                    labelChB.Text = "Username : " + byFaculty.Username;
                    textBoxChB.Text = "Citations : " + "\r\n";

                    foreach (var citation in byFaculty.Citations)
                    {
                        textBoxChB.Text += "* " + citation + "\r\n";
                    }
                }

                if (byFaculty.FacultyName == "Daniel Ashbrook")
                {
                    groupBoxDA.Text = byFaculty.FacultyName;
                    labelDA.Text = "Username : " + byFaculty.Username;
                    textBoxDA.Text = "Citations : " + "\r\n";

                    foreach (var citation in byFaculty.Citations)
                    {
                        textBoxDA.Text += "* " + citation + "\r\n";
                    }
                }

                if (byFaculty.FacultyName == "Jai Kang")
                {
                    groupBoxJK.Text = byFaculty.FacultyName;
                    labelJK.Text = "Username : " + byFaculty.Username;
                    textBoxJK.Text = "Citations : " + "\r\n";

                    foreach (var citation in byFaculty.Citations)
                    {
                        textBoxJK.Text += "* " + citation + "\r\n";
                    }
                }
            }
        }

        private void FormResearch_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            Populate();
        }

        private void FormResearch_FormClosed(object sender, FormClosedEventArgs e)
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

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormContact frmContact = new FormContact();
            this.Hide();
            frmContact.Show();
        }

        private void btnResources_Click(object sender, EventArgs e)
        {
            FormResources frmResources = new FormResources();
            this.Hide();
            frmResources.Show();
        }
    }
}