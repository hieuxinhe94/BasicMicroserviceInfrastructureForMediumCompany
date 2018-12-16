using Dal.Implemented;
using Dal.Implemented.Base;
using Dal.Interfaces;
using Dal.Interfaces.Base;
using Microsoft.Extensions.DependencyInjection;

namespace Middleware
{
    public static class RepositoryDependencyInjectionMiddleware
    {
        public static void RegisterRepositories(this IServiceCollection service)
        {
            service.AddSingleton(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            service.AddScoped<IProductRepository, ProductRepository>();
            service.AddScoped<IAppRepository, AppRepository>();
            service.AddScoped<ICustomerRepository, CustomerRepository>();
            service.AddScoped<IEmployeeRepository, EmployeeRepository>();
            service.AddScoped<IOrderRepository, OrderRepository>();
            service.AddScoped<IOrderStatusRepository, OrderStatusRepository>();
            service.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
            service.AddScoped<IProductModelRepository, ProductModelRepository>();
            service.AddScoped<IProductViewRepository, ProductViewRepository>();
            service.AddScoped<IUserRepositoy, UserRepositoy>();
            service.AddScoped<IVisitorRepositoy, VisitorRepositoy>();
        }
    }
}
