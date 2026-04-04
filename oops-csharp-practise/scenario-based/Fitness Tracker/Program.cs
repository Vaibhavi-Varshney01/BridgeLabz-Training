using System;

var user = new UserProfile("Vaibhavi", 22);

Workout cardio = new CardioWorkout("Running", 30, 5);
Workout strength = new StrengthWorkout("Weight Lifting", 40, 15);

user.ShowWorkoutDetails(cardio);
Console.WriteLine();
user.ShowWorkoutDetails(strength);
