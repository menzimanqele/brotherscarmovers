using BrothersCarMovers.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCarMovers.Entities
{
    public class Employee : BaseSyncEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ImageID { get; set; }
        public int JobTitleId { get; set; }
        public JobTitle JobTitle { get; set; }
    }
}
