using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalInteractor
{
    public struct OutPutData
    {
        //public string FileFullName { get; set; }
        public string FileName { get; set; }
        //public string DirPath { get; set; }
        public string Extension { get; set; }
        public bool AnalyzedState { get; set; }
        public bool EditedState { get; set; }
    }
}
