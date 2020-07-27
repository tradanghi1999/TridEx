using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalGUIWinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            LocalDatabase.HardDriveDataMapper hddm = new LocalDatabase.HardDriveDataMapper();
            LocalInteractor.IOgateWay io = (LocalInteractor.IOgateWay)(hddm);

            LocalHIstoryMapper.HDHistoryDataMapper hdhdm = new LocalHIstoryMapper.HDHistoryDataMapper();
            LocalInteractor.IHistory ihis = (LocalInteractor.IHistory)hdhdm;

            PreController.ViewModel viewModel = new PreController.ViewModel();
            PreController.Presenter presenter = new PreController.Presenter(viewModel);
            LocalInteractor.OutPutBoudary outPutBoudary = (LocalInteractor.OutPutBoudary)presenter;

            LocalInteractor.Interactor interactor = new LocalInteractor.Interactor(io, outPutBoudary, ihis);

            LocalInteractor.InputBoundary inputBoundary = (LocalInteractor.InputBoundary)interactor;

            PreController.Controller ctrl = new PreController.Controller(inputBoundary);
            PreController.IController ictrl = (PreController.IController)ctrl;

            Form gui = new GUI(ictrl, viewModel);

            interactor.LoadHistory();

            Application.Run(gui);
        }
    }
}
