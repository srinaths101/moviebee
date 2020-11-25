using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
  public class PlotSummary
  {
    public string id { get; set; }
    public string text { get; set; }
    public string author { get; set; }

  }
}