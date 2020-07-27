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
    public partial class TestCaseGUI : Form, TestCaseIGUI
    {
        public TestCaseGUI()
        {
            InitializeComponent();

            //rtbRes.Text += "Testing HardDrive class...\n";

            //rtbRes.Text += "Test completed\n";
        }

        public void attachResult(string res)
        {
            //throw new NotImplementedException();
            rtbRes.Text += res +"\n";

            //rtbRes.Text += "test completed\n";

        }

        public void beginTesting(string testContent)
        {
            rtbRes.Text += "Testing "+testContent+" class...\n";
        }

        public void endTesting()
        {
            rtbRes.Text += "test completed\n\n";
        }
    }
}
