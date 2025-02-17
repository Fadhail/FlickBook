using FlickBook.Controllers;
using FlickBook.Models;
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
    public partial class BookForm : Form
    {
        Koneksi koneksi = new Koneksi();
        TicketController Cticket = new TicketController();
        TicketModel Mticket = new TicketModel();
        private readonly MovieController _movieController;
        private List<FlickBook.Models.Movie> _allMovies;
        private FlickBook.Models.Movie _selectedMovie;

        public BookForm(string movieId)
        {
            InitializeComponent();
            _movieController = new MovieController();
            LoadMovieDetail(movieId);
        }

        private async void LoadMovieDetail(string movieId)
        {
            try
            {
                _allMovies = await _movieController.GetMoviesAsync();
                _selectedMovie = _allMovies.FirstOrDefault(m => m.Id == movieId);
                if (_selectedMovie != null)
                {
                    DisplayMovieDetail(_selectedMovie);
                }
                else
                {
                    MessageBox.Show("Movie not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load movie details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadBackdrop(FlickBook.Models.Movie movie)
        {
            if (!string.IsNullOrEmpty(movie.Backdrop))
            {
                try
                {
                    if (Uri.IsWellFormedUriString(movie.Backdrop, UriKind.Absolute))
                    {
                        backdropPict.Load(movie.Backdrop);
                    }
                    else
                    {
                        backdropPict.Image = Image.FromFile(movie.Backdrop);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load backdrop: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                backdropPict.Image = null;
            }
        }

        private void DisplayMovieDetail(FlickBook.Models.Movie movie)
        {
            tbMovie.Text = movie.Title + movie.Language;
            LoadBackdrop(movie);
            GetDataSeat();
        }

        public void GetDataSeat()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM seat");
            while (reader.Read())
            {
                int seat_no = reader.GetInt32("seat_no");
                cbSeat.Items.Add(seat_no);
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            if (tbMovie.Text == "" || cbSeat.Text == "" || cbClock.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mticket.Tittle = tbMovie.Text;
                Mticket.Seat_id = cbSeat.Text;
                Mticket.Clock = cbClock.Text;
                Cticket.Insert(Mticket);
                this.Close();
            }
        }
    }
}
