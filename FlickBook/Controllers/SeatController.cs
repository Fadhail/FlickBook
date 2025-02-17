using FlickBook.Models;
using FlickBook.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlickBook.Controllers
{
    internal class SeatController
    {
        Koneksi koneksi = new Koneksi();
        public bool status;

        public bool Insert(SeatModel seat)
        {
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO seat (seat_id, theater_id, seat_no) VALUES('" + seat.Seat_id + "', '" + seat.Theater_id + "','" + seat.Seat_no + "')");
                status = true;
                MessageBox.Show("Insert Data Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Insert Data Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status = false;
            }
            return status;
        }

        public bool Update(SeatModel seat)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE seat SET seat_no = '" + seat.Seat_no + "', location = '" + seat.Theater_id + "' WHERE theater_id = '" + seat.Seat_id + "'");
                status = true;
                MessageBox.Show("Update Data Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Update Data Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Delete(string Seat_id)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM seat WHERE seat_id = '" + Seat_id + "'");
                MessageBox.Show("Delete Data Success");
                koneksi.CloseConnection();
                status = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Failed Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
