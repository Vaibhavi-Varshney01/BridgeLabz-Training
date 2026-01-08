using System;
class TextState{
    public string Content;
    public TextState Prev, Next;

    public TextState(string c)
    {
        Content = c;
    }
}
class Editor
{
    TextState current;
    public void AddState(string text)
    {
        TextState node = new TextState(text);
        if (current != null)
        {
            current.Next = node;
            node.Prev = current;
        }
        current = node;
    }
    public void Undo()
    {
        if (current?.Prev != null)
            current = current.Prev;
    }
    public void Redo()
    {
        if (current?.Next != null)
            current = current.Next;
    }
}
