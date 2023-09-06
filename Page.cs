public class Page
{
    public string Content;
    public Page(string content)
    {
        Content = content;
    }

    public void Read()
    {
        Console.Clear();
        Console.WriteLine("\nPage contents:");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Book.WriteLine(Content);
        Console.ResetColor();
    }
}