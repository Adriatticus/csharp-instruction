using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_array_vs_list_vs_arraylist_demo
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product(int ProductID, string Code, string Description, decimal Price)
        {
            this.ProductID = ProductID;
            this.Code = Code;
            this.Description = Description;
            this.Price = Price;
        }

        public override string ToString()
        {
            return $"Product: {ProductID}|{Code}|{Description}|{Price:c}";
        }
    }
}
