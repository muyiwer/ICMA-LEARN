using IcmaLearn.Repository.Interface;
using IcmaLearn.Repository.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace IcmaLearn.Business
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddIcmaLearnApplicationServices(this IServiceCollection services)
        {
            // AppService services
            services.AddScoped<ICourseService, CourseService>();

            //services.AddTransient<IRoleAppService, RolepcmAppService>();


            // repositories services
          //  services.AddManagementCoreRepositories();


            return services;
        }
    }
}
