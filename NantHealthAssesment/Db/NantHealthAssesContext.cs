using Microsoft.EntityFrameworkCore;
using NantHealthAssesmentLibrary.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NantHealthAssesment.Db
{
    public class NantHealthAssesContext : DbContext
    {
        public DbSet<UserAuthenticationsEntity> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=DESKTOP-2ENJ0B3\\SQLEXPRESS;Database=NantHealthAssesment;Trusted_Connection=True;");
    }
}
