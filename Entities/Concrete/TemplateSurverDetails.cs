using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{

    class TemplateSurverDetails:IEntity
    {
        public int Id { get; set; }
        public int TemplateSurverMasterId { get; set; }
        public string QuestionText { get; set; }
        public int Score { get; set; }

    }
}
