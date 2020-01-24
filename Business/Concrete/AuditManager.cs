using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Business.Constants;
using System.Linq;

namespace Business.Concrete
{
    public class AuditManager : IAuditService
    {
        private ISurveyDetailDal surveyDetailDal;
        private ISurveyMasterDal surveyMasterDal;
        private ITemplateSurveyDetailDal templateSurveyDetailDal;
        private ITemplateSurveyMasterDal templateSurveyMasterDal;
        private ISurveyDetailService surveyDetailService;
        private ISurveyMasterService surveyMasterService;


        public AuditManager(ISurveyDetailDal _surveyDetailDal, ISurveyMasterDal _surveyMasterDal, ITemplateSurveyDetailDal _templateSurveyDetailDal, ITemplateSurveyMasterDal _templateSurveyMasterDal, ISurveyDetailService _surveyDetailService, ISurveyMasterService _surveyMasterService)
        {
            surveyDetailDal = _surveyDetailDal;
            surveyMasterDal = _surveyMasterDal;
            templateSurveyMasterDal = _templateSurveyMasterDal;
            templateSurveyDetailDal = _templateSurveyDetailDal;
            surveyDetailService = _surveyDetailService;
            surveyMasterService = _surveyMasterService;
        }

        public IResult CreateSurvey(AuditStartInfoDto dto, DeviceDto deviceDto)
        {
            if (!surveyMasterService.IsExist(deviceDto).Success) return new ErrorResult(Messages.AuditMasterAlreadyExist);
            SurveyMasters master = new SurveyMasters()
            {
                // TODO: Get User Info 
                //AuditorId=,
                CompanyOfficial = dto.CompanionName,
                AuditStartDate = dto.AuditDate,
                CustomerId = dto.CustomerId,
                TemplateSurveyMasterId = dto.TemplateMasterId,
                DeviceID = deviceDto.DeviceId,
                DeviceUUID = deviceDto.DeviceUUID

            };
            int MasterId = surveyMasterDal.Add(master);
            if (MasterId < 0) return new ErrorResult(Messages.AuditMasterSaveError);
            List<SurveyDetails> surveyDetails = templateSurveyDetailDal.GetList(x => x.TemplateSurverMasterId == dto.TemplateMasterId).Select(s => new SurveyDetails
            {
                DeviceMasterId = deviceDto.DeviceId,
                DeviceUUID = deviceDto.DeviceUUID,
                SurveyMasterId = MasterId
            }).ToList();
            if (!surveyDetails.Any()) return new ErrorResult(Messages.AuditDetailsNotFound);
            surveyDetailDal.AddRange(surveyDetails);
            return new SuccessDataResult<AuditDto>(new AuditDto() { surveyMaster = master, surveyDetails = surveyDetails }, Messages.AuditAdded);
        }

       

        public IResult FinishSurvey(SurveyFinishInfoDto dto)
        {
            SurveyMasters surveyMaster = surveyMasterDal.Get(x => x.Id == dto.MasterId);
            if (surveyMaster == null) return new ErrorResult(Messages.AuditMasterNotFound);
            surveyMaster.CompanyOfficialSignature = dto.ComponionSigniture;
            surveyMaster.AuditEndDate = dto.AuditEndDate;
            surveyMasterDal.Update(surveyMaster);
            return new SuccessDataResult<SurveyMasters>(surveyMaster, Messages.AuditEndSuccessful);
        }

        public IResult SyncDevice(SurveySyncDto dto)
        {
            throw new NotImplementedException();
        }

        public IResult UpdateSurveyMasterByStartInfo(AuditStartInfoDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
