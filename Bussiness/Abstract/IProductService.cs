using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IProductService
    {
       IDataResult<List<Product>> GetAll();
       IDataResult<Product> GetByBarcode(string barcode);
       IResult Add(Product product);
       IResult Update(Product product);
       IResult Delete(Product product);

        IDataResult<List<ProductDetailDto>> GetAllProductDetail();
    }
}
