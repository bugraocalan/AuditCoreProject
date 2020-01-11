using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SurveyDetailImages : IEntity
    {
        public int Id { get; set; }
        public int SurveyDetailId { get; set; }
        public byte[] ImageBin { get; set; }
        public string DeviceUUID { get; set; }
        public int DeviceDetailId { get; set; }
        public int DeviceId { get; set; }
    }
}
