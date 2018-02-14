using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Identity.Models;

namespace Identity.Data
{
    //main dbcontext 
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        //constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //some sort of overide method, but not sure what it is actually overiding
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        

        //some sort of overide method, but not sure what it is actually overiding
        //public DbSet<Identity.Models.UserModel> UserModel { get; set; }
    }
}
