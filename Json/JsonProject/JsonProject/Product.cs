using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonProject
{
    public class Product
    {
        public string? Name { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellPrice { get; set; }
        private static int __id = 0;
        public int id { get;  private set; }
        public Product()
        {
            __id++;
            id= __id;
        }
    }
}
