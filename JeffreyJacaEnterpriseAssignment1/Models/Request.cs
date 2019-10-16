using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JeffreyJacaEnterpriseAssignment1.Models
{

    public class Request
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [RegularExpression("^\\(?([0-9]{3})\\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
            ErrorMessage = "Please enter a valid phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please choose your role")]
        public string Role { get; set; }

        [Required(ErrorMessage = "Please choose an equipment type")]
        public EquipmentType EquipmentType { get; set; }

        [Required(ErrorMessage = "Please enter your request details")]
        public string Details { get; set; }

        [Required(ErrorMessage = "Please enter the period of time you expect to borrow the item")]
        public int Duration { get; set; }
    }
}
