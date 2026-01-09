using System;
using System.Collections.Generic;

class StackSorting{
  static void Sort(Stack<int> stack){
    if(stack.Count > 0){
      int temp = stack.Pop();
      Sort(stack);
      InsertSorted(stack, temp);
    }
  }
  static void InsertSorted(Stack<int> stack, int element){
    if(stack.Count == 0 || stack.Peek() <= element){
      stack.Push(element);
      return;
    }
    int temp = stack.Pop();
    InsertSorted(stack, element);
    stack.Push(temp);
  }
}