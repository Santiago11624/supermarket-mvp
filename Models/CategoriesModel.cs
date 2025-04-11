using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class CategoriesModel
    {
        [DisplayName("ID Categories")]
        public int Id { get; set; }
        [DisplayName("Categories")]
        [Required(ErrorMessage = "Categories Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pay mode name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Price")]
        [Required(ErrorMessage = "Price is required.")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Categories name must be between 3 and 200 characters")]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public int Stock { get; set; }
    }
}
