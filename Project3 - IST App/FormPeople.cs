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
    public partial class FormPeople : FormBase
    {
        People people;
        public FormPeople()
        {
            InitializeComponent();
        }
        private void Populate()
        {
            people = _dataService.GetPeopleInformation();

            foreach (Faculty faculty in people.Faculty)
            {

                GroupBox grpboxFaculty = new GroupBox();
                grpboxFaculty.Text = faculty.Name;
                grpboxFaculty.Font = new Font("Georgia", 14);
                grpboxFaculty.BackColor = Color.FromArgb(192, 192, 255);
                grpboxFaculty.Height = 281;
                grpboxFaculty.Width = 382;

                Panel panel = new Panel();
                panel.AutoScroll = true;
                panel.Height = 270;
                panel.Width = 380;
                panel.Location = new Point(5, 22);

                TextBox container = new TextBox();
                container.Height = 170;
                container.Width = 330;
                container.Multiline = true;
                container.BorderStyle = BorderStyle.None;
                container.BackColor = Color.FromArgb(192, 192, 255);
                container.Location = new Point(20, 170);
                container.Font = new Font("Georgia", 10);
                container.TextAlign = HorizontalAlignment.Center;
                container.Text = "Username : " + faculty.Username + "\r\n" + faculty.Tagline + "\r\n" + "Title : " + faculty.Title + "\r\n" + 
                    "Interest Area : " + faculty.InterestArea + "\r\n" + "Office : " + faculty.Office + "\r\n" + 
                    "Website : " + faculty.Website + "\r\n" + "Phone : " + faculty.Phone + "\r\n" + "Email : " + faculty.Email + "\r\n" + 
                    "Twitter : " + faculty.Twitter + "\r\n" + "Facebook : " + faculty.Facebook;

                PictureBox facultyPicture = new PictureBox();
                facultyPicture.Size = new System.Drawing.Size(150, 150);
                facultyPicture.Location = new Point(115,15);
                facultyPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                facultyPicture.Load(faculty.ImagePath);

                grpboxFaculty.Controls.Add(panel);
                panel.Controls.Add(facultyPicture);
                panel.Controls.Add(container);

                flowLayoutPeople.Controls.Add(grpboxFaculty);
            }

            foreach (Staff staff in people.Staff)
            {
                GroupBox grpboxStaff = new GroupBox();
                grpboxStaff.Text = staff.Name;
                grpboxStaff.Font = new Font("Georgia", 14);
                grpboxStaff.BackColor = Color.FromArgb(192, 192, 255);
                grpboxStaff.Height = 281;
                grpboxStaff.Width = 382;

                Panel panel = new Panel();
                panel.AutoScroll = true;
                panel.Height = 270;
                panel.Width = 380;
                panel.Location = new Point(5, 22);

                TextBox container = new TextBox();
                container.Height = 170;
                container.Width = 330;
                container.Multiline = true;
                container.BorderStyle = BorderStyle.None;
                container.BackColor = Color.FromArgb(192, 192, 255);
                container.Location = new Point(20, 170);
                container.Font = new Font("Georgia", 10);
                container.TextAlign = HorizontalAlignment.Center;
                container.Text = "Username : " + staff.Username + "\r\n" + staff.Tagline + "\r\n" + "Title : " + staff.Title + "\r\n" +
                    "Interest Area : " + staff.InterestArea + "\r\n" + "Office : " + staff.Office + "\r\n" +
                    "Website : " + staff.Website + "\r\n" + "Phone : " + staff.Phone + "\r\n" + "Email : " + staff.Email + "\r\n";
                    // + "Twitter : " + staff.Twitter + "\r\n" + "Facebook : " + staff.Facebook;

                PictureBox facultyPicture = new PictureBox();
                facultyPicture.Size = new System.Drawing.Size(150, 150);
                facultyPicture.Location = new Point(115, 15);
                facultyPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                facultyPicture.Load(staff.ImagePath);

                grpboxStaff.Controls.Add(panel);
                panel.Controls.Add(facultyPicture);
                panel.Controls.Add(container);

                flowLayoutStaff.Controls.Add(grpboxStaff);
            }

        }

        private void FormPeople_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            Populate();
        }

        private void FormPeople_FormClosed(object sender, FormClosedEventArgs e)
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
