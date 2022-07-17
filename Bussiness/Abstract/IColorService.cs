using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();

        IDataResult<List<Color>> GetAllByFilter(string filter);

        IResult Add(Color color);
        IResult Delete(Color color);
    }
}
