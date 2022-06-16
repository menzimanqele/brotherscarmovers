using BrothersCarMovers.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCarMovers.Entities
{
    public class VehicleManufacture : BaseSyncEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int VehicleModelId { get; set; }
        public ICollection<VehicleModel> VehicleModel { get; set; }
    }
}
