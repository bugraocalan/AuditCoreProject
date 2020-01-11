using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class SurveyDetails:IEntity
    {
        public int Id { get; set; }
        public int SurveyMasterId { get; set; }
        public string QuestionText { get; set; }
        public int MaxScore { get; set; }
        public int Score { get; set; }
        public bool IsOutOfScope { get; set; }
        public string DeviceUUID { get; set; }
        public int DeviceMasterId { get; set; }
        public int DeviceId { get; set; }

    }
}
