using BrothersCarMovers.Data.Context;
using BrothersCarMovers.Domain.Interfaces;
using BrothersCarMovers.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCarMovers.Data.Repositories
{
    public class UserRepository : IUserService
    {
        private readonly BrothersCarMoversDataContext _context;
        public UserRepository(BrothersCarMoversDataContext brothersCarMoversDataContext)
        {
            _context = brothersCarMoversDataContext;
        }
        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
