using System;
class ItemNode{
    public int Id;
    public string Name;
    public int Qty;
    public double Price;
    public ItemNode Next;
    public ItemNode(int id, string n, int q, double p){
        Id = id; Name = n; Qty = q; Price = p;
    }
}
class Inventory{
    ItemNode head;
    public void Add(int id, string n, int q, double p){
        ItemNode node = new ItemNode(id, n, q, p);
        node.Next = head;
        head = node;
    }
    public void TotalValue(){
        double sum = 0;
        ItemNode temp = head;
        while (temp != null){
            sum += temp.Price * temp.Qty;
            temp = temp.Next;
        }
        Console.WriteLine("Total Inventory Value = " + sum);
    }
}
