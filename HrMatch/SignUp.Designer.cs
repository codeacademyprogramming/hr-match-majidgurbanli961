namespace HrMatch
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.TextBox();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.passwordLabel = new System.Windows.Forms.TextBox();
            this.secondPassword = new System.Windows.Forms.TextBox();
            this.randomLabel = new System.Windows.Forms.Label();
            this.randomTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Shifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tekrar Shifre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Daxil edin";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Location = new System.Drawing.Point(322, 119);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(100, 20);
            this.usernameLabel.TabIndex = 6;
            // 
            // emailLabel
            // 
            this.emailLabel.Location = new System.Drawing.Point(322, 159);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(100, 20);
            this.emailLabel.TabIndex = 7;
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Location = new System.Drawing.Point(322, 191);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(121, 21);
            this.statusBox.TabIndex = 8;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(322, 229);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.PasswordChar = '*';
            this.passwordLabel.Size = new System.Drawing.Size(100, 20);
            this.passwordLabel.TabIndex = 9;
            // 
            // secondPassword
            // 
            this.secondPassword.Location = new System.Drawing.Point(322, 264);
            this.secondPassword.Name = "secondPassword";
            this.secondPassword.PasswordChar = '*';
            this.secondPassword.Size = new System.Drawing.Size(100, 20);
            this.secondPassword.TabIndex = 10;
            // 
            // randomLabel
            // 
            this.randomLabel.AutoSize = true;
            this.randomLabel.Location = new System.Drawing.Point(269, 305);
            this.randomLabel.Name = "randomLabel";
            this.randomLabel.Size = new System.Drawing.Size(35, 13);
            this.randomLabel.TabIndex = 11;
            this.randomLabel.Text = "label7";
            // 
            // randomTextBox
            // 
            this.randomTextBox.Location = new System.Drawing.Point(322, 298);
            this.randomTextBox.Name = "randomTextBox";
            this.randomTextBox.Size = new System.Drawing.Size(100, 20);
            this.randomTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.randomTextBox);
            this.Controls.Add(this.randomLabel);
            this.Controls.Add(this.secondPassword);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox usernameLabel;
        private System.Windows.Forms.TextBox emailLabel;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.TextBox passwordLabel;
        private System.Windows.Forms.TextBox secondPassword;
        private System.Windows.Forms.Label randomLabel;
        private System.Windows.Forms.TextBox randomTextBox;
        private System.Windows.Forms.Button button1;
    }
}