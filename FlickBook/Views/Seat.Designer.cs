namespace FlickBook.Views
{
    partial class Seat
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
            this.seatLabel = new System.Windows.Forms.Label();
            this.gbTabelSeat = new System.Windows.Forms.GroupBox();
            this.dataTheater = new System.Windows.Forms.DataGridView();
            this.gbFormTheater = new System.Windows.Forms.GroupBox();
            this.Theater = new System.Windows.Forms.Label();
            this.NoKursi = new System.Windows.Forms.Label();
            this.seatID = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.cbTheater = new System.Windows.Forms.ComboBox();
            this.gbTabelSeat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTheater)).BeginInit();
            this.gbFormTheater.SuspendLayout();
            this.SuspendLayout();
            // 
            // seatLabel
            // 
            this.seatLabel.AutoSize = true;
            this.seatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatLabel.Location = new System.Drawing.Point(29, 15);
            this.seatLabel.Name = "seatLabel";
            this.seatLabel.Size = new System.Drawing.Size(72, 25);
            this.seatLabel.TabIndex = 0;
            this.seatLabel.Text = "Seats";
            // 
            // gbTabelSeat
            // 
            this.gbTabelSeat.Controls.Add(this.dataTheater);
            this.gbTabelSeat.Location = new System.Drawing.Point(34, 80);
            this.gbTabelSeat.Name = "gbTabelSeat";
            this.gbTabelSeat.Size = new System.Drawing.Size(710, 520);
            this.gbTabelSeat.TabIndex = 1;
            this.gbTabelSeat.TabStop = false;
            this.gbTabelSeat.Text = "Seat Table";
            // 
            // dataTheater
            // 
            this.dataTheater.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTheater.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTheater.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTheater.Location = new System.Drawing.Point(3, 16);
            this.dataTheater.Name = "dataTheater";
            this.dataTheater.Size = new System.Drawing.Size(704, 501);
            this.dataTheater.TabIndex = 0;
            // 
            // gbFormTheater
            // 
            this.gbFormTheater.Controls.Add(this.cbTheater);
            this.gbFormTheater.Controls.Add(this.Theater);
            this.gbFormTheater.Controls.Add(this.NoKursi);
            this.gbFormTheater.Controls.Add(this.seatID);
            this.gbFormTheater.Controls.Add(this.textBox3);
            this.gbFormTheater.Controls.Add(this.textBox2);
            this.gbFormTheater.Controls.Add(this.button3);
            this.gbFormTheater.Controls.Add(this.button2);
            this.gbFormTheater.Controls.Add(this.button1);
            this.gbFormTheater.Location = new System.Drawing.Point(750, 80);
            this.gbFormTheater.Name = "gbFormTheater";
            this.gbFormTheater.Size = new System.Drawing.Size(302, 466);
            this.gbFormTheater.TabIndex = 2;
            this.gbFormTheater.TabStop = false;
            this.gbFormTheater.Text = "Form";
            // 
            // Theater
            // 
            this.Theater.AutoSize = true;
            this.Theater.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Theater.Location = new System.Drawing.Point(16, 193);
            this.Theater.Name = "Theater";
            this.Theater.Size = new System.Drawing.Size(65, 18);
            this.Theater.TabIndex = 8;
            this.Theater.Text = "Theater";
            // 
            // NoKursi
            // 
            this.NoKursi.AutoSize = true;
            this.NoKursi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoKursi.Location = new System.Drawing.Point(16, 117);
            this.NoKursi.Name = "NoKursi";
            this.NoKursi.Size = new System.Drawing.Size(104, 18);
            this.NoKursi.TabIndex = 7;
            this.NoKursi.Text = "Nomor Kursi";
            // 
            // seatID
            // 
            this.seatID.AutoSize = true;
            this.seatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatID.Location = new System.Drawing.Point(16, 46);
            this.seatID.Name = "seatID";
            this.seatID.Size = new System.Drawing.Size(63, 18);
            this.seatID.TabIndex = 6;
            this.seatID.Text = "ID Seat";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 138);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(259, 30);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 66);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(259, 30);
            this.textBox2.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(264, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 25);
            this.textBox1.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(410, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(754, 552);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(298, 48);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // cbTheater
            // 
            this.cbTheater.FormattingEnabled = true;
            this.cbTheater.Location = new System.Drawing.Point(19, 214);
            this.cbTheater.Name = "cbTheater";
            this.cbTheater.Size = new System.Drawing.Size(256, 21);
            this.cbTheater.TabIndex = 9;
            // 
            // Seat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbFormTheater);
            this.Controls.Add(this.gbTabelSeat);
            this.Controls.Add(this.seatLabel);
            this.Name = "Seat";
            this.Text = "Theater";
            this.Load += new System.EventHandler(this.Seat_Load);
            this.gbTabelSeat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTheater)).EndInit();
            this.gbFormTheater.ResumeLayout(false);
            this.gbFormTheater.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label seatLabel;
        private System.Windows.Forms.GroupBox gbTabelSeat;
        private System.Windows.Forms.GroupBox gbFormTheater;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label NoKursi;
        private System.Windows.Forms.Label seatID;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Theater;
        private System.Windows.Forms.DataGridView dataTheater;
        private System.Windows.Forms.ComboBox cbTheater;
    }
}