namespace FlickBook.Views
{
    partial class MyTicket
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
            this.gbTicket = new System.Windows.Forms.GroupBox();
            this.gbExport = new System.Windows.Forms.GroupBox();
            this.dataTicket = new System.Windows.Forms.DataGridView();
            this.TicketPanel = new System.Windows.Forms.Panel();
            this.labelReceipt = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelClock = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTittle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSeat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTheater = new System.Windows.Forms.Label();
            this.labelFlickbook = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTicket.SuspendLayout();
            this.gbExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTicket)).BeginInit();
            this.TicketPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTicket
            // 
            this.gbTicket.Controls.Add(this.dataTicket);
            this.gbTicket.Location = new System.Drawing.Point(12, 12);
            this.gbTicket.Name = "gbTicket";
            this.gbTicket.Size = new System.Drawing.Size(736, 629);
            this.gbTicket.TabIndex = 0;
            this.gbTicket.TabStop = false;
            this.gbTicket.Text = "My Ticket";
            // 
            // gbExport
            // 
            this.gbExport.Controls.Add(this.btnPrint);
            this.gbExport.Controls.Add(this.TicketPanel);
            this.gbExport.Location = new System.Drawing.Point(748, 12);
            this.gbExport.Name = "gbExport";
            this.gbExport.Size = new System.Drawing.Size(304, 629);
            this.gbExport.TabIndex = 1;
            this.gbExport.TabStop = false;
            this.gbExport.Text = "Export Ticket";
            // 
            // dataTicket
            // 
            this.dataTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTicket.Location = new System.Drawing.Point(6, 19);
            this.dataTicket.Name = "dataTicket";
            this.dataTicket.Size = new System.Drawing.Size(724, 593);
            this.dataTicket.TabIndex = 0;
            this.dataTicket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTicket_CellClick);
            // 
            // TicketPanel
            // 
            this.TicketPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TicketPanel.Controls.Add(this.label1);
            this.TicketPanel.Controls.Add(this.labelFlickbook);
            this.TicketPanel.Controls.Add(this.labelTheater);
            this.TicketPanel.Controls.Add(this.label8);
            this.TicketPanel.Controls.Add(this.labelSeat);
            this.TicketPanel.Controls.Add(this.label6);
            this.TicketPanel.Controls.Add(this.labelTittle);
            this.TicketPanel.Controls.Add(this.label4);
            this.TicketPanel.Controls.Add(this.labelClock);
            this.TicketPanel.Controls.Add(this.labelDate);
            this.TicketPanel.Controls.Add(this.labelReceipt);
            this.TicketPanel.Location = new System.Drawing.Point(17, 19);
            this.TicketPanel.Name = "TicketPanel";
            this.TicketPanel.Size = new System.Drawing.Size(281, 300);
            this.TicketPanel.TabIndex = 0;
            // 
            // labelReceipt
            // 
            this.labelReceipt.AutoSize = true;
            this.labelReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReceipt.Location = new System.Drawing.Point(16, 15);
            this.labelReceipt.Name = "labelReceipt";
            this.labelReceipt.Size = new System.Drawing.Size(133, 31);
            this.labelReceipt.TabIndex = 0;
            this.labelReceipt.Text = "RECEIPT";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(33, 110);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date";
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.Location = new System.Drawing.Point(121, 108);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(0, 13);
            this.labelClock.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Movie";
            // 
            // labelTittle
            // 
            this.labelTittle.AutoSize = true;
            this.labelTittle.Location = new System.Drawing.Point(121, 150);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(0, 13);
            this.labelTittle.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Seat No";
            // 
            // labelSeat
            // 
            this.labelSeat.AutoSize = true;
            this.labelSeat.Location = new System.Drawing.Point(121, 190);
            this.labelSeat.Name = "labelSeat";
            this.labelSeat.Size = new System.Drawing.Size(0, 13);
            this.labelSeat.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Theater";
            // 
            // labelTheater
            // 
            this.labelTheater.AutoSize = true;
            this.labelTheater.Location = new System.Drawing.Point(121, 230);
            this.labelTheater.Name = "labelTheater";
            this.labelTheater.Size = new System.Drawing.Size(0, 13);
            this.labelTheater.TabIndex = 8;
            // 
            // labelFlickbook
            // 
            this.labelFlickbook.AutoSize = true;
            this.labelFlickbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFlickbook.Location = new System.Drawing.Point(17, 57);
            this.labelFlickbook.Name = "labelFlickbook";
            this.labelFlickbook.Size = new System.Drawing.Size(104, 25);
            this.labelFlickbook.TabIndex = 9;
            this.labelFlickbook.Text = "Flickbook";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(17, 352);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(281, 76);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print Ticket";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "-------";
            // 
            // MyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.gbExport);
            this.Controls.Add(this.gbTicket);
            this.Name = "MyTicket";
            this.Text = "MyTicket";
            this.Load += new System.EventHandler(this.MyTicket_Load);
            this.gbTicket.ResumeLayout(false);
            this.gbExport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTicket)).EndInit();
            this.TicketPanel.ResumeLayout(false);
            this.TicketPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTicket;
        private System.Windows.Forms.GroupBox gbExport;
        private System.Windows.Forms.DataGridView dataTicket;
        private System.Windows.Forms.Panel TicketPanel;
        private System.Windows.Forms.Label labelSeat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelReceipt;
        private System.Windows.Forms.Label labelTheater;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelFlickbook;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label1;
    }
}