using EdgarAparicio.APIDepartamentosEsperanza.Manager.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.APIDepartamentosEsperanza.Repository.Context
{
    public class DepartamentosEsperanzaContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Context"/> class.
        /// </summary>
        /// <param name="options"></param>
        public DepartamentosEsperanzaContext(DbContextOptions<DepartamentosEsperanzaContext> options) : base(options)
        {

        }
        /// <summary>
        /// Gets or Sets the Users
        /// </summary>
        /// <value>
        /// The Users
        /// </value>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Gets or Sets the departaments
        /// <value>
        /// The Departments
        /// </value>
        /// </summary>
        public DbSet<Department> Departaments { get; set; }

        /// <summary>
        /// Gets or Sets the UsersDepartments
        /// </summary>
        /// <value>
        /// The UserDepartments
        /// </value>
        public DbSet<UserDepartment> UserDepartments { get; set; }
    }
}
