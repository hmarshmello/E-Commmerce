using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commmerce.Models
{
    [Table("ShoppingCart")]
    public class ShoppingCart
    {
        [Key]
        public int RecordId { get; set; }
        public string CartId { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public DateTime DateCreated { get; set; }

        public Product Product { get; set; }
    }
}
