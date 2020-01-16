using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAuditService
    {
     

        IResult CreateSurvey(SurveyStartInfoDto dto, DeviceDto deviceDto);
        IResult UpdateSurveyMasterByStartInfo(SurveyStartInfoDto dto);
        IResult FinishSurvey(SurveyFinishInfoDto dto);
        IResult SyncDevice(SurveySyncDto dto);

    }
}
