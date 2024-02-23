﻿using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace TopMovies.Web.Infrastructure.Extensions
{
    public static class WebApplicationBuilderExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services, Type serviceType)
        {
            Assembly? serviceAssembly = Assembly.GetAssembly(serviceType);

            if (serviceAssembly == null)
            {
                throw new InvalidOperationException("Invalid service type provided!");
            }

            Type[] serviceTypes = serviceAssembly
                .GetTypes()
                .Where(t => t.Name.EndsWith("Service") && !t.IsInterface)
                .ToArray();

            foreach (var service in serviceTypes)
            {
                Type? interfaceType = service
                                    .GetInterface($"I{service.Name}");

                if (interfaceType == null)
                {
                    throw new InvalidOperationException(
                        $"No interface exists for the service: {service.Name}");
                }

                services.AddScoped(interfaceType, service);
            }
        }
    }
}
