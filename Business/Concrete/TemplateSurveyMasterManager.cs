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
    public class TemplateSurveyMasterManager : ITemplateSurveyMasterService
    {
        private ITemplateSurveyMasterDal templateSurveyMasterDal;
        public TemplateSurveyMasterManager(ITemplateSurveyMasterDal _templateSurveyMasterDal)
        {
            templateSurveyMasterDal = _templateSurveyMasterDal;
        }
        public IDataResult<TemplateSurveyMasters> GetById(int TemplateMasterId)
        {
            return new SuccessDataResult<TemplateSurveyMasters>(templateSurveyMasterDal.Get(x => x.Id == TemplateMasterId));
        }

        public IDataResult<List<TemplateSurveyMasters>> GetList()
        {
            return new SuccessDataResult<List<TemplateSurveyMasters>>(templateSurveyMasterDal.GetList().ToList());
        }
    }
}
