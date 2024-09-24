// Linked List
internal class wantedchamp<T>
{
    public class Node
    {
        public string Value { get; set; }
        public Node Next { get; set; }

        public Node(string value)
        {
            this.Value = value;
            this.Next = null;
        }
    }

    private Node head;
    public Node Head
    {
        get { return this.head; }
    }

    public wantedchamp(string[] values)
    {
        this.head = new Node(values[0]);
        Node current = this.head;
        for (int i = 1; i < values.Length; i++)
        {
            current.Next = new Node(values[i]);
            current = current.Next;
        }
    }

    public bool LookFor(string e)
    {
        // Lookup through list
        Node curr = head;
        bool found = false;
        // curr.Value = default(T);
        while (curr != null)
        {
            if(curr.Value!.Equals(e))
            {
                found = true;
            }
            curr = curr.Next;
        }
        return found;
    }

    public string? Get(string e)
    {
        // Lookup through list
        Node? curr = head;
        string? found = default(string);
        // curr.Value = default(T);
        while (curr != null)
        {
            if (curr.Value!.Equals(e))
            {
                found = curr.Value;
                return found;
            }
            curr = curr.Next;
        }
        return null;
    }

}