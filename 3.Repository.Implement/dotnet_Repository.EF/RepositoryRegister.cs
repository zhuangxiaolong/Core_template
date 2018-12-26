using dotnet_Models;
using dotnet_Repository.EF.Basic;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_Repository.EF
{
    public static class RepositoryRegister
    {
        public static void RegistRepository(this IServiceCollection services)
        {
            services.AddScoped<IRepository<MusicInfo, int>, MusicRepository>();
            services.AddScoped<IRepository<UserInfo, int>, UserRepository>();
        }
    }
}
