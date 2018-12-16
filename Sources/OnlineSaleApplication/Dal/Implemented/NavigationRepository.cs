using Dal.Implemented.Base;
using Dal.Interfaces;
using Domains; 

namespace Dal.Implemented
{
    public class NavigationRepository : RepositoryBase<Navigation>, INavigationRepository
    {
        public NavigationRepository(ApplicationContext context) : base(context)
        {}

    }
}
