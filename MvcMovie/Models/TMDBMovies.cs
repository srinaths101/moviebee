using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MvcMovie.Models
{
  public class TMDBMovies
  {
    [JsonProperty("page")]
    public string page { get; set; }

    [JsonProperty("total_results")]
    public string total_results { get; set; }

    [JsonProperty("total_pages")]
    public string total_pages { get; set; }

    [JsonProperty("results")]
    public List<TMDBMovie> results { get; set; }

  }
}