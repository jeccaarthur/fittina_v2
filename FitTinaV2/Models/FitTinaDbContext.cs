using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitTinaV2.Models;
using Microsoft.EntityFrameworkCore;

namespace FitTinaV2.Models
{
    public class FitTinaDbContext : DbContext
    {
        public FitTinaDbContext(DbContextOptions<FitTinaDbContext> options) : base(options) { }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Workout> Workouts { get; set; }
    }
}
