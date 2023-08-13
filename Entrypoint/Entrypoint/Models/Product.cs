using System.ComponentModel.DataAnnotations;

namespace Entrypoint.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a valid code.")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Please enter a valid title.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a valid price.")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
