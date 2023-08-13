using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        [Required(ErrorMessage = "Please enter a valid product name.")]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Required(ErrorMessage = "Please enter a valid quantity.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Please select a status.")]
        public StatusTypes Status { get; set; }

        
    }

    public class OrderViewsModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a valid client name.")]
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        [Required(ErrorMessage = "Please enter a valid product name.")]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Required(ErrorMessage = "Please enter a valid quantity.")]
        public int Quantity { get; set; }
        public int QuantitySum { get; set; }

        [Required(ErrorMessage = "Please select a status.")]
        public StatusTypes Status { get; set; }

        

    }

}
