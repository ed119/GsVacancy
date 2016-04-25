using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GsVacancy.BLL.Auth;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


using GsVacancy.BLL.Services;

namespace GsVacancy.BLL
{
    public class ContainerInstructor
    {
        public void Instruct(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            var dalInstructor = new GsVacancy.DAL.ContainerInstructor();
            dalInstructor.Instructor(serviceCollection, configuration);
            //serviceCollection.Add(new ServiceDescriptor(typeof(IAuth), typeof(Auth.Auth), ServiceLifetime.Transient));
            serviceCollection.AddTransient<IAuth, Auth.Auth>();
            serviceCollection.AddTransient<IEmailSender, MessageServices>();
            serviceCollection.AddTransient<ISmsSender, MessageServices>();
        }
    }
}
