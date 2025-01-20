namespace FlickBook.Views
{
    partial class Profile
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
            this.ProfilLlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProfilLlabel
            // 
            this.ProfilLlabel.AutoSize = true;
            this.ProfilLlabel.Location = new System.Drawing.Point(52, 36);
            this.ProfilLlabel.Name = "ProfilLlabel";
            this.ProfilLlabel.Size = new System.Drawing.Size(36, 13);
            this.ProfilLlabel.TabIndex = 0;
            this.ProfilLlabel.Text = "Profile";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProfilLlabel);
            this.Name = "Profile";
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProfilLlabel;
    }
}