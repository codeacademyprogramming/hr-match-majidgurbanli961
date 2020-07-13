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
    public partial class AddElan : Form
    {
        public AddElan()
        {
            InitializeComponent();
        }

       

        private void AddElan_Load(object sender, EventArgs e)
        {
            using(HrConnect db = new HrConnect())
            {

                var categories = db.Works.ToList();
                foreach (var item in categories)
                {
                    kateqoriaBox.Items.Add(item.Id + "." + item.WorkName);
                    

                }
                var tehsils = db.Educations.ToList();
                foreach (var item in tehsils)
                {
                    educationBox.Items.Add(item.Id + "." + item.EducationName);



                }
                
                experienceBox.Items.Add("1 ilden asagi");
                experienceBox.Items.Add("1 ilden 3 - ile qeder");
                experienceBox.Items.Add("3 ilden - 5 ile qeder");
                experienceBox.Items.Add(" 5 ilden daha cox");

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string elanName = elanAdi.Text;
            string shirketName = sirketAdi.Text;
            string workName =  kateqoriaBox.Text.Substring(2);
            string description = ishInfo.Text;
            string city = cityBox.Text;
            int salary = Convert.ToInt32( maashBox.Value);
            int age = Convert.ToInt32(yashBox.Value);
            string educationName = educationBox.Text.Substring(2);

            string tecrube = experienceBox.Text;
            string phone = phoneBox.Text;
             using(HrConnect db = new HrConnect())
            {
                db.Elans.Add(new Elan { ElanName = elanName,
                ShirketName=shirketName,
                Workname= workName,
                Education=educationName,
                Description=description,
                City=city,
                Salary=salary.ToString(),
                Age=age,
                Experience=tecrube,
                Telephone=phone,
                Userid=Helper.userId

                
                });
                db.SaveChanges();
                elanAdi.Text = "";
                sirketAdi.Text = "";
                ishInfo.Text = "";
                cityBox.Text = "";
                maashBox.Value = 0;
                yashBox.Value = 0;
                

            }
        }
    }
}
