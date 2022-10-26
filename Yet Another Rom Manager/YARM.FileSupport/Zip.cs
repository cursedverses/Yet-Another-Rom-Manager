using YARM.FileSupport.Interfaces;

namespace YARM.FileSupport
{
    internal class Zip : IRomContainer
    {
        public IRomItem[] Files => throw new NotImplementedException();

        public FileSystemInfo FsContainer => throw new NotImplementedException();

        public HashAlgorithm SupportedHashAlgorithms => throw new NotImplementedException();

        public string[] Tags => throw new NotImplementedException();

        public RomContainer Type => RomContainer.Zip;
        public int CompareTo(IDatRomFile dat)
        {
            throw new NotImplementedException();
        }
    }
}
