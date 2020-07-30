using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LocalGUIWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        [STAThread]
        public  static void Main()
        {

            App app = new App();

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

            Window gui = new MainWindow(ictrl, viewModel);

            interactor.LoadHistory();

            //Window gui = new WindowTest();

            app.Run(gui);


        }
    }
}
