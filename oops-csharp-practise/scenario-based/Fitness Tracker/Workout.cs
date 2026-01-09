using System;

public class Workout : ITrackable
{
    public string WorkoutName { get; set; }
    public int Duration { get; set; }

    public Workout(string workoutName, int duration)
    {
        WorkoutName = workoutName;
        Duration = duration;
    }

    public virtual void TrackWorkout()
    {
        Console.WriteLine("Tracking generic workout...");
    }
}
