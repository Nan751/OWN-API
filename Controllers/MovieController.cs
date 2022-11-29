using Microsoft.AspNetCore.Mvc;
using Movieapi.Models;

namespace Movieapi.Controllers;

[ApiController]
[Route("api/Movie")]
public class MovieController : ControllerBase

{
    private readonly MoviesdbContext DB;

    public MovieController(MoviesdbContext db)
    {
        this.DB=db;
    }
    [HttpGet("Getmovie")]
    public Movie GetMovies(string Movienames)
   {
    try{
        return  DB.Movies.Where(e=>e.Title.Equals(Movienames)).FirstOrDefault();
    }
    catch(System.Exception)
    {
        throw;
    }
    }
}
