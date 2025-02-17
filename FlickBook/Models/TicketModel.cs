using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickBook.Models
{
    internal class TicketModel
    {
        string ticket_id, seat_id, tittle, clock;

        public TicketModel()
        {
        }

        public TicketModel(string ticket_id, string seat_id, string tittle, string clock)
        {
            this.Ticket_id = ticket_id;
            this.Seat_id = seat_id;
            this.Tittle = tittle;
            this.Clock = clock;
        }

        public string Ticket_id { get => ticket_id; set => ticket_id = value; }
        public string Seat_id { get => seat_id; set => seat_id = value; }
        public string Tittle { get => tittle; set => tittle = value; }
        public string Clock { get => clock; set => clock = value; }
    }
}
