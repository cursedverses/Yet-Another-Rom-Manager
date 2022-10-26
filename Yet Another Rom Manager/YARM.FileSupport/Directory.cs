using YARM.FileSupport.Interfaces;

namespace YARM.FileSupport
{
    internal class Directory : IRomContainer
    {
        public Directory(DirectoryInfo di)
        {
            FsContainer = di;
        }
        public IRomItem[] Files => throw new NotImplementedException();

        public FileSystemInfo FsContainer { get; private set; }

        public HashAlgorithm SupportedHashAlgorithms => throw new NotImplementedException();

        public string[] Tags => throw new NotImplementedException();

        public RomContainer Type => RomContainer.Directory;

        public int CompareTo(IDatRomFile dat)
        {
            throw new NotImplementedException();
        }
    }
}
