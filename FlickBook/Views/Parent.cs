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
            if (moviePage != null)
            {
                moviePage.WindowState = FormWindowState.Maximized;
            }
        }
        private void movieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(riwayatTransaksi != null)
            {
                riwayatTransaksi.Close();
                riwayatTransaksi = null;
            }

            if (moviePage == null)
            {
                moviePage = new Movie();
                moviePage.MdiParent = this;
                moviePage.FormClosed += new FormClosedEventHandler(moviePage_FormClosed);
                moviePage.WindowState = FormWindowState.Maximized;
                moviePage.Show();
            }
            else
            {
                moviePage.Activate();
            }
        }
        private void moviePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            moviePage = null;
        }

        private void riwayatTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (moviePage != null)
            {
                moviePage.Close();
                moviePage = null;
            }

            if (riwayatTransaksi == null)
            {
                riwayatTransaksi = new Riwayat();
                riwayatTransaksi.MdiParent = this;
                riwayatTransaksi.FormClosed += new FormClosedEventHandler(riwayatTransaksi_FormClosed);
                riwayatTransaksi.WindowState = FormWindowState.Maximized;
                riwayatTransaksi.Show();
            }
            else
            {
                riwayatTransaksi.Activate();
            }
        }

        private void riwayatTransaksi_FormClosed(object sender, FormClosedEventArgs e)
        {
            riwayatTransaksi = null;
        }
    }
}
