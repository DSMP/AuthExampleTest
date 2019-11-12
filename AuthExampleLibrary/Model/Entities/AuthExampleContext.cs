using Microsoft.EntityFrameworkCore;
using AuthExampleLibrary.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthExampleLibrary.Model.Entities
{
    public class AuthExampleContext : DbContext
    {
        private DbContextOptions<AuthExampleContext> options;
        public AuthExampleContext()
        {

        }

        public AuthExampleContext(DbContextOptions<AuthExampleContext> options) : base(options)
        {
            this.options = options;
        }

        public DbSet<UserAuthenticationsEntity> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=DESKTOP-2ENJ0B3\\SQLEXPRESS;Database=NantHealthAssesment;Trusted_Connection=True;");
            }
        }
    }
}
