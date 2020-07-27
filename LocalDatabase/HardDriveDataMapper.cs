using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase
{
    public class HardDriveDataMapper : LocalInteractor.IOgateWay
    {
        HardDrive hardDrive;
        public HardDriveDataMapper()
        {
            hardDrive = new HardDrive();
        }

        public byte[] getByteFromFile(string fileName)
        {
            //throw new NotImplementedException();
            return hardDrive.getByteFromFile(fileName);
        }

        public string[] getFileInFolderNonRecursive(string dirPath)
        {
            //throw new NotImplementedException();

            return hardDrive.getAllFilesInFolder(dirPath);
        }
    }
}
