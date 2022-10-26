using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YARM.FileSupport.Interfaces;

namespace YARM.FileSupport
{
    internal class Chd : Base.Rom, IRomContainer
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
