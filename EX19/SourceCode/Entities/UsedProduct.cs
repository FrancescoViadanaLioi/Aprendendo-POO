using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using EX19.Controllers;

namespace EX19.Entities
{
    internal sealed class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; private set; }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }
        public override string PriceTag()
        {
            return $"{Name} (used): ${Formatter.Format(Price)} (Manufacture Date: {ManufactureDate.ToString("dd/MM/yyyy")}";
        }
    }
}
