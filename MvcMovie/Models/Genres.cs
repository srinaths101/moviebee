using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MvcMovie.Models
{
  public class Genres
  {
    [JsonProperty("id")]
    public int id { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }
  }
}