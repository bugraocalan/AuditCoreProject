using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISurveyDetailService
    {
        IDataResult<List<SurveyDetails>> GetListByMasterId(int MasterId);
        IDataResult<List<SurveyDetails>> GetListByDeviceMasterId(int DeviceMasterId,string DeviceUUID);
        IResult IsExist(DeviceDto dto);
    }
}
