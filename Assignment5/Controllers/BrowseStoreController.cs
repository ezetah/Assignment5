using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment5.Data;
using Assignment5.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace Assignment5.Controllers
{
    public class BrowseStoreController : Controller
    {
        private readonly Assignment5Context _context;

        public BrowseStoreController(Assignment5Context context)
        {
            _context = context;
        }
        
        public IActionResult Index(string selectedGenre, string selectedArtist)
        {
            var songs = _context.Song.ToList();
            var genreList = _context.Genre.Select(g => new SelectListItem {
                Value = g.Id.ToString(),
                Text = g.genreTitle
            }).ToList();

            ViewBag.GenreList = new SelectList(genreList, "Value", "Text");

            var artistList = _context.Artist.Select(a => new SelectListItem
            {
                Value = a.artistTitle,
                Text = a.artistTitle
            }).ToList();

            ViewBag.ArtistList = new SelectList(artistList, "Value", "Text");

            if (!string.IsNullOrEmpty(selectedGenre))
            {
                int selectedGenreId; // Variable to hold the parsed selected genre ID

                // Attempt to parse the selectedGenre to int (assuming it's an ID)
                bool parsed = int.TryParse(selectedGenre, out selectedGenreId);

                // Filter songs by genreId matching the selectedGenreId
                if (parsed)
                {
                    songs = songs.Where(s => s.genreID == selectedGenreId).ToList();
                }
                else
                {
                    return View(songs.ToList());
                }
            }

            if (!string.IsNullOrEmpty(selectedArtist))
            {
                songs = songs.Where(s => s.artistTitle != null && s.artistTitle == selectedArtist).ToList();
            }


            return View(songs.ToList());
        }

        public async Task<IActionResult> StoreDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var song = await _context.Song
                .FirstOrDefaultAsync(m => m.songID == id);
            if (song == null)
            {
                return NotFound();
            }

            return View(song);
        }
    }
}
