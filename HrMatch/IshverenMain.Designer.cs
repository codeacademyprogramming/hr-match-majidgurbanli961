namespace HrMatch
{
    partial class IshverenMain
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
            this.elanYerlesdir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // elanYerlesdir
            // 
            this.elanYerlesdir.Location = new System.Drawing.Point(25, 111);
            this.elanYerlesdir.Name = "elanYerlesdir";
            this.elanYerlesdir.Size = new System.Drawing.Size(151, 23);
            this.elanYerlesdir.TabIndex = 0;
            this.elanYerlesdir.Text = "Elan Yerleshdir";
            this.elanYerlesdir.UseVisualStyleBackColor = true;
            this.elanYerlesdir.Click += new System.EventHandler(this.elanYerlesdir_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(461, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cixish";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IshverenMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.elanYerlesdir);
            this.Name = "IshverenMain";
            this.Text = "IshverenMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button elanYerlesdir;
        private System.Windows.Forms.Button button2;
    }
}