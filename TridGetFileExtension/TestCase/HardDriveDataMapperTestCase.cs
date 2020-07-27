using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridGetFileExtension
{
    public class HardDriveDataMapperTestCase
    {
        TestCaseIGUI _igui;
        HardDriveDataMapper _hddm;
        public HardDriveDataMapperTestCase(TestCaseIGUI iGUI)
        {
            _hddm = new HardDriveDataMapper();

            this._igui = iGUI;
            this._igui.beginTesting("HardDriveDataMapper");
            //this._igui.attachResult(getFieModelFromHardDriveTestWithFileExtension());
            //this._igui.attachResult(getFieModelFromHardDriveTestWithoutFileExtension());
            this._igui.attachResult(getFileInFolderNonRecursiveTest());
            this._igui.attachResult(getByteFromFileTest());
            this._igui.endTesting();
        }

        public string getFileInFolderNonRecursiveTest()
        {
            string[] files = _hddm.getFileInFolderNonRecursive("C:\\TestDir");
            if (files.Length < 3)
            {
                return "getFileInFolderNonRecursiveTest unpass";
            }
            //

            if (!(files[0].Contains("file1.txt")) ||
               !(files[1].Contains("file2.php")) ||
               !(files[2].Contains("file3")))
                return "getFileInFolderNonRecursiveTest unpass";



            return "getFileInFolderNonRecursiveTest pass";

        }

        public string getByteFromFileTest()
        {
            if (!(_hddm.getByteFromFile("C:\\TestDir\\file2.php").Length > 0))
                return "getByteFromFileTest unpass";
            return "getByteFromFileTest pass";
            //return "getByteFromFileTest unpass"; 
        }

        //public string getFieModelFromHardDriveTestWithoutFileExtension()
        //{
        //    string fileFullName = "C:\\hochanh\\file";

        //    //FileModel fileModel = _hddm.getFieModelFromHardDrive(fileFullName);

        //    //if (fileModel == null ||
        //    //    fileModel.FileName != "file" ||
        //    //    fileModel.DirPath == null ||
        //    //    (fileModel.Extension != null && fileModel.Extension != "") ||
        //    //    !(fileModel.DirPath.Contains("C:\\hochanh")))
        //    //{
        //    //    return "getFieModelFromHardDriveTest unpass";
        //    //}
        //    return "getFieModelFromHardDriveTest pass";
        //}

        //public string getFieModelFromHardDriveTestWithFileExtension()
        //{
        //    string fileFullName = "C:\\hochanh\\file.txt";

        //    //FileModel fileModel = _hddm.getFieModelFromHardDrive(fileFullName);

        //    //if(fileModel ==null ||
        //    //    fileModel.FileName != "file" ||
        //    //    fileModel.DirPath==null||
        //    //    fileModel.Extension==null||
        //    //    !(fileModel.DirPath.Contains("C:\\hochanh"))||
        //    //    !(fileModel.Extension.Contains("txt")))
        //    //{
        //    //    return "getFieModelFromHardDriveTest unpass";
        //    //}
        //    return "getFieModelFromHardDriveTest pass";
        //}
    }
}
