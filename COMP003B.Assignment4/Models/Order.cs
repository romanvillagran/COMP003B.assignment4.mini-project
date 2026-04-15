using System.ComponentModel.DataAnnotations;
namespace COMP003B.Assignment4.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Range(1, 100)]
        public int Quantity { get; set; }

      public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
