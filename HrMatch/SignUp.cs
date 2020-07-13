using HrMatch.DB;
using HrMatch.DB.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrMatch
{
    public partial class SignUp : Form
    {
        
        public SignUp()
        {
            InitializeComponent();
           
        }
       

        private void SignUp_Load(object sender, EventArgs e)
        {
            
            

                
            
            Random rnd = new Random();
            int randomInt = rnd.Next(1000, 5000);
            randomLabel.Text = randomInt.ToString();
            statusBox.Items.Add("1.Ishci");
            statusBox.Items.Add("2.Ishveren");

        }


        private void button1_Click(object sender, EventArgs e)
        {
            HrConnect db = new HrConnect();
            var username = usernameLabel.Text;
            var email = emailLabel.Text;
            var passwordFirst = passwordLabel.Text;
            var passwordSecond = secondPassword.Text;
            string random = randomTextBox.Text;
            int whichUser = Convert.ToInt32(statusBox.Text.Substring(0, 1));


            if (emailChecker(email)&& passwordChecker(passwordFirst)&&identicPasswordChecker(passwordFirst,passwordSecond)&&randomChecker(random)&&username.Length>=4 )
            {
                var users = db.Users.ToList();
                if (users.Exists(x => x.Username == username))
                {
                    MessageBox.Show("Bele Username artig var");
                }else if (users.Exists(x => x.Email == email))
                {
                    MessageBox.Show("Bele email var");
                }
                else
                {
                    
                    db.Users.Add(new User()
                    {
                        Username = username,
                        Email = email,
                        Password = passwordFirst,
                        WhichUser =whichUser
                    });
                    db.SaveChanges();
                   
                    var secondusers = db.Users.ToList();
                    Helper.userId = secondusers[secondusers.Count - 1].Id;
                    MessageBox.Show(Helper.userId.ToString());
                    db.Dispose();

                    usernameLabel.Text = "";
                    emailLabel.Text = "";
                    passwordLabel.Text = "";
                    secondPassword.Text = "";
                    randomLabel.Text = "";
                    if (whichUser == 1)
                    {
                        var ishciMain = new IshciMain();
                        ishciMain.Show();
                        this.Hide();
                    }
                    else
                    {
                        var ishverenMain = new IshverenMain();
                        ishverenMain.Show();
                        this.Hide();

                    }



                }
                

            }
            else
            {
                MessageBox.Show("Melumatlar yanlishdir");
            }
            

           
        }
        private bool emailChecker(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
              
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Email yanlishdir");
                return false;
            }

        }
        private bool passwordChecker (string password)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(password);
            int counterNumber = 0;
            int counterString = 0;
            for (int i = 0; i < asciiBytes.Length; i++)
            {
                if(asciiBytes[i]>=65 && asciiBytes[i] <= 90)
                {
                    counterString++;

                }
                else if(asciiBytes[i]>=33 && asciiBytes[i]<=57)
                {
                    counterNumber++;

                }
                

            }
               if(counterString>=1 && counterNumber >= 2)
            {
               
                return true;
            }
            else
            {
                MessageBox.Show("Parolda 1 boyuk 1 reqem ve 1 simvol olmalidir");

            }
            return false;
        }
     
        private bool randomChecker(string random)
        {
            if (random == randomLabel.Text)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Random ededi duzgun daxil edin");
            }
            return false;
        }
        private bool identicPasswordChecker(string passwordFirst, string passwordSecond)
        {
            if(passwordFirst== passwordSecond)
            {
                return true;
            }
            return false;
        }
    }
}
