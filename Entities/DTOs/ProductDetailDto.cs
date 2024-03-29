﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ProductDetailDto : IDto
    {
        public int ProductId { get; set; }
        public string? StockCode { get; set; }
        public string Barcode { get; set; }
        public string ProductName { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public int UnitId { get; set; }
        public string UnitName { get; set; }

        public int BrandId { get; set; }
        public string BrandName { get; set; }

        public int? ColorId { get; set; }
        public string? ColorName { get; set; }

        public decimal? PurchasePrice { get; set; }

        public decimal SalePrice { get; set; }

        public string? SpecialCode { get; set; }

        public string? SpecialCode2 { get; set; }

        public decimal? CriticalQuantity { get; set; }

        public decimal? Vat { get; set; }

        public decimal? Discount { get; set; }

        public string? Description { get; set; }

        public string? ImgPath { get; set; }

        public bool Active { get; set; }
        public decimal Quantity { get; set; }

    }
}
