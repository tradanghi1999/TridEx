using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridGetFileExtension.TestCase
{
    public class FileModelTestCase
    {
        TestCaseIGUI _iGUI;
        FileModel _filemdl;
        public FileModelTestCase(TestCaseIGUI igui)
        {
            InitiateObj();

            _iGUI = igui;

            _iGUI.beginTesting("FileModel");
            _iGUI.attachResult(receiveMemoryFromInteractorTest());
            _iGUI.attachResult(analyzeTest());
            _iGUI.endTesting();
        }

        private void InitiateObj()
        {
            _filemdl = new FileModel();
            _filemdl.FileFullName = "C:\\TestDir\\0ac62dc26de49c05241fa8f63432babb";
            _filemdl.Extension = "";
            _filemdl.FileName = "0ac62dc26de49c05241fa8f63432babb";
            _filemdl.DirPath = "C:\\TestDir";
        }

        public string receiveMemoryFromInteractorTest()
        {
            string fileName = "C:\\TestDir\\0ac62dc26de49c05241fa8f63432babb";
            byte[] bytes;
            using (FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                bytes = new byte[file.Length];
                file.Read(bytes, 0, (int)file.Length);
            }
            //return bytes;
            _filemdl.receiveMemoryFromInteractor(bytes);

            string tempContent;
            using (StreamReader file = new StreamReader(_filemdl.TempPath))
            {
                tempContent = file.ReadToEnd();
            }

            string rootContent;
            
            using (StreamReader file = new StreamReader(fileName))
            {
                rootContent = file.ReadToEnd();
            }

            if (tempContent.GetHashCode() != rootContent.GetHashCode())
            {
                return "receiveMemoryFromInteractorTest unpass";
            }

            return "receiveMemoryFromInteractorTest pass";
        }

        public string analyzeTest()
        {
            _filemdl.analyze();
            if (!(_filemdl.Extension.ToLower().Contains("djv")))
                return "AnalyzeTest unpass";
            return "AnalyzeTest pass";
        }


    }
}
