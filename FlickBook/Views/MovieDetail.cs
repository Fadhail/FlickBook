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
    public partial class MovieDetail : Form
    {
        private readonly MovieController _movieController;
        private List<FlickBook.Models.Movie> _allMovies;
        private FlickBook.Models.Movie _selectedMovie;

        public MovieDetail(string movieId)
        {
            InitializeComponent();
            _movieController = new MovieController();
            LoadMovieDetail(movieId);
        }

        private async void Movie_Load(object sender, EventArgs e)
        {
            try
            {
                _allMovies = await _movieController.GetMoviesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load movies: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            movieName.Text = movie.Title + movie.Language;
            ratingLabel.Text = "Rating: " + movie.Rating.Substring(0, 3) + "/10";
            releaseLabel.Text = "Released: " + movie.ReleaseDate;
            descriptionLabel.Text = movie.Description;
            LoadImage(movie);
            LoadBackdrop(movie);
        }

        private void LoadImage(FlickBook.Models.Movie movie)
        {
            if (!string.IsNullOrEmpty(movie.Image))
            {
                try
                {
                    if (Uri.IsWellFormedUriString(movie.Image, UriKind.Absolute))
                    {
                        moviePict.Load(movie.Image);
                    }
                    else
                    {
                        moviePict.Image = Image.FromFile(movie.Image);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                moviePict.Image = null;
            }
        }
    }
}
