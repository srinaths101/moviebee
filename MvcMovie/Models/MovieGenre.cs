using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
  public class MovieGenreViewModel
  {
    public List<Movies> Movies { get; set; }
    public List<TMDBMovies> TMDBMovies { get; set; }
    public List<TMDBMovie> MovieList { get; set; }
    public List<Title> Title { get; set; }
    public SelectList Genres { get; set; }
    public string MovieGenre { get; set; }
    public string ReleaseDate { get; set; }
    public string Popularity { get; set; }
    public string SearchString { get; set; }
  }
}