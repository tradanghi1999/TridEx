using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalInteractor
{
    public struct InputData
    {
        private string[] _fileNames;
        public InputData(string[] fileNames)
        {
            this._fileNames = fileNames;
            this._indexes = null;
        }
        private int[] _indexes;
        public InputData(int[] indexes, string[] fileNames)
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
