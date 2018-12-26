using Models;
using Repository.EF.Basic;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Repository.EF
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
