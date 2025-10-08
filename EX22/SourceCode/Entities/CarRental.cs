using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EX22.Entities;

namespace EX22.Entities
{
    internal class CarRental
    {
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }
        public Vehicle Vehicle { get; private set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime end, Vehicle vehicle)
        {
            Start = start;
            End = end;
            Vehicle = vehicle;
        }
    }
}
