namespace YARM.FileSupport.Interfaces
{
    internal interface IDatFile
    {
        string Category { get; }
        string Description { get; }
        IDatRomFile[] FileSet { get; }
        IDatHeader Header { get; }
    }
}
