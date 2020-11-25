using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MvcMovie.Models
{
  public class Search
  {
    [JsonProperty("query")]
    public string query { get; set; }

    [JsonProperty("results")]
    public List<Results> results { get; set; }

    [JsonProperty("types")]
    public List<string> types { get; set; }

  }
}