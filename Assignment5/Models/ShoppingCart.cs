using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment5.Models
{
    public class ShoppingCart
    {

        [Key]
        public int shoppingCartID { get; set; }

        public int songID { get; set; }

        public int userID { get; set; }
    }
}
