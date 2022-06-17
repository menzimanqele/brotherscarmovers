using BrothersCarMovers.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BrothersCarMovers.Entities
{
    public class File : BaseSyncEntity
    {
        [Required]

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string FileName { get; set; }
        [Required]
        public string OnlineFileName { get; set; }
        public bool? IsUploadComplete { get; set; }
        public int CreatedByUser { get; set; }
        public User Employee { get; set; }
        public int FileRelatedTypeId { get; set; }
        public FileRelatedType FileRelated { get; set; }
    }
}
