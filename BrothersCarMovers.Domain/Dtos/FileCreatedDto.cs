using BrothersCarMovers.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCarMovers.Domain.Dtos
{
    public class FileCreatedDto
    {
        
        public string FileName { get; set; }
        public string OnlineFileName { get; set; }
        public bool? IsUploadComplete { get; set; }
        public byte[] Bytes { get; set; }
        public int CreatedByUserId { get; set; }       
        public int FileRelatedTypeId { get; set; }
       
    }
}
