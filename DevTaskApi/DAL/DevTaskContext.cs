using DevTaskApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTaskApi.DAL
{
    /// <summary>
    /// Data access layer
    /// </summary>
    public class DevTaskContext : DbContext
    {
        /// <summary>
        /// Main Constructor
        /// </summary>
        /// <param name="options"></param>
        public DevTaskContext(DbContextOptions<DevTaskContext> options) : base(options)
        {

        }

        public DbSet<User> Users { set; get; }
        public DbSet<Solution> Solutions { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
