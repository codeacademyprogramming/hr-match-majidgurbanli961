using HrMatch.DB;
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
    public partial class EnUygunIsh : Form
    {
        public EnUygunIsh()
        {
            InitializeComponent();
        }

        private void EnUygunIsh_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Elan adi");
            listView1.Columns.Add("Shirket adi");

            listView1.Columns.Add("Ish  adi");
            listView1.Columns.Add("Description");
            listView1.Columns.Add("Sheher");
            listView1.Columns.Add("Maash ");
            listView1.Columns.Add("Yash");
            listView1.Columns.Add("Tecrube");
            listView1.Columns.Add("Tehsil");
            listView1.Columns.Add("Telephone");

            using (HrConnect db = new HrConnect())
            {
                var cv = db.Cvs.FirstOrDefault(x => x.Userid == Helper.userId);
                string workName = cv.WorkName;
                string educationName = cv.EducationName;
                var elans = db.Elans.Where(x => x.Workname == workName || x.Education == educationName).ToList();
                if (elans.Count >= 1)
                {
                    foreach (var item in elans)
                    {
                        listView1.Items.Add(new ListViewItem(new string[] { item.ElanName,item.ShirketName,
                    item.Workname,item.Description,item.City,item.Salary,item.Age.ToString(),item.Experience,
                    item.Education,item.Telephone.ToString()}));


                    }
                }
                else
                {
                    MessageBox.Show("Uygun ish tapilmadi");
                }



            }
        }
    }
}
