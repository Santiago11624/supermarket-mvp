using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class CustomersModel
    {
        [DisplayName("ID")]
        [Required(ErrorMessage = "Document number is required")]
        [StringLength(15, ErrorMessage = "Document number must be up to 15 characters")]
        public int Document_Number { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, ErrorMessage = "First name must be up to 50 characters")]
        public string Name { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, ErrorMessage = "Last name must be up to 50 characters")]
        public string Last_Name { get; set; }

        [DisplayName("Address")]
        [Required(ErrorMessage = "Address is required")]
        [StringLength(80, ErrorMessage = "Address must be up to 80 characters")]
        public string Address { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Birthday { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is required")]
        [StringLength(100, ErrorMessage = "Email must be up to 100 characters")]
        public string Email { get; set; }

        [DisplayName("Phone")]
        [Phone(ErrorMessage = "Invalid phone number")]
        [StringLength(16, ErrorMessage = "Phone number must be up to 16 characters")]
        public string Phone_Number { get; set; }

    }
}
