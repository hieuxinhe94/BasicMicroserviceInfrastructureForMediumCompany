using AutoMapper;
using Domains;
using Service.ViewModel;

namespace Service.Middleware
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Product, ProductViewModel>();
            CreateMap<ProductViewModel, Product>();

            CreateMap<User, LoginViewModel>();
            CreateMap<LoginViewModel, User>();

            CreateMap<ApplicationParam, AppParamViewModel>();
            CreateMap<AppParamViewModel, ApplicationParam>();

            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<ProductCategoryViewModel, ProductCategory>();

            CreateMap<Product, ProductViewModel>();
            CreateMap<ProductViewModel, Product>();

            CreateMap<Product, ProductViewModel>();
            CreateMap<ProductViewModel, Product>();

            CreateMap<Navigation, NavigationViewModel>();
            CreateMap<NavigationViewModel, Navigation>();
        }
    }
}
