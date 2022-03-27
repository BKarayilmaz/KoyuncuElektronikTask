using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KoyuncuElektronikTask.Data.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "This field cannot be null.")]
        [StringLength(30, ErrorMessage = "Only 4-30 characters can be used in this field.", MinimumLength = 4)]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "This field cannot be null.")]
        public string CategoryDescription { get; set; }
        public bool IsDeleted { get; set; }
        public List<Product> Products { get; set; }
    }
}
