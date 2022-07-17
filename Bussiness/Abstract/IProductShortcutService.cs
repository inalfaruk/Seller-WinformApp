using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public  interface IProductShortcutService
    {
        IDataResult<List<ProductShortcut>> GetAll();

        IDataResult<List<ShortcutDetailDto>> GetAllDetails();
        IResult Add(ProductShortcut shortcut);

        IResult Delete(ProductShortcut shortcut);
    }
}
