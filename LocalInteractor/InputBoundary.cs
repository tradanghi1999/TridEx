using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalInteractor
{
    public interface InputBoundary
    {
        void recieveFileNamesFromController(InputData inputData);
        void recevieAnaFileNamesFromController(InputData inputData);
        void recevieEdtFileNamesFromController(InputData inputData);
        void recevieOpenFileNamesFromController(InputData inputData);
    }
}
