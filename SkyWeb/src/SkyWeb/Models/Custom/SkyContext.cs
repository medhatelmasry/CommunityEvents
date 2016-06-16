using DataModel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkyWeb.Models.Custom
{
    public class SkyContext : DbContext
    {
        public SkyContext(DbContextOptions<SkyContext> options) : base(options)
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Activity> Activities { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Category>().HasKey(m => m.CategoryId);
        //    builder.Entity<Activity>().HasKey(m => m.ActivityId);

        //    base.OnModelCreating(builder);
        //}
    }
}
