using Dal.Implemented.Base;
using Dal.Interfaces;
using Domains;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dal.Implemented
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(ApplicationContext context) : base(context)
        {

        }

        public async Task<ICollection<Product>> GetBySectionAsync(string sectionName, int pageIndex, int pageSize)
        {
            var tmp = await GetAll()
                .Include(t => t.ProductCategory)
                .Where(t => t.ProductCategory.CategoryName.ToLower().Contains(sectionName.ToLower()))
                .Skip(pageSize * ( pageIndex -1) )
                .Take(pageSize)
                .ToListAsync();

            return tmp;
        }

        public async Task<ICollection<Product>> GetRecommendProductAsync(int id, int count, int optionId)
        {
            // ToDO: Implement your logic to get them
            var thisProduct = await GetByIdAsync(id);

            return await GetAll().OrderBy(t => t.Id).Where(t => t.ProductCategoryId > thisProduct.ProductCategoryId).Take(count).ToListAsync();
        }
    }
}
