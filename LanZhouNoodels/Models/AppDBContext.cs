using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace LanZhouNoodels.Models
{
    //public class AppDBContext : DbContext
    public class AppDBContext : IdentityDbContext<IdentityUser>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) 
       {
        }

        public DbSet<Noodle> Noodles { get; set; }
        public DbSet<FeedBack> FeedBacks{ get; set; }
    }
}
