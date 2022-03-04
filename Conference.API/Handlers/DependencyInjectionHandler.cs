using Conference.BL.Repositories;
using Conference.BL.Repositories.Implements;
using Conference.BL.Services;
using Conference.BL.Services.Implements;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.API.Handlers
{
    public class DependencyInjectionHandler
    {
        public static void AddScoped(IServiceCollection services)
        {
            services.AddScoped<ITalkService, TalkService>();
            //services.AddScoped<IGenericService, GenericService>();
            services.AddScoped<IAttendeeService, AttendeeService>();
            services.AddScoped<ISpeakerService, SpeakerService>();

            services.AddScoped<ITalkRepository, TalkRepository>();
            //services.AddScoped<IGenericService, GenericService>();
            services.AddScoped<IAttendeeRepository, AttendeeRepository>();
            services.AddScoped<ISpeakerRepository, SpeakerRepository>();
        }
    }
}
