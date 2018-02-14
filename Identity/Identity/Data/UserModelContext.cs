using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Identity.Models
{
    public class UserModelContext : DbContext
    {
        public UserModelContext (DbContextOptions<UserModelContext> options)
            : base(options)
        {
        }

        public DbSet<Identity.Models.UserModel> UserModel { get; set; }
    }
}
