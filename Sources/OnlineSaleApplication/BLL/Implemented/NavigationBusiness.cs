using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bll.Interfaces;
using Core;
using Core.ViewModel;
using Dal.Interfaces;
using Domains;

namespace Bll.Implemented
{
    public class NavigationBusiness : INavigationBusiness
    {
        private readonly INavigationRepository _navigationRepository;

        public NavigationBusiness(INavigationRepository navigationRepository)
        {
            _navigationRepository = navigationRepository;
        }

        public async Task<ServiceResponeCode> CreateAsync(Navigation entityToCreate)
        {
            if (entityToCreate.Id != 0)
            {
                return ServiceResponeCode.INVALID;
            }
            try
            {
                await _navigationRepository.CreateAsync(entityToCreate);
                return ServiceResponeCode.OK;
            }
            catch
            {
                return ServiceResponeCode.ERROR;
            }
        }

        public async Task<ServiceResponeCode> DeleteAsync(int id)
        {
            if (id == 0)
            {
                return ServiceResponeCode.INVALID;
            }
            try
            {
                await _navigationRepository.DeleteAsync(id);
                return ServiceResponeCode.OK;
            }
            catch
            {
                return ServiceResponeCode.ERROR;
            }
        }

        public ICollection<Navigation> GetAllWithoutPagination()
        {
            return _navigationRepository.GetAll().ToList();
        }

        public ICollection<Navigation> GetAllWithPagination(SearchViewModel searchView)
        {
            try
            {
                return _navigationRepository.GetAll().Take(searchView.PageSize).Skip(searchView.PageSize * searchView.PageIndex).ToList();
            }
            catch
            {
                return null;
            }
        }

        public async Task<Navigation> GetByIdAsync(int id)
        {
            return await _navigationRepository.GetByIdAsync(id);
        }

        public async Task<ServiceResponeCode> UpdateAsync(int id, Navigation entityToUpdate)
        {
            var current = _navigationRepository.GetByIdAsync(id);

            if (current != null)
            {
                await _navigationRepository.UpdateAsync(id, entityToUpdate);
                return ServiceResponeCode.OK;

            }
            return ServiceResponeCode.NOT_FOUND;
        }
    }
}
