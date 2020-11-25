using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MvcMovie.Models
{
  public class TMDBMovie
  {
    [JsonProperty("popularity")]
    public double popularity { get; set; }

    [JsonProperty("vote_count")]
    public int vote_count { get; set; }

    [JsonProperty("video")]
    public bool video { get; set; }

    [JsonProperty("poster_path")]
    public string poster_path { get; set; }

    [JsonProperty("id")]
    public int id { get; set; }

    [JsonProperty("adult")]
    public bool adult { get; set; }

    [JsonProperty("backdrop_path")]
    public string backdrop_path { get; set; }

    [JsonProperty("original_language")]
    public string original_language { get; set; }

    [JsonProperty("original_title")]
    public string original_title { get; set; }

    [JsonProperty("genre_ids")]
    public List<int> genre_ids { get; set; }

    [JsonProperty("genres")]
    public List<Genres> genres { get; set; }

    [JsonProperty("title")]
    public string title { get; set; }

    [JsonProperty("vote_average")]
    public double vote_average { get; set; }

    [JsonProperty("overview")]
    public string overview { get; set; }

    [JsonProperty("release_date")]
    public string release_date { get; set; }

    [JsonProperty("imdb_id")]
    public string imdb_id { get; set; }

    [JsonProperty("runtime")]
    public string runtime { get; set; }

    [JsonProperty("tagline")]
    public string tagline { get; set; }

  }
}