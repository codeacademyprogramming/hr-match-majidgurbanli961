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
    public partial class SeeAppliedCvs : Form
    {
        public SeeAppliedCvs()
        {
            InitializeComponent();
        }

        private void SeeAppliedCvs_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Elan adi");
            listView1.Columns.Add("Ishci adi");
            listView1.Columns.Add("Ishci Familyasi");
      

            listView1.Columns.Add("Yas");
            listView1.Columns.Add("Cins");
            listView1.Columns.Add("Tecrube");
            listView1.Columns.Add("Sheher");
            listView1.Columns.Add("Minimum maash");
            listView1.Columns.Add("Telephone nomresi");
            listView1.Columns.Add("WorkName");
            using(HrConnect db  = new HrConnect())
            {
                var elans = db.Elans.Include("Cvs").Where(x => x.Userid == Helper.userId).ToList();
                foreach (var elan in elans)
                {
                    string[] listviewitem = new string[10];
                    listviewitem[0] = elan.ElanName;
                    foreach (var cv in elan.Cvs)
                    {
                        listviewitem[1] = cv.CvName;
                        listviewitem[2] = cv.CvSurname;
                        listviewitem[3] = cv.CvAge.ToString();
                        listviewitem[4] = cv.CvSex;
                        listviewitem[5] = cv.CvWorkExperiment;
                        listviewitem[6] = cv.CvCity;
                        listviewitem[7] = cv.CvMinSalary;

                        listviewitem[8] = cv.ContactPhone;
                        listviewitem[9] = cv.WorkName;
                        listView1.Items.Add(new ListViewItem(new string[] { listviewitem[0],
                        listviewitem[1],listviewitem[2],listviewitem[3],listviewitem[4],
                        listviewitem[5],listviewitem[6],listviewitem[7],listviewitem[8],listviewitem[9]}));











                    }
                }
            }




        }
    }
}
