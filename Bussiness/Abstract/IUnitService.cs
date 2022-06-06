using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IUnitService
    {
        IDataResult<List<Unit>> GetAll();
        IDataResult<List<Unit>> GetAllByFilter(string filter);

        IDataResult<Unit> GetById(int id);

        IResult Add(Unit unit);
        IResult Update(Unit unit);
        IResult Delete(Unit unit);
    }
}
