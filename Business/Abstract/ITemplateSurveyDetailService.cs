using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITemplateSurveyDetailService
    {
        IDataResult<List<TemplateSurveyDetails>> GetListbyMasterId(int MasterId);

    }
}
