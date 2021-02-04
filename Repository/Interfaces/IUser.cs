using EdgarAparicio.APIDepartamentosEsperanza.Manager.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.APIDepartamentosEsperanza.Repository.Interfaces
{
    /// <summary>
    /// Esta Interfaz define metodos para el acceso a la BD para la entidad User pero con el ObjectGeneric ya no se necesitan estos metodos porque 
    /// dichos metodos ya se encuentran en la clase IBaseRepository, lo unico que haremos aqui es heredar la clase IBaseReposotity 
    /// y le pasamos la entidad User ya que puede como es un objectGeneric puede recibir cualquier tipo de entidad
    /// sin embargo la Interfaz se realiza por si se requiere realizar alguna funcion que no contenta la clase IBaseRepository.
    /// </summary>
    public interface IUser : IBaseRepository<User>
    {
        
        /// <summary>
        /// Gets the instance
        /// </summary>
        /// <returns>User´s List</returns>
        //List<User> Get();
        /// <summary>
        /// Gets the identifier
        /// </summary>
        /// <param name="id">The identifier</param>
        /// <returns>User</returns>
        //User GetById(int id);
        /// <summary>
        /// Posts the specified entity
        /// </summary>
        /// <param name="user"></param>
        /// <returns>int</returns>
        //int Post(User user);
        /// <summary>
        /// Patches the specified entity
        /// </summary>
        /// <param name="user"></param>
        //void Patch(User user);
        /// <summary>
        /// Deletes the specified identifier
        /// </summary>
        /// <param name="id"></param>
        //void Delete(int id);


    }
}
