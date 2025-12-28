using System;
class Null{
    static void Main(){
        NullReference();
    }
    static void NullReference(){
        try
        {
            string str = null;
            Console.WriteLine(str.Length);
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine("NullReferenceException caught!");
            Console.WriteLine(e.Message);
        }
    }
}
