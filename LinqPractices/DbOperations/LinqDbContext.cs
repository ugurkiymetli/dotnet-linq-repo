﻿using Microsoft.EntityFrameworkCore;

namespace LinqPractices
{
    internal class LinqDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "LinqDatabase");
        }
    }
}
