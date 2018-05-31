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
    public partial class FormNews : FormBase
    {
        public FormNews()
        {
            InitializeComponent();
        }

        public void Populate()
        {
            News news = _dataService.GetNewsInformation();

            listViewYear.View = View.Details;
            listViewYear.GridLines = true;
            listViewYear.FullRowSelect = true;
            listViewYear.LabelEdit = true;
            listViewYear.LabelWrap = true;

            listViewYear.Columns.Add("Date", 110);
            listViewYear.Columns.Add("Title", 240);
            listViewYear.Columns.Add("Description", 609);


            foreach (var item in news.year)
            {
                ListViewItem i = new ListViewItem(new String[]
                {
                    item.Date, item.Title, item.Description
                });
                listViewYear.Items.Add(i);
            }

            listViewOlder.View = View.Details;
            listViewOlder.GridLines = true;
            listViewOlder.FullRowSelect = true;
            listViewOlder.LabelEdit = true;
            listViewOlder.LabelWrap = true;

            listViewOlder.Columns.Add("Date", 110);
            listViewOlder.Columns.Add("Title", 240);
            listViewOlder.Columns.Add("Description", 609);


            foreach (var item in news.older)
            {
                ListViewItem i = new ListViewItem(new String[]
                {
                    item.Date, item.Title, item.Description
                });
                listViewOlder.Items.Add(i);
            }
        }
        private void FormNews_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            Populate();
        }

        private void FormNews_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            FormStatistics frmStatistics = new FormStatistics();
            this.Hide();
            frmStatistics.Show();
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