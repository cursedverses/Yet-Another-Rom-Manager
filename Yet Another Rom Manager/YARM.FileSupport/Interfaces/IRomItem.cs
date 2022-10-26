using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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
