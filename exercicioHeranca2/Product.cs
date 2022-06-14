using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHeranca2
{
    public class Product
    {
        public string Name { get; set; }    
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string Pricetag()
        {
            return Name + " $" + Price.ToString("F2");
        }
    }
}
