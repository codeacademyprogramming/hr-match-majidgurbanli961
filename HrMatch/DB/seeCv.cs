using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrMatch.DB
{
    public partial class seeCv : Form
    {
        public seeCv()
        {
            InitializeComponent();
        }
        public seeCv(int id)
        {
            InitializeComponent();
            Helper.userId = id;
        }

        private void seeCv_Load(object sender, EventArgs e)
        {
            using(HrConnect db = new HrConnect())
            {
                listView1.Columns.Add("Name");
                listView1.Columns.Add("Surname");
                listView1.Columns.Add("Age");
                listView1.Columns.Add("Sex");
                listView1.Columns.Add("Work Experiment");
                listView1.Columns.Add("City");
                listView1.Columns.Add("Minimum Salary");
                listView1.Columns.Add("Contact Phone");

                listView1.Columns.Add("Work Name ");
                listView1.Columns.Add("Education Name ");
                listView1.GridLines = true;
                var cv = db.Cvs.FirstOrDefault(x => x.Userid == Helper.userId);
                string educationName = cv.EducationName;
                string workName = cv.WorkName;
               
               
                listView1.Items.Add(new ListViewItem(new string[]
                {
                    cv.CvName,
                    cv.CvSurname,
                    cv.CvAge.ToString(),
                    cv.CvSex,
                    cv.CvWorkExperiment,
                    cv.CvCity,
                    cv.CvMinSalary,
                    cv.ContactPhone,
                    workName,
                    educationName

                }));












            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var seeAllElans = new SeeAllELans();
            seeAllElans.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var uygunish = new EnUygunIsh();
            uygunish.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ishAxtar = new SearchIsh();
            ishAxtar.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var mylogin = new Login();
            mylogin.Show();
            this.Hide();
        }
    }
}
