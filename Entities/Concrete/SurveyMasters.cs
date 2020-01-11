using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SurveyMasters:IEntity
    {
        public int Id { get; set; }
        public int TemplateSurveyMasterId { get; set; }
        public string Question { get; set; }
        public int MaxScore { get; set; }

    }
}
