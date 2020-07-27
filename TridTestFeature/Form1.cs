using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TridTestFeature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void btnAsync_Click(object sender, EventArgs e)
        {
            
            string path = null;

            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += delegate (object sdr, DoWorkEventArgs ev) {
                if (path != null)
                    getByteFromFile(path);
            };

            bw.RunWorkerCompleted += delegate (object sdr, RunWorkerCompletedEventArgs ev)
            {
                btnAsync.Text = "Done";
            };

            if(ofd.ShowDialog()==DialogResult.OK)
            {
                path = ofd.FileName;
                btnAsync.Text = "Trying";
                bw.RunWorkerAsync();
               
            }
            else
            {
                path = null;
            }    
            

        }

        public byte[] getByteFromFile(string fileName)
        {

            byte[] bytes;
            using (FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                bytes = new byte[file.Length];
                file.Read(bytes, 0, (int)file.Length);
            }
            return bytes;
            //throw new NotImplementedException();
            //return null;
        }
    }
}
