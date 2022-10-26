namespace YARM.FileSupport.Interfaces
{
    internal interface IDatHeader
    {
        string Author { get; }
        DateTime Date { get; }
        string Description { get; }
        string Homepage { get; }
        string Name { get; }
        Uri Url { get; }
        DateTime Version { get; }
    }
}
