using Bll.Implemented;
using Bll.Interfaces;
using BLL.Implemented;
using Dal.Implemented;
using Microsoft.Extensions.DependencyInjection;

namespace Middleware
{
    public static class ServiceDependencyInjectionMiddleware
    {
        public static void RegisterServices(this IServiceCollection service)
        {
            service.AddScoped<IProductService, ProductService>();
            service.AddScoped<IAppParamBusiness, AppParamBusiness>();
            service.AddScoped<ICustomerBusiness, CustomerBusiness>();
            service.AddScoped<IEmployeeBusiness, EmployeeBusiness>();
            service.AddScoped<IOrderBusiness, OrderBusiness>();
            service.AddScoped<IOrderDetailBusiness, OrderDetailBusiness>();
            service.AddScoped<IOrderStatusBusiness, OrderStatusBusiness>();
            service.AddScoped<IProductCategoryBusiness, ProductCategoryBusiness>();
            service.AddScoped<IProductModelBusiness, ProductModelBusiness>();
            service.AddScoped<IUserBusiness, UserBusiness>();
            service.AddScoped<IProductModelBusiness, ProductModelBusiness>();
            service.AddScoped<IVisitorBusiness, VisitorBusiness>();
        }
    }
}
