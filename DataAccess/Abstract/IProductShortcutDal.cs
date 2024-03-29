﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductShortcutDal :IEntityRepository<ProductShortcut>
    {

        public List<ShortcutDetailDto> GetShortcutDetails(Expression<Func<ShortcutDetailDto, bool>> filter = null);
    }
}
