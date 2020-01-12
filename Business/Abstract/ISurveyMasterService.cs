using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISurveyMasterService
    {
        IDataResult<List<SurveyMasters>> GetListByCustomerId(int CustomerId);
        IDataResult<List<SurveyMasters>> GetList();
        IDataResult<SurveyMasters> GetByDeviceInfo(DeviceDto dto);
        IResult IsExist(DeviceDto dto);
        
    }
}
