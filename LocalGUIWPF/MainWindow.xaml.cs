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
using Svg.Skia;
using SkiaSharp;
using System.Data;
using Microsoft.Win32;

namespace LocalGUIWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //

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

            //
            showDoing();
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
            if (_viewModel.OpenState)
                hideDoing();
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


                WPF_FileViewModel  vm= new WPF_FileViewModel(stt, fvm);

                dgvFileChosen.Items.Add(
                    vm
                    );
                
                if(vm.HasContextMenu)
                {
                    
                }
                stt++;
            }
            

            hideDoing();
        }

        private void hideDoing()
        {
            pnlLoadingChosen.Visibility = Visibility.Hidden;
            //throw new NotImplementedException();
        }

        private void showDoing()
        {
            pnlLoadingChosen.Visibility = Visibility.Visible;
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
            public bool HasContextMenu { get; set; }
            public WPF_FileViewModel(int id, FileViewModel fvm)
            {
                Id = id + "";
                FileName = fvm.FileName;
                Extension = fvm.Extension;
                AnalyzedStateImage = fvm.getAnalyzedStateImage();
                EditedStateImage = fvm.getEditedStateImage();
                HasContextMenu = fvm.EditedState;
            }
        }

        private void btnAna_Click(object sender, RoutedEventArgs e)
        {
            showDoing();
            if (dgvFileChosen.SelectedItems.Count < 1)
            {
                hideDoing();
                return;
            }

            _iController.sendIndexesAndFileNamesInJsonToAnalyze(getItemsJsonStringArray());
        }

        string[] getItemsJsonStringArray()
        {
            string[] items = new string[dgvFileChosen.SelectedItems.Count];

            int fvmsCount = _viewModel.FileViewModels.Count;
            int sttInItems = 0;
            var rows = dgvFileChosen.SelectedItems;
            foreach (var row in rows)
            {
                WPF_FileViewModel vm = (WPF_FileViewModel)row;
                //sort anh huong den index

                int temp = -1;
                
                string index = "0";
                if (int.TryParse(vm.Id, out temp))
                {
                    index = (temp-1)+"";
                }
                
                string fileName = vm.FileName;
                //string fileName = row.Cells["colFName"].Value.ToString();

                string item = "{" +
                                   "\'index\': \'" + index + "\'," +
                                    "\'fileName\': \'" + fileName + "\'" +
                               "}";
                items[sttInItems] = item;
                sttInItems++;
            }
            return items;
        }

        private void btnEdt_Click(object sender, RoutedEventArgs e)
        {
            showDoing();
            if (dgvFileChosen.SelectedItems.Count < 1)
            {
                hideDoing();
                return;
            }

            _iController.sendIndexesAndFileNamesInJsonToEdit(getItemsJsonStringArray());
        }


        

        OpenFileDialog ofd = new OpenFileDialog();
        private void btnChoose_Click(object sender, RoutedEventArgs e)
        {
            ofd.Multiselect = true;
            if ((bool)ofd.ShowDialog())
            {
                _iController.sendFileNames(ofd.FileNames);
            }
        }

        private void dgvFileChosen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgvFileChosen.SelectedItems.Count < 1)
            {
                //hideDoing();
                return;
            }
            foreach (var row in dgvFileChosen.SelectedItems)
            {
                if(row is WPF_FileViewModel)
                {
                    WPF_FileViewModel vm = (WPF_FileViewModel)row;
                    if(!vm.HasContextMenu)
                    {
                        mnuOpen.IsEnabled = false;
                        mnuSave.IsEnabled = false;
                        return;
                    }    
                }    
            }
            mnuOpen.IsEnabled = true;
            mnuSave.IsEnabled = true;

        }

        private void dgvFileChosen_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dgvFileChosen.SelectedItems.Count < 1)
            {
                //hideDoing();
                return;
            }

            foreach (var row in dgvFileChosen.SelectedItems)
            {
                if (row is WPF_FileViewModel)
                {
                    WPF_FileViewModel vm = (WPF_FileViewModel)row;
                    if (!vm.HasContextMenu)
                    {
                        return;
                    }
                }
            }
            openFiles();
        }

        private void openFiles()
        {
            //throw new NotImplementedException();
            showDoing();
            //throw new NotImplementedException();
            if (dgvFileChosen.SelectedItems.Count != 1)
            {
                //hideDoing();
                return;
            }
            _iController.sendIndexesAndFileNamesInJsonToOpen(getItemsJsonStringArray());
        }

        private void mnuOpen_Click(object sender, RoutedEventArgs e)
        {
            openFiles();
        }
    }
}
