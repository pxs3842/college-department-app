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

namespace Project3___IST_App
{
    public partial class FormResources : FormBase
    {
        Resources resources;
        public FormResources()
        {
            InitializeComponent();
        }

        public void Populate()
        {
            resources = _dataService.getResourcesInformation();

            textBoxTitle.Text = resources.title;

            textBoxStudyAbroad.Text = resources.studyAbroad.title;
            textBoxStudyAbroadDes.Text = resources.studyAbroad.description;

            foreach (var item in resources.studyAbroad.places)
            {
                if (item.nameOfPlace == "Dubrovnik, Croatia")
                {
                    textBoxCroatiaTitle.Text = item.nameOfPlace;
                    textBoxCroatiaDes.Text = item.description;
                }

                if (item.nameOfPlace == "Dubai, United Arab Emirates (UAE)")
                {
                    textBoxUAETitle.Text = item.nameOfPlace;
                    textBoxUAEDes.Text = item.description;
                }
            }

            textBoxStudentServices.Text = resources.studentServices.title;

            textBoxAcaAdvisor.Text = resources.studentServices.academicAdvisors.title;
            textBoxAcaAdvisorDes.Text = resources.studentServices.academicAdvisors.description;
            textBoxFaq.Text = resources.studentServices.academicAdvisors.faq.title;

            textBoxProfAdvisor.Text = resources.studentServices.professonalAdvisors.title;
            foreach (var item in resources.studentServices.professonalAdvisors.advisorInformation)
            {
                if (item.name == "Matt Lake")
                {
                    textBoxProfAdv1.Text = "Name : " + item.name + "\r\n" + "Department : " + item.department + "\r\n" + "Email : " + item.email;
                }

                if (item.name == "Betty Hillman")
                {
                    textBoxProfAdv2.Text = "Name : " + item.name + "\r\n" + "Department : " + item.department + "\r\n" + "Email : " + item.email;
                }

                if (item.name == "Jill Persson")
                {
                    textBoxProfAdv3.Text = "Name : " + item.name + "\r\n" + "Department : " + item.department + "\r\n" + "Email : " + item.email;
                }
            }

            textBoxFacAdv.Text = resources.studentServices.facultyAdvisors.title;
            textBoxFacAdvDes.Text = resources.studentServices.facultyAdvisors.description;

            textBoxTutor.Text = resources.tutorsAndLabInformation.title;
            textBoxTutorDes.Text = "\r\n" + "\r\n" + resources.tutorsAndLabInformation.description;

            textBoxMinorAdv.Text = resources.studentServices.istMinorAdvising.title;
            foreach (var item in resources.studentServices.istMinorAdvising.minorAdvisorInformation)
            {
                if (item.email == "ephics@rit.edu")
                {
                    textBoxMinor1.Text = "Title : " + item.title + "\r\n" + "Advisor : " + item.advisor + "\r\n" + "Email : " + item.email;
                }

                if (item.email == "bmtski@rit.edu")
                {
                    textBoxMinor2.Text = "Title : " + item.title + "\r\n" + "Advisor : " + item.advisor + "\r\n" + "Email : " + item.email;
                }

                if (item.title == "Health IT")
                {
                    textBoxMinor3.Text = "Title : " + item.title + "\r\n" + "Advisor : " + item.advisor + "\r\n" + "Email : " + item.email;
                }

                if (item.title == "Mobile Design and Development")
                {
                    textBoxMinor4.Text = "Title : " + item.title + "\r\n" + "Advisor : " + item.advisor + "\r\n" + "Email : " + item.email;
                }

                if (item.title == "Mobile Development")
                {
                    textBoxMinor5.Text = "Title : " + item.title + "\r\n" + "Advisor : " + item.advisor + "\r\n" + "Email : " + item.email;
                }

                if (item.title == "Networking and Systems Administration")
                {
                    textBoxMinor6.Text = "Title : " + item.title + "\r\n" + "Advisor : " + item.advisor + "\r\n" + "Email : " + item.email;
                }

                if (item.email == "rpvvks@rit.edu")
                {
                    textBoxMinor7.Text = "Title : " + item.title + "\r\n" + "Advisor : " + item.advisor + "\r\n" + "Email : " + item.email;
                }

                if (item.email == "dan.bogaard@rit.edu")
                {
                    textBoxMinor8.Text = "Title : " + item.title + "\r\n" + "Advisor : " + item.advisor + "\r\n" + "Email : " + item.email;
                }
            }

            textBoxStuAmb.Text = resources.studentAmbassadors.title;
            pictureBoxAmb.Load(resources.studentAmbassadors.ambassadorsImageSource);
            textBoxNote.Text = resources.studentAmbassadors.note;

            foreach (var item in resources.studentAmbassadors.subSectionContent)
            {
                if (item.title == "Mission Statement")
                {
                    textBoxMission.Text = item.title + "\r\n" + "\r\n" + item.description;
                }

                if (item.title == "Overview")
                {
                    textBoxOverview.Text = item.title + "\r\n" + "\r\n" + item.description;
                }

                if (item.title == "Criteria")
                {
                    textBoxCriteria.Text = item.title + "\r\n" + "\r\n" + item.description;
                }

                if (item.title == "Duties")
                {
                    textBoxDuties.Text = item.title + "\r\n" + "\r\n" + item.description;
                }

                if (item.title == "Expectations")
                {
                    textBoxExpectations.Text = item.title + "\r\n" + "\r\n" + item.description;
                }

                if (item.title == "Perks")
                {
                    textBoxPerks.Text = item.title + "\r\n" + "\r\n" + item.description;
                }

                if (item.title == "apply")
                {
                    textBoxApply.Text = item.title + "\r\n" + "\r\n" + item.description;
                }
            }

            foreach (var item in resources.forms.graduateForms)
            {
                if (item.formName == "Grad Special Topic Proposal")
                {
                    buttonGradForm1.Text = item.formName;
                    lbl1.Text = item.href;
                }

                if (item.formName == "Capstone Guide")
                {
                    buttonGradForm2.Text = item.formName;
                    lbl2.Text = item.href;
                }

                if (item.formName == "Proposal Approval")
                {
                    buttonGradForm3.Text = item.formName;
                    lbl3.Text = item.href;
                }

                if (item.formName == "Defense Announcement")
                {
                    buttonGradForm4.Text = item.formName;
                    lbl4.Text = item.href;
                }

                if (item.formName == "Title Page")
                {
                    buttonGradForm5.Text = item.formName;
                    lbl5.Text = item.href;
                }

                if (item.formName == "Final Approval")
                {
                    buttonGradForm6.Text = item.formName;
                    lbl6.Text = item.href;
                }

                if (item.formName == "Defense Announcement")
                {
                    buttonGradForm7.Text = item.formName;
                    lbl7.Text = item.href;
                }
            }

            foreach (var item in resources.forms.undergraduateForms)
            {
                if (item.formName == "Independent Study Form")
                {
                    buttonUGradForm1.Text = item.formName;
                    lbl8.Text = item.href;
                }
            }

            textBoxCoop.Text = resources.coopEnrollment.title;

            foreach(var item in resources.coopEnrollment.enrollmentInformationContent)
            {
                if(item.title == "Pre-requisites")
                {
                    textBoxCoop1.Text = item.title + "\r\n" + "\r\n" + "Description : " + item.description;
                }

                if (item.title == "How to enroll in a co-op you found on JobZone")
                {
                    textBoxCoop2.Text = item.title + "\r\n" + "\r\n" + "Description : " + item.description;
                }

                if (item.title == "How to enroll in a co-op you found outside of JobZone")
                {
                    textBoxCoop3.Text = item.title + "\r\n" + "\r\n" + "Description : " + item.description;
                }

                if (item.title == "Approval Process")
                {
                    textBoxCoop4.Text = item.title + "\r\n" + "\r\n" + "Description : " + item.description;
                }
            }
        }


        private void FormResources_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            Populate();
        }

        private void FormResources_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnEmployment_Click(object sender, EventArgs e)
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

        private void btnResearch_Click(object sender, EventArgs e)
        {
            FormResearch frmResearch = new FormResearch();
            this.Hide();
            frmResearch.Show();
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

        private void textBoxFaq_Click(object sender, EventArgs e)
        {
            Process.Start('"' + resources.studentServices.academicAdvisors.faq.contentHref + '"');
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxMinor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            Process.Start('"' + resources.studentAmbassadors.applicationFormLink + '"');
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void buttonGradForm1_Click(object sender, EventArgs e)
        {
            foreach (var item in resources.forms.graduateForms)
            {
                if (item.formName == "Grad Special Topic Proposal")
                {
                    Process.Start('"' + "http://ist.rit.edu/" + item.href + '"');
                }

            }
        }

        private void buttonGradForm2_Click(object sender, EventArgs e)
        {
            foreach (var item in resources.forms.graduateForms)
            {
                if (item.formName == "Capstone Guide")
                {
                    Process.Start('"' + "http://ist.rit.edu/" + item.href + '"');
                }
            }
        }

        private void buttonGradForm3_Click(object sender, EventArgs e)
        {
            foreach (var item in resources.forms.graduateForms)
            {
                if (item.formName == "Proposal Approval")
                {
                    Process.Start('"' + "http://ist.rit.edu/" + item.href + '"');
                }
            }
        }

        private void buttonGradForm4_Click(object sender, EventArgs e)
        {
            foreach (var item in resources.forms.graduateForms)
            {
                if (item.formName == "Defense Announcement")
                {
                    Process.Start('"' + "http://ist.rit.edu/" + item.href + '"');
                }
            }
        }

        private void buttonGradForm5_Click(object sender, EventArgs e)
        {
            foreach (var item in resources.forms.graduateForms)
            {
                if (item.formName == "Title Page")
                {
                    Process.Start('"' + "http://ist.rit.edu/" + item.href + '"');
                }
            }
        }

        private void buttonGradForm6_Click(object sender, EventArgs e)
        {
            foreach (var item in resources.forms.graduateForms)
            {
                if (item.formName == "Final Approval")
                {
                    Process.Start('"' + "http://ist.rit.edu/" + item.href + '"');
                }
            }
        }

        private void buttonGradForm7_Click(object sender, EventArgs e)
        {
            foreach (var item in resources.forms.graduateForms)
            {
                if (item.formName == "Defense Announcement")
                {
                    Process.Start('"' + "http://ist.rit.edu/" + item.href + '"');
                }
            }
        }

        private void buttonUGradForm1_Click(object sender, EventArgs e)
        {
            foreach (var item in resources.forms.graduateForms)
            {
                if (item.formName == "Independent Study Formt")
                {
                    Process.Start('"' + "http://ist.rit.edu/" + item.href + '"');
                }
            }
        }

        private void buttonJobZone_Click(object sender, EventArgs e)
        {
            Process.Start('"'+ resources.coopEnrollment.RITJobZoneGuidelink +'"');
        }
    }
}
