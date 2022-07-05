using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagementSystem.Models
{
    public class Warehouse
    {
        [Key]
        public int Id
        {
            get;
            set;
        }
        public int Count
        {
            get;
            set;
        }
      /*  [ForeignKey("BookId")]
        public int BookId { get; set; }*/
        public Book Book
        {
            get;
            set;
        }
        
    }
}
