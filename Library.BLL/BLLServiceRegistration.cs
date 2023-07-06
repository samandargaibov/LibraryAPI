using Library.BLL.Services.Contracts;
using Library.BLL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Library.BLL
{
    public static class BLLServiceRegistration
    {
        public static IServiceCollection AddBllServices(this IServiceCollection services)
        {
            services.AddScoped<IBookService, BookManager>();
            services.AddScoped<IAuthorService, AuthorManager>();
            services.AddScoped<IBookAuthorService, BookAuthorManager>();

            return services;
        }
    }
}
