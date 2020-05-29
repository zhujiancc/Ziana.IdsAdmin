using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using Ziana.IdsAdmin.Server.Domains;

namespace Ziana.IdsAdmin.Server.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole,Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
