using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.APIDepartamentosEsperanza.Manager.Interfaces
{
    /// <summary>
    /// Base Manager
    /// </summary>
    /// <typeparam name="TypeEntity"></typeparam>
    /// <typeparam name="TypeViewModel"></typeparam>
    public interface IBaseManager<TypeEntity, TypeViewModel>
    {
        /// <summary>
        /// Gets the instance
        /// </summary>
        /// <returns></returns>
        List<TypeViewModel> Get();

        /// <summary>
        /// Gets the by identifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TypeViewModel GetById(int id);
        /// <summary>
        /// Posts the specified entity
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int Post(TypeViewModel model);
        /// <summary>
        /// Patches the specified entity
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        void Patch(int id, TypeViewModel model);
        /// <summary>
        /// Deletes the by identifier
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);
        /// <summary>
        /// Prepares the add data
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        TypeEntity PrepareAddData(TypeViewModel model);
        /// <summary>
        /// Prepares the update data
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        TypeEntity PrepareUpdateData(TypeEntity entity, TypeViewModel model);
        /// <summary>
        /// Prepares the single return
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        TypeViewModel PrepareSingleReturn(TypeEntity entity);
        /// <summary>
        /// Prepares the multples return
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        List<TypeViewModel> PreparesMultipleReturn(List<TypeEntity> entities);



    }
}
