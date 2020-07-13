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
    public partial class SeeappliedElan : Form
    {
        public SeeappliedElan()
        {
            InitializeComponent();
        }

        private void SeeappliedElan_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Elan adi");
            listView1.Columns.Add("Shirket adi");
            listView1.Columns.Add("Ish  adi");
            listView1.Columns.Add("Description");
            listView1.Columns.Add("City");
            listView1.Columns.Add("Salary");
     
            listView1.Columns.Add("Telephone");






            using (HrConnect db = new HrConnect()){
              

                var cv = db.Cvs.Include("Elans").FirstOrDefault(x=>x.Userid==Helper.userId);




                var elans = cv.Elans.ToList();
                foreach (var item in elans)
                {
                    listView1.Items.Add(new ListViewItem(new string[] { item.ElanName, item.ShirketName
                    ,item.Workname,item.Description,item.City,item.Salary,item.Telephone}));

                }

            }

        }
    }
}
