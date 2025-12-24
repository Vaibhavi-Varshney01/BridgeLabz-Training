using System;
public class PenDivision{
  public static void Main(String [] args){
    int pen = 14;
    int stu = 3;
    int remains = pen % stu;
    int divided = pen / stu;
    Console.WriteLine("The pen per Student is " + divided + " and the remaining pen not distributed is " + remains);
  }
}