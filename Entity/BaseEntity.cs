using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EdgarAparicio.APIDepartamentosEsperanza.Manager.Entity
{
    public class BaseEntity
    {
        /// <summary>
        /// Gets or Sets the Identifier
        /// </summary>
        /// <value>
        /// The Identifier
        /// </value>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets indicating whether this <see cref="User"/ is active>
        /// </summary>
        /// <value>
        /// <c>true</c> if active; otherwise, <c>false</c>
        /// </value>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the created at
        /// </summary>
        /// <value>
        /// The created at
        /// </value>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the updated at
        /// </summary>
        /// <value>
        /// The updated at
        /// </value>
        public DateTime UpdatedAt { get; set; }
    }
}
