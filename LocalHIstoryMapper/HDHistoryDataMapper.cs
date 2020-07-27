using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LocalHIstoryMapper
{
    public class HDHistoryDataMapper : LocalInteractor.IHistory
    {
        HardDriveHistory hdh;
        public HDHistoryDataMapper()
        {
            hdh = new HardDriveHistory();
        }
        public string getJsonHistory()
        {
            //throw new NotImplementedException();
            return hdh.getJsonHistory();
        }

        public void writeJsonHistory(string jsonHis)
        {
            //throw new NotImplementedException();
            hdh.writeJsonHistory(jsonHis);
        }
    }
    
}
