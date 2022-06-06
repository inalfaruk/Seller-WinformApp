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
    public interface IOrderDetailService
    {

        IDataResult<List<OrderDetailDto>> GetOrdersDetails();
        IResult Add(OrderDetail orderDetail);
    }
}
