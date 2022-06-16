using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCarMovers.Entities.Base
{
    public class BaseSyncEntity : BaseEntity
    {
        public bool? IsNew { get; set; }
  
        public bool? IsSynced { get; set; }
       
        public Guid? LastSyncClient { get; set; }
       
        public DateTime? LastSyncDateTime { get; set; }
       
        public DateTime? CreateDateTime { get; set; }
       
        public DateTime? ModifiedDateTime { get; set; }
       
        public bool? IsCurrent { get; set; }
    }
}
