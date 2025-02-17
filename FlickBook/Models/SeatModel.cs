using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickBook.Models
{
    internal class SeatModel
    {
        string seat_id, seat_no, created_at, theater_id, theater_name;

        public SeatModel()
        {

        }
        public SeatModel(string seat_id, string seat_no, string created_at, string theater_id, string theater_name)
        {
            this.Seat_id = seat_id;
            this.Theater_id = theater_id;
            this.Seat_no = seat_no;
        }

        public string Seat_id { get => seat_id; set => seat_id = value; }
        public string Theater_id { get => theater_id; set => theater_id = value; }
        public string Seat_no { get => seat_no; set => seat_no = value; }
    }
}
