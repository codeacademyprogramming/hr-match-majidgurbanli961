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
    public partial class SeeSelectedElan : Form
    {
        private int elanId;
        public SeeSelectedElan()
        {
            InitializeComponent();
        }

        public SeeSelectedElan(int elanId)
        {
            this.elanId = elanId;
            InitializeComponent();

        }

        private void SeeSelectedElan_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Id");
            listView1.Columns.Add("Elan Adi");
            listView1.Columns.Add("Shirket Adi");
            listView1.Columns.Add("Ish Adi");
            listView1.Columns.Add("Melumat");
            listView1.Columns.Add("Sheher");
            listView1.Columns.Add("Maash");
            listView1.Columns.Add("Yash");
            listView1.Columns.Add("Tecrube");
            listView1.Columns.Add("Telephone");
            listView1.Columns.Add("Muraciet Et");









            using (HrConnect db = new HrConnect())
            {
                var elan = db.Elans.FirstOrDefault(x => x.Id == elanId);
                listView1.Items.Add(new ListViewItem(new string[] { 
                elan.Id.ToString(),
                elan.ElanName,
                elan.ShirketName,
                elan.Workname,
                elan.Description,
                elan.City,
                elan.Salary,
                elan.Age.ToString(),
                elan.Experience,
                elan.Telephone,
                "Muraciet et"

                
                }));
            }
        }

        private void listviewClick(object sender, EventArgs e)
        {
            var selectedItem = Convert.ToInt32( listView1.SelectedItems[0].Text);
            using(HrConnect db = new HrConnect())
            {
                var elan = db.Elans.FirstOrDefault(x => x.Id == selectedItem);
                var cv = db.Cvs.FirstOrDefault(x => x.Userid == Helper.userId);
                MessageBox.Show(elan.Id.ToString()+"Elan Id");
                MessageBox.Show(cv.Id.ToString()+"Cv id");
                //db.Elans.Remove(elan);
                //elan.Cvs.Add(cv);
                //db.Elans.Add(elan);
                db.Elans.FirstOrDefault(x => x.Id == selectedItem).Cvs.Add(cv);

                db.SaveChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var seeAllElans = new SeeAllELans();
            seeAllElans.Show();
            this.Hide();

        }
    }
}
