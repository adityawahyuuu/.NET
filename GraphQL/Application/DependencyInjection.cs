using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

using graphQL.Application.Query;

namespace graphQL.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services
                .AddGraphQLServer()
                .AddQueryType<QueryGetBooks>();

            return services;
        }
    }
}
