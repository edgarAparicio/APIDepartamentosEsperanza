using EdgarAparicio.APIDepartamentosEsperanza.Manager.Entity;
using EdgarAparicio.APIDepartamentosEsperanza.Manager.Entity.ViewModels;
using EdgarAparicio.APIDepartamentosEsperanza.Manager.Interfaces;
using EdgarAparicio.APIDepartamentosEsperanza.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EdgarAparicio.APIDepartamentosEsperanza.Manager.Manager
{
    /// <summary>
    /// UserManager
    /// </summary>
    public class UserManager : IUserManager
    {
        private readonly IUser _userRepository;
        private const bool Active = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserManager"/>
        /// </summary>
        /// <param name="userRepository"></param>
        public UserManager(IUser userRepository)
        {
            this._userRepository = userRepository;
        }
        /// <summary>
        /// Gets the Instance
        /// </summary>
        /// <returns></returns>
        public List<UserViewModel> Get()
        {
            //var userEntity = _userRepository.Get();
            //var user = userEntity.Select(u => new UserViewModel()
            //{
            //    Id = u.Id,
            //    Name = u.Name,
            //    Age = u.Age,
            //    Active = u.Active
            //});
            //return user.ToList();

            //Menos Codigo
            return _userRepository.Get().Select(u => new UserViewModel()
            {
                Id = u.Id,
                Name = u.Name,
                Age = u.Age,
                Active = u.Active
            }).ToList();
        }
        /// <summary>
        /// Gets the identifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserViewModel GetById(int id)
        {
            var userEntity = _userRepository.GetById(id);
            var user = new UserViewModel()
            {
                Id = userEntity.Id,
                Name = userEntity.Name,
                Age = userEntity.Age,
                Active = userEntity.Active
            };
            return user;
        }
        /// <summary>
        /// Posts the specified entity
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns></returns>
        public int Post(UserViewModel userModel)
        {
            User userEntity = new User();
            userEntity.Name = userModel.Name;
            userEntity.Age = userModel.Age;
            userEntity.Active = userModel.Active;
            userEntity.CreatedAt = DateTime.Now;

            return _userRepository.Post(userEntity);
        }

        /// <summary>
        /// Patches the specified entity
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userModel"></param>
        public void Patch(int id, UserViewModel userModel)
        {
            var userEntity = _userRepository.GetById(id);

            userEntity.Name = userModel.Name;
            userEntity.Age = userModel.Age;
            userEntity.UpdatedAt = DateTime.Now;

            _userRepository.Patch(userEntity);
        }
        /// <summary>
        /// Deletews the specified identifier
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }
    }
}
