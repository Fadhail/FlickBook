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
            this.gbFormTheater = new System.Windows.Forms.GroupBox();
            this.Lokasi = new System.Windows.Forms.Label();
            this.NamaTheater = new System.Windows.Forms.Label();
            this.theaterID = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dataTheater = new System.Windows.Forms.DataGridView();
            this.gbTabelTheater.SuspendLayout();
            this.gbFormTheater.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTheater)).BeginInit();
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
            // gbFormTheater
            // 
            this.gbFormTheater.Controls.Add(this.Lokasi);
            this.gbFormTheater.Controls.Add(this.NamaTheater);
            this.gbFormTheater.Controls.Add(this.theaterID);
            this.gbFormTheater.Controls.Add(this.textBox4);
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(16, 214);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(259, 30);
            this.textBox4.TabIndex = 5;
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
            this.gbFormTheater.ResumeLayout(false);
            this.gbFormTheater.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTheater)).EndInit();
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label NamaTheater;
        private System.Windows.Forms.Label theaterID;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Lokasi;
        private System.Windows.Forms.DataGridView dataTheater;
    }
}