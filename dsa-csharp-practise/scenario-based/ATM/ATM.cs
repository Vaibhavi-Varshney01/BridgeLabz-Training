using System;
class ATM{
  private ATMNote[] notes;
  public ATM(int [] denominations){
    notes = new ATMNote[denominations.Length];
    for(int i = 0; i<denominations.Length; i++){
      notes[i] = new ATMNote(denominations[i]);
    }
  }
  public void Dispense(int amount){
    int remaining = amount;
    for(int i = 0; i<notes.Length; i++){
      if(remaining >= notes[i].Denomination){
        notes[i].Count = remaining / notes[i].Denomination;
        remaining %= notes[i].Denomination;
      }
    }
    if(remaining == 0){
      Console.WriteLine("Exact cash dispensed");
    }
    else{
      Console.WriteLine("Fallback Combo used");
    }
    for(int i = 0; i<notes.Length; i++){
      if(notes[i].Count > 0){
        Console.WriteLine($"Rs.{notes[i].Denomination} x {notes[i].Count}");
      }
      if(remaining>0){
        Console.WriteLine($"Remaining: Rs.{remaining}");
      }
    }
  }
}