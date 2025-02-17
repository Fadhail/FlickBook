using FlickBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlickBook.Controllers
{
    internal class TicketController
    {
        Koneksi koneksi = new Koneksi();
        public bool status;

        public bool Insert(TicketModel ticket)
        {
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO ticket (ticket_id, seat_id, tittle, clock) VALUES('" + ticket.Ticket_id + "', '" + ticket.Seat_id + "','" + ticket.Tittle + "','" + ticket.Clock + "')");
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
    }
}
