using System;
class TicketNode{
    public int Id;
    public string Customer, Movie;
    public TicketNode Next;
}
class Ticket {
    TicketNode head;
    public void Add(int id, string c, string m){
        TicketNode node = new TicketNode { Id = id, Customer = c, Movie = m };
        if (head == null)
        {
            head = node;
            node.Next = head;
            return;
        }
        TicketNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;
        temp.Next = node;
        node.Next = head;
    }
}
