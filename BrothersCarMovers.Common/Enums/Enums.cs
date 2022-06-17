using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BrothersCarMovers.Common.Enums
{
    public class Enums
    {
    }


    public enum RoleEnum
    {
        [Description("Driver")] Monday = 1,
        [Description("Client")] Tuesday = 2,
        [Description("Admin")] Wednesday = 3,
        [Description("Management")] Thursday = 4,
       
    }
}
