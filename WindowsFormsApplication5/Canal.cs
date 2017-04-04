using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    class Canal
    {
        public int NumCanal;
        public Bitmap ImgCanal;

        public Canal()
        {
            NumCanal = 2;
            ImgCanal = WindowsFormsApplication5.Properties.Resources.canal2;
        }

        public void ChUP()
        {
            if (NumCanal == 13)
                NumCanal = 2;
            else
                NumCanal++;
            Bitmap bmp = (Bitmap)Properties.Resources.ResourceManager.GetObject("canal" + NumCanal);
            ImgCanal = bmp;
        }

        public void ChDwn()
        {
            if (NumCanal == 2)
                NumCanal = 13;

            else
                NumCanal--;

            Bitmap bmp = (Bitmap)Properties.Resources.ResourceManager.GetObject("canal" + NumCanal);
            ImgCanal = bmp;
        }

    }
}
