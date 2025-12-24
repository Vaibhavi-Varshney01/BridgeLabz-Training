using System;
public class DivideBy5{
  public static void Main(String [] args){
	Cosnole.WriteLine("Enter the number: ");
	int num = int.Parse(Console.ReadLine());
	bool flag = false;
	if(num % 5 == 0){
		flag = true;
		Console.WriteLine("Is the number " + num + " is divisible by 5 ? " + flag);
	}
	else{
		Console.WriteLine("Is the number " + num + " is divisible by 5 ? " + flag);
	}
  }
}

		