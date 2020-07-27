using PreController;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LocalGUIWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private PreController.IController _iController;
        private PreController.ViewModel _viewModel;
        public MainWindow(PreController.IController controller, PreController.ViewModel viewModel)
        {
            InitializeComponent();
            //ui doing

            //binding
            _iController = controller;
            _viewModel = viewModel;

            //binding event
            doDataBindingEvents();
        }

        private void doDataBindingEvents()
        {
            //throw new NotImplementedException();
            _viewModel.FileViewModelsChanged += _viewModel_FileViewModelsChanged;
            _viewModel.OpenStateChanged += _viewModel_OpenStateChanged;
        }

        private void _viewModel_OpenStateChanged()
        {
            //throw new NotImplementedException();
        }

        private void _viewModel_FileViewModelsChanged()
        {
            //throw new NotImplementedException();

            recieveFileViewModelsFromPresenter(_viewModel.FileViewModels);
        }

        private void recieveFileViewModelsFromPresenter(List<FileViewModel> fvms)
        {
            //throw new NotImplementedException();

            if (fvms == null || fvms.Count == 0)
            {
                hideDoing();
                return;
            }
            dgvFileChosen.Items.Clear();


            

            int stt = 1;
            foreach (PreController.FileViewModel fvm in fvms)
            {



                dgvFileChosen.Items.Add(
                    new WPF_FileViewModel(stt, fvm)
                    );

                stt++;
            }
        }

        private void hideDoing()
        {
            throw new NotImplementedException();
        }

        private void MenuItem_Checked(object sender, RoutedEventArgs e)
        {
            grbPreview.Visibility = Visibility.Visible;
        }

        private void MenuItem_Unchecked(object sender, RoutedEventArgs e)
        {
            grbPreview.Visibility = Visibility.Collapsed;
        }

        private void MenuItem_Checked_1(object sender, RoutedEventArgs e)
        {
            grbExplorer.Visibility = Visibility.Visible;
        }

        private void MenuItem_Unchecked_1(object sender, RoutedEventArgs e)
        {
            grbExplorer.Visibility = Visibility.Collapsed;
        }


        public struct WPF_FileViewModel
        {
            public string Id { get; set; }
            public string FileName { get; set; }
            public string Extension { get; set; }
            public Bitmap AnalyzedStateImage { get; set; }
            public Bitmap EditedStateImage { get; set; }
            public WPF_FileViewModel(int id, FileViewModel fvm)
            {
                Id = id + "";
                FileName = fvm.FileName;
                Extension = fvm.Extension;
                AnalyzedStateImage = fvm.getAnalyzedStateImage();
                EditedStateImage = fvm.getEditedStateImage();
            }
        }
    }
}
