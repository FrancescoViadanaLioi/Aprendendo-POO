using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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
            return $"{Name} (used): ${Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture Date: {ManufactureDate.ToString("dd/MM/yyyy")}";
        }
    }
}
