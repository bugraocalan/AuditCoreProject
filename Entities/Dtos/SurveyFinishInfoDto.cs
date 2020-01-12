using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class SurveyFinishInfoDto:IDto
    {
        public int MasterId { get; set; }
        public byte[] ComponionSigniture { get; set; }
        public DateTime AuditEndDate { get; set; }
    }
}
