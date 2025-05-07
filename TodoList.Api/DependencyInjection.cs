using Microsoft.AspNetCore.Mvc.Infrastructure;
using TodoList.Api.Common.Errors;
using TodoList.Api.Common.Mapping;

namespace TodoList.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory, TodoListProblemDetailsFactory>();

        services.AddMappings();

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }
}
