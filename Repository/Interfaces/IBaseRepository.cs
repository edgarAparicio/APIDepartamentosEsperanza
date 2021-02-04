using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.APIDepartamentosEsperanza.Repository.Interfaces
{
    /// <summary>
    /// Base Repository, Esta interfaz define los metodos generales para las peticiones que pueda realizar la app, se hace uso de ObjectGeneric 
    /// para recibir cualquier tipo de entidad, la clase que implementa esta interfaz es BaseRepository
    /// </summary>
    /// <typeparam name="TypeEntity">The type of entity</typeparam>
    public interface IBaseRepository<TypeEntity>
    {
        /// <summary>
        /// Gets the instance
        /// </summary>
        /// <returns></returns>
        List<TypeEntity> Get();
        /// <summary>
        /// Gets the identifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TypeEntity GetById(int id);

        /// <summary>
        /// Posts the specified entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Post(TypeEntity entity);

        /// <summary>
        /// Patches the specified entity
        /// </summary>
        /// <param name="entity"></param>
        void Patch(TypeEntity entity);

        /// <summary>
        /// Deletes the specified identifier
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);















    }
}
