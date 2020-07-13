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
    public partial class IshciMain : Form
    {
        public IshciMain()
        {
            InitializeComponent();
        }

        private void cvAdd_Click(object sender, EventArgs e)
        {
            var cvAdd = new AddCv();
            cvAdd.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var uygunIsh = new EnUygunIsh();
            uygunIsh.Show();
            this.Hide();
        }
    }
}
