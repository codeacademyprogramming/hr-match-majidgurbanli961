using HrMatch.DB;
using HrMatch.DB.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrMatch
{
    public partial class AddCv : Form
    {
        public AddCv()
        {
            InitializeComponent();
        }

        private void AddCv_Load(object sender, EventArgs e)
        {
            
            sexBox.Items.Add("1.Kisi");
            sexBox.Items.Add("2.Qadin");
            educationBox.Items.Add("1.Orta");
            educationBox.Items.Add("2.Natamam Ali");
            educationBox.Items.Add("3.Ali");
            experienceBox.Items.Add("1 ilden asagi");
            experienceBox.Items.Add("1 ilden 3 - ile qeder");
            experienceBox.Items.Add("3 ilden - 5 ile qeder");
            experienceBox.Items.Add(" 5 ilden daha cox");
            using(HrConnect db = new HrConnect())
            {
                foreach (var work in db.Works)
                {
                    categoryBox.Items.Add(work.Id + "." + work.WorkName);

                }
            }


        }

        private void clickMe_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string surname = surnameTextbox.Text;
            string gender = sexBox.Text.Substring(2);
            int age = Convert.ToInt32(ageBox.Value);
            int education = Convert.ToInt32( educationBox.Text.Substring(0, 1));
            string ishTecrubesi = experienceBox.Text;
            int work = Convert.ToInt32( categoryBox.Text.Substring(0,1));
            string city = cityBox.Text;
            string minSalary = minSalaryBox.Value.ToString();
            string cellphone = cellPhone.Text;
           
            using (HrConnect db = new HrConnect())
            {
                var cvs = db.Cvs.ToList();
                var result = cvs.Where(x => x.Userid == Helper.userId).ToList();
                if (result.Count > 0)
                {
                    MessageBox.Show("Bu usernamenin uygun cv si var");
                }
                else
                {
                    string workName = db.Works.FirstOrDefault(x => x.Id == work).WorkName;
                    string educationName = db.Educations.FirstOrDefault(x => x.Id == education).EducationName;


                    db.Cvs.Add(new Cv()
                    {
                        CvName = name,
                        CvSurname = surname,
                        CvSex = gender,
                        CvAge = age,
                        EducationName = educationName,
                        CvWorkExperiment = ishTecrubesi,
                        WorkName = workName,
                        CvCity = city,
                        CvMinSalary = minSalary,
                        ContactPhone = cellphone,
                        Userid = Helper.userId
                    });
                    db.SaveChanges();
                    nameBox.Text = "";
                    surnameTextbox.Text = "";
                    sexBox.Text = "";
                    ageBox.Value = 0;
                    educationBox.Text = "";
                    experienceBox.Text = "";
                    categoryBox.Text = "";
                    cityBox.Text = "";
                    minSalaryBox.Value = 0;
                    cellPhone.Text = "";


                }
            }


        }

        private void seeCv_Click(object sender, EventArgs e)
        {
            var seeCv = new seeCv();
            seeCv.Show();
            this.Hide();
        }
    }
}
