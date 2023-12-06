using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment5.Data;
using Assignment5.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment5.Controllers
{
    public class BrowseStoreController : Controller
    {
        private readonly Assignment5Context _context;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Data()
        {
            var genres = _context.Genre.ToList();
            var genreSelectList = new SelectList(genres, "Id", "genreTitle");
            ViewBag.GenreSelectList = genreSelectList;

            return View();
        }


        public IActionResult Genre()
        {
            ViewData["GenreId"] = new SelectList(_context.Genre, "Id", "genreTitle");
            return View();
        }
    }
}
