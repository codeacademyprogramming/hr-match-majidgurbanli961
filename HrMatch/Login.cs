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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }
    }
}
