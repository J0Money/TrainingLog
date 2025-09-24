namespace TrainingLog.Models;

public class Workout
{
    public int Id { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public string Type { get; set; }
    public string? Notes { get; set; }
}