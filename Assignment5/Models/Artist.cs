using System.ComponentModel.DataAnnotations;


namespace Assignment5.Models
{
    public class Artist
    {
        public int artistID {  get; set; }
        public int genreID { get; set; }
        public string? artistTitle { get; set; }
    }
}
