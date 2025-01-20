using FlickBook.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlickBook.Views
{
    public partial class Theater : Form
    {
        Koneksi koneksi = new Koneksi();

        public void Tampil()
        {
            dataTheater.DataSource = koneksi.ShowData("SELECT * FROM theater");
            dataTheater.Columns[0].HeaderText = "ID Theater";
            dataTheater.Columns[1].HeaderText = "Nama Theater";
            dataTheater.Columns[2].HeaderText = "Kapasitas";
        }
        public Theater()
        {
            InitializeComponent();
        }

        private void Theater_Load(object sender, EventArgs e)
        {
            Tampil();
        }
    }
}
