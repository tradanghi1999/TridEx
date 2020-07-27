using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridGetFileExtension
{
    public class IOGateWayTestCase
    {
        IOgateWay _iIO;
        TestCaseIGUI _iGUI;
        public IOGateWayTestCase(IOgateWay iIO, TestCaseIGUI iGUI)
        {
            _iIO = iIO;
            _iGUI = iGUI;

            _iGUI.beginTesting("IOGateWay");
            _iGUI.attachResult(getFileInFolderNonRecursiveIoTest());
            _iGUI.attachResult(getByteFromFileIOTest());
            _iGUI.endTesting();


        }

        public string getFileInFolderNonRecursiveIoTest()
        {
            string[] files = _iIO.getFileInFolderNonRecursive("C:\\TestDir");
            if (files.Length < 3)
            {
                return "getFileInFolderNonRecursiveIoTest unpass";
            }
            //

            if (!(files[0].Contains("file1.txt")) ||
               !(files[1].Contains("file2.php")) ||
               !(files[2].Contains("file3")))
                return "getFileInFolderNonRecursiveIoTest unpass";



            return "getFileInFolderNonRecursiveIoTest pass";
        }
        public string getByteFromFileIOTest()
        {
            if (!(_iIO.getByteFromFile("C:\\TestDir\\file2.php").Length > 0))
                return "getByteFromFileTest unpass";
            return "getByteFromFileTest pass";
        }
       
    }
}
