using BrothersCarMovers.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BrothersCarMovers.Entities
{
    public class Vehicle  : BaseSyncEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int MakeID { get; set; }
        public int ModelId { get; set; }
        public string Licence { get; set; }
    }
}
