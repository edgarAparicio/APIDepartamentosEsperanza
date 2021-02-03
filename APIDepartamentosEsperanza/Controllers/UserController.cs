using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdgarAparicio.APIDepartamentosEsperanza.Manager.Entity.ViewModels;
using EdgarAparicio.APIDepartamentosEsperanza.Manager.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIDepartamentosEsperanza.Controllers
{
    /// <summary>
    /// UserController
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase"/>
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserManager _userManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserController"/>
        /// </summary>
        /// <param name="userManager"></param>
        public UserController(IUserManager userManager)
        {
            this._userManager = userManager;
        }

        /// <summary>
        /// Gets the specified entity
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<UserViewModel> Get()
        {
            return _userManager.Get();
        }

        /// <summary>
        /// Gets the specified identifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public UserViewModel Get(int id)
        {
            return _userManager.GetById(id);
        }
        /// <summary>
        /// Posts the spcified value
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] UserViewModel userModel)
        {
            _userManager.Post(userModel);
            return Ok();
        }
        /// <summary>
        /// Patches the specified identifier
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns></returns>
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, UserViewModel userModel)
        {
            _userManager.Patch(id, userModel);
            return Ok();
        }
        /// <summary>
        /// Deletes the specified identifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userManager.Delete(id);
            return Ok();
        }




    }
}
