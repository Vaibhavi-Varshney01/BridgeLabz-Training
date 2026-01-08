using System;
class ProcessNode{
    public int Pid, Burst;
    public ProcessNode Next;
}
class RoundRobin{
    ProcessNode head;
    public void AddProcess(int id, int burst){
        ProcessNode node = new ProcessNode { Pid = id, Burst = burst };
        if (head == null)
        {
            head = node;
            node.Next = head;
            return;
        }
        ProcessNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;
        temp.Next = node;
        node.Next = head;
    }
}
