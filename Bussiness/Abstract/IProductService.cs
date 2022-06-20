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
       IDataResult<Product> GetById(int id);
        IDataResult<List<ProductDetailDto>> GetAllByProductName(string productName);
       IDataResult<List<ProductDetailDto>>GetAllByBarcode(string barcode);
       
        IDataResult<List<ProductDetailDto>> GetAllByStockCode(string stockCode);

       IDataResult<List<ProductDetailDto>> GetAllByBrand(string brand);

       IDataResult<List<ProductDetailDto>> GetAllByCategory(string category);

        IResult Add(Product product);
       IResult Update(Product product);
       IResult Delete(Product product);

        IDataResult<List<ProductDetailDto>> GetAllProductDetail();



      
    }
}
