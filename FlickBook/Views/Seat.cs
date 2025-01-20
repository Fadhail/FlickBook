using FlickBook.Controllers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlickBook.Views
{
    public partial class Seat : Form
    {
        Koneksi koneksi = new Koneksi();

        public void Tampil()
        {
            dataTheater.DataSource = koneksi.ShowData("SELECT seat.seat_id, seat.seat_no, theater.theater_id, theater.theater_name FROM seat JOIN theater ON theater.theater_id = seat.theater_id");
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
    }
}
