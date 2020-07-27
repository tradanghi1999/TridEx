using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TridGetFileExtension
{
    public class HardDriveHistory
    {
        string _fileName;
        public HardDriveHistory()
        {
            _fileName = ConfigurationManager.ConnectionStrings["history"].ConnectionString;
        }
        public HardDriveHistory(string fileName)
        {
            _fileName = fileName;
        }

        internal string getJsonHistory()
        {
            //throw new NotImplementedException();
            if (!(File.Exists(_fileName)))
                return null;

            string json;
            using (StreamReader stream = new StreamReader(_fileName))
            {
                json = stream.ReadToEnd();
            }
            return json;
        }

        internal void writeJsonHistory(string jsonHis)
        {
            //throw new NotImplementedException();
            using (StreamWriter stream = new StreamWriter(_fileName))
            {
                stream.Write(jsonHis);
            }    

        }
    }
}
