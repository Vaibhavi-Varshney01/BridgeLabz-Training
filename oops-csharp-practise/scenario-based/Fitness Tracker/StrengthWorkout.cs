using System;

public class StrengthWorkout : Workout
{
    public int Reps { get; set; }

    public StrengthWorkout(string workoutName, int duration, int reps)
        : base(workoutName, duration)
    {
        Reps = reps;
    }

    public override void TrackWorkout()
    {
        Console.WriteLine($"Strength Workout: {WorkoutName}");
        Console.WriteLine($"Duration: {Duration} minutes");
        Console.WriteLine($"Repetitions: {Reps}");
    }
}
