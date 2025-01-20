using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using FlickBook.Models;

namespace FlickBook.Controllers
{
    public class MovieController
    {
        private readonly HttpClient _client;

        public MovieController()
        {
            _client = new HttpClient();
        }

        public async Task<List<Movie>> GetMoviesAsync()
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api.themoviedb.org/3/movie/top_rated?language=en-US"),
                Headers =
                {
                    { "accept", "application/json" },
                    { "Authorization", "API" },
                },
            };

            using (var response = await _client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var jsonObject = JObject.Parse(body);

                var movies = new List<Movie>();

                var results = jsonObject["results"] as JArray;
                if (results != null)
                {
                    foreach (var item in results)
                    {
                        movies.Add(new Movie
                        {
                            Id = item["id"]?.ToString(),
                            Title = item["title"]?.ToString(),
                            Image = item["poster_path"] != null ? $"https://image.tmdb.org/t/p/w500{item["poster_path"]}" : null,
                            Rating = item["vote_average"]?.ToString(),
                            Description = item["overview"]?.ToString(),
                            ReleaseDate = item["release_date"]?.ToString(),
                            Language = item["original_language"]?.ToString(),
                            Genre = item["genre_ids"]?.ToString(),
                            Backdrop = item["backdrop_path"] != null ? $"https://image.tmdb.org/t/p/w500{item["backdrop_path"]}" : null
                        });
                    }
                }

                return movies;
            }
        }
    }
}
