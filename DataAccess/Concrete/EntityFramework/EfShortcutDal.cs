using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfShortcutDal : EfEntityRepositoryBase<Shortcut, StockDbContext>, IShortcutDal
    {

        public List<ShortcutDetailDto> GetShortcutDetails(Expression<Func<ShortcutDetailDto, bool>> filter = null)
        {
            using (StockDbContext context = new StockDbContext())
            {
                var result = from s in context.Shortcuts
                             join p in context.Products on s.ProductId equals p.ProductId

                             select new ShortcutDetailDto
                             {
                                 ShortcutId = s.ShortcutId,
                                 ProductId = s.ProductId,
                                 Barcode = p.Barcode,
                                 ProductName = p.ProductName

                             };

                return filter == null 
                    ? result.ToList() 
                    : result.Where(filter).ToList();

            }
        }

    }
}
