using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITemplateSurveyMasterService
    {
        IDataResult<List<TemplateSurveyMasters>> GetList();
        IDataResult<TemplateSurveyMasters> GetById(int TemplateMasterId);
        

    }
}
