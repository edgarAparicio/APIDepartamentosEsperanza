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
    /// Como la clase BaseManager ya contiene la logica que esta clase necesita lo unico que se hace es hereredar de BaseManager e incicarle 
    /// la entidad y el viewmodel con los que trabajara.
    /// Mediante el contructor se hace la inyeccion de dependencia de repository para podernos conectar con la capa de repository
    /// y mandarle la propiedad que necesita baseManager en su contructor para poder trabajar
    /// En esta clase se sobreescribiran algunos metodos para poder hacer la conversion de entidad - viewmodel y poder regresar el viewmodel a
    /// los endpoints
    /// </summary>
    public class UserManager : BaseManager<User, UserViewModel>, IUserManager
    {
        private readonly IUser _repository;
        /// <summary>
        /// Initializes a new instance of the <see cref="UserManager"/>
        /// </summary>
        /// <param name="repository"></param>
        public UserManager(IUser repository) : base (repository) //Aqu le mandamos lo que necesita el contructor de BaseManager
        {
            _repository = repository;
        }

        /// <summary>
        /// Prepares the multiple return
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override List<UserViewModel> PreparesMultipleReturn(List<User> entities)
        {
            return entities.Select(userEntity => new UserViewModel()
            {
                Id = userEntity.Id,
                Name = userEntity.Name,
                Age = userEntity.Age,
                Active = userEntity.Active,
                CreatedAt = userEntity.CreatedAt,
                UpdatedAt = userEntity.UpdatedAt
            }).ToList();
            
        }
        /// <summary>
        /// Prepares the single return
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override UserViewModel PrepareSingleReturn(User entity)
        {
            var user = new UserViewModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Age = entity.Age,
                Active = entity.Active,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt
            };
            return user;
        }
        /// <summary>
        /// Prepares the add data
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override User PrepareAddData(UserViewModel model)
        {
            var entity = new User()
            {
                Id = model.Id,
                Name = model.Name,
                Age = model.Age,
                Active = model.Active,
                CreatedAt = DateTime.Now,
            };

            return entity;
        }

        public override User PrepareUpdateData(User entity, UserViewModel model)
        {
            entity.Name = model.Name;
            entity.Age = model.Age;
            entity.UpdatedAt = model.UpdatedAt;
            return entity;
        }
    }

    //#region[Clase sin ObjectGeneric]
    //public class UserManager : IUserManager
    //{
    //    private readonly IUser _userRepository;
    //    private const bool Active = true;

    //    /// <summary>
    //    /// Initializes a new instance of the <see cref="UserManager"/>
    //    /// </summary>
    //    /// <param name="userRepository"></param>
    //    public UserManager(IUser userRepository)
    //    {
    //        this._userRepository = userRepository;
    //    }
    //    /// <summary>
    //    /// Gets the Instance
    //    /// </summary>
    //    /// <returns></returns>
    //    public List<UserViewModel> Get()
    //    {
    //        //var userEntity = _userRepository.Get();
    //        //var user = userEntity.Select(u => new UserViewModel()
    //        //{
    //        //    Id = u.Id,
    //        //    Name = u.Name,
    //        //    Age = u.Age,
    //        //    Active = u.Active
    //        //});
    //        //return user.ToList();

    //        //Menos Codigo
    //        return _userRepository.Get().Select(u => new UserViewModel()
    //        {
    //            Id = u.Id,
    //            Name = u.Name,
    //            Age = u.Age,
    //            Active = u.Active
    //        }).ToList();
    //    }
    //    /// <summary>
    //    /// Gets the identifier
    //    /// </summary>
    //    /// <param name="id"></param>
    //    /// <returns></returns>
    //    public UserViewModel GetById(int id)
    //    {
    //        var userEntity = _userRepository.GetById(id);
    //        var user = new UserViewModel()
    //        {
    //            Id = userEntity.Id,
    //            Name = userEntity.Name,
    //            Age = userEntity.Age,
    //            Active = userEntity.Active
    //        };
    //        return user;
    //    }
    //    /// <summary>
    //    /// Posts the specified entity
    //    /// </summary>
    //    /// <param name="userModel"></param>
    //    /// <returns></returns>
    //    public int Post(UserViewModel userModel)
    //    {
    //        User userEntity = new User();
    //        userEntity.Name = userModel.Name;
    //        userEntity.Age = userModel.Age;
    //        userEntity.Active = userModel.Active;
    //        userEntity.CreatedAt = DateTime.Now;

    //        return _userRepository.Post(userEntity);
    //    }

    //    /// <summary>
    //    /// Patches the specified entity
    //    /// </summary>
    //    /// <param name="id"></param>
    //    /// <param name="userModel"></param>
    //    public void Patch(int id, UserViewModel userModel)
    //    {
    //        var userEntity = _userRepository.GetById(id);

    //        userEntity.Name = userModel.Name;
    //        userEntity.Age = userModel.Age;
    //        userEntity.UpdatedAt = DateTime.Now;

    //        _userRepository.Patch(userEntity);
    //    }
    //    /// <summary>
    //    /// Deletews the specified identifier
    //    /// </summary>
    //    /// <param name="id"></param>
    //    public void Delete(int id)
    //    {
    //        _userRepository.Delete(id);
    //    }
    //}

    //#endregion[Clase sin ObjectGeneric]
}
