using System;
using System.Collections.Generic;

class StockSpan{
  public static void CalculateSpan(int [] price){
    int n = price.Length;
    int [] span = new int[n];
    Stack<int> stack = new Stack<int>();

    Stack.Push(0);
    span[0] = 1;
    for(int i = 1; i<n; i++){
      while(stack.Count > 0 && price[stack.Peek()] <= price[i])
        stack.Pop();
        span[i] = (stack.Count == 0) ? i + 1 : i - stack.Peek();
        stack.Push(i);
    }
    for(int i = 0; i<n; i++){
      Console.WriteLine(span[i] + " ");
    }
  }
}