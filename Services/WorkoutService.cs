using TrainingLog.Models;
using TrainingLog.Data;
using Microsoft.EntityFrameworkCore;

namespace TrainingLog.Services;

public class WorkoutService
{
    // Constructor der modtager AppDbContext via dependency injection
    private readonly AppDbContext _context; // Felt der holder databasen

    public WorkoutService(AppDbContext context) // Constructor som får injectet  databasen
    {
        _context = context; // Gemmer den i feltet så databasen kan bruges i hele klassen
    }
    public async Task<List<Workout>> GetWorkoutsAsync()
    {
        var workouts = new List<Workout>
        {
            new Workout{Id = 1, Date = DateTime.Now, Type = "løb", Notes = "5km på 25min"},
            new Workout {Id = 2, Date = DateTime.Now, Type = "Styrke", Notes = "Ryg og Biceps"}
        };
            return await Task.FromResult(workouts);
    }

    public async Task AddWorkoutAsync(Workout workout)
    {
        
    }
    
}