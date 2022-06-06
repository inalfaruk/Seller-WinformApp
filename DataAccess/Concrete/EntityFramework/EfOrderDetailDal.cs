using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDetailDal : EfEntityRepositoryBase<OrderDetail,StockDbContext>,IOrderDetailDal
    {
        public List<OrderDetailDto> GetOrdersDetails()
        {
            using (StockDbContext context = new StockDbContext())
            {
                var result = from o in context.OrderDetails 
                             join p in context.Products on o.ProductId equals p.ProductId
                             join u in context.Units on p.UnitId equals u.UnitId
                             select new OrderDetailDto 
                             {
                                 

                                ProductId=o.ProductId,
                               
                                OrderDetailId=o.OrderDetailId,
                                Quantity=o.Quantity,
                                UnitName=u.UnitName,
                                ProductName= p.ProductName,                              
                                UnitPrice=p.SalesPrice,
                                Total=o.Quantity*o.UnitPrice
                                
                                 
                             };
                return result.ToList();
            }
        }
    }
}
