using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TridGetFileExtension
{
    public partial class MessageRenameBox : Form
    {
        public MessageRenameBox()
        {
            InitializeComponent();
            btnAccept.Click += BtnAccept_Click;
            this.VisibleChanged += MessageRenameBox_VisibleChanged;
        }

        private void MessageRenameBox_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                txbFileName.Focus();
                txbFileName.SelectAll();
                
            }    
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Accepted();
            this.Close();
        }

        public string FileName
        {
            get

            {
                return txbFileName.Text;
            }
            set
            {
                txbFileName.Text = value;
                txbFileName.SelectAll();
            }
        }
        public event Action Accepted;
    }
}
