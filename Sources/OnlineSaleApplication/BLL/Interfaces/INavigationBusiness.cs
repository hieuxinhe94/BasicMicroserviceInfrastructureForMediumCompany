using Core;
using Core.ViewModel;
using Domains;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Bll.Interfaces
{
    public interface INavigationBusiness
    {
        #region CRUD Basic

        /// <summary>
        ///  Return a list contains all of record from db
        /// </summary>
        /// <returns></returns>
        ICollection<Navigation> GetAllWithoutPagination();

        /// <summary>
        ///  Return a list with pagination
        /// </summary>
        /// <param name="searchView"></param>
        /// <returns></returns>
        ICollection<Navigation> GetAllWithPagination(SearchViewModel searchView);

        /// <summary>
        ///  Find a entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Navigation> GetByIdAsync(int id);
        /// <summary>
        /// Delete item from db
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ServiceResponeCode</returns>
        Task<ServiceResponeCode> DeleteAsync(int id);

        /// <summary>
        ///  Update entity with id provided to new entity, not chage the id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entityToUpdate"></param>
        /// <returns>ServiceResponeCode</returns>
        Task<ServiceResponeCode> UpdateAsync(int id, Navigation entityToUpdate);

        /// <summary>
        ///  Create entity
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entityToCreate"></param>
        /// <returns>ServiceResponeCode</returns>
        Task<ServiceResponeCode> CreateAsync(Navigation entityToCreate);

        #endregion
    }
}
