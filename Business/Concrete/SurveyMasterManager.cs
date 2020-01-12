using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class SurveyMasterManager : ISurveyMasterService
    {
        private ISurveyMasterDal surveyMasterDal;
        public SurveyMasterManager(ISurveyMasterDal _surveyMasterDal)
        {
            surveyMasterDal = _surveyMasterDal;
        }
        public IDataResult<SurveyMasters> GetByDeviceInfo(DeviceDto dto)
        {
            return new SuccessDataResult<SurveyMasters>(surveyMasterDal.Get(x=>x.DeviceID==dto.DeviceId && x.DeviceUUID==dto.DeviceUUID));
        }

        public IDataResult<List<SurveyMasters>> GetList()
        {
            return new SuccessDataResult<List<SurveyMasters>>(surveyMasterDal.GetList().ToList());
        }

        public IDataResult<List<SurveyMasters>> GetListByCustomerId(int CustomerId)
        {
            return new SuccessDataResult<List<SurveyMasters>>(surveyMasterDal.GetList(x => x.CustomerId == CustomerId).ToList());
        }

        public IResult IsExist(DeviceDto dto)
        {
            return new Result(surveyMasterDal.Get(x => x.DeviceID == dto.DeviceId && x.DeviceUUID == dto.DeviceUUID) != null);
        }
    }
}
