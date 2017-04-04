using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace WindowsFormsApplication5
{
    class power
    {
        public bool bEstado;
        public string sEstado;
        

        public power()
        {
            bEstado = false;
            sEstado = "Apagado";

        }        

        public void OnOff(System.Windows.Forms.Form forma)
        {

            if (bEstado == true)
            {
                bEstado = false;
                sEstado = "Apagado";
                foreach (Control Ctrl in forma.Controls)
                {
                    if (Ctrl is Label)
                    {
                        ((Label)Ctrl).Hide();
                    }
                    if (Ctrl is PictureBox)
                    {
                        ((PictureBox)Ctrl).Hide();
                    }
                }
               
                
            }

            else
            {
                bEstado = true;
                sEstado = "Encendido";
                foreach (Control Ctrl in forma.Controls)
                {
                    if (Ctrl is Label)
                    {
                        ((Label)Ctrl).Visible = bEstado;
                    }
                    if (Ctrl is PictureBox)
                    {
                        ((PictureBox)Ctrl).Visible = bEstado;
                    }
                }
            }           
        }
    }
}
