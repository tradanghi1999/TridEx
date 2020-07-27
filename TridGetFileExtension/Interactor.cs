using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridGetFileExtension
{
    public class Interactor: InputBoundary
    {
        public IOgateWay IGateWay { get; set; }
        public OutPutBoudary OutPutBoudary { get; set; }
        public IHistory IHistory { get; set; }


        private List<FileModel> fileModels;
        public Interactor(IOgateWay gate)
        {
            this.IGateWay = gate;

        }

        public Interactor(IOgateWay gate, OutPutBoudary outbound)
        {
            this.IGateWay = gate;
            this.OutPutBoudary = outbound;

        }

        public Interactor(IOgateWay gate, OutPutBoudary outbound, IHistory iHis)
        {
            this.IGateWay = gate;
            this.OutPutBoudary = outbound;
            this.IHistory = iHis;
        }


        public void LoadHistory()
        {
            string his =null;
            if (IHistory != null)
                his = IHistory.getJsonHistory();

            fileModels = createFileModelsFromJsonHis(his);
            if (fileModels == null || fileModels.Count == 0)
                return;

            List<OutPutData> outPutDatas = generateOutputDataFromFileModels(fileModels);
            sendOutputDatas(outPutDatas);


        }

        public string[] getAllFilesInFolder(string dirPath)
        {
            return IGateWay.getFileInFolderNonRecursive(dirPath);
        }

        public List<FileModel> createFileModelsFromJsonHis(string json)
        {
            if (json == null)
                return null;

            List<FileModel> fileModels;

            fileModels = Newtonsoft.Json.JsonConvert.DeserializeObject<List<FileModel>>(json);

            return fileModels;



            
        }

        public List<FileModel> createFileModelsFromNames(string[] filesFullName)
        {
            if (filesFullName.Length == 0
                || filesFullName == null)
                return null;

            if(fileModels == null)
                fileModels = new List<FileModel>();
            
            foreach(string fileFN in filesFullName)
            {
                fileModels.Add(getFieModelFromFileFullName(fileFN));
            }
            return fileModels;
        }
        private FileModel getFieModelFromFileFullName(string fileFullName)
        {
            FileModel fileMdl = new FileModel();
            fileMdl.AnalyzedState = false;
            fileMdl.EditedState = false;
            fileMdl.FileFullName = fileFullName;
            fileMdl.FileName = getFileNameFromFileFullName(fileFullName);
            fileMdl.Extension = getExtensionFromFileFullName(fileFullName);
            fileMdl.DirPath = getDirPathFromFileFullName(fileFullName);

            return fileMdl;

            //return null;
        }

        private bool ProvideMemForModel(FileModel fmdl) // hop ly now
        {
            byte[] bytes = IGateWay.getByteFromFile(fmdl.FileFullName);
            fmdl.receiveMemoryFromInteractor(bytes);
            return false;
        }
        private string getFileNameFromFileFullName(string fileFullName)
        {
            return Path.GetFileNameWithoutExtension(fileFullName);
        }

        private string getExtensionFromFileFullName(string fileFullName)
        {
            return Path.GetExtension(fileFullName);
        }
        private string getDirPathFromFileFullName(string fileFullName)
        {
            return Path.GetDirectoryName(fileFullName);
        }

        public void recieveFileNamesFromController(InputData inputData)
        {
            //throw new NotImplementedException();
            addToFileModels(inputData.FileNames);
            List<OutPutData> outPutDatas = generateOutputDataFromFileModels(fileModels);
            sendOutputDatas(outPutDatas);

            IHistory.writeJsonHistory(Newtonsoft.Json.JsonConvert.SerializeObject(fileModels));
        }

        private void sendOutputDatas(List<OutPutData> outPutDatas)
        {
            OutPutBoudary.receiveOutPutDataFromInteractor(outPutDatas);
        }

        private List<OutPutData> generateOutputDataFromFileModels(List<FileModel> fileModels)
        {
            if (fileModels == null || fileModels.Count < 1)
                return null;

            List<OutPutData> outPutDatas = new List<OutPutData>();
            foreach(FileModel fMdl in fileModels)
            {
                OutPutData outPut = new OutPutData();
                outPut.AnalyzedState = fMdl.AnalyzedState;
                //outPut.DirPath = fMdl.DirPath;
                outPut.EditedState = fMdl.EditedState;
                outPut.Extension = fMdl.Extension;
                outPut.FileName = fMdl.FileName;
                //
                outPutDatas.Add(outPut);
            }
            return outPutDatas;
        }

        private void addToFileModels(string[] fileNames)
        {
            //throw new NotImplementedException();
            if (fileModels == null)
                fileModels = new List<FileModel>();

            foreach (string fileFN in fileNames)
            {
                if(!fileModelsExistInList(fileModels, fileFN))
                    fileModels.Add(getFieModelFromFileFullName(fileFN));
            }
        }
        private bool fileModelsExistInList(List<FileModel> fileModels, string fileName)
        {
            var fileMdl = fileModels.Find(x => x.FileFullName == fileName);
            if (fileMdl != null)
                return true;
            return false;
        }

        public void recevieAnaFileNamesFromController(InputData inputData)
        {
            //throw new NotImplementedException();
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += delegate (object sdr, DoWorkEventArgs ev)
            {
                BackgroundWorker wkr = sdr as BackgroundWorker;
                askFileModelsToAnalyze(inputData.Indexes, inputData.FileNames);

            };

            bw.ProgressChanged += delegate (object sdr, ProgressChangedEventArgs ev)
            {

            };
            bw.RunWorkerCompleted += delegate (object sdr, RunWorkerCompletedEventArgs ev)
            {
                List<OutPutData> outPutDatas = generateOutputDataFromFileModels(fileModels);
                sendOutputDatas(outPutDatas);

                IHistory.writeJsonHistory(Newtonsoft.Json.JsonConvert.SerializeObject(fileModels));
            };


            bw.RunWorkerAsync();
            

           

        }

        private void askFileModelsToAnalyze(int[] indexes, string[] fileNames)
        {
            if (indexes.Length != fileNames.Length)
                return;

            for (int i = 0; i < indexes.Length; i++)
            {
                if (fileModels[indexes[i]].FileName == fileNames[i])
                {
                    if (accquireMemoryForFileModel(fileModels[indexes[i]]))
                        fileModels[indexes[i]].analyze();
                    
                }
            }

        }

        private bool accquireMemoryForFileModel(FileModel fdm)
        {

            //version ngày 26/7
            try
            {
            
                byte[] memblock = IGateWay.getByteFromFile(fdm.FileFullName);
                sendMemForFileModel(memblock, fdm);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
            
        }

        private void sendMemForFileModel(byte[] memblock, FileModel fdm)
        {
            fdm.receiveMemoryFromInteractor(memblock);
        }

        public void recevieEdtFileNamesFromController(InputData inputData)
        {
            //throw new NotImplementedException();
            askFileModelsToEdit(inputData.Indexes, inputData.FileNames);

            List<OutPutData> outPutDatas = generateOutputDataFromFileModels(fileModels);
            sendOutputDatas(outPutDatas);

            IHistory.writeJsonHistory(Newtonsoft.Json.JsonConvert.SerializeObject(fileModels));
        }

        private bool askFileModelsToEdit(int[] indexes, string[] fileNames)
        {
            //throw new NotImplementedException();
            if (indexes.Length != fileNames.Length)
                return false;

            for (int i = 0; i < indexes.Length; i++)
            {
                if (fileModels[indexes[i]].FileName == fileNames[i])
                {
                        fileModels[indexes[i]].edit();
                }
            }

            return true;
        }

        public void recevieOpenFileNamesFromController(InputData inputData)
        {
            //throw new NotImplementedException();
            bool state;
            if ( state = askFileModelsToOpen(inputData.Indexes, inputData.FileNames))
            {
                sendOpenStateToOutBoundary(state);
            }    

        }
        void sendOpenStateToOutBoundary(bool state)
        {
            OutPutBoudary.recieveOpenFileStateFromInteractor(state);
        }

        private bool askFileModelsToOpen(int[] indexes, string[] fileNames)
        {
            //throw new NotImplementedException();
            if (indexes.Length != fileNames.Length)
                return false;

            for (int i = 0; i < indexes.Length; i++)
            {
                if (fileModels[indexes[i]].FileName == fileNames[i])
                {
                    return fileModels[indexes[i]].open();
                }
            }
            return false;

            
        }
    }
}
