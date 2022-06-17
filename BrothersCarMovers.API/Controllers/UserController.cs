
using BrothersCarMovers.Common.ViewModels;
using BrothersCarMovers.Domain.Interfaces;
using BrothersCarMovers.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrothersCarMovers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly AutoMapper.IMapper mapper;

        private static readonly string[] Summaries = new[]
       {
            "Freezingxxxx", "Bracingxxxx", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public UserController(IUserService userService, AutoMapper.IMapper mapper)
        {
            this.userService = userService;
            this.mapper = mapper;
        }


        [HttpPost("AddNewUser")]
        public async Task<int> Add(UserVM user)
        {
            var model = mapper.Map<User>(user);
            userService.AddUser(model);
            return 0;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new System.Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
