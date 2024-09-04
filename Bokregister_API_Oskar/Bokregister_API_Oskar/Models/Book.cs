using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Bokregister_API_Oskar.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        [StringLength(13, MinimumLength = 13)]
        [RegularExpression(@"^\d{13}$", ErrorMessage = "ISBN must be exactly 13 digits.")]
        public string ISBN { get; set; }
    }
}
