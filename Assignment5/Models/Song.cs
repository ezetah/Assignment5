using System.ComponentModel.DataAnnotations;


namespace Assignment5.Models
{
    public class Song
    {
        public int songID { get; set; }
        public int genreID { get; set; }
        public int artistID { get; set; }
        public string? songTitle { get; set; }
        public string? artistTitle { get; set; }
        public decimal price { get; set; }
    }
}
