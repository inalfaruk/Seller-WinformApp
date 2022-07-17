using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Order : IEntity
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public bool Status { get; set; }

        public string Description { get; set; }

        public decimal Total { get; set; }

        public string PaymentType { get; set; }
       // public bool OrderType { get; set; }
    }
}
