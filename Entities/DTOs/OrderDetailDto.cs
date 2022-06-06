using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public  class OrderDetailDto : IDto

    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public int OrderDetailId { get; set; }


        public decimal UnitPrice { get; set; }

        public decimal Quantity { get; set; }

        public string UnitName { get; set; }
       
        public decimal Total { get; set; }

    }
}
