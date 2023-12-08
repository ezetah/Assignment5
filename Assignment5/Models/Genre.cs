using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Assignment5.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public string? genreTitle { get; set; }
        public ICollection<Song>? songs { get; set; } // property for collected songs
    }
}
