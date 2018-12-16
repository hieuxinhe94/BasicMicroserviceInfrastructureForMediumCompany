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
    public class OrderStatusBusiness : IOrderStatusBusiness
    {
        private readonly IOrderStatusRepository _orderStatusRepository;

        public OrderStatusBusiness(IOrderStatusRepository orderStatusRepository)
        {
            _orderStatusRepository = orderStatusRepository;
        }

        public async Task<ServiceResponeCode> CreateAsync(OrderStatus entityToCreate)
        {
            if (entityToCreate.Id != 0)
            {
                return ServiceResponeCode.INVALID;
            }
            try
            {
                await _orderStatusRepository.CreateAsync(entityToCreate);
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
                await _orderStatusRepository.DeleteAsync(id);
                return ServiceResponeCode.OK;
            }
            catch
            {
                return ServiceResponeCode.ERROR;
            }
        }

        public ICollection<OrderStatus> GetAllWithoutPagination()
        {
            return _orderStatusRepository.GetAll().ToList();
        }

        public ICollection<OrderStatus> GetAllWithPagination(SearchViewModel searchView)
        {
            try
            {
                return _orderStatusRepository.GetAll().Take(searchView.PageSize).Skip(searchView.PageSize * searchView.PageIndex).ToList();
            }
            catch
            {
                return null;
            }
        }

        public async Task<OrderStatus> GetByIdAsync(int id)
        {
            return await _orderStatusRepository.GetByIdAsync(id);
        }

        public async Task<ServiceResponeCode> UpdateAsync(int id, OrderStatus entityToUpdate)
        {
            var current = _orderStatusRepository.GetByIdAsync(id);

            if (current != null)
            {
                await _orderStatusRepository.UpdateAsync(id, entityToUpdate);
                return ServiceResponeCode.OK;
            }

            return ServiceResponeCode.NOT_FOUND;
        }
    }
}
