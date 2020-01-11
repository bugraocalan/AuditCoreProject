using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customers : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
    }
}
