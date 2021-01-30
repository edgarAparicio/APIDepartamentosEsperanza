using EdgarAparicio.APIDepartamentosEsperanza.Manager.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.APIDepartamentosEsperanza.Repository.Interfaces
{
    public interface IUser
    {
        
        /// <summary>
        /// Gets the instance
        /// </summary>
        /// <returns>User´s List</returns>
        List<User> Get();
        /// <summary>
        /// Gets the identifier
        /// </summary>
        /// <param name="id">The identifier</param>
        /// <returns>User</returns>
        User GetById(int id);
        /// <summary>
        /// Posts the specified entity
        /// </summary>
        /// <param name="user"></param>
        /// <returns>int</returns>
        int Post(User user);
        /// <summary>
        /// Patches the specified entity
        /// </summary>
        /// <param name="user"></param>
        void Patch(User user);
        /// <summary>
        /// Deletes the specified identifier
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);


    }
}
