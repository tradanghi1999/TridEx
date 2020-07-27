using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreController
{
    public class StateViewModel
    {

        private static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
        public StateViewModel(bool state)
        {
            this.State = state;
        }
        public bool State;
        public Bitmap getStateImage()
        {
            if (State)
            {
                return Properties.Resources.tick;
            }
            return Properties.Resources.cancel;
            //return null;
        }

        public Bitmap getStateImage(int dim)
        {
            if (State)
            {
                return StateViewModel.ResizeImage(Properties.Resources.tick, dim, dim);
            }
            return StateViewModel.ResizeImage(Properties.Resources.cancel, dim, dim);
        }
    }
}
