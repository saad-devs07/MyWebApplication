using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyWebApplication.Models;
namespace MyWebApplication.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> xyz) : base(xyz) { }

        public DbSet<Student> Std { get; set; }
        public DbSet<Fee> Fees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasKey(e => e.SId);
            modelBuilder.Entity<Fee>()
                .HasKey(e => e.FId);
        }

        public DbSet<MyWebApplication.Models.Fee> Fee { get; set; } = default!;
    }
}
