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
    public partial class SeeAllELans : Form
    {
        public SeeAllELans()
        {
            InitializeComponent();
        }

        private void SeeAllELans_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Id");
            listView1.Columns.Add("Name");

            using (HrConnect db = new  HrConnect())
            {
                var elans = db.Elans.ToList();
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

        private void listViewClick(object sender, EventArgs e)
        {
            var selectedItem = Convert.ToInt32( listView1.SelectedItems[0].Text.ToString());
            MessageBox.Show(selectedItem.ToString());
            var selectedElan = new SeeSelectedElan(selectedItem);
            selectedElan.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var appliedElan = new SeeappliedElan();
            appliedElan.Show();
            this.Hide();
        }
    }
}
