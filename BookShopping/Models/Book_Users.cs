
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookShopping.Models
{
    public class Book_Users
    {

        public int Id { get; set; }
        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Email")]
        public string email { get; set;}
        [Required]
        [DisplayName("Password")]
        [PasswordPropertyText]
        public string password { get; set;}
        [Required]
        [DisplayName("Re-Enter Password")]
        [PasswordPropertyText]
        public string re_password { get; set;}

    }
}
