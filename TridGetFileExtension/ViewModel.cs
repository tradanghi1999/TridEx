using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridGetFileExtension
{
    public class ViewModel
    {
        List<FileViewModel> _fileViewModels;
        private bool _openState;
        public bool OpenState
        {
            get
            {
                return _openState;
            }
            set
            {
                _openState = value;
                OpenStateChanged();
            }
        }
        public List<FileViewModel> FileViewModels
        {
            get
            {
                return _fileViewModels;
            }
            set
            {
                _fileViewModels = value;
                FileViewModelsChanged();
            }
        }

        public event Action FileViewModelsChanged;
        public event Action OpenStateChanged;
    }
}
