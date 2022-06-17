using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCarMovers.Entities
{
    public class UserFile
    {
        public File FileId { get; set; }
        public File File { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
