using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TridGetFileExtension.TestCase;

namespace TridGetFileExtension
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GUI());





            //Form gui = new TestCaseGUI();


            //TestCaseIGUI igui = (TestCaseIGUI)gui;
            //HardDriveTestCase hdTest = new HardDriveTestCase(igui);
            //HardDriveDataMapperTestCase hddmTest = new HardDriveDataMapperTestCase(igui);

            //IOgateWay io = new HardDriveDataMapper();
            //IOGateWayTestCase ioTest = new IOGateWayTestCase(io, igui);


            //IOgateWay io2 = new HardDriveDataMapper();
            //InteractorTestCase interTest = new InteractorTestCase(io2, igui);

            //FileModelTestCase fileTest = new FileModelTestCase(igui);

            //igui.attachResult(TrID.TrIDEngine.GetExtensionByFileContent("C:\\TestDir\\0ac62dc26de49c05241fa8f63432babb"));




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            HardDriveDataMapper hddm = new HardDriveDataMapper();
            IOgateWay io = (IOgateWay)hddm;

            HDHistoryDataMapper hdhdm = new HDHistoryDataMapper();
            IHistory ihis = (IHistory)hdhdm;

            ViewModel viewModel = new ViewModel();
            Presenter presenter = new Presenter(viewModel);
            OutPutBoudary outPutBoudary = (OutPutBoudary)presenter;

            Interactor interactor = new Interactor(io, outPutBoudary, ihis);

            InputBoundary inputBoundary = (InputBoundary)interactor;

            Controller ctrl = new Controller(inputBoundary);
            IController ictrl = (IController)ctrl;

            Form gui = new GUI(ictrl, viewModel);

            interactor.LoadHistory();

            Application.Run(gui);

            //Coordinate point = new Coordinate();

            //point.CoordinatesChanged += StructEventHandler;
            //point.x = 10;
            //point.y = 20;
        }

        static void StructEventHandler(int point)
        {
            Console.WriteLine("Coordinate changed to {0}", point);
        }
    }

    struct Coordinate
    {
        private int _x, _y;

        public int x
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
                CoordinatesChanged(_x);
            }
        }

        public int y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
                CoordinatesChanged(_y);
            }
        }

        public event Action<int> CoordinatesChanged;
    }
}
