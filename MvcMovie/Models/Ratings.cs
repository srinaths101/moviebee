using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
  public class Rating
  {
    public bool canRate { get; set; }
    public double rating { get; set; }
    public int ratingCount { get; set; }

  }
}