using LibraryDAL.Repositories;
using LibraryDAL.Repositories.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryDAL
{
    public static class DALServiceRegistration
    {
        public static IServiceCollection AddDalServices(this IServiceCollection services)
        {
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IBookAuthorsRepository, BookAuthorsRepository>();

            return services;
        }
    }
}
