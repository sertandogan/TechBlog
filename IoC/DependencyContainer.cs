using Application.Interfaces;
using Application.Services;
using DataStore;
using DataStore.Repository;
using Domain.CommandHandlers;
using Domain.Commands;
using Domain.Interfaces;
using Infrastructure.Bus;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain InMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handlers
            services.AddScoped<IRequestHandler<CreateCategoryCommand, bool>, CreateCategoryCommandHandler>();

            //Application Layer 
            services.AddScoped<ICategoryService, CategoryService>();

            //Infra.Data Layer
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<TechBlogDbContext>();
        }
    }
}
