using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace TridGetFileExtension
{
    public partial class GUI : Form
    {

        private Timer tmr;
        private MessageRenameBox msgRename;
        //IGUI iGUI;
        private IController _iController;
        private ViewModel _viewModel;
        

        public GUI(IController controller, ViewModel viewModel)
        {
            InitializeComponent();
            pnlLoading.Location = new Point((this.panel4.Width - pnlLoading.Width) / 2, ((this.panel4.Height - pnlLoading.Height) /2));
            panel4.Location = new Point((grbMain.Width-panel4.Width) / 2, (grbMain.Height - panel4.Height) / 2);
            //((ContextMenuStrip)viewToolStripMenuItem.DropDown).ShowCheckMargin = true;

            dgvFileChosen.RowStateChanged += DgvFileChosen_RowStateChanged;
            dgvFileChosen.CellMouseDown += DgvFileChosen_CellMouseDown;
            dgvFileChosen.CellDoubleClick += DgvFileChosen_CellDoubleClick;
            tulStrItmOpen.Click += TulStrItmOpen_Click;
            tulStrItmRename.Click += TulStrItmRename_Click;
            
            tmr = new Timer();
            tmr.Tick += Tmr_Tick;

            //
            //gbrPreview.Visible = false;

            //
            this.Load += GUI_Load;

            //lblHead.BackColor = Color.Transparent;
            //panel1.BackColor = Color.Transparent;
            //pictureBox1.BackColor = Color.FromArgb(0, Color.Black);
            //pnlDoing.BackColor = Color.FromArgb(0, Color.White);
            //public GUI(IGUI iGUI)
            //{
            //    InitializeComponent();
            //    this.iGUI = iGUI;

            //}
            _iController = controller;
            _viewModel = viewModel;


            doDataBindingEvents();
            //hideDoing();
            showDoing();

        }

        private void GUI_Load(object sender, EventArgs e)
        {
            InitiateMsg();
            //throw new NotImplementedException();
        }

        private void TulStrItmRename_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            DataGridViewRow row = dgvFileChosen.SelectedRows[0];
            openMsgRename(row.Cells["colFName"].Value.ToString()+ row.Cells["colExt"].Value.ToString());
        }

        private void openMsgRename(string fileName)
        {
            //throw new NotImplementedException();
            msgRename.FileName = fileName;
            msgRename.ShowDialog();
        }

        private void InitiateMsg()
        {
            //throw new NotImplementedException();
            msgRename = new MessageRenameBox();
            this.LocationChanged += GUI_LocationChangedAndChangeMsg;
            msgRename.Load += MsgRename_Load;
            msgRename.Accepted += MsgRename_Accepted;

        }

        private void MsgRename_Accepted()
        {
            //MessageBox.Show(msgRename.FileName);
        }

        private void MsgRename_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            resetMsgLocation();
        }

        private void GUI_LocationChangedAndChangeMsg(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            resetMsgLocation();

        }
        void resetMsgLocation()
        {
            int mainXonScreen = this.DesktopLocation.X;
            int mainYonScreen = this.DesktopLocation.Y;
            //
            int msgRenameOnMainX = (this.Width - msgRename.Width) / 2;
            int msgRenameOnMainY = (this.Height - msgRename.Height) / 2;
            //
            int msgRenameOnScreenX = mainXonScreen + msgRenameOnMainX;
            int msgRenameOnScreenY = mainYonScreen + msgRenameOnMainY;
            //
            msgRename.DesktopLocation = new Point(msgRenameOnScreenX, msgRenameOnScreenY);
        }

        private void DgvFileChosen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //throw new NotImplementedException();
            if(dgvFileChosen.Rows[e.RowIndex].ContextMenuStrip != null)    
                openFile();
            
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            //
            tmr.Stop();
            hideDoing();
        }

        private void TulStrItmOpen_Click(object sender, EventArgs e)
        {
            openFile();
        }
        void openFile()
        {
            showDoing();
            //throw new NotImplementedException();
            if (dgvFileChosen.SelectedRows.Count != 1)
            {
                //hideDoing();
                return;
            }
            _iController.sendIndexesAndFileNamesInJsonToOpen(getItemsJsonStringArray());
        }

        private void DgvFileChosen_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //throw new NotImplementedException();
            if(e.Button == MouseButtons.Right)
            {
                dgvFileChosen.ClearSelection();
                dgvFileChosen.Rows[e.RowIndex].Selected = true;
            }    
            
            
        }

        private void DgvFileChosen_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //showDoing();
            if (dgvFileChosen.SelectedRows == null)
            {
                //hideDoing();
                return;
            }


            //var rows = dgvFileChosen.SelectedRows;
            //foreach (DataGridViewRow row in rows)
            //{
            //    int index = row.Index;
            //    if (index > _viewModel.FileViewModels.Count - 1)
            //        return;
            //    if (_viewModel.FileViewModels[index].AnalyzedState)
            //    {
            //        btnAnal.Enabled = false;
            //        break;
            //    }    
                    
                
            //}


        }

        private void hideDoing()
        {
            panel4.Visible = false;
            //pnlDoing.Visible = false;
            //throw new NotImplementedException();
        }

        private void showDoing()
        {
            panel4.Visible = true;
            //pnlDoing.Visible = true;
            //throw new NotImplementedException();

            // glassyPanel1.Invalidate();
            // glassyPanel1.BringToFront();
            tmr.Enabled= true;
            tmr.Interval=5000;
            tmr.Start();
        }

        private void doDataBindingEvents()
        {
            _viewModel.FileViewModelsChanged += _viewModel_FileViewModelsChanged;
            _viewModel.OpenStateChanged += _viewModel_OpenStateChanged;
        }

        private void _viewModel_OpenStateChanged()
        {
            if (_viewModel.OpenState)
                hideDoing();
        }

        private void _viewModel_FileViewModelsChanged()
        {
            //throw new NotImplementedException();
            recieveFileViewModelsFromPresenter(_viewModel.FileViewModels);

        }

        OpenFileDialog ofd;
        private void btnChoseFile_Click(object sender, EventArgs e)
        {
            //iGUI.onClickOpenDialog();
            ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _iController.sendFileNames(ofd.FileNames);
            }
        }

        public void recieveFileViewModelsFromPresenter(List<FileViewModel> fvms)
        {
            //throw new NotImplementedException();



            //int stt = 1;
            //foreach (FileViewModel fvm in fvms)
            //{
            //    ListViewItem lsvi = new ListViewItem();

            //    lsvi.SubItems.Add(stt + "");
            //    lsvi.SubItems.Add(fvm.FileName);


            //    lsvi.SubItems.Add(fvm.AnalyzedState ? "true" : "false");

            //    lsvi.SubItems.Add(fvm.EditedState ? "true" : "false");
            //    lsvi.SubItems.Add(fvm.Extension);

            //    lsvi.Tag = fvm;

            //    lsvFileChosen.Items.Add(lsvi);

            //    stt++;
            //}

            ////
            //stt = 1;
            if (fvms == null || fvms.Count == 0)
            {
                hideDoing();
                return;
            }
            dgvFileChosen.Rows.Clear();

            foreach (FileViewModel fvm in fvms)
            {
                int index = dgvFileChosen.Rows.Add();
                var row = dgvFileChosen.Rows[index];
                row.ReadOnly = true;
                row.Cells["colNo"].Value = (fvms.Count - index) + "";
                row.Cells["colFName"].Value = fvm.FileName;
                row.Cells["colAna"].Value = fvm.getAnalyzedStateImage();
                row.Cells["colEdt"].Value = fvm.getEditedStateImage();
                row.Cells["colExt"].Value = fvm.Extension;

                if (fvm.EditedState)
                    row.ContextMenuStrip = ctxMnuStr;

                //stt++;
            }

            dgvFileChosen.Sort(new FileRowComparer(SortOrder.Ascending));

            //foreach (FileViewModel fvm in fvms)
            //{
            //    int index = dgvFileChosen.Rows.Add();
            //    var row = dgvFileChosen.Rows[index];
            //    row.ReadOnly = true;
            //    row.Cells["colNo"].Value = (index + 1) + "";
            //    row.Cells["colFName"].Value = fvm.FileName;
            //    row.Cells["colAna"].Value = fvm.getAnalyzedStateImage();
            //    row.Cells["colEdt"].Value = fvm.getEditedStateImage();
            //    row.Cells["colExt"].Value = fvm.Extension;

            //    if (fvm.EditedState)
            //        row.ContextMenuStrip = ctxMnuStr;

            //    //stt++;
            //}
            hideDoing();


            
            //dgvFileChosen.DataSource = dtb;
            //showDoing();

           
        }

        private class FileRowComparer : IComparer
        {
            private static int sortOrderModifier = 1;

            public FileRowComparer(SortOrder sortOrder)
            {
                if (sortOrder == SortOrder.Descending)
                {
                    sortOrderModifier = -1;
                }
                else if (sortOrder == SortOrder.Ascending)
                {
                    sortOrderModifier = 1;
                }
            }
            public int Compare(object x, object y)
            {
                //throw new NotImplementedException();
                DataGridViewRow rowX = (DataGridViewRow)x;
                DataGridViewRow rowY = (DataGridViewRow)y;

                int noX =0;
                int noY =0;
                int.TryParse(rowX.Cells["colNo"].Value.ToString(),out noX);
                int.TryParse(rowY.Cells["colNo"].Value.ToString(), out noY);

                int CompareResult = noX.CompareTo(noY);
                if(CompareResult ==0)
                {
                    CompareResult = System.String.Compare(rowX.Cells["colFName"].Value.ToString(),
                        rowY.Cells["colFName"].Value.ToString());
                }

                return CompareResult * sortOrderModifier;

            }
        }

        private void btnAnal_Click(object sender, EventArgs e)
        {
            showDoing();
            if (dgvFileChosen.SelectedRows == null)
            {
                hideDoing();
                return;
            }
                
            //JSchema schema = new JSchema()
            //items = items.Remove(items.Length - 1);
            //items += "]";
            _iController.sendIndexesAndFileNamesInJsonToAnalyze(getItemsJsonStringArray());
        }

        string[] getItemsJsonStringArray()
        {
            string[] items = new string[dgvFileChosen.SelectedRows.Count];

            int fvmsCount = _viewModel.FileViewModels.Count;
            int sttInItems = 0;
            var rows = dgvFileChosen.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {

                //sort anh huong den index
                int index = -1;
                int.TryParse(row.Cells["colNo"].Value.ToString(), out index);
                if(index >-1)
                {
                    index = fvmsCount - index;
                }
                else
                {
                    index = 0;
                }

                string fileName = row.Cells["colFName"].Value.ToString();

                string item = "{" +
                                   "\'index\': \'" + index + "\'," +
                                    "\'fileName\': \'" + fileName + "\'" +
                               "}";
                items[sttInItems] = item;
                sttInItems++;
            }
            return items;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            showDoing();
            if (dgvFileChosen.SelectedRows == null)
            {
                hideDoing();
                return;
            }



            //items = items.Remove(items.Length - 1);
            //items += "]";

            _iController.sendIndexesAndFileNamesInJsonToEdit(getItemsJsonStringArray());
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem pre = sender as ToolStripMenuItem;
            
        }
    }
}
