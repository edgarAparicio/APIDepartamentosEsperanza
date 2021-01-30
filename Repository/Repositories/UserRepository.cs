using EdgarAparicio.APIDepartamentosEsperanza.Manager.Entity;
using EdgarAparicio.APIDepartamentosEsperanza.Repository.Interfaces;
using EdgarAparicio.APIDepartamentosEsperanza.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EdgarAparicio.APIDepartamentosEsperanza.Repository.Repositories
{
    public class UserRepository : IUser
    {
        private readonly DepartamentosEsperanzaContext _context;
        private bool ActiveFalse = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/>
        /// </summary>
        /// <param name="context"></param>
        public UserRepository(DepartamentosEsperanzaContext context)
        {
            _context = context;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        /// <summary>
        /// Deletes the specified identifier
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            //Albino
            var entity = GetById(id);
            entity.Active = ActiveFalse;
            entity.UpdatedAt = DateTime.Now;
            _context.SaveChanges();


            //Mine
            //var entity = GetById(id);
            //_context.Remove(entity);
        }
        /// <summary>
        /// Gets the instance
        /// </summary>
        /// <returns></returns>
        public List<User> Get()
        {
            return _context.Users.ToList();
        }
        /// <summary>
        /// Gets the identifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetById(int id)
        {
            return _context.Users.Where(u => u.Id == id).FirstOrDefault();
        }

        /// <summary>
        /// Patchs the speicified entity
        /// </summary>
        /// <param name="user"></param>
        public void Patch(User user)
        {
            //Mine
            //var entity = _context.Users.Attach(user);
            //entity.State = EntityState.Modified;

            //ALbino
            var entity = GetById(user.Id);
            entity.Name = user.Name;
            entity.Age = user.Age;
            entity.UpdatedAt = user.UpdatedAt;
            _context.SaveChanges();
        }

        /// <summary>
        /// Posts the specified entity
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Post(User user)
        {
             _context.Users.Add(user);
            return _context.SaveChanges();
        }
    }
}
