using Dal.Interfaces.Base;
using Domains;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dal.Interfaces
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        // More specific methods only need on Product Data Access Layer
        Task<ICollection<Product>> GetBySectionAsync(string sectionName, int pageIndex, int pageSize);

        Task<ICollection<Product>> GetRecommendProductAsync(int id, int count, int optionId);
    }
}
