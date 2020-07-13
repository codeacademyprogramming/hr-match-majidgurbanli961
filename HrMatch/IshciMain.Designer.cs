namespace HrMatch
{
    partial class IshciMain
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
            this.cvAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cvAdd
            // 
            this.cvAdd.Location = new System.Drawing.Point(119, 85);
            this.cvAdd.Name = "cvAdd";
            this.cvAdd.Size = new System.Drawing.Size(125, 23);
            this.cvAdd.TabIndex = 0;
            this.cvAdd.Text = "Cv Yerleshdir";
            this.cvAdd.UseVisualStyleBackColor = true;
            this.cvAdd.Click += new System.EventHandler(this.cvAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ish Axtar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IshciMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cvAdd);
            this.Name = "IshciMain";
            this.Text = "IshciMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cvAdd;
        private System.Windows.Forms.Button button1;
    }
}