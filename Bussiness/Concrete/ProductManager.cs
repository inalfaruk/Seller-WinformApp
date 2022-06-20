using Bussiness.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class ProductManager : IProductService
    {

        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult();
        }

        public IResult Delete(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult();


        
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll());
        }

        public IDataResult<List<ProductDetailDto>> GetAllProductDetail()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }

        public IDataResult<Product> GetByBarcode(string barcode)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.Barcode == (barcode)));

           
        }

       

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult();
          
        }

        IDataResult<List<ProductDetailDto>> IProductService.GetAllByProductName(string productName)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails(p => p.ProductName.StartsWith(productName)));
        }
    

        public IDataResult<List<ProductDetailDto>> GetAllByBarcode(string barcode)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails(p => p.Barcode.StartsWith(barcode)));
        }

        public IDataResult<List<ProductDetailDto>> GetAllByStockCode(string stockCode)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails(p => p.StockCode.StartsWith(stockCode)));
        }

        public IDataResult<List<ProductDetailDto>> GetAllByBrand(string brand)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails(p => p.BrandName.StartsWith(brand)));
        }

        public IDataResult<List<ProductDetailDto>> GetAllByCategory(string category)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails(p => p.CategoryName.StartsWith(category)));
        }

        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == (id)));
        }
    }
}
