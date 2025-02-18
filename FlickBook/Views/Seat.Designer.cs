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
            this.cbTheater = new System.Windows.Forms.ComboBox();
            this.Theater = new System.Windows.Forms.Label();
            this.NoKursi = new System.Windows.Forms.Label();
            this.seatID = new System.Windows.Forms.Label();
            this.tbSeatNo = new System.Windows.Forms.TextBox();
            this.tbSeatID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
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
            this.dataTheater.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTheater_CellClick);
            // 
            // gbFormTheater
            // 
            this.gbFormTheater.Controls.Add(this.cbTheater);
            this.gbFormTheater.Controls.Add(this.Theater);
            this.gbFormTheater.Controls.Add(this.NoKursi);
            this.gbFormTheater.Controls.Add(this.seatID);
            this.gbFormTheater.Controls.Add(this.tbSeatNo);
            this.gbFormTheater.Controls.Add(this.tbSeatID);
            this.gbFormTheater.Controls.Add(this.btnUpdate);
            this.gbFormTheater.Controls.Add(this.btnInsert);
            this.gbFormTheater.Controls.Add(this.btnDelete);
            this.gbFormTheater.Location = new System.Drawing.Point(750, 80);
            this.gbFormTheater.Name = "gbFormTheater";
            this.gbFormTheater.Size = new System.Drawing.Size(302, 466);
            this.gbFormTheater.TabIndex = 2;
            this.gbFormTheater.TabStop = false;
            this.gbFormTheater.Text = "Form";
            // 
            // cbTheater
            // 
            this.cbTheater.FormattingEnabled = true;
            this.cbTheater.Location = new System.Drawing.Point(19, 214);
            this.cbTheater.Name = "cbTheater";
            this.cbTheater.Size = new System.Drawing.Size(256, 21);
            this.cbTheater.TabIndex = 9;
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
            // tbSeatNo
            // 
            this.tbSeatNo.Location = new System.Drawing.Point(16, 138);
            this.tbSeatNo.Multiline = true;
            this.tbSeatNo.Name = "tbSeatNo";
            this.tbSeatNo.Size = new System.Drawing.Size(259, 30);
            this.tbSeatNo.TabIndex = 4;
            // 
            // tbSeatID
            // 
            this.tbSeatID.Location = new System.Drawing.Point(16, 66);
            this.tbSeatID.Multiline = true;
            this.tbSeatID.Name = "tbSeatID";
            this.tbSeatID.Size = new System.Drawing.Size(259, 30);
            this.tbSeatID.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(19, 379);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(264, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(16, 336);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(267, 23);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(19, 423);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(264, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(34, 49);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(370, 25);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
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
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Seat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
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
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbSeatID;
        private System.Windows.Forms.Label NoKursi;
        private System.Windows.Forms.Label seatID;
        private System.Windows.Forms.TextBox tbSeatNo;
        private System.Windows.Forms.Label Theater;
        private System.Windows.Forms.DataGridView dataTheater;
        private System.Windows.Forms.ComboBox cbTheater;
    }
}