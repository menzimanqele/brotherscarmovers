﻿using BrothersCarMovers.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCarMovers.Entities
{
    public class VehicleModel : BaseSyncEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ManufactureId { get; set; }
        public VehicleManufacture VehicleManufacture { get; set; }
    }
}
