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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var username = userName.Text;
            var passwordBox = password.Text;
           
            using(HrConnect db = new HrConnect())
            {
                var result = db.Users.Count(x => x.Username == username && x.Password == passwordBox);

                if (result == 1)
                {
                    var myUser = db.Users.FirstOrDefault(x => x.Username == username && x.Password == passwordBox);
                    Helper.userId = myUser.Id;
                    MessageBox.Show(myUser.Id.ToString());
                    if (myUser.WhichUser == 1)
                    {
                        var cvLook = new seeCv(myUser.Id);
                        cvLook.Show();
                        this.Hide();
                    }else if (myUser.WhichUser == 2)
                    {
                        var allelans = new SeeAllElansIshveren();
                        allelans.Show();
                        this.Hide();

                    }
                    
                }
                
            }
        }
    }
}
