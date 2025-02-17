namespace FlickBook.Views
{
    partial class BookForm
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
            this.backdropPict = new System.Windows.Forms.PictureBox();
            this.cbClock = new System.Windows.Forms.ComboBox();
            this.cbSeat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBooking = new System.Windows.Forms.Button();
            this.tbMovie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backdropPict)).BeginInit();
            this.SuspendLayout();
            // 
            // backdropPict
            // 
            this.backdropPict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backdropPict.Location = new System.Drawing.Point(0, 0);
            this.backdropPict.Name = "backdropPict";
            this.backdropPict.Size = new System.Drawing.Size(800, 450);
            this.backdropPict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backdropPict.TabIndex = 0;
            this.backdropPict.TabStop = false;
            // 
            // cbClock
            // 
            this.cbClock.FormattingEnabled = true;
            this.cbClock.Items.AddRange(new object[] {
            "10.00 - 12.00",
            "13.00 - 15.00",
            "17.00 - 19.00",
            "20.00 - 22.00"});
            this.cbClock.Location = new System.Drawing.Point(259, 291);
            this.cbClock.Name = "cbClock";
            this.cbClock.Size = new System.Drawing.Size(283, 21);
            this.cbClock.TabIndex = 2;
            // 
            // cbSeat
            // 
            this.cbSeat.FormattingEnabled = true;
            this.cbSeat.Location = new System.Drawing.Point(259, 215);
            this.cbSeat.Name = "cbSeat";
            this.cbSeat.Size = new System.Drawing.Size(283, 21);
            this.cbSeat.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seat";
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(467, 350);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(75, 23);
            this.btnBooking.TabIndex = 8;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // tbMovie
            // 
            this.tbMovie.Location = new System.Drawing.Point(259, 139);
            this.tbMovie.Name = "tbMovie";
            this.tbMovie.Size = new System.Drawing.Size(283, 20);
            this.tbMovie.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Movie Name";
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMovie);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSeat);
            this.Controls.Add(this.cbClock);
            this.Controls.Add(this.backdropPict);
            this.Name = "BookForm";
            this.Text = "BookForm";
            ((System.ComponentModel.ISupportInitialize)(this.backdropPict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backdropPict;
        private System.Windows.Forms.ComboBox cbClock;
        private System.Windows.Forms.ComboBox cbSeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.TextBox tbMovie;
        private System.Windows.Forms.Label label3;
    }
}