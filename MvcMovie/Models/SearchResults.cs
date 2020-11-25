using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MvcMovie.Models
{
  public class Results
  {
    [JsonProperty("id")]
    public string id { get; set; }
    [JsonProperty("image")]
    public Image image { get; set; }
    [JsonProperty("runningTimeInMinutes")]
    public int runningTimeInMinutes { get; set; }
    [JsonProperty("title")]
    public string title { get; set; }
    [JsonProperty("titleType")]
    public string titleType { get; set; }
    [JsonProperty("year")]
    public int year { get; set; }

  }
}