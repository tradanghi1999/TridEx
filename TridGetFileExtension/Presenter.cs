using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TridGetFileExtension
{
    public class Presenter : OutPutBoudary
    {
        ViewModel viewModel;
        
        public Presenter(ViewModel vmodel)
        {
            viewModel = vmodel;
        }

        public void receiveOutPutDataFromInteractor(List<OutPutData> outPutDatas)
        {
            //throw new NotImplementedException();
            
            sendFileViewModelsToUI(generateFileViewModels(outPutDatas));
        }

        private void sendFileViewModelsToUI(List<FileViewModel> fileViewModels)
        {
            //throw new NotImplementedException();
            viewModel.FileViewModels = fileViewModels;
        }

        private List<FileViewModel> generateFileViewModels(List<OutPutData> outPutDatas)
        {
            if (outPutDatas == null || outPutDatas.Count == 0)
                return null;
            
            
            List<FileViewModel> fileViewModels = new List<FileViewModel>();
            foreach(OutPutData outPutData in outPutDatas)
            {
                fileViewModels.Add(new FileViewModel()
                {
                    AnalyzedState = outPutData.AnalyzedState,
                    EditedState = outPutData.EditedState,
                    FileName = outPutData.FileName,
                    Extension = outPutData.Extension
                });
            }

            return fileViewModels;
            

        }

        

        public void recieveOpenFileStateFromInteractor(bool state)
        {
            //throw new NotImplementedException();
            viewModel.OpenState = state;
        }
    }
}
