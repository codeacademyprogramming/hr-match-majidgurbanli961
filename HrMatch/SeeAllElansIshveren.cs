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
    public partial class SeeAllElansIshveren : Form
    {
        public SeeAllElansIshveren()
        {
            InitializeComponent();
        }

        private void SeeAllElansIshveren_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Id");
            listView1.Columns.Add("Name");

            using (HrConnect db = new HrConnect())
            {
                var elans = db.Elans.Where(x=>x.Userid==Helper.userId).ToList();
                foreach (var item in elans)
                {
                    listView1.Items.Add(new ListViewItem(new string[]
                    {
                        item.Id.ToString(),
                        item.ElanName.ToString()

                    }));


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var applied = new SeeAppliedCvs();
            applied.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var mylogin = new Login();
            mylogin.Show();
            this.Hide();
        }
    }
}
