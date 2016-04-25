using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GsVacancy.DAL.Models;

using Microsoft.Data.Entity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GsVacancy.DAL
{
    public class ContainerInstructor
    {
        public void Instructor(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            //SqlServerDbContextOptionsExtensions
            serviceCollection.AddEntityFramework()
                .AddSqlServer()
                .AddDbContext<AppDbContext>(options =>
                {
                    options.UseSqlServer(configuration["Data:ConnectionString"]);

                });
        }
    }
}
