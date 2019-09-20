using BlazorApp1.DataAccess.Contracts;
using BlazorApp1.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace BlazorApp1.DataAccess
{
    public class DemoContext : DbContext, IDemoContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {
        }

        public DbSet<Warrior> Warrior { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Warrior>().ToTable("Warrior");

        }
    }
}
