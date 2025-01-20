namespace FlickBook.Views
{
    partial class MovieDetail
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
            this.moviePict = new System.Windows.Forms.PictureBox();
            this.movieName = new System.Windows.Forms.Label();
            this.releaseLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.Bookingbutton = new System.Windows.Forms.Button();
            this.backdropPict = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.moviePict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backdropPict)).BeginInit();
            this.SuspendLayout();
            // 
            // moviePict
            // 
            this.moviePict.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.moviePict.InitialImage = null;
            this.moviePict.Location = new System.Drawing.Point(60, 59);
            this.moviePict.Margin = new System.Windows.Forms.Padding(4);
            this.moviePict.Name = "moviePict";
            this.moviePict.Size = new System.Drawing.Size(361, 417);
            this.moviePict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moviePict.TabIndex = 0;
            this.moviePict.TabStop = false;
            // 
            // movieName
            // 
            this.movieName.AutoSize = true;
            this.movieName.BackColor = System.Drawing.Color.Transparent;
            this.movieName.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieName.ForeColor = System.Drawing.Color.Black;
            this.movieName.Location = new System.Drawing.Point(496, 75);
            this.movieName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.movieName.MaximumSize = new System.Drawing.Size(600, 0);
            this.movieName.Name = "movieName";
            this.movieName.Size = new System.Drawing.Size(98, 45);
            this.movieName.TabIndex = 1;
            this.movieName.Text = "Tittle";
            // 
            // releaseLabel
            // 
            this.releaseLabel.AutoSize = true;
            this.releaseLabel.BackColor = System.Drawing.Color.Transparent;
            this.releaseLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.releaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseLabel.Location = new System.Drawing.Point(504, 128);
            this.releaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.releaseLabel.MaximumSize = new System.Drawing.Size(600, 0);
            this.releaseLabel.Name = "releaseLabel";
            this.releaseLabel.Size = new System.Drawing.Size(123, 27);
            this.releaseLabel.TabIndex = 2;
            this.releaseLabel.Text = "Released : ";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.descriptionLabel.Location = new System.Drawing.Point(506, 216);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.MaximumSize = new System.Drawing.Size(500, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(77, 18);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.BackColor = System.Drawing.Color.Transparent;
            this.ratingLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.Location = new System.Drawing.Point(505, 163);
            this.ratingLabel.MaximumSize = new System.Drawing.Size(600, 0);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(58, 22);
            this.ratingLabel.TabIndex = 4;
            this.ratingLabel.Text = "Rating";
            // 
            // Bookingbutton
            // 
            this.Bookingbutton.Location = new System.Drawing.Point(791, 401);
            this.Bookingbutton.Name = "Bookingbutton";
            this.Bookingbutton.Size = new System.Drawing.Size(147, 60);
            this.Bookingbutton.TabIndex = 5;
            this.Bookingbutton.Text = "Booking";
            this.Bookingbutton.UseVisualStyleBackColor = true;
            // 
            // backdropPict
            // 
            this.backdropPict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backdropPict.Location = new System.Drawing.Point(0, 0);
            this.backdropPict.Name = "backdropPict";
            this.backdropPict.Size = new System.Drawing.Size(1046, 838);
            this.backdropPict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backdropPict.TabIndex = 6;
            this.backdropPict.TabStop = false;
            // 
            // MovieDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 838);
            this.Controls.Add(this.Bookingbutton);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.releaseLabel);
            this.Controls.Add(this.movieName);
            this.Controls.Add(this.moviePict);
            this.Controls.Add(this.backdropPict);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MovieDetail";
            this.Text = "MovieDetail";
            ((System.ComponentModel.ISupportInitialize)(this.moviePict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backdropPict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox moviePict;
        private System.Windows.Forms.Label movieName;
        private System.Windows.Forms.Label releaseLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Button Bookingbutton;
        private System.Windows.Forms.PictureBox backdropPict;
    }
}