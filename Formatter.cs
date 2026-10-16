static class Formatter
{
    public static string Format(Node node)
    {
        return node.Name + "; available=" + node.Available;
    }
}