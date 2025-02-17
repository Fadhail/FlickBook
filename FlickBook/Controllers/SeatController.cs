using FlickBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                string query = "INSERT INTO seat (seat_no, created_at, theater_id, theater_name) VALUES ('" + seat.Seat_no + "', '" + seat.Created_at + "', '" + seat.Theater_id + "', '" + seat.Theater_name + "')";
                koneksi.ExecuteQueries(query);
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            finally
            {
                koneksi.CloseConnection();
            }
            return status;
        }
    }
}
