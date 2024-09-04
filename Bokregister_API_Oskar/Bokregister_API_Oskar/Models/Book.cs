using System.ComponentModel.DataAnnotations;

namespace Bokregister_API_Oskar.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
    }
}
