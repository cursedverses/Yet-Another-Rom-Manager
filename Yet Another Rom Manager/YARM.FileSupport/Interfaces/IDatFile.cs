using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
