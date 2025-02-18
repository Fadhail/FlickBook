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
    public partial class Parent : Form
    {
        private Movie moviePage;
        private Riwayat riwayatTransaksi;
        public Parent()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.SizeChanged += new EventHandler(Main_SizeChanged);
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            moviePage.WindowState = FormWindowState.Maximized;
        }
        private void movieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.MdiParent = this;
            movie.WindowState = FormWindowState.Maximized;
            movie.Show();
        }

        private void theaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Theater theater = new Theater();
            theater.MdiParent = this;
            theater.WindowState = FormWindowState.Maximized;
            theater.Show();
        }

        private void seatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Seat seat = new Seat();
            seat.MdiParent = this;
            seat.WindowState = FormWindowState.Maximized;
            seat.Show();
        }

        private void riwayatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Riwayat riwayat = new Riwayat();
            riwayat.MdiParent = this;
            riwayat.WindowState = FormWindowState.Maximized;
            riwayat.Show();
        }

        private void myTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyTicket ticket = new MyTicket();
            ticket.MdiParent = this;
            ticket.WindowState = FormWindowState.Maximized;
            ticket.Show();
        }
    }
}
