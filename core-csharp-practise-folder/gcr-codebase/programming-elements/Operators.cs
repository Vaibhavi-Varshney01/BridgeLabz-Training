//Use all the operators in c#
using System;
class Operators{
  static void Main(string[] args){
    int p=5;
    int q=5;

    //Arithmetic Operators
    Console.WriteLine("Arithmetic Operators:");
    Console.WriteLine("Addition: " + (p + q));
    Console.WriteLine("Subtraction: " + (p - q));
    Console.WriteLine("Multiplication: " + (p * q));
    Console.WriteLine("Division: " + (p / q));
    Console.WriteLine("Modulus: " + (p % q));

    //Relational Operators
    Console.WriteLine("Comparison Operators:");
    Console.WriteLine("Equal to: " + (p == q));
    Console.WriteLine("Not equal to: " + (p != q));
    Console.WriteLine("Greater than: " + (p > q));
    Console.WriteLine("Less than: " + (p < q));
    Console.WriteLine("Greater than or equal to: " + (p >= q));
    Console.WriteLine("Less than or equal to: " + (p <= q));
    
    //Logical Operators
    Console.WriteLine("Logical Operators:");
    Console.WriteLine("Logical AND: " + (p > 0 && q > 0));
    Console.WriteLine("Logical OR: " + (p > 0 || q < 0));
    Console.WriteLine("Logical NOT: " + !(p > 0));
    
    //Assignment Operators
    Console.WriteLine("Assignment Operators:");
    int c = p;
    Console.WriteLine("Assignment: " + c);
    c += q; // Addition 
    Console.WriteLine("Addition Assignment: " + c);
    c -= q; // Subtraction
    Console.WriteLine("Subtraction Assignment: " + c);
    c *= q; // Multiplication
    Console.WriteLine("Multiplication Assignment: " + c);
    c /= q; // Division
    Console.WriteLine("Division Assignment: " + c);
    c %= q; // Modulus 
    Console.WriteLine("Modulus Assignment: " + c);



    //Increment and Decrement Operators
    Console.WriteLine("Increment and Decrement Operators:");
    Console.WriteLine("Initial value of a: " + p);
    Console.WriteLine("Post-increment a: " + (p++));
    Console.WriteLine("Value of a after post-increment: " + p);
    Console.WriteLine("Pre-increment a: " + (++p));
    Console.WriteLine("Value of a after pre-increment: " + p);
    Console.WriteLine("Post-decrement a: " + (p--));
    Console.WriteLine("Value of a after post-decrement: " + p);
    Console.WriteLine("Pre-decrement a: " + (--p));
    Console.WriteLine("Value of a after pre-decrement: " + p);
  }
}