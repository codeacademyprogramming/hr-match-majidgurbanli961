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
    public partial class IshverenMain : Form
    {
        public IshverenMain()
        {
            InitializeComponent();
        }

        private void elanYerlesdir_Click(object sender, EventArgs e)
        {
            var addElan = new AddElan();
            addElan.Show();
            this.Hide();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
