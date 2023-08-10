using System.ComponentModel.DataAnnotations;

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
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a valid client name.")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        [Required(ErrorMessage = "Please enter a valid product name.")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Required(ErrorMessage = "Please enter a valid quantity.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Please select a status.")]
        public StatusTypes Status { get; set; }

        
    }
}
