using System.ComponentModel.DataAnnotations;

namespace Assignment5.Models
{
    public class User
    {

        [Key]
        public int userID { get; set; }
        public string? Username { get; set; }

        public string? Password { get; set; }
    }
}
