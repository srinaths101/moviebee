using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
  public class Image
  {
    public int height { get; set; }
    public string id { get; set; }

    public string url { get; set; }
    public int width { get; set; }

  }
}