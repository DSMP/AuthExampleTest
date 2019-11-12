using Microsoft.EntityFrameworkCore;
using AuthExampleLibrary.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthExampleLibrary.Model.Entities
{
    public class AuthExampleContext : DbContext
    {
        public DbSet<UserAuthenticationsEntity> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=DESKTOP-2ENJ0B3\\SQLEXPRESS;Database=NantHealthAssesment;Trusted_Connection=True;");
    }
}
