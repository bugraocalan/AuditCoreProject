using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public static class DbStatus
    {
        public enum DbStatusEnum
        {
           Deleted=2,
           Updated=1,
           Active=0,
        }

    }
}
