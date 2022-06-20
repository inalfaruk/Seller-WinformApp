using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; } 
        public string? StockCode { get; set; }
        public string Barcode { get; set; } 
        public string? ProductName { get; set; } 

        public int CategoryId { get; set; } 

        public int UnitId { get; set; } 

        public int BrandId { get; set; } 

        public int ColorId { get; set; } 

        public decimal PurchasePrice { get; set; } 

        public decimal SalesPrice { get; set; } 

        public string? SpecialCode { get; set; } 

        public string? SpecialCode2 { get; set; } 

         public decimal Quantity { get; set; }
        public decimal? CriticalQuantity { get; set; } 

        public decimal? Vat { get; set; } 

        public decimal? Discount { get; set; } 

        public string? Description { get; set; }

        public string? ImgPath { get; set; }

        public bool Active { get; set; } 





    }
}
