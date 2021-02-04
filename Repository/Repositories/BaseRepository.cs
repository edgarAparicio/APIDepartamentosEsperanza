using EdgarAparicio.APIDepartamentosEsperanza.Repository.Context;
using EdgarAparicio.APIDepartamentosEsperanza.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EdgarAparicio.APIDepartamentosEsperanza.Repository.Repositories
{
    /// <summary>
    /// BaseRepository, clase que implementa la Interfaz IBAseRepository que recibe un tipo de entidad para poder tener acceso a la BD
    /// </summary>
    /// <typeparam name="TypeEntity"></typeparam>
    /// <seealso cref="IBaseRepository{TypeEntity}"/>
    public class BaseRepository<TypeEntity> : IBaseRepository<TypeEntity> where TypeEntity : class
    {
        private readonly DepartamentosEsperanzaContext _context;
        /// <summary>
        /// Se crear contructor para realizar la inyeccion de dependencias, indicamos que esperamos un parametro de tipo DepartamentosEsperanzaContext 
        /// y se guaradara en context, posteriormente declaramos una propiedad _context para vaciar lo que tiene context y de esta manera la clase pueda
        /// utilizar el contexto que hace la conexion a la BD
        /// </summary>
        /// <param name="context"></param>
        public BaseRepository(DepartamentosEsperanzaContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Gets the instance
        /// </summary>
        /// <returns></returns>
        public List<TypeEntity> Get()
        {
            var listEntity= _context.Set<TypeEntity>().ToList();
            return listEntity;
        }
        /// <summary>
        /// Gets the specified identifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TypeEntity GetById(int id)
        {
            var entity = _context.Set<TypeEntity>().Find(id);
            return entity;
        }
        /// <summary>
        /// Posts the specifed entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Post(TypeEntity entity)
        {
            _context.Set<TypeEntity>().Add(entity);
            return _context.SaveChanges();
            
        }

        /// <summary>
        /// Patches the specified entity
        /// </summary>
        /// <param name="entity"></param>
        public void Patch(TypeEntity entity)
        {
            _context.Set<TypeEntity>().Update(entity);
            _context.SaveChanges();
        }

        /// <summary>
        /// Deletes the specified identifier
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var toRemove = _context.Set<TypeEntity>().Find(id);
            _context.Set<TypeEntity>().Remove(toRemove);
            _context.SaveChanges();
        }
    }
}
