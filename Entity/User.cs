using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.APIDepartamentosEsperanza.Manager.Entity
{
    /// <summary>
    /// User entity
    /// </summary>
    public class User : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        /// <value>
        /// The Name
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the age
        /// </summary>
        /// <value>
        /// the age
        /// </value>
        public Nullable<int> Age { get; set; }
    }
}
