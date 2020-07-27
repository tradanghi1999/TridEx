namespace TridGetFileExtension
{
    partial class MessageRenameBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbFileName = new System.Windows.Forms.TextBox();
            this.lblRename = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbFileName);
            this.panel1.Controls.Add(this.lblRename);
            this.panel1.Location = new System.Drawing.Point(41, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 48);
            this.panel1.TabIndex = 0;
            // 
            // txbFileName
            // 
            this.txbFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbFileName.Location = new System.Drawing.Point(134, 0);
            this.txbFileName.Name = "txbFileName";
            this.txbFileName.Size = new System.Drawing.Size(332, 29);
            this.txbFileName.TabIndex = 1;
            // 
            // lblRename
            // 
            this.lblRename.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRename.Location = new System.Drawing.Point(0, 0);
            this.lblRename.Name = "lblRename";
            this.lblRename.Size = new System.Drawing.Size(134, 48);
            this.lblRename.TabIndex = 0;
            this.lblRename.Text = "Rename To:";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(220, 107);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(103, 40);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // MessageRenameBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 182);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MessageRenameBox";
            this.Text = "MessageRenameBox";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbFileName;
        private System.Windows.Forms.Label lblRename;
        private System.Windows.Forms.Button btnAccept;
    }
}