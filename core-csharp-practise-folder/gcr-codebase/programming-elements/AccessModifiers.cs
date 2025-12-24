using System;

class AccessModifiers{

    public int num1=20;

    private int num2=40;

  
    protected int num3=60;

    internal int num4 = 80;

    private void ShowPrivate(){
        Console.WriteLine("The private number is: " + num2);
    }

    public void display(){
        Console.WriteLine("The protected number is: " + num3);
        Console.WriteLine("The Public variable is: " + num1);
        Console.WriteLine("The internal variable is: " + num4);
        ShowPrivate();
    }

    static void Main(string[] args){
            AccessModifier am=new AccessModifier();
            am.display();
    }
}