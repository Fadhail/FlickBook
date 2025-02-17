namespace FlickBook.Views
{
    partial class Theater
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
            this.theaterLabel = new System.Windows.Forms.Label();
            this.gbTabelTheater = new System.Windows.Forms.GroupBox();
            this.dataTheater = new System.Windows.Forms.DataGridView();
            this.gbFormTheater = new System.Windows.Forms.GroupBox();
            this.Lokasi = new System.Windows.Forms.Label();
            this.NamaTheater = new System.Windows.Forms.Label();
            this.theaterID = new System.Windows.Forms.Label();
            this.tbLokasi = new System.Windows.Forms.TextBox();
            this.tbTheaterName = new System.Windows.Forms.TextBox();
            this.tbTheaterID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.gbTabelTheater.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTheater)).BeginInit();
            this.gbFormTheater.SuspendLayout();
            this.SuspendLayout();
            // 
            // theaterLabel
            // 
            this.theaterLabel.AutoSize = true;
            this.theaterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theaterLabel.Location = new System.Drawing.Point(29, 15);
            this.theaterLabel.Name = "theaterLabel";
            this.theaterLabel.Size = new System.Drawing.Size(93, 25);
            this.theaterLabel.TabIndex = 0;
            this.theaterLabel.Text = "Theater";
            // 
            // gbTabelTheater
            // 
            this.gbTabelTheater.Controls.Add(this.dataTheater);
            this.gbTabelTheater.Location = new System.Drawing.Point(34, 80);
            this.gbTabelTheater.Name = "gbTabelTheater";
            this.gbTabelTheater.Size = new System.Drawing.Size(710, 520);
            this.gbTabelTheater.TabIndex = 1;
            this.gbTabelTheater.TabStop = false;
            this.gbTabelTheater.Text = "Theater Table";
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
            this.gbFormTheater.Controls.Add(this.Lokasi);
            this.gbFormTheater.Controls.Add(this.NamaTheater);
            this.gbFormTheater.Controls.Add(this.theaterID);
            this.gbFormTheater.Controls.Add(this.tbLokasi);
            this.gbFormTheater.Controls.Add(this.tbTheaterName);
            this.gbFormTheater.Controls.Add(this.tbTheaterID);
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
            // Lokasi
            // 
            this.Lokasi.AutoSize = true;
            this.Lokasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lokasi.Location = new System.Drawing.Point(16, 193);
            this.Lokasi.Name = "Lokasi";
            this.Lokasi.Size = new System.Drawing.Size(58, 18);
            this.Lokasi.TabIndex = 8;
            this.Lokasi.Text = "Lokasi";
            // 
            // NamaTheater
            // 
            this.NamaTheater.AutoSize = true;
            this.NamaTheater.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaTheater.Location = new System.Drawing.Point(16, 117);
            this.NamaTheater.Name = "NamaTheater";
            this.NamaTheater.Size = new System.Drawing.Size(114, 18);
            this.NamaTheater.TabIndex = 7;
            this.NamaTheater.Text = "Nama Theater";
            // 
            // theaterID
            // 
            this.theaterID.AutoSize = true;
            this.theaterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theaterID.Location = new System.Drawing.Point(16, 46);
            this.theaterID.Name = "theaterID";
            this.theaterID.Size = new System.Drawing.Size(86, 18);
            this.theaterID.TabIndex = 6;
            this.theaterID.Text = "ID Theater";
            // 
            // tbLokasi
            // 
            this.tbLokasi.Location = new System.Drawing.Point(16, 214);
            this.tbLokasi.Multiline = true;
            this.tbLokasi.Name = "tbLokasi";
            this.tbLokasi.Size = new System.Drawing.Size(259, 30);
            this.tbLokasi.TabIndex = 5;
            // 
            // tbTheaterName
            // 
            this.tbTheaterName.Location = new System.Drawing.Point(16, 138);
            this.tbTheaterName.Multiline = true;
            this.tbTheaterName.Name = "tbTheaterName";
            this.tbTheaterName.Size = new System.Drawing.Size(259, 30);
            this.tbTheaterName.TabIndex = 4;
            // 
            // tbTheaterID
            // 
            this.tbTheaterID.Location = new System.Drawing.Point(16, 66);
            this.tbTheaterID.Multiline = true;
            this.tbTheaterID.Name = "tbTheaterID";
            this.tbTheaterID.Size = new System.Drawing.Size(259, 30);
            this.tbTheaterID.TabIndex = 3;
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
            // Theater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbFormTheater);
            this.Controls.Add(this.gbTabelTheater);
            this.Controls.Add(this.theaterLabel);
            this.Name = "Theater";
            this.Text = "Theater";
            this.Load += new System.EventHandler(this.Theater_Load);
            this.gbTabelTheater.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTheater)).EndInit();
            this.gbFormTheater.ResumeLayout(false);
            this.gbFormTheater.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label theaterLabel;
        private System.Windows.Forms.GroupBox gbTabelTheater;
        private System.Windows.Forms.GroupBox gbFormTheater;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbTheaterID;
        private System.Windows.Forms.Label NamaTheater;
        private System.Windows.Forms.Label theaterID;
        private System.Windows.Forms.TextBox tbLokasi;
        private System.Windows.Forms.TextBox tbTheaterName;
        private System.Windows.Forms.Label Lokasi;
        private System.Windows.Forms.DataGridView dataTheater;
    }
}