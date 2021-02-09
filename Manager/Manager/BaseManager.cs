using EdgarAparicio.APIDepartamentosEsperanza.Manager.Interfaces;
using EdgarAparicio.APIDepartamentosEsperanza.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.APIDepartamentosEsperanza.Manager.Manager
{
    /// <summary>
    /// Mediante esta clase se implementa la interfaz IBaseManager que espera recibir un TypeEntity y un TypeViewModel
    /// Esta clase contiene la logica general para recibir el ViewModel y convertirlo a Entity y mandar la entity a la capa de repository
    /// Una vez que lacapa de repository hizo las consultas a BD con las entidades correspondientes nos regresa la entity
    /// Cuando ya se tiene en esta capa la consulta realizada con la entidad correspondiente lo que se hace es covertir la entity a viewmodel
    /// y de esta manera regresar el viewmodel a los endpoints
    /// </summary>
    /// <typeparam name="TypeEntity"></typeparam>
    /// <typeparam name="TypeViewModel"></typeparam>
    public class BaseManager<TypeEntity, TypeViewModel> : IBaseManager<TypeEntity, TypeViewModel> where TypeEntity : class where TypeViewModel : class
    {
        private readonly IBaseRepository<TypeEntity> _repository;
        /// <summary>
        /// Initializes the instance of the <see cref="IBaseRepository{TypeEntity}<"/>
        /// </summary>
        /// <param name="repository"></param>
        public BaseManager(IBaseRepository<TypeEntity> repository)
        {
            _repository = repository;
        }
        
        /// <summary>
        /// Gets this instance
        /// </summary>
        /// <returns></returns>
        public List<TypeViewModel> Get()
        {
            var entities = _repository.Get();
            return PreparesMultipleReturn(entities);
        }

        /// <summary>
        /// Gets the by identifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TypeViewModel GetById(int id)
        {
            var entity = _repository.GetById(id);
            return PrepareSingleReturn(entity);
        }

        /// <summary>
        /// Posts the specified entity
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Post(TypeViewModel model)
        {
            var entity = PrepareAddData(model);
            return _repository.Post(entity);
        }
        /// <summary>
        /// Patches the specified entity
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        public void Patch(int id, TypeViewModel model)
        {
            var entity = _repository.GetById(id);
            var updatedEntity = PrepareUpdateData(entity, model);
            _repository.Patch(updatedEntity);
        }

        /// <summary>
        /// Deletes the specified identifier
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public virtual List<TypeViewModel> PreparesMultipleReturn(List<TypeEntity> entities)
        {
            throw new NotImplementedException();
            //Este metodo permite convertir la lista de entidad user en lista viewmodel user
            //Aqui no se tiene codigo porque en la clase UserManager se va a sobreescribir este metodo 
            //No olvidar que debe llevar la palabra reservada virtual.
            //De igual manera se hara con todas las entidades
        }

                //public abstract List<TypeViewModel> Prepare(List<TypeEntity> entities); Ejemplo de abstraca

        /// <summary>
        /// Prepeares the single return
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual TypeViewModel PrepareSingleReturn(TypeEntity entity)
        {
            throw new NotImplementedException();
            //Este metodo permite convertir la entidad user en viewmodel user
            //Aqui no se tiene codigo porque en la clase UserManager se va a sobreescribir este metodo 
            //No olvidar que debe llevar la palabra reservada virtual.
            //De igual manera se hara con todas las entidades
        }

        /// <summary>
        /// Prepares the add data
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public virtual TypeEntity PrepareAddData(TypeViewModel model)
        {
            throw new NotImplementedException();
            //Este metodo permite convertir el modelo en entidad para poder agregarla a la BD
            //Ya que no se puede agregar a la BD un viiewmodel
            //Aqui no se tiene codigo porque en la clase UserManager se va a sobreescribir este metodo 
            //No olvidar que debe llevar la palabra reservada virtual.
            //De igual manera se hara con todas las entidades
        }

        /// <summary>
        /// Prepares the update data
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public virtual TypeEntity PrepareUpdateData(TypeEntity entity, TypeViewModel model)
        {
            throw new NotImplementedException();
            //Este metodo permite convertir la entidad User en un viewmodel de tipo user
            //Ya que no se puede agregar a la BD un viewmodel
            //Aqui no se tiene codigo porque en la clase UserManager se va a sobreescribir este metodo 
            //No olvidar que debe llevar la palabra reservada virtual.
            //De igual manera se hara con todas las entidades
        }
    }
}
