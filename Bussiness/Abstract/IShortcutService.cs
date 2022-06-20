using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public  interface IShortcutService
    {
        IDataResult<List<Shortcut>> GetAll();

        IDataResult<List<ShortcutDetailDto>> GetAllDetails();
    }
}
