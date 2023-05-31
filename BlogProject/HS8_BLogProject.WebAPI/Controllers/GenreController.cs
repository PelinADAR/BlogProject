using Microsoft.AspNetCore.Mvc;

namespace HS8_BLogProject.WebAPI.Controllers
{
    public class GenreController : Controller
    {
        private readonly IGenreService _genreService;

     

        [HttpGet]
        public IActionResult GetAllGenres()
        {
            
            return View();
        }
    }
}
