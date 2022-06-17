using BrothersCarMovers.Data.Repositories;
using BrothersCarMovers.Domain.Interfaces;
using BrothersCarMovers.Mapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrothersCarMovers.IoC
{
    public class DependancyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Mapper
            services.AddTransient<IUserService, UserRepository>();

            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfiles());
            });
            var mapper = config.CreateMapper();

            services.AddSingleton(mapper);

            #endregion
        }
    }
}
