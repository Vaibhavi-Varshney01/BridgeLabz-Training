using System;
class MathematicalOperations{
  static void Main(){
    Console.WriteLine("Enter the number: ");
    int num = int.Parse(Console.ReadLine()); // user input
    Console.WriteLine("Enter the num2: "); 
    int num2 = int.Parse(Console.ReadLine()); // user input second no.
    int fact = Factorial(num); // factorial function calling
    bool prime = Prime(num); // prime number calling
    int gcd = GCD(num, num2); // gcd calling
    int fibo = Fibonacci(num); // fibonacci calling
    Console.WriteLine("Factorial code is: " + fact);
    Console.WriteLine("Prime number " + prime);
    Console.WriteLine("GCD are: " + gcd);
    COnsole.WriteLine("Fibonacci series is: " + fibo);
  }
  // method for factorial
  static int Factorial(int num){
    if(num == 0 || num == 1){
      return 1;
    }
    if(num < 0){
      return 0;
    }
    int fact = 1;
    for(int i = 1; i<num; i++){
      fact = fact*i;
    }
    return fact;
  }
  // method for prime
  static bool Prime(int num){
    if(num <=1){
      return false;
    }
    bool ans = true;
    for(int i = 2; i<=Math.sqrt(num); i++){
      if(num % i == 0){
        ans = false;
        break;
      }
    }
    return ans;
  }
  // method for GCD
  static int GCD(int a, int b){
     while(b != 0){
      int gcd = a%b;
      a = b;
      b = gcd;
     }
     return a;
  }
  // method for fibonacci
  static void Fibonacci(int num){
    int a = 0;
    int b = 1;
    for(int i = 0; i<=n; i++){
      Console.WriteLine(a + " ");
      int c = a+b;
      a = b; 
      b = c;
    }
  }
}