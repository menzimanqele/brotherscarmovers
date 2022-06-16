using BrothersCarMovers.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCarMovers.Entities
{
    public class JobTitle : BaseSyncEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Employee> Employee { get; set; }
    }
}
