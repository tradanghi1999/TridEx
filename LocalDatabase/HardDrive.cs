using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDatabase
{
    internal class HardDrive
    {

        //config cho vào được các thư mục khoá mói chuẩn - giống database php



        public string[] getAllFilesInFolder(string dirPath)
        {
            return Directory.GetFiles(dirPath);
        }
        public byte[] getByteFromFile(string fileName)
        {

            byte[] bytes;
            using (FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                bytes = new byte[file.Length];
                file.Read(bytes, 0, (int)file.Length);
            }
            return bytes;
            //throw new NotImplementedException();
            //return null;
        }
    }
}
