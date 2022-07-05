using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagementSystem.Models
{
    public class Book
    {
        [Key]
        public int Id
        {
            get;
            set;
        }
        public string Title
        {
            get;
            set;
        }
        public int Year
        {
            get;
            set;
        }
        public int Price
        {
            get;
            set;
        }
        public List<Warehouse> Warehouses { get; set; }
        /*        [ForeignKey("AuthorId")]
        */
        /*public int AuthorId { get; set; }*/
        public Author Author
        {
            get;
            set;
        }
        /*        [ForeignKey("PublisherId")]
        */
        /*public int PulisherId { get; set; }*/
        public Publisher Publisher
        {
            get;
            set;
        }
    }
}
