﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IOrderService
    {


        IResult Add(Order order);
        IResult Delete(Order order);
        IResult Update(Order order);
    }
}
