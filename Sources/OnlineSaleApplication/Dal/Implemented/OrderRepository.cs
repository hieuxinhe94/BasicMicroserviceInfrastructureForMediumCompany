using Dal.Implemented.Base;
using Dal.Interfaces;
using Domains; 

namespace Dal.Implemented
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationContext context) : base(context)
        {

        }
 
    }
}
