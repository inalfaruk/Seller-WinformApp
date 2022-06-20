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
    public class ShortcutManager : IShortcutService
    {
        IShortcutDal _shortcutdal;

        public ShortcutManager(IShortcutDal shortcutdal)
        {
            _shortcutdal = shortcutdal;
        }

        public IDataResult<List<Shortcut>> GetAll()
        {
            return new SuccessDataResult<List<Shortcut>>(_shortcutdal.GetAll());
        }

        public IDataResult<List<ShortcutDetailDto>> GetAllDetails()
        {
            return new SuccessDataResult<List<ShortcutDetailDto>>(_shortcutdal.GetShortcutDetails());
        }
    }
}
