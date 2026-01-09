using System;
using System.Collections.Generic;

class PetrolPump{
  public static int FindStart(int [] petrol, int [] distance){
    int start = 0, surplus=0, deficit = 0;
    for(int i = 0; i<petrol.Length; i++){
      surplus += petrol[i] - distance[i];

      if(surplus < 0){
        start = i+1;
        deficit += surplus;
        surplus = 0;
      }
    }
    return (surplus + deficit >= 0) ? start : -1;
  }
}