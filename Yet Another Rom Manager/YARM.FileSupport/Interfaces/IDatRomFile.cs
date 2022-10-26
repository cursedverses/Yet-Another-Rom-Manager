using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YARM.FileSupport.Interfaces
{
    internal interface IDatRomFile
    {
        byte[] Crc { get; }
        byte[] Md5 { get; }
        string Name { get; }
        byte[] Sha1 { get; }
        long Size { get; }
    }
}
