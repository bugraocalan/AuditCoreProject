using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AuditManager : IAuditService
    {
        private ISurveyDetailDal surveyDetailDal;
        private ISurveyMasterDal surveyMasterDal;
        private ITemplateSurveyDetailDal templateSurveyDetailDal;
        private ITemplateSurveyMasterDal templateSurveyMasterDal;


        public AuditManager(ISurveyDetailDal _surveyDetailDal, ISurveyMasterDal _surveyMasterDal, ITemplateSurveyDetailDal _templateSurveyDetailDal, ITemplateSurveyMasterDal _templateSurveyMasterDal)
        {
            surveyDetailDal = _surveyDetailDal;
            surveyMasterDal = _surveyMasterDal;
            templateSurveyMasterDal = _templateSurveyMasterDal;
            templateSurveyDetailDal = _templateSurveyDetailDal;
        }
        public IResult CreateSurveyMaster(SurveyStartInfoDto dto, DeviceDto Devicedto)
        {
            surveyMasterDal.Add(new SurveyMasters() { 
             // TODO: Get User Info 
                //AuditorId=,
                CompanyOfficial=dto.CompanionName,
                AuditStartDate=dto.AuditDate,
                CustomerId=dto.CustomerId,
                TemplateSurveyMasterId=dto.TemplateMasterId,
                DeviceID=Devicedto.DeviceId,
                DeviceUUID=Devicedto.DeviceUUID
            });


            throw new NotImplementedException();
        }

        public IResult FinishSurvey(SurveyFinishInfoDto dto)
        {
            throw new NotImplementedException();
        }

        public IResult SyncDevice(SurveySyncDto dto)
        {
            throw new NotImplementedException();
        }

        public IResult UpdateSurveyMasterByStartInfo(SurveyStartInfoDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
