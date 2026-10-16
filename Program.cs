using System;

class Program
{
    static void Main(string[] args)
    {
        Node[] nodes =
        {
            new Node("nodeA", true),
            new Node("nodeB", false),
            new Node("nodeC", true),
            new Node("nodeD", false)
        };

        Node[] selected = Selection.Apply(nodes);

        foreach (Node node in selected)
        {
            Console.WriteLine(Formatter.Format(node));
        }

        string summary = Summary.Build(selected);

        if (summary.Length > 0)
        {
            Console.WriteLine(summary);
        }
    }
}
