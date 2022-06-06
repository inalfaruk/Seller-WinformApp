using Core.DataAccess;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public  interface IBrandService 
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<List<Brand>> GetAllByFilter(string filter);
        IResult Add(Brand brand);
        IResult Delete(Brand brand);
        IResult Update(Brand brand);
        
    }
}
