using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
  public class Movies
  {
    public string id { get; set; }
    public Title title { get; set; }
    public Rating ratings { get; set; }
    public List<string> genres { get; set; }
    public string releaseDate { get; set; }
    public PlotSummary plotOutline { get; set; }
    public PlotSummary plotSummary { get; set; }
    public List<Review> movieReviews { get; set; }
    public TMDBMovie movieDetails {get; set;}
    public Review review {get; set;}
    public List<TMDBMovie> similarMovies { get; set; }

  }
}