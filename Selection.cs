using System.Collections.Generic;

static class Selection
{
    public static Node[] Apply(Node[] nodes)
    {
        var result = new List<Node>();

        foreach (Node node in nodes)
        {
            if (node.Available == false)
            {
                result.Add(node);
            }
        }

        return result.ToArray();
    }
}