using System;

public class CardioWorkout : Workout
{
    public int Distance { get; set; }

    public CardioWorkout(string workoutName, int duration, int distance)
        : base(workoutName, duration)
    {
        Distance = distance;
    }

    public override void TrackWorkout()
    {
        Console.WriteLine($"Cardio Workout: {WorkoutName}");
        Console.WriteLine($"Duration: {Duration} minutes");
        Console.WriteLine($"Distance Covered: {Distance} km");
    }
}
