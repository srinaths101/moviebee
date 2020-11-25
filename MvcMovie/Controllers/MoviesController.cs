using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Security.Principal;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using MvcMovie.Areas.Identity.Data;

namespace MvcMovie.Controllers
{
  public class MoviesController : Controller
  {
    private readonly MvcMovieContext _context;

    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    private string baseUrl = "https://rapidapi.p.rapidapi.com/title/";
    private string baseUrlTMDB = "https://api.themoviedb.org/3/";
    private string apiKeyTMDB = "6b004675ff8a591c19242d826a62ac67";
    private string baseImageUrl = "https://image.tmdb.org/t/p/w500";
    private Dictionary<string, string> genreDict;


    public MoviesController(MvcMovieContext context, SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager)
    {
      _context = context;
      _userManager = userManager;
      _signInManager = signInManager;
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
      string url = $"{this.baseUrlTMDB}{urlParam}?api_key={this.apiKeyTMDB}&language=en-US&page=1{query}";
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

    // GET: Movies
    public async Task<IActionResult> Index()
    {
      try
      {
        MovieGenreViewModel movieGenreViewModel = new MovieGenreViewModel();
        TMDBMovies popularMovies = new TMDBMovies();
        var res = await GetTMDBMovieData("movie/popular");

        popularMovies = JsonConvert.DeserializeObject<TMDBMovies>(res);
        movieGenreViewModel.MovieList = popularMovies.results;
        ViewData["baseImageUrl"] = this.baseImageUrl;

        ViewData["isData"] = "true";
        return View(movieGenreViewModel);
      }
      catch (Exception e)
      {
        ViewData["isData"] = "false";
        Console.WriteLine(e);
      }
      ViewData["isData"] = "false";
      return View();
    }

    public async Task<IActionResult> GenreMovie(string movieGenre, string ReleaseDate, string popularity)
    {
      MovieGenreViewModel movieGenreViewModel = new MovieGenreViewModel();
      string query = "";
      if (!string.IsNullOrEmpty(ReleaseDate))
      {
        query += $"&primary_release_date.gte={ReleaseDate}";
      }

      if (!string.IsNullOrEmpty(popularity) && popularity == "sort")
      {
        query += $"&sort_by=popularity.asc&vote_average.gte=8";
      }

      if (!string.IsNullOrEmpty(movieGenre))
      {
        query += $"&with_genres={movieGenre}";
      }

      try
        {
          TMDBMovies popularMovies = new TMDBMovies();
          var res = await GetTMDBMovieData("discover/movie", query);

          popularMovies = JsonConvert.DeserializeObject<TMDBMovies>(res);

          movieGenreViewModel.MovieList = popularMovies.results;
          ViewData["baseImageUrl"] = this.baseImageUrl;

          ViewData["Genre"] = "Filter Results";

          ViewData["isData"] = "true";
          return View(movieGenreViewModel);
        }
        catch (Exception e)
        {
          ViewData["isData"] = "false";
          Console.WriteLine(e);
        }


      ViewData["isData"] = "false";

      return View(movieGenreViewModel);
    }

    // GET: Movies/Details/5
    public async Task<IActionResult> Details(string id)
    {
      if (!string.IsNullOrEmpty(id))
      {
        ViewData["isLogin"] = "false";
        bool isAuthenticated = User.Identity.IsAuthenticated;
        if (isAuthenticated)
        {
          ViewData["isLogin"] = "true";
        }

        var movie = await _context.Review.Where(m => m.MovieId == id).ToListAsync();

        ViewData["hasReviews"] = "true";
        if ((movie == null) || (movie.Count == 0))
        {
          ViewData["hasReviews"] = "false";
        }

        string movieId = id.Split("%2F")[2];
        var movieStr = await GetMovieData($"get-overview-details?tconst={movieId}&currentCountry=US");
        Movies movies = JsonConvert.DeserializeObject<Movies>(movieStr);
        movies.movieReviews = movie;
        return View(movies);
      }

      return View();
    }

    // GET: Movies/Details/5
    public async Task<IActionResult> TMDBDetails(string id)
    {
      if (!string.IsNullOrEmpty(id))
      {
        ViewData["isLogin"] = "false";
        bool isAuthenticated = User.Identity.IsAuthenticated;
        if (isAuthenticated)
        {
          ViewData["isLogin"] = "true";
        }

        var movieReviews = await _context.Review.Where(m => m.MovieId == id).ToListAsync();

        ViewData["hasReviews"] = "true";
        if ((movieReviews == null) || (movieReviews.Count == 0))
        {
          ViewData["hasReviews"] = "false";
        }

        var movieStr = await GetTMDBMovieData($"movie/{id}");
        TMDBMovie movieDetails = new TMDBMovie();
        movieDetails = JsonConvert.DeserializeObject<TMDBMovie>(movieStr);

        var similarMovieStr = await GetTMDBMovieData($"movie/{id}/similar");
        TMDBMovies similarMovies = new TMDBMovies();
        similarMovies = JsonConvert.DeserializeObject<TMDBMovies>(similarMovieStr);

        Movies movies = new Movies();
        movies.movieReviews = movieReviews;
        movies.movieDetails = movieDetails;
        movies.similarMovies = similarMovies.results;
        movies.similarMovies = movies.similarMovies.Take(4).ToList();

        Review review = new Review();
        movies.review = review;

        ViewData["baseImageUrl"] = this.baseImageUrl;

        return View(movies);
      }

      return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateReview(string movieId)
    {
      bool isAuthenticated = User.Identity.IsAuthenticated;
      if (isAuthenticated)
      {
        ClaimsPrincipal currentUser = this.User;
        var currentUserId = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
        ApplicationUser user = await _userManager.FindByIdAsync(currentUserId);

        Review review = new Review();
        review.MovieReview = HttpContext.Request.Form["review"];
        review.Rating = int.Parse(HttpContext.Request.Form["rating"]);
        review.UserId = currentUserId;
        review.UserName = user.Name;
        review.MovieId = movieId;

        if (ModelState.IsValid) {
          _context.Add(review);
          await _context.SaveChangesAsync();
        }

      }
      return RedirectToAction("TMDBDetails" ,new { id = movieId });;
    }

    // GET: Movies/Create
    public IActionResult Create()
    {
      return View();
    }

    // POST: Movies/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Title,ReleaseDate,Genre,Price,Rating")] Movie movie)
    {
      if (ModelState.IsValid)
      {
        _context.Add(movie);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
      }
      return View(movie);
    }

    // GET: Movies/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var movie = await _context.Movie.FindAsync(id);
      if (movie == null)
      {
        return NotFound();
      }
      return View(movie);
    }

    // POST: Movies/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to, for
    // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,Genre,Price,Rating")] Movie movie)
    {
      if (id != movie.Id)
      {
        return NotFound();
      }

      if (ModelState.IsValid)
      {
        try
        {
          _context.Update(movie);
          await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
          if (!MovieExists(movie.Id))
          {
            return NotFound();
          }
          else
          {
            throw;
          }
        }
        return RedirectToAction(nameof(Index));
      }
      return View(movie);
    }

    // GET: Movies/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var movie = await _context.Movie
          .FirstOrDefaultAsync(m => m.Id == id);
      if (movie == null)
      {
        return NotFound();
      }

      return View(movie);
    }

    // POST: Movies/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
      var movie = await _context.Movie.FindAsync(id);
      _context.Movie.Remove(movie);
      await _context.SaveChangesAsync();
      return RedirectToAction(nameof(Index));
    }

    private bool MovieExists(int id)
    {
      return _context.Movie.Any(e => e.Id == id);
    }
  }
}
