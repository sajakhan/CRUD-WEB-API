using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.Models
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }

        public string PublisherName { get; set; }

        public String Address { get; set; }

        public int Phone { get; set; }

        public List<Book> Books { get; set; }
        

    }
}
