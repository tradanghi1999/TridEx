using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridGetFileExtension
{
    public class HardDriveTestCase
    {
        HardDrive hardDrive;
        public TestCaseIGUI TestCaseIGUI { get; set; }
        public HardDriveTestCase(TestCaseIGUI iGUI)
        {
            hardDrive = new HardDrive();

            this.TestCaseIGUI = iGUI;
            iGUI.beginTesting("HardDrive");
            //iGUI.attachResult(getFileNameTest());
            //iGUI.attachResult(getFileExtensionTest());
            //iGUI.attachResult(getDirPathTest());
            iGUI.attachResult(getAllFilesInDirTes());
            iGUI.attachResult(getByteFromFileTest());
            iGUI.endTesting();
        }
        //public string getFileNameTest()
        //{
            
        //    if(hardDrive.getFileNameFromFileFullName("C:\\file.txt") =="file")
        //    {
        //        return "getFileNameTest Pass";
                
        //    }    
        //    else
        //    {
        //        return "getFileNameTest unpass";
        //    }
        //    //Console.ReadLine();
        //}
        //public string getFileExtensionTest()
        //{
        //    if (hardDrive.getExtensionFromFileFullName("C:\\file.txt").Contains("txt"))
        //    {
        //        return "getFileExtensionTest Pass";

        //    }
        //    else
        //    {
        //        return "getFileNameTest unpass";
        //    }
        //}

        //public string getDirPathTest()
        //{

        //    //string dir = hardDrive.getDirPathFromFileFullName("C:\\file.txt");
        //    if (hardDrive.getDirPathFromFileFullName("C:\\hochanh\\file.txt").Contains("C:\\hochanh"))
        //    {
        //        return "getDirPathTest Pass";

        //    }
        //    else
        //    {
        //        return "getDirPathTest unpass";
        //    }
        //}

        public string getByteFromFileTest()
        {
            if (!(hardDrive.getByteFromFile("C:\\TestDir\\file2.php").Length > 0))
                return "getByteFromFileTest unpass";
            return "getByteFromFileTest pass";
        }

        public string getAllFilesInDirTes()
        {
            string[] files = hardDrive.getAllFilesInFolder("C:\\TestDir");
            //
            if(files.Length < 3)
            {
                return "getAllFilesInDirTes unpass";
            }
            //

            if(!(files[0].Contains("file1.txt"))||
               !(files[1].Contains("file2.php"))||
               !(files[2].Contains("file3")))
                return "getAllFilesInDirTes unpass";



            return "getAllFilesInDirTes pass";
        }
    }
}
