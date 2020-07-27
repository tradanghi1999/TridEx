using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridGetFileExtension
{
    public interface IGUI
    {
        void recieveFileViewModelsFromPresenter(List<FileViewModel> fvms);
    }
}
