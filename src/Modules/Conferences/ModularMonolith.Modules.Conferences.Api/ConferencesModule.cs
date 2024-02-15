using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

[assembly:InternalsVisibleTo("ModularMonolith.Bootstrapper")]
namespace ModularMonolith.Modules.Conferences.Api;

internal static class ConferencesModule
{
    public static IServiceCollection AddConferencesModule(this IServiceCollection service)
    {
        return service;
    }

    public static IApplicationBuilder UseConferencesModule(this IApplicationBuilder app)
    {
        return app;
    }
}