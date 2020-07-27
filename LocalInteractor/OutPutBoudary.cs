using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalInteractor
{
    public interface OutPutBoudary
    {
        void receiveOutPutDataFromInteractor(List<OutPutData> outPutDatas);
        void recieveOpenFileStateFromInteractor(bool state);
    }
}
