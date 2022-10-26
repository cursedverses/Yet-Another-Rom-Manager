namespace YARM.FileSupport.Interfaces
{
    internal interface IRomItem
    {
        byte[] Crc { get; }
        string FileName { get; }
        byte[] Md5sum { get; }
        byte[] Sha1sum { get; }
    }
}
