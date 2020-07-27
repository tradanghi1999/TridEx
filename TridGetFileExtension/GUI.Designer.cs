namespace TridGetFileExtension
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHead = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mnS = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.grbMain = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlLoading = new System.Windows.Forms.Panel();
            this.lblLoading = new System.Windows.Forms.Label();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.dgvFileChosen = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAna = new System.Windows.Forms.DataGridViewImageColumn();
            this.colEdt = new System.Windows.Forms.DataGridViewImageColumn();
            this.colExt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAnal = new System.Windows.Forms.Button();
            this.btnChoseFile = new System.Windows.Forms.Button();
            this.lsvFileChosen = new System.Windows.Forms.ListView();
            this.clmCheck = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHdrSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHdrFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHdrAnaRes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHdrEditRes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHdrAnaExt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.gbrPreview = new System.Windows.Forms.GroupBox();
            this.lblNoPreview = new System.Windows.Forms.Label();
            this.ctxMnuStr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tulStrItmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tulStrItmRename = new System.Windows.Forms.ToolStripMenuItem();
            this.tulStrItmCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.bwkUpdateTable = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.mnS.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.grbMain.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileChosen)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.gbrPreview.SuspendLayout();
            this.ctxMnuStr.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHead.Location = new System.Drawing.Point(0, 38);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(1161, 36);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "File Extension Detection App";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHead);
            this.panel1.Controls.Add(this.mnS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 74);
            this.panel1.TabIndex = 1;
            // 
            // mnS
            // 
            this.mnS.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnS.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.mnS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.mnS.Location = new System.Drawing.Point(0, 0);
            this.mnS.Name = "mnS";
            this.mnS.Size = new System.Drawing.Size(1161, 38);
            this.mnS.TabIndex = 1;
            this.mnS.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previewToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(75, 34);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.CheckOnClick = true;
            this.previewToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.previewToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3);
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.previewToolStripMenuItem.Text = "Preview";
            this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1161, 468);
            this.panel2.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.grbMain);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(807, 468);
            this.panel6.TabIndex = 5;
            // 
            // grbMain
            // 
            this.grbMain.Controls.Add(this.panel4);
            this.grbMain.Controls.Add(this.dgvFileChosen);
            this.grbMain.Controls.Add(this.panel3);
            this.grbMain.Controls.Add(this.lsvFileChosen);
            this.grbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbMain.Location = new System.Drawing.Point(0, 0);
            this.grbMain.Margin = new System.Windows.Forms.Padding(20);
            this.grbMain.Name = "grbMain";
            this.grbMain.Padding = new System.Windows.Forms.Padding(20);
            this.grbMain.Size = new System.Drawing.Size(807, 468);
            this.grbMain.TabIndex = 3;
            this.grbMain.TabStop = false;
            this.grbMain.Text = "File Chosen";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnlLoading);
            this.panel4.Location = new System.Drawing.Point(441, 197);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 4;
            // 
            // pnlLoading
            // 
            this.pnlLoading.Controls.Add(this.lblLoading);
            this.pnlLoading.Controls.Add(this.picLoading);
            this.pnlLoading.Location = new System.Drawing.Point(281, 109);
            this.pnlLoading.Name = "pnlLoading";
            this.pnlLoading.Size = new System.Drawing.Size(200, 99);
            this.pnlLoading.TabIndex = 6;
            // 
            // lblLoading
            // 
            this.lblLoading.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLoading.Location = new System.Drawing.Point(0, 66);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(200, 33);
            this.lblLoading.TabIndex = 5;
            this.lblLoading.Text = "Loading";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picLoading
            // 
            this.picLoading.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLoading.Image = global::TridGetFileExtension.Properties.Resources.spinner;
            this.picLoading.Location = new System.Drawing.Point(0, 0);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(200, 80);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoading.TabIndex = 4;
            this.picLoading.TabStop = false;
            // 
            // dgvFileChosen
            // 
            this.dgvFileChosen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFileChosen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colFName,
            this.colAna,
            this.colEdt,
            this.colExt});
            this.dgvFileChosen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFileChosen.Location = new System.Drawing.Point(20, 42);
            this.dgvFileChosen.Name = "dgvFileChosen";
            this.dgvFileChosen.RowHeadersWidth = 20;
            this.dgvFileChosen.RowTemplate.Height = 31;
            this.dgvFileChosen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFileChosen.Size = new System.Drawing.Size(767, 345);
            this.dgvFileChosen.TabIndex = 3;
            // 
            // colNo
            // 
            this.colNo.FillWeight = 60F;
            this.colNo.HeaderText = "No.";
            this.colNo.MinimumWidth = 9;
            this.colNo.Name = "colNo";
            this.colNo.Width = 50;
            // 
            // colFName
            // 
            this.colFName.FillWeight = 200F;
            this.colFName.HeaderText = "File Name";
            this.colFName.MinimumWidth = 9;
            this.colFName.Name = "colFName";
            this.colFName.Width = 150;
            // 
            // colAna
            // 
            this.colAna.FillWeight = 60F;
            this.colAna.HeaderText = "Analyzed State";
            this.colAna.MinimumWidth = 9;
            this.colAna.Name = "colAna";
            this.colAna.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAna.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAna.Width = 50;
            // 
            // colEdt
            // 
            this.colEdt.FillWeight = 60F;
            this.colEdt.HeaderText = "Edited State";
            this.colEdt.MinimumWidth = 9;
            this.colEdt.Name = "colEdt";
            this.colEdt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEdt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEdt.Width = 50;
            // 
            // colExt
            // 
            this.colExt.FillWeight = 80F;
            this.colExt.HeaderText = "Extension";
            this.colExt.MinimumWidth = 9;
            this.colExt.Name = "colExt";
            this.colExt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colExt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colExt.Width = 80;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnAnal);
            this.panel3.Controls.Add(this.btnChoseFile);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(20, 387);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(767, 61);
            this.panel3.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Window;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnEdit.FlatAppearance.BorderSize = 3;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(391, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(116, 61);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAnal
            // 
            this.btnAnal.BackColor = System.Drawing.SystemColors.Window;
            this.btnAnal.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAnal.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAnal.FlatAppearance.BorderSize = 3;
            this.btnAnal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnal.Location = new System.Drawing.Point(507, 0);
            this.btnAnal.Name = "btnAnal";
            this.btnAnal.Size = new System.Drawing.Size(116, 61);
            this.btnAnal.TabIndex = 1;
            this.btnAnal.Text = "Analyze";
            this.btnAnal.UseVisualStyleBackColor = false;
            this.btnAnal.Click += new System.EventHandler(this.btnAnal_Click);
            // 
            // btnChoseFile
            // 
            this.btnChoseFile.BackColor = System.Drawing.SystemColors.Window;
            this.btnChoseFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChoseFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnChoseFile.FlatAppearance.BorderSize = 3;
            this.btnChoseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoseFile.Location = new System.Drawing.Point(623, 0);
            this.btnChoseFile.Name = "btnChoseFile";
            this.btnChoseFile.Size = new System.Drawing.Size(144, 61);
            this.btnChoseFile.TabIndex = 0;
            this.btnChoseFile.Text = "Choose...";
            this.btnChoseFile.UseVisualStyleBackColor = false;
            this.btnChoseFile.Click += new System.EventHandler(this.btnChoseFile_Click);
            // 
            // lsvFileChosen
            // 
            this.lsvFileChosen.CheckBoxes = true;
            this.lsvFileChosen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmCheck,
            this.clmHdrSTT,
            this.clmHdrFile,
            this.clmHdrAnaRes,
            this.clmHdrEditRes,
            this.clmHdrAnaExt});
            this.lsvFileChosen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvFileChosen.FullRowSelect = true;
            this.lsvFileChosen.GridLines = true;
            this.lsvFileChosen.HideSelection = false;
            this.lsvFileChosen.Location = new System.Drawing.Point(20, 42);
            this.lsvFileChosen.Name = "lsvFileChosen";
            this.lsvFileChosen.Size = new System.Drawing.Size(767, 406);
            this.lsvFileChosen.TabIndex = 0;
            this.lsvFileChosen.UseCompatibleStateImageBehavior = false;
            this.lsvFileChosen.View = System.Windows.Forms.View.Details;
            // 
            // clmCheck
            // 
            this.clmCheck.Text = "";
            // 
            // clmHdrSTT
            // 
            this.clmHdrSTT.Text = "No.";
            this.clmHdrSTT.Width = 30;
            // 
            // clmHdrFile
            // 
            this.clmHdrFile.Text = "File";
            this.clmHdrFile.Width = 150;
            // 
            // clmHdrAnaRes
            // 
            this.clmHdrAnaRes.Text = "Analysis Result";
            this.clmHdrAnaRes.Width = 40;
            // 
            // clmHdrEditRes
            // 
            this.clmHdrEditRes.Text = "Edit Result";
            this.clmHdrEditRes.Width = 40;
            // 
            // clmHdrAnaExt
            // 
            this.clmHdrAnaExt.Text = "Extension";
            this.clmHdrAnaExt.Width = 80;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gbrPreview);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(807, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(354, 468);
            this.panel5.TabIndex = 4;
            // 
            // gbrPreview
            // 
            this.gbrPreview.Controls.Add(this.lblNoPreview);
            this.gbrPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbrPreview.Location = new System.Drawing.Point(0, 0);
            this.gbrPreview.Name = "gbrPreview";
            this.gbrPreview.Padding = new System.Windows.Forms.Padding(15);
            this.gbrPreview.Size = new System.Drawing.Size(354, 468);
            this.gbrPreview.TabIndex = 0;
            this.gbrPreview.TabStop = false;
            this.gbrPreview.Text = "Preview";
            // 
            // lblNoPreview
            // 
            this.lblNoPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoPreview.Location = new System.Drawing.Point(15, 37);
            this.lblNoPreview.Name = "lblNoPreview";
            this.lblNoPreview.Size = new System.Drawing.Size(324, 416);
            this.lblNoPreview.TabIndex = 0;
            this.lblNoPreview.Text = "No Preview";
            this.lblNoPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctxMnuStr
            // 
            this.ctxMnuStr.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.ctxMnuStr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tulStrItmOpen,
            this.tulStrItmRename,
            this.tulStrItmCopy});
            this.ctxMnuStr.Name = "ctxMnuStr";
            this.ctxMnuStr.Size = new System.Drawing.Size(182, 112);
            // 
            // tulStrItmOpen
            // 
            this.tulStrItmOpen.Name = "tulStrItmOpen";
            this.tulStrItmOpen.Size = new System.Drawing.Size(181, 36);
            this.tulStrItmOpen.Text = "Open";
            // 
            // tulStrItmRename
            // 
            this.tulStrItmRename.Name = "tulStrItmRename";
            this.tulStrItmRename.Size = new System.Drawing.Size(181, 36);
            this.tulStrItmRename.Text = "Rename";
            // 
            // tulStrItmCopy
            // 
            this.tulStrItmCopy.Name = "tulStrItmCopy";
            this.tulStrItmCopy.Size = new System.Drawing.Size(181, 36);
            this.tulStrItmCopy.Text = "Copy To ...";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.mnS;
            this.Name = "GUI";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mnS.ResumeLayout(false);
            this.mnS.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.grbMain.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlLoading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileChosen)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.gbrPreview.ResumeLayout(false);
            this.ctxMnuStr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grbMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lsvFileChosen;
        private System.Windows.Forms.Button btnChoseFile;
        private System.Windows.Forms.Button btnAnal;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ColumnHeader clmHdrSTT;
        private System.Windows.Forms.ColumnHeader clmHdrFile;
        private System.Windows.Forms.ColumnHeader clmHdrAnaRes;
        private System.Windows.Forms.ColumnHeader clmHdrEditRes;
        private System.Windows.Forms.ColumnHeader clmHdrAnaExt;
        private System.Windows.Forms.ColumnHeader clmCheck;
        private System.Windows.Forms.DataGridView dgvFileChosen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFName;
        private System.Windows.Forms.DataGridViewImageColumn colAna;
        private System.Windows.Forms.DataGridViewImageColumn colEdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExt;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.Panel pnlLoading;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ContextMenuStrip ctxMnuStr;
        private System.Windows.Forms.ToolStripMenuItem tulStrItmOpen;
        private System.Windows.Forms.ToolStripMenuItem tulStrItmRename;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox gbrPreview;
        private System.Windows.Forms.Label lblNoPreview;
        private System.Windows.Forms.ToolStripMenuItem tulStrItmCopy;
        private System.ComponentModel.BackgroundWorker bwkUpdateTable;
        private System.Windows.Forms.MenuStrip mnS;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
    }
}

