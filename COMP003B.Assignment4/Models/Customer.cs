using System.ComponentModel.DataAnnotations;
namespace COMP003B.Assignment4.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email {  get; set; }

        [Required]
        [StringLength(10)]
        public string Phone {  get; set; }
    }
}
