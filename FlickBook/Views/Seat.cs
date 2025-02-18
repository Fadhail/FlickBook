using FlickBook.Controllers;
using FlickBook.lib;
using FlickBook.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlickBook.Views
{
    public partial class Seat : Form
    {
        Koneksi koneksi = new Koneksi();
        SeatModel Mseat = new SeatModel();
        SeatController Cseat = new SeatController();

        public void Tampil()
        {
            dataTheater.DataSource = koneksi.ShowData("SELECT seat_id, seat_no, theater.theater_id, theater.theater_name FROM seat JOIN theater ON theater.theater_id = seat.theater_id");
            dataTheater.Columns[0].HeaderText = "ID Seat";
            dataTheater.Columns[1].HeaderText = "Nomor Seat";
            dataTheater.Columns[2].HeaderText = "ID Theater";
            dataTheater.Columns[3].HeaderText = "Nama Theater";
        }
        public Seat()
        {
            InitializeComponent();
        }

        private void Seat_Load(object sender, EventArgs e)
        {
            Tampil();
            GetDataTheater();
        }

        public void GetDataTheater()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM theater");
            while (reader.Read())
            {
                int theater_id = reader.GetInt32("theater_id");
                cbTheater.Items.Add(theater_id);
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void Reset()
        {
            tbSeatID.Text = "";
            tbSeatNo.Text = "";
            cbTheater.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (tbSeatID.Text == "" || tbSeatNo.Text == "" || cbTheater.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mseat.Seat_id = tbSeatID.Text;
                Mseat.Seat_no = tbSeatNo.Text;
                Mseat.Theater_id = cbTheater.Text;
                Cseat.Insert(Mseat);
                Reset();
                Tampil();
            }
        }

        private void dataTheater_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbSeatID.Text = dataTheater.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbSeatNo.Text = dataTheater.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbTheater.Text = dataTheater.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbSeatID.Text == "" || tbSeatNo.Text == "" || cbTheater.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mseat.Seat_id = tbSeatID.Text;
                Mseat.Seat_no = tbSeatNo.Text;
                Mseat.Theater_id = cbTheater.Text;
                Cseat.Update(Mseat);
                Reset();
                Tampil();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Cseat.Delete(tbSeatID.Text);
                Reset();
                Tampil();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            dataTheater.DataSource = koneksi.ShowData("SELECT seat_id, seat_no, theater.theater_id, theater.theater_name FROM seat JOIN theater ON theater.theater_id = seat.theater_id WHERE seat_id LIKE '%" + tbSearch.Text + "%' OR seat_no LIKE '%" + tbSearch.Text + "%' OR theater.theater_id LIKE '%" + tbSearch.Text + "%' OR theater.theater_name LIKE '%" + tbSearch.Text + "%'");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Documents (*.xlsx) | *.xlsx";
            save.FileName = "Report Seat.xlsx";

            if (save.ShowDialog() == DialogResult.OK)
            {
                string directory = Path.GetDirectoryName(save.FileName);
                string fileNameWithoutExt = Path.GetFileNameWithoutExtension(save.FileName);
                string extension = Path.GetExtension(save.FileName);
                int count = 1;
                string filePath = save.FileName;

                while (File.Exists(filePath))
                {
                    filePath = Path.Combine(directory, $"{fileNameWithoutExt} ({count}){extension}");
                    count++;
                }

                Excel excel_lib = new Excel();
                excel_lib.ExportToExcel(dataTheater, filePath);

                MessageBox.Show("Data berhasil di export ke excel", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
