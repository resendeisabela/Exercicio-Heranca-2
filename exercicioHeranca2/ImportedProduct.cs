using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioHeranca2
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee)
            :base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string Pricetag()
        {
            return Name + " $ " + TotalPrice().ToString("F2") + " (Customs fee: $" + CustomsFee.ToString("F2") + ")";
        }
    }
}
