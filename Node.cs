class Node
{
    public string Name { get; }
    public bool Available { get; }

    public Node(string name, bool available)
    {
        Name = name;
        Available = available;
    }
}