using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcMovie.Models;
using Newtonsoft.Json;
using System.Security.Principal;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using MvcMovie.Areas.Identity.Data;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using MimeKit.Text;

namespace MvcMovie.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    private string baseUrl = "https://rapidapi.p.rapidapi.com/title/";
    private string baseUrlTMDB = "https://api.themoviedb.org/3/";
    private string apiKeyTMDB = "6b004675ff8a591c19242d826a62ac67";
    private string baseImageUrl = "https://image.tmdb.org/t/p/w500";
    private Dictionary<string, string> genreDict;


    public HomeController(SignInManager<ApplicationUser> signInManager,
            ILogger<HomeController> logger,
            UserManager<ApplicationUser> userManager)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _logger = logger;
      genreDict = new Dictionary<string, string>();
      genreDict.Add("28", "Action");
      genreDict.Add("12", "Adventure");
      genreDict.Add("16", "Animation");
      genreDict.Add("35", "Comedy");
      genreDict.Add("80", "Crime");
      genreDict.Add("99", "Documentary");
      genreDict.Add("10751", "Family");
      genreDict.Add("14", "Fantasy");
      genreDict.Add("36", "History");
      genreDict.Add("27", "Horror");
      genreDict.Add("10402", "Music");
      genreDict.Add("9648", "Mystery");
      genreDict.Add("10749", "Romance");
      genreDict.Add("878", "Science Fiction");
      genreDict.Add("10770", "TV Movie");
      genreDict.Add("53", "Thriller");
      genreDict.Add("10752", "War");
      genreDict.Add("37", "Western");
    }

    private async Task<string> GetMovieData(string urlParam)
    {
      var client = new HttpClient();
      var request = new HttpRequestMessage
      {
        Method = HttpMethod.Get,
        RequestUri = new Uri(this.baseUrl + urlParam),
        Headers = {
            { "x-rapidapi-key", "af39a2aa6amsh426a9e4ddb991d4p12e52bjsn8186a9aad89e" },
            { "x-rapidapi-host", "imdb8.p.rapidapi.com" },
        },
      };

      var apiResponse = "";
      using (var response = await client.SendAsync(request))
      {
        response.EnsureSuccessStatusCode();
        apiResponse = await response.Content.ReadAsStringAsync();
      }

      return apiResponse;

    }

    private async Task<string> GetTMDBMovieData(string urlParam, string query="")
    {
      string url = $"{this.baseUrlTMDB}{urlParam}?api_key={this.apiKeyTMDB}&language=en-US&page=1&{query}";
      var client = new HttpClient();
      var request = new HttpRequestMessage
      {
        Method = HttpMethod.Get,
        RequestUri = new Uri(url),
      };

      var apiResponse = "";
      using (var response = await client.SendAsync(request))
      {
        response.EnsureSuccessStatusCode();
        apiResponse = await response.Content.ReadAsStringAsync();
      }

      return apiResponse;

    }

    public async Task<IActionResult> Index()
    {
      ViewData["isError"] = "false";
      try
      {
        bool isAuthenticated = User.Identity.IsAuthenticated;
        TMDBMovies recomendedMovies = new TMDBMovies();

        if (isAuthenticated)
        {
          ClaimsPrincipal currentUser = this.User;
          var currentUserName = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
          ApplicationUser user = await _userManager.FindByIdAsync(currentUserName);

          string prefferedGenre1 = user.PrefferedGenre1;
          string prefferedGenre2 = user.PrefferedGenre2;

          string query = "";

          if (string.IsNullOrEmpty(prefferedGenre1) && string.IsNullOrEmpty(prefferedGenre2))
          {
            query += "comedy,";
          }
          else
          {
            if (!string.IsNullOrEmpty(prefferedGenre1))
            {
              query += $"{prefferedGenre1},";
            }
            if (!string.IsNullOrEmpty(prefferedGenre2))
            {
              query += $"{prefferedGenre2},";
            }
          }

          var recomendedRes = await GetTMDBMovieData("discover/movie", query.Substring(0, query.Count() - 1));
          recomendedMovies = JsonConvert.DeserializeObject<TMDBMovies>(recomendedRes);

          ViewData["isRecommended"] = "true";
        }
        else
        {
          ViewData["isRecommended"] = "false";
        }

        TMDBMovies topRatedMovies = new TMDBMovies();
        var res = await GetTMDBMovieData("movie/top_rated");

        topRatedMovies = JsonConvert.DeserializeObject<TMDBMovies>(res);

        TMDBMovies popularMovies = new TMDBMovies();
        res = await GetTMDBMovieData("movie/popular");

        popularMovies = JsonConvert.DeserializeObject<TMDBMovies>(res);

        TMDBMovies upcomingMovies = new TMDBMovies();
        res = await GetTMDBMovieData("movie/upcoming");

        upcomingMovies = JsonConvert.DeserializeObject<TMDBMovies>(res);

        ViewData["baseImageUrl"] = this.baseImageUrl;

        var tuple = new Tuple<IEnumerable<TMDBMovie>, IEnumerable<TMDBMovie>, IEnumerable<TMDBMovie>, IEnumerable<TMDBMovie>>(topRatedMovies.results, popularMovies.results, upcomingMovies.results, recomendedMovies.results);

        return View(tuple);
      }
      catch (Exception e)
      {
        ViewData["isError"] = "true";
        Console.WriteLine(e);
      }

      return View();
    }

    public async Task<IActionResult> SearchMovie(string searchStr)
    {
      try
      {
        if (!string.IsNullOrEmpty(searchStr))
        {
          TMDBMovies searchedMovies = new TMDBMovies();
          var res = await GetTMDBMovieData("search/movie", $"query={searchStr}");

          searchedMovies = JsonConvert.DeserializeObject<TMDBMovies>(res);

          ViewData["baseImageUrl"] = this.baseImageUrl;

          if (searchedMovies.results.Count == 0)
          {
            ViewData["isData"] = "false";
            ViewData["msg"] = $"No movies found with {searchStr}";
          }
          else
          {
            ViewData["isData"] = "true";
          }
          ViewData["searchStr"] = searchStr;
          return View(searchedMovies.results);
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
      }

      ViewData["isData"] = "false";
      ViewData["msg"] = "No movies found. Please enter search query.";
      return View();
    }

    [HttpGet]
    public IActionResult ContactUs() {
      ViewData["msg"] = "";
      return View();
    }

    [HttpPost]
    public IActionResult ContactUs([Bind("Id","Name","EmailId","Message")] Contact contact)
    {
      if (ModelState.IsValid) {
        try {
          ViewData["msg"] = "";

          string emailTo = "deepu996@gmail.com";
          string emailFrom = contact.EmailId;
          var email = new MimeMessage();
          email.From.Add(new MailboxAddress(contact.Name, emailFrom));
          email.To.Add(new MailboxAddress("MovieBee", emailTo));
          email.Subject = "MovieBee User Message!";
          email.Body = new TextPart(TextFormat.Html)
          { Text = $"<h3>Email: {emailFrom}</h3><h3>Name: {contact.Name}</h3><p>Message: {contact.Message }</p>"};

          // send email
          using var smtp = new SmtpClient();
          smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
          smtp.Authenticate("srinaths101@gmail.com", "Sreenath@03");
          smtp.Send(email);
          smtp.Disconnect(true);
          ViewData["msg"] = "Message sent successfully";
          ModelState.Clear();
        } catch (Exception e) {
          ViewData["msg"] = "Your message cannot be sent. Please try again.";
          Console.WriteLine(e);
        }
      }

      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
