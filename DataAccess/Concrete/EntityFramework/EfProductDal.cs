using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, StockDbContext>,IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (StockDbContext context = new StockDbContext())
            {
                var result = from p in context.Products
                            join b in context.Brands on p.BrandId equals b.BrandId 
                            join c in context.Categories on p.CategoryId equals c.CategoryId
                            join u in context.Units on p.UnitId equals u.UnitId into joinunit
                            from ucl in joinunit.DefaultIfEmpty()
                            join cl in context.Colors on p.ColorId equals cl.ColorId into joincolor  
                            from jcl in joincolor.DefaultIfEmpty()






                             select new ProductDetailDto
                             {
                                 StockCode=p.StockCode,                                
                                 ProductName = p.ProductName,
                                 Barcode = p.Barcode,
                                 BrandName = b.BrandName,
                                 ColorName = jcl.ColorName == null ? null : (jcl.ColorName??null),
                                 
                                 UnitName = ucl.UnitName == null ? null: (ucl.UnitName??null),
                                 CategoryName =c.CategoryName,                                 
                                 PurchasePrice = p.PurchasePrice,
                                 SalesPrice =p.SalesPrice,
                                 Description=p.Description,
                                 Discount=p.Discount,  
                                 Vat=p.Vat,
                                 CriticalQuantity = p.CriticalQuantity,
                                 SpecialCode =p.SpecialCode,
                                 SpecialCode2=p.SpecialCode2,
                                 ImgPath=p.ImgPath,
                                 Active=p.Active,
                                 ProductId = p.ProductId,
                                 BrandId = p.BrandId,
                                 ColorId=jcl.ColorId == null ? 0 : jcl.ColorId ?? 0,
                                 UnitId = ucl.UnitId == null ? 0 : ucl.UnitId ?? 0,
                                 CategoryId = p.CategoryId,
                             };

                return result.ToList();
            }
            
            
         




        }
    }
}
