using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrID;

namespace LocalFileModelEngine
{
    public class FileModel : Model
    {
        [JsonProperty("file_full_name")]
        public string FileFullName { get; set; }
        [JsonProperty("file_name")]
        public string FileName { get; set; }
        [JsonProperty("dir_path")]
        public string DirPath { get; set; }
        [JsonProperty("ext")]
        public string Extension { get; set; }
        [JsonProperty("ana_st")]
        public bool AnalyzedState { get; set; }
        [JsonProperty("edt_st")]
        public bool EditedState { get; set; }

        private string _tempPath;
        private byte[] _memFile;
        //private TrIDEngine _trid;
        public bool receiveMemoryFromInteractor(byte[] bytes)
        {
            _memFile = bytes;
            using (Stream file = File.OpenWrite(_tempPath = Path.GetTempFileName()))
            {
                file.Write(_memFile, 0, _memFile.Length);
            }
            return false;

        }

        public string TempPath
        {
            get
            {
                return _tempPath;
            }
        }

        public void analyze()
        {
            if (_tempPath == null)
                return;
            if (AnalyzedState == true && (Extension != "" || Extension != null))
                return;
            // if (_trid == null)
            //    _trid = new TrIDEngine();



            //return null;


            try
            {
                this.Extension = TrID.TrIDEngine.GetExtensionByFileContent(_tempPath);
                this.AnalyzedState = true;
            }
            catch (Exception e)
            {
                //obejct was not set to instance of object là file không có gì
                // out side bound of array là không có file như vậy
            }
        }

        private string analyzeWithFileName(string filename)
        {
            //return TrIDEngine.GetBestExtension(filename);
            //throw new NotImplementedException();
            if (!(File.Exists(filename)))
                return null;
            return TrID.TrIDEngine.GetExtensionByFileContent(filename);
        }

        public void edit()
        {
            //chưa phân tích
            if (Extension == null ||
                Extension == "" ||
                AnalyzedState == false
                )
                return;

            //file tồn tại ở cùng thư mục

            //file copy đi chỗ khác


            // if (_trid == null)
            //    _trid = new TrIDEngine();



            //return null;


            try
            {
                // đáng lẽ phải acquire memory from interactor - nơi cấp nguồn lực
                if (FileFullName.Contains(Extension))//file đã có sẫn đúng extension
                {

                }
                else
                {
                    File.Copy(FileFullName, DirPath + "\\" + FileName + Extension);
                }
                this.EditedState = true;
            }
            catch (Exception e)
            {
                //obejct was not set to instance of object là file không có gì
                // out side bound of array là không có file như vậy
            }
        }

        string getFileEditedFullName()
        {
            return DirPath + "\\" + FileName + Extension;
        }
        public bool open()
        {
            if (AnalyzedState == false || !EditedState)
            {
                return openFileNotepad(FileFullName);
            }
            string fileFN = getFileEditedFullName();
            if (File.Exists(fileFN))
            {
                // what the hell
            }
            else
            {
                File.Copy(FileFullName, DirPath + "\\" + FileName + Extension);
            }
            return openFile(fileFN);

        }
        bool openFileNotepad(string fileName)
        {
            try
            {
                System.Diagnostics.Process.Start("notepad.exe", fileName);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        bool openFile(string fileName)
        {
            try
            {
                System.Diagnostics.Process.Start(fileName);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
