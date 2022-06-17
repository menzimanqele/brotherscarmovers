using BrothersCarMovers.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCarMovers.Domain.Interfaces
{
    public interface IUserService
    {
        void AddUser(User user);
    }
}
