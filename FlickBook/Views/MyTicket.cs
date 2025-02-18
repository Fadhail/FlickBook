using FlickBook.Controllers;
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
    public partial class MyTicket : Form
    {
        Koneksi koneksi = new Koneksi();

        public MyTicket()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            dataTicket.DataSource = koneksi.ShowData("SELECT ticket_id, tittle, seat.seat_no, theater.theater_name, clock FROM ticket JOIN seat ON seat.seat_id = ticket.seat_id JOIN theater ON theater.theater_id = seat.theater_id");
            dataTicket.Columns[0].HeaderText = "ID Ticket";
            dataTicket.Columns[1].HeaderText = "Movie Name";
            dataTicket.Columns[2].HeaderText = "Seat No";
            dataTicket.Columns[3].HeaderText = "Theater Name";
            dataTicket.Columns[4].HeaderText = "Start";
        }

        private void MyTicket_Load(object sender, EventArgs e)
        {
            Tampil();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Ukuran kertas (8cm x 6cm dalam piksel untuk 300 dpi)
            int paperWidth = 945;
            int paperHeight = 709;

            // Font dan brush
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font subTitleFont = new Font("Arial", 14, FontStyle.Bold);
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;
            Brush backgroundBrush = new SolidBrush(Color.LightYellow);
            Pen borderPen = new Pen(Color.Black, 1);

            // Posisi awal margin
            int margin = 10;
            int startX = margin;
            int startY = margin;
            int width = paperWidth - (2 * margin);
            int height = paperHeight - (2 * margin);

            // Latar belakang
            e.Graphics.FillRectangle(backgroundBrush, startX, startY, width, height);

            // Garis border
            e.Graphics.DrawRectangle(borderPen, startX, startY, width, height);

            // Cetak Judul
            int textY = startY + 10;
            e.Graphics.DrawString("RECEIPT", titleFont, brush, startX + 10, textY);
            textY += 30;
            e.Graphics.DrawString("Flickbook", subTitleFont, brush, startX + 10, textY);

            // Garis pemisah
            textY += 30;
            e.Graphics.DrawLine(borderPen, startX + 10, textY, startX + width - 10, textY);

            // Ambil data dari DataGridView
            string date = "Date: " + dataTicket.SelectedRows[0].Cells[0].Value.ToString();
            string movie = "Movie: " + dataTicket.SelectedRows[0].Cells[1].Value.ToString();
            string seatNo = "Seat No: " + dataTicket.SelectedRows[0].Cells[2].Value.ToString();
            string theater = "Theater: " + dataTicket.SelectedRows[0].Cells[3].Value.ToString();

            // Cetak isi tiket
            textY += 20;
            e.Graphics.DrawString(date, font, brush, startX + 10, textY);
            textY += 25;
            e.Graphics.DrawString(movie, font, brush, startX + 10, textY);
            textY += 25;
            e.Graphics.DrawString(seatNo, font, brush, startX + 10, textY);
            textY += 25;
            e.Graphics.DrawString(theater, font, brush, startX + 10, textY);
        }


        private void dataTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelClock.Text = dataTicket.Rows[e.RowIndex].Cells[4].Value.ToString();
            labelTittle.Text = dataTicket.Rows[e.RowIndex].Cells[1].Value.ToString();
            labelSeat.Text = dataTicket.Rows[e.RowIndex].Cells[2].Value.ToString();
            labelTheater.Text = dataTicket.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
