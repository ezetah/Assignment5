using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Assignment5.Models
{
    public class Song
    {

        [Key]
        public int songID { get; set; }

        public int genreID { get; set; }

        public int artistID { get; set; }
        public string? songTitle { get; set; }
        public string? artistTitle { get; set; }
        public decimal price { get; set; }

        public Genre? Genre { get; set; } //nav for related genre

    }
}
