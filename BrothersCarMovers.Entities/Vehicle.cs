using BrothersCarMovers.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCarMovers.Entities
{
    public class Vehicle  : BaseSyncEntity
    {
        public int Id { get; set; }
        public int MakeID { get; set; }
        public int ModelId { get; set; }
        public string Licence { get; set; }
    }
}
