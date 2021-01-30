using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EdgarAparicio.APIDepartamentosEsperanza.Manager.Entity
{
    /// <summary>
    /// Department entity
    /// </summary>
    public class Department : BaseEntity
    {
        /// <summary>
        /// Gest or sets the name
        /// </summary>
        /// <value>
        /// the name
        /// </value>
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the level
        /// </summary>
        /// <value>
        /// the level
        /// </value>
        [Required]
        public int Level { get; set; }

        /// <summary>
        /// Gets or Sets the bedrooms
        /// </summary>
        /// <value>
        /// the bedrooms
        /// </value>
        [Required]
        public int Bedrooms { get; set; }
    }
}

