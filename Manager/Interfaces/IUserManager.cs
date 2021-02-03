using EdgarAparicio.APIDepartamentosEsperanza.Manager.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.APIDepartamentosEsperanza.Manager.Interfaces
{
    /// <summary>
    /// IUserManager
    /// </summary>
    public interface IUserManager
    {
        /// <summary>
        /// Gets the instance
        /// </summary>
        /// <returns></returns>
        List<UserViewModel> Get();

        /// <summary>
        /// Gets the Identifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        UserViewModel GetById(int id);

        /// <summary>
        /// Posts the specified entity
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns></returns>
        int Post(UserViewModel userModel);

        /// <summary>
        /// Patches the specified entity
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userModel"></param>
        void Patch(int id, UserViewModel userModel);

        /// <summary>
        /// Deletes the specified identifier
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);












    }
}
