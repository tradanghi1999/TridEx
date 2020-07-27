using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridGetFileExtension
{
    public struct AnaInputData
    {
        private string[] _fileNames;
        private int[] _indexes;
        public AnaInputData(int[] indexes,string[] fileNames)
        {
            this._fileNames = fileNames;
            this._indexes = indexes;
        }
        public string[] FileNames
        {
            get
            {
                return _fileNames;
            }
            set
            {
                _fileNames = value;
            }
        }

        public int[] Indexes
        {
            get
            {
                return _indexes;
            }
            set
            {
                _indexes = value;
            }
        }
    }
}
