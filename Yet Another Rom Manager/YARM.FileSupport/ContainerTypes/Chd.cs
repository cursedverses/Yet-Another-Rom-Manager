using YARM.FileSupport.Interfaces;

namespace YARM.FileSupport.ContainerTypes
{
    internal class Chd : IRomContainer
    {
        public Chd(FileInfo fi)
        {
            FsContainer = fi;
        }
        public IRomItem[] Files => throw new NotImplementedException();

        public FileSystemInfo FsContainer { get; private set; }

        public HashAlgorithm SupportedHashAlgorithms => throw new NotImplementedException();

        public string[] Tags => throw new NotImplementedException();

        public RomContainer Type => RomContainer.Chd;

        public int CompareTo(IDatRomFile dat)
        {
            throw new NotImplementedException();
        }
    }
}
