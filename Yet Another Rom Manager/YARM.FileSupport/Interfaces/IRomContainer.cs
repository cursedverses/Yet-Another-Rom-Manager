using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YARM.FileSupport.Interfaces
{
    enum RomContainer
    {
        Directory,
        Zip,
        Chd
    }
    enum HashAlgorithm
    {
        CRC = 0b00000001,
        MD5 = 0b00000010,
        SHA1 = 0b00000100
    }
    internal interface IRomContainer
    {
        IRomItem[] Files { get; }
        FileSystemInfo FsContainer { get; }
        HashAlgorithm SupportedHashAlgorithms { get; }
        string[] Tags { get; }
        RomContainer Type { get; }
        public int CompareTo(IDatRomFile dat);
    }
}
