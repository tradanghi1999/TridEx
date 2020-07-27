using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridGetFileExtension
{
    public interface IOgateWay
    {
        string[] getFileInFolderNonRecursive(string dirPath);
        byte[] getByteFromFile(string fileName);
    }
}
