using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
   public class AuditStartInfoDto:IDto
    {
        public int MasterId { get; set; }
        public int TemplateMasterId { get; set; }
        public int CustomerId { get; set; }
        public string CompanionName { get; set; }

        public DateTime AuditDate { get; set; }
    }
}
