using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridGetFileExtension
{
    interface IGUIview
    {
        void onClickOKOpenDialog(string[] fileNames);
    }
}
