using Core.Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class SurveySyncDto : IDto
    {
        public SurveyMasters Master { get; set; }
        public List<SurveyDetails> Details { get; set; }
        public List<SurveyDetailImages> SurveyDetailImages { get; set; }
    }
}
