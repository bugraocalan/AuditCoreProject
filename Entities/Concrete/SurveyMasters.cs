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
        public int CustomerId { get; set; }
        public string DeviceUUID { get; set; }
        public int DeviceID { get; set; }
        public int AuditorId { get; set; }
        public Nullable<DateTime> AuditStartDate { get; set; }
        public Nullable<DateTime> AuditEndDate { get; set; }
        public string CompanyOfficial { get; set; }
        public byte[] CompanyOfficialSignature { get; set; }

    }
}
