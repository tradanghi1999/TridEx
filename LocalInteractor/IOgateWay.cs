using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalInteractor
{
    public interface IOgateWay
    {
        string[] getFileInFolderNonRecursive(string dirPath);
        byte[] getByteFromFile(string fileName);
    }
}
