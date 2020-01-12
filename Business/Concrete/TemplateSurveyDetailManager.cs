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
    public class TemplateSurveyDetailManager : ITemplateSurveyDetailService
    {
        private ITemplateSurveyDetailDal templateSurveyDetailDal;
        public TemplateSurveyDetailManager(ITemplateSurveyDetailDal _templateSurveyDetailDal)
        {
            templateSurveyDetailDal = _templateSurveyDetailDal;
        }
        public IDataResult<List<TemplateSurveyDetails>> GetListbyMasterId(int MasterId)
        {
            return new SuccessDataResult<List<TemplateSurveyDetails>>(templateSurveyDetailDal.GetList(x=>x.TemplateSurverMasterId==MasterId).ToList());
        }
    }
}
