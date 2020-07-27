using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TridGetFileExtension
{
    public class GlassyPanel : Panel
    {
        protected override CreateParams CreateParams 
    {            
        get {
            CreateParams cp =  base.CreateParams;
            cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
            return cp;
            }
    }
    protected override void OnPaintBackground(PaintEventArgs e) 
    {
            //base.OnPaintBackground(e);

            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(50, 0, 0, 0)), this.ClientRectangle);
        }
    }
}
