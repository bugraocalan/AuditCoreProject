using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal customerDal;
        public CustomerManager(ICustomerDal _customerDal)
        {
            customerDal = _customerDal;
        }
        public IDataResult<Customers> GetById(int customerId)
        {
            return new SuccessDataResult<Customers>(customerDal.Get(x=>x.Id==customerId));
        }
        public IDataResult<List<Customers>> GetList()
        {
            return new SuccessDataResult<List<Customers>>(customerDal.GetList().ToList());

        }
    }
}
