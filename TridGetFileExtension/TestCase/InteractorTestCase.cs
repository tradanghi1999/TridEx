using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridGetFileExtension
{
    public class InteractorTestCase
    {
        Interactor _interactor;
        TestCaseIGUI _iGUI;
        public InteractorTestCase(IOgateWay io,TestCaseIGUI igui)
        {

            _interactor = new Interactor(io);
            _iGUI = igui;

            _iGUI.beginTesting("Interactor");
            _iGUI.attachResult(getAllFilesInFolderTest());
            _iGUI.attachResult(createFileModelsFromNamesTest());

            _iGUI.endTesting();
        }

        public string getAllFilesInFolderTest()
        {
            string[] files = _interactor.getAllFilesInFolder("C:\\TestDir");
            if (files.Length < 3)
            {
                return "getAllFilesInFolderTest unpass";
            }
            //

            if (!(files[0].Contains("file1.txt")) ||
               !(files[1].Contains("file2.php")) ||
               !(files[2].Contains("file3")))
                return "getAllFilesInFolderTest unpass";



            return "getAllFilesInFolderTest pass";
        }


        public string createFileModelsFromNamesTest()
        {
            string[] files = new string[] {
                "C:\\TestDir\\file1.txt",
                "C:\\TestDir\\file2.php",
                "C:\\TestDir\\file3"
            };
            
            List<FileModel> fileModels = _interactor.createFileModelsFromNames(files);
            
            //
            if(fileModels.Count < 3)
            {
                return "createFileModelsFromNamesTest unpass";
            } 
            //
            if(fileModels[0].FileName!="file1"||
                !(fileModels[0].Extension.Contains("txt"))||
                !(fileModels[0].DirPath.Contains("C:\\TestDir")))
            {
                return "createFileModelsFromNamesTest unpass";
            }
            //
            if (fileModels[1].FileName != "file2" ||
                !(fileModels[1].Extension.Contains("php")) ||
                !(fileModels[1].DirPath.Contains("C:\\TestDir")))
            {
                return "createFileModelsFromNamesTest unpass";
            }
            //
            if (fileModels[2].FileName != "file3" ||
                (fileModels[2].Extension != null && fileModels[2].Extension != "") ||
                !(fileModels[2].DirPath.Contains("C:\\TestDir")))
            {
                return "createFileModelsFromNamesTest unpass";
            }

            return "createFileModelsFromNamesTest pass";


        }
    }
}
