using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, StockDbContext>,IProductDal
    {
        public List<ProductDetailDto> GetProductDetails(Expression<Func<ProductDetailDto, bool>> filter=null)
        {
            using (StockDbContext context = new StockDbContext())
            {
                var result = from p in context.Products
                             join b in context.Brands on p.BrandId equals b.BrandId
                             join c in context.Categories on p.CategoryId equals c.CategoryId into joincategories
                             from jc in joincategories.DefaultIfEmpty()

                             join u in context.Units on p.UnitId equals u.UnitId into joinunit
                             from ju in joinunit.DefaultIfEmpty()

                             join cl in context.Colors on p.ColorId equals cl.ColorId into joincolor
                             from jcl in joincolor.DefaultIfEmpty()
                             

                             select new ProductDetailDto
                             {
                                 StockCode = p.StockCode,
                                 ProductName = p.ProductName,
                                 Barcode = p.Barcode,
                                 BrandName = b.BrandName,
                                 ColorName = jcl.ColorName == null ? null : (jcl.ColorName ?? null),
                                 UnitName = ju.UnitName == null ? null : (ju.UnitName ?? null),
                                 CategoryName = jc.CategoryName == null ? null : (jc.CategoryName ?? null),
                                 PurchasePrice = p.PurchasePrice,
                                 SalePrice = p.SalePrice,
                                 Description = p.Description,
                                 Discount = p.Discount,
                                 Vat = p.Vat,
                                 CriticalQuantity = p.CriticalQuantity,
                                 SpecialCode = p.SpecialCode,
                                 SpecialCode2 = p.SpecialCode2,
                                 ImgPath = p.ImgPath,
                                 Active = p.Active,
                                 ProductId = p.ProductId,
                                 BrandId = p.BrandId,
                                 ColorId = p.ColorId,/*jcl.ColorId == null ? 0 : jcl.ColorId ?? 0,*/
                                 UnitId = p.UnitId,/* ju.UnitId == null ? 0 : ju.UnitId ?? 0,*/
                                 CategoryId = p.CategoryId,
                                 Quantity = p.Quantity
                             };

                return filter == null
                 ? result.ToList()
                 : result.Where(filter).ToList();
            }
            
            
         
          


        }

       
    }
}
