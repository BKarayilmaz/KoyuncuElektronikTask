using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoyuncuElektronikTask.Data.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public bool IsDeleted { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
