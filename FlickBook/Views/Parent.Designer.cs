namespace FlickBook.Views
{
    partial class Parent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.movieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theaterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.riwayatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieToolStripMenuItem,
            this.TicketToolStripMenuItem,
            this.seatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // movieToolStripMenuItem
            // 
            this.movieToolStripMenuItem.Name = "movieToolStripMenuItem";
            this.movieToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.movieToolStripMenuItem.Text = "Movie";
            this.movieToolStripMenuItem.Click += new System.EventHandler(this.movieToolStripMenuItem_Click);
            // 
            // TicketToolStripMenuItem
            // 
            this.TicketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theaterToolStripMenuItem,
            this.seatToolStripMenuItem1,
            this.riwayatToolStripMenuItem});
            this.TicketToolStripMenuItem.Name = "TicketToolStripMenuItem";
            this.TicketToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.TicketToolStripMenuItem.Text = "Admin View";
            // 
            // theaterToolStripMenuItem
            // 
            this.theaterToolStripMenuItem.Name = "theaterToolStripMenuItem";
            this.theaterToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.theaterToolStripMenuItem.Text = "Theater";
            this.theaterToolStripMenuItem.Click += new System.EventHandler(this.theaterToolStripMenuItem_Click);
            // 
            // seatToolStripMenuItem1
            // 
            this.seatToolStripMenuItem1.Name = "seatToolStripMenuItem1";
            this.seatToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.seatToolStripMenuItem1.Text = "Seat";
            this.seatToolStripMenuItem1.Click += new System.EventHandler(this.seatToolStripMenuItem1_Click);
            // 
            // riwayatToolStripMenuItem
            // 
            this.riwayatToolStripMenuItem.Name = "riwayatToolStripMenuItem";
            this.riwayatToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.riwayatToolStripMenuItem.Text = "Riwayat";
            this.riwayatToolStripMenuItem.Click += new System.EventHandler(this.riwayatToolStripMenuItem_Click);
            // 
            // seatToolStripMenuItem
            // 
            this.seatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myTicketToolStripMenuItem});
            this.seatToolStripMenuItem.Name = "seatToolStripMenuItem";
            this.seatToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.seatToolStripMenuItem.Text = "User";
            // 
            // myTicketToolStripMenuItem
            // 
            this.myTicketToolStripMenuItem.Name = "myTicketToolStripMenuItem";
            this.myTicketToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.myTicketToolStripMenuItem.Text = "My Ticket";
            this.myTicketToolStripMenuItem.Click += new System.EventHandler(this.myTicketToolStripMenuItem_Click);
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 711);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Parent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parent";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem movieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theaterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem riwayatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myTicketToolStripMenuItem;
    }
}