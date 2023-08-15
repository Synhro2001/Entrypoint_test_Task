using System.ComponentModel.DataAnnotations;

namespace Entrypoint.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Product code")]
        [Required(ErrorMessage = "Please enter a valid code.")]
        public string? Code { get; set; }
        [Display(Name = "Product name")]
        [Required(ErrorMessage = "Please enter a valid title.")]
        public string? Title { get; set; }
        [Display(Name = "Price")]
        [Required(ErrorMessage = "Please enter a valid price.")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

    }
}
