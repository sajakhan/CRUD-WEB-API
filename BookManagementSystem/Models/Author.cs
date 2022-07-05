using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        public string AuthorName { get; set; }

        public String Address { get; set; }
        public int Age { get; set; }

        public int Phone { get; set; }
        public  List<Book> Books  { get; set; }
    }
}
