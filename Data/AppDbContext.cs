﻿using Microsoft.EntityFrameworkCore;
using TrainingLog.Models;

namespace TrainingLog.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Workout> Workouts { get; set; }
}