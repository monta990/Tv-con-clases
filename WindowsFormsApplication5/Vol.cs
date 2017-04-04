using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    class Vol
    {
        public int NumVolumen;

        public Vol()
        {
            NumVolumen = 50;
        }

        public void VolumenUp()
        {
            if (NumVolumen < 100)
                NumVolumen++;
        }

        public void VolumenDown()
        {
            if (NumVolumen > 0)
                NumVolumen--;

        }

    }
}
