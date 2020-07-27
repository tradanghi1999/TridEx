using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PreController
{
    public class FileViewModel
    {
        //public string FileFullName { get; set; }
        public string FileName { get; set; }
        //public string DirPath { get; set; }
        public string Extension { get; set; }
        public bool AnalyzedState { get; set; }
        public bool EditedState { get; set; }
        public Bitmap getAnalyzedStateImage()
        {
            return (new StateViewModel(this.AnalyzedState)).getStateImage(16);
        }
        public Bitmap getEditedStateImage()
        {
            return (new StateViewModel(this.EditedState)).getStateImage(16);
        }
    }
}
