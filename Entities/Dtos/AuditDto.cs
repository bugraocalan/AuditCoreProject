using Core.Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class AuditDto : IDto
    {
        public SurveyMasters surveyMaster { get; set; }
        public List<SurveyDetails> surveyDetails { get; set; }
    }
}
