using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Entrypoint.Models;

namespace Entrypoint.Models
{
    public enum GenderTypes
    {
        Male,
        Female
    }
    public class Client
    {
       
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a valid name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a valid email.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a valid birth date.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = false)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Please select a gender.")]
        public GenderTypes Gender { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }

    public class ClientViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a valid name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a valid email.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a valid birth date.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = false)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Please select a gender.")]
        public GenderTypes Gender { get; set; }

        public int NumberOfOrders { get; set; }
        public decimal AverageOrderAmount { get; set; }
    }

}
