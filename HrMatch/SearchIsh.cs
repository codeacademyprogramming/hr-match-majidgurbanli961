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
    public partial class SearchIsh : Form
    {
        public SearchIsh()
        {
            InitializeComponent();
        }

        private void SearchIsh_Load(object sender, EventArgs e)
        {
            using(HrConnect db = new HrConnect())
            {
                var educations = db.Educations.ToList();
                foreach (var item in educations)
                {
                    comboBox1.Items.Add(item.EducationName);


                }
                listView1.Columns.Add("Elan Adi ");
                listView1.Columns.Add("Shirket Adi ");
                listView1.Columns.Add("Ish Adi ");
                listView1.Columns.Add("Description ");
                listView1.Columns.Add("City ");
                listView1.Columns.Add("Maash ");
                listView1.Columns.Add("Yash ");
                listView1.Columns.Add("Tecrube ");
                listView1.Columns.Add("Tehsil ");
                listView1.Columns.Add("Telephone ");











            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
           
                    listView1.Items.Remove(item);
            using (HrConnect db = new HrConnect())
            {
                var educationName = comboBox1.Text;
                var elans = db.Elans.Where(x => x.Education == educationName).ToList();
               
                foreach (var item in elans)
                {
                    listView1.Items.Add(new ListViewItem(new string[] {item.ElanName,
                    item.ShirketName,item.Workname,item.Description,item.City,
                    item.Salary,item.Age.ToString(), item.Experience,item.Education,item.Telephone}));

                }
            }
        }
    }
}
