namespace DateTimeWorkaround.Types;

[QueryType]
public static class Query
{
    public static Book GetBook(DateTime dateTime, DateTimeOffset dateTimeOffset)
    {
        Console.WriteLine(dateTime.ToString("o"));
        Console.WriteLine(dateTimeOffset.ToString("o"));

        return new Book("C# in depth.", new Author("Jon Skeet"));
    }
}
