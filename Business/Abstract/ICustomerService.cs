using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<Customers> GetById(int customerId);
        IDataResult<List<Customers>> GetList();
    }
}
