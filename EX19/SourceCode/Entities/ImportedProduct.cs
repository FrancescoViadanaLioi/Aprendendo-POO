using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using EX19.Controllers;

namespace EX19.Entities
{
    internal sealed class ImportedProduct : Product
    {
        public double CustomFee { get; private set; }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }
        public double TotalPrice()
        {
            return Price + Price * CustomFee;
        }
        public override string PriceTag()
        {
            double totalPrice = TotalPrice();
            return $"{Name} (imported): ${Formatter.Format(totalPrice)} (custom fee: ${Formatter.Format(CustomFee * Price)})";
        }
    }
}
