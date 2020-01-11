using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
   public class DeviceDto:IDto
    {
        public string DeviceUUID { get; set; }
    }
}
