using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Assignment5.Models
{
    public class Artist
    {

        [Key]
        public int artistID {  get; set; }

        public int genreID { get; set; }
        public string? artistTitle { get; set; }
    }
}
