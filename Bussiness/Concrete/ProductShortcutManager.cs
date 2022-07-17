using Bussiness.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class ProductShortcutManager : IProductShortcutService
    {
        IProductShortcutDal _shortcutdal;

        public ProductShortcutManager(IProductShortcutDal shortcutdal)
        {
            _shortcutdal = shortcutdal;
        }

        public IResult Add(ProductShortcut shortcut)
        {
            _shortcutdal.Add(shortcut);
            return new SuccessResult(); 
        }

        public IResult Delete(ProductShortcut shortcut)
        {
            _shortcutdal.Delete(shortcut);
            return new SuccessResult();
        }

        public IDataResult<List<ProductShortcut>> GetAll()
        {
            return new SuccessDataResult<List<ProductShortcut>>(_shortcutdal.GetAll());
        }

        public IDataResult<List<ShortcutDetailDto>> GetAllDetails()
        {
            return new SuccessDataResult<List<ShortcutDetailDto>>(_shortcutdal.GetShortcutDetails());
        }
    }
}
