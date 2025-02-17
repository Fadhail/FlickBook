using FlickBook.Controllers;
using FlickBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlickBook.Views
{
    public partial class Theater : Form
    {
        Koneksi koneksi = new Koneksi();
        TheaterModel Mtheater = new TheaterModel();
        TheaterController Ctheater = new TheaterController();

        public Theater()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            dataTheater.DataSource = koneksi.ShowData("SELECT * FROM theater");
            dataTheater.Columns[0].HeaderText = "ID Theater";
            dataTheater.Columns[1].HeaderText = "Nama Theater";
            dataTheater.Columns[2].HeaderText = "Kapasitas";
        }

        private void Theater_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        public void Reset()
        {
            tbTheaterID.Text = "";
            tbTheaterName.Text = "";
            tbLokasi.Text = "";
        }   

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (tbTheaterID.Text == "" || tbTheaterName.Text == "" || tbLokasi.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mtheater.Theater_id = tbTheaterID.Text;
                Mtheater.Name = tbTheaterName.Text;
                Mtheater.Location = tbLokasi.Text;
                Ctheater.Insert(Mtheater);
                Reset();
                Tampil();
            }
        }

        private void dataTheater_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbTheaterID.Text = dataTheater.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbTheaterName.Text = dataTheater.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbLokasi.Text = dataTheater.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbTheaterID.Text == "" || tbTheaterName.Text == "" || tbLokasi.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mtheater.Theater_id = tbTheaterID.Text;
                Mtheater.Name = tbTheaterName.Text;
                Mtheater.Location = tbLokasi.Text;
                Ctheater.Update(Mtheater);
                Reset();
                Tampil();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Ctheater.Delete(tbTheaterID.Text);
                Reset();
                Tampil();
            }
        }


    }
}
