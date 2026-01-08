using System;
class FriendNode{
    public int Id;
    public FriendNode Next;
    public FriendNode(int id) { Id = id; }
}
class UserNode{
    public int Id;
    public string Name;
    public FriendNode Friends;
    public UserNode Next;
    public UserNode(int id, string name)
    {
        Id = id; Name = name;
    }
}
class SocialMedia{
    UserNode head;

    public void AddUser(int id, string name)
    {
        UserNode u = new UserNode(id, name);
        u.Next = head;
        head = u;
    }

    UserNode Find(int id)
    {
        for (UserNode t = head; t != null; t = t.Next)
            if (t.Id == id) return t;
        return null;
    }

    public void AddFriend(int a, int b)
    {
        UserNode u1 = Find(a), u2 = Find(b);
        u1.Friends = new FriendNode(b) { Next = u1.Friends };
        u2.Friends = new FriendNode(a) { Next = u2.Friends };
    }

    public void Show(int id)
    {
        FriendNode f = Find(id).Friends;
        Console.Write("Friends: ");
        while (f != null)
        {
            Console.Write(f.Id + " ");
            f = f.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        SocialMedia s = new SocialMedia();
        s.AddUser(1, "A");
        s.AddUser(2, "B");
        s.AddFriend(1, 2);
        s.Show(1);
    }
}
