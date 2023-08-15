using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Entrypoint.Models
{
    public enum StatusTypes
    {
        Created,
        Paid,
        Delivered
    }
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Client")]
        [Required]
        public int ClientId { get; set; }
        public virtual Client? Client { get; set; }
        [ForeignKey("Product")]
        [Required]
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
        [Required(ErrorMessage = "Please enter a valid quantity.")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Please select a status.")]
        public StatusTypes Status { get; set; }

    }

    public class OrderViewsModel
    {
        public int Id { get; set; }
        [Display(Name = "Clients")]
        public int ClientId { get; set; }
        public virtual Client? Client { get; set; }
        [Display(Name = "Products")]
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
        [Required(ErrorMessage = "Please enter a valid quantity.")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }
        [Display(Name = "Total Quantity")]
        public decimal QuantitySum { get; set; }
        [Required(ErrorMessage = "Please select a status.")]
        public StatusTypes Status { get; set; }

        

    }

}
