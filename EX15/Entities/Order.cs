using EX15.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX15.Entities
{
    internal class Order
    {
        public string Id { get; private set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public Order(string id, DateTime moment, OrderStatus status)
        {
            if (id == null || id.Length != 5 || !id.All(char.IsLetterOrDigit)) throw new ArgumentException("Esse ID é inválido.");

            Id = id;
            Moment = moment;
            Status = status;
        }
    }
}
