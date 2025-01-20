using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlickBook.Controllers;
using FlickBook.Models;

namespace FlickBook.Views
{
    public partial class Movie : Form
    {
        private readonly MovieController _movieController;
        private List<FlickBook.Models.Movie> _allMovies;
        private int _currentPage = 0;
        private const int PageSize = 12;

        public Movie()
        {
            InitializeComponent();
            _movieController = new MovieController();
        }

        private async void Movie_Load(object sender, EventArgs e)
        {
            await LoadMoviesAsync();
        }

        private async Task LoadMoviesAsync()
        {
            try
            {
                _allMovies = await _movieController.GetMoviesAsync();
                DisplayPage(_currentPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load movies: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayPage(int page)
        {
            flpMovies.Controls.Clear();

            var moviesToShow = _allMovies
                .Skip(page * PageSize)
                .Take(PageSize)
                .ToList();

            foreach (var movie in moviesToShow)
            {
                var card = CreateCard(movie);
                flpMovies.Controls.Add(card);
            }

            buttonPrevious.Enabled = page > 0;
            buttonNext.Enabled = (page + 1) * PageSize < _allMovies.Count;
        }

        private Panel CreateCard(FlickBook.Models.Movie movie)
        {
            var panel = new Panel
            {
                Width = 150,
                Height = 250,
                Margin = new Padding(8),
                BackColor = Color.Black,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Movie Image
            var pictureBox = new PictureBox
            {
                ImageLocation = movie.Image,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = 150,
                Height = 150,
                Dock = DockStyle.Top
            };
            panel.Controls.Add(pictureBox);

            // Movie Title
            var labelTitle = new Label
            {
                Text = movie.Title,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Height = 50
            };
            panel.Controls.Add(labelTitle);

            // Movie Rating
            var labelRating = new Label
            {
                Text = $"Rating: {movie.Rating}",
                Dock = DockStyle.Bottom,
                TextAlign = ContentAlignment.MiddleCenter
            };
            panel.Controls.Add(labelRating);

            panel.Click += (sender, e) => RedirectToDetail(movie.Id);
            pictureBox.Click += (sender, e) => RedirectToDetail(movie.Id);
            labelTitle.Click += (sender, e) => RedirectToDetail(movie.Id);
            labelRating.Click += (sender, e) => RedirectToDetail(movie.Id);

            return panel;
        }

        private void RedirectToDetail(string movieId)
        {
            var detailForm = new MovieDetail(movieId)
            {
                MdiParent = this.MdiParent
            };
            detailForm.Show();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            _currentPage++;
            DisplayPage(_currentPage);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            _currentPage--;
            DisplayPage(_currentPage);
        }
    }
}
