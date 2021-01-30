using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.APIDepartamentosEsperanza.Manager.Entity.ViewModels
{
    /// <summary>
    /// UserDepartmentViewModel
    /// </summary>
    /// <seealso cref="APIDepartamentosEsperanza.Manager.Entity.ViewModels.BaseViewModel"/>
    public class UserDepartmentViewModel : BaseViewModel
    {
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public int UserId { get; set; }
        /// <summary>
        /// Gets or sets the department identifier.
        /// </summary>
        /// <value>
        /// The department identifier.
        /// </value>
        public int DepartmentId { get; set; }
    }
}
