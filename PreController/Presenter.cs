using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreController
{
    public class Presenter : LocalInteractor.OutPutBoudary
    {
        ViewModel viewModel;

        public Presenter(ViewModel vmodel)
        {
            viewModel = vmodel;
        }

        public void receiveOutPutDataFromInteractor(List<LocalInteractor.OutPutData> outPutDatas)
        {
            //throw new NotImplementedException();

            sendFileViewModelsToUI(generateFileViewModels(outPutDatas));
        }

        private void sendFileViewModelsToUI(List<FileViewModel> fileViewModels)
        {
            //throw new NotImplementedException();
            viewModel.FileViewModels = fileViewModels;
        }

        private List<FileViewModel> generateFileViewModels(List<LocalInteractor.OutPutData> outPutDatas)
        {
            if (outPutDatas == null || outPutDatas.Count == 0)
                return null;


            List<FileViewModel> fileViewModels = new List<FileViewModel>();
            foreach (LocalInteractor.OutPutData outPutData in outPutDatas)
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
