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
    public class SurveyDetailManager : ISurveyDetailService
    {
        private ISurveyDetailDal surveyDetailDal;
        private ISurveyMasterDal surveyMasterDal;
        public SurveyDetailManager(ISurveyDetailDal _surveyDetailDal, ISurveyMasterDal _surveyMasterDal)
        {
            surveyDetailDal = _surveyDetailDal;
            surveyMasterDal = _surveyMasterDal;
        }
        public IDataResult<List<SurveyDetails>> GetListByDeviceMasterId(int DeviceMasterId, string DeviceUUID)
        {

            return new SuccessDataResult<List<SurveyDetails>>(surveyDetailDal.GetList(x => x.DeviceMasterId == DeviceMasterId && x.DeviceUUID == DeviceUUID).ToList());
        }

        public IDataResult<List<SurveyDetails>> GetListByMasterId(int MasterId)
        {
            return new SuccessDataResult<List<SurveyDetails>>(surveyDetailDal.GetList(x => x.SurveyMasterId == MasterId).ToList());
        }

        public IResult IsExist(DeviceDto dto)
        {
            return new Result(surveyDetailDal.Get(x => x.DeviceId == dto.DeviceId && x.DeviceUUID == dto.DeviceUUID) != null);
        }
    }
}
