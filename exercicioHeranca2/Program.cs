using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHeranca2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int num = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();

            for(int i=0; i<num; i++)
            {
                Console.WriteLine("\nProduct #"+(i+1)+" data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                string aux = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                string producttype = aux.ToLower();

                if(producttype == "i")
                {
                    Console.Write("Customs fee: ");
                    double cf = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(name, price, cf));
                }
                else if(producttype == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime mdate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct (name, price, mdate));
                }
                else
                {
                    products.Add(new Product(name, price));
                }

            }

            Console.WriteLine("\nPRICE TAGS:");

            foreach(Product p in products)
            {
                Console.WriteLine(p.Pricetag());
            }

            Console.ReadLine();
        }
    }
}
