using EdgarAparicio.APIDepartamentosEsperanza.Manager.Entity;
using EdgarAparicio.APIDepartamentosEsperanza.Manager.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.APIDepartamentosEsperanza.Manager.Interfaces
{
    /// <summary>
    /// IUserManager
    /// Esta interfaz definia los metodos para la entidad User antes de utilizar ObjectGEneric
    /// Ahora que estamos utilizando ObjectGeneric todos estos metodos que son generales ya los contiene IBaseManager
    /// Lo unico que haremos es heredar IBaseManager e indicarle la entidad y viewmodel con los que trabajara
    /// Donde todas las clases EntityManager podra utilizar IBaseManager
    /// Sin embargo se hace la interfaz para logica extra que requiera la entitdad User
    /// </summary>
    public interface IUserManager : IBaseManager<User, UserViewModel>
    {



        #region[Codigo sin usar ObjectGeneric]
        /// <summary>
        /// Gets the instance
        /// </summary>
        /// <returns></returns>
        //List<UserViewModel> Get();

        /// <summary>
        /// Gets the Identifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //UserViewModel GetById(int id);

        /// <summary>
        /// Posts the specified entity
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns></returns>
        //int Post(UserViewModel userModel);

        /// <summary>
        /// Patches the specified entity
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userModel"></param>
        //void Patch(int id, UserViewModel userModel);

        /// <summary>
        /// Deletes the specified identifier
        /// </summary>
        /// <param name="id"></param>
        //void Delete(int id);

        #endregion[Codigo si unsar ObjectGeneric]

    }
}
