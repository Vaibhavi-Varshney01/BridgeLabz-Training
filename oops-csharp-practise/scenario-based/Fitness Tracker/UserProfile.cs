using System;

public class UserProfile
{
    public string UserName { get; set; }
    public int Age { get; set; }

    public UserProfile(string userName, int age)
    {
        UserName = userName;
        Age = age;
    }

    public void ShowWorkoutDetails(Workout workout)
    {
        Console.WriteLine($"User: {UserName}, Age: {Age}");
        workout.TrackWorkout();
    }
}
