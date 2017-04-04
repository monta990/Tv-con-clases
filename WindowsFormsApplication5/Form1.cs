using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {    
        private Canal objCh;
        private Vol objVol;
        private power objPwr;
        public Form1()
        {
            InitializeComponent();    
            objCh = new Canal();
            objVol = new Vol();
            objPwr = new power();
            label1.Hide();
            lbcanal.Hide();
            lbCanal1.Hide();
            lbVol.Hide();
            lbVol1.Hide();
            btnVol1.Enabled = false;
            btnVol2.Enabled = false;
            btnCh1.Enabled = false;
            btnCh2.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }     

        private void btnVol1_Click(object sender, EventArgs e)
        //volumen + boton tele
        {
            objVol.VolumenUp();
            lbVol1.Text = objVol.NumVolumen.ToString();
            lbVol1.Show();
            lbVol.Show();
        }

        private void btnVol2_Click(object sender, EventArgs e)
        //volumen - boton tele
        {
            objVol.VolumenDown();
            lbVol1.Text = objVol.NumVolumen.ToString();
            lbVol1.Show();
            lbVol.Show();
        }        

        private void btnCh1_Click(object sender, EventArgs e)
        //boton canal +
        {
            objCh.ChUP();
            lbCanal1.Text = objCh.NumCanal.ToString();
            pictureBox1.Image = objCh.ImgCanal;
            lbcanal.Show();
            lbCanal1.Show();

        }

        private void btnCh2_Click(object sender, EventArgs e)
        //boton canal -
        {
            objCh.ChDwn();
            lbCanal1.Text = objCh.NumCanal.ToString();
            pictureBox1.Image = objCh.ImgCanal;
            lbcanal.Show();
            lbCanal1.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbVol1.Hide();
            lbVol.Hide();
            lbCanal1.Hide();
            lbcanal.Hide();
            label1.Hide();

        }

        private void btnEnc_Click(object sender, EventArgs e)
        {
            pictureBox3.Show();
            pbTv.Show();
            objPwr.OnOff(this);
            label1.Text = "ENCENDIDO";
            timer1.Start();
            timer1.Enabled = Enabled;
            pbTv.Show();
            pictureBox3.Show();
            if (objPwr.bEstado == true)
            {
                btnVol1.Enabled = true;
                btnVol2.Enabled = true;
                btnCh1.Enabled = true;
                btnCh2.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else if (objPwr.bEstado == false)
            {
                btnVol1.Enabled = false;
                btnVol2.Enabled = false;
                btnCh1.Enabled = false;
                btnCh2.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {    
            lbcanal.Show();
            lbCanal1.Show();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {            
            lbcanal.Show();
            lbCanal1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            objVol.VolumenUp();
            lbVol1.Text = objVol.NumVolumen.ToString();
            lbVol1.Show();
            lbVol.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {            
            lbVol1.Show();
            lbVol.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox3.Show();
            pbTv.Show();
            objPwr.OnOff(this);
            label1.Text = "ENCENDIDO";
            timer1.Start();
            timer1.Enabled = Enabled;
            pbTv.Show();
            pictureBox3.Show();
            if (objPwr.bEstado == true)
            {
                btnVol1.Enabled = true;
                btnVol2.Enabled = true;
                btnCh1.Enabled = true;
                btnCh2.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else if (objPwr.bEstado == false)
            {
                btnVol1.Enabled = false;
                btnVol2.Enabled = false;
                btnCh1.Enabled = false;
                btnCh2.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            objCh.ChUP();
            lbCanal1.Text = objCh.NumCanal.ToString();
            pictureBox1.Image = objCh.ImgCanal;
            lbcanal.Show();
            lbCanal1.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            objVol.VolumenDown();
            lbVol1.Text = objVol.NumVolumen.ToString();
            lbVol1.Show();
            lbVol.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            objCh.ChDwn();
            lbCanal1.Text = objCh.NumCanal.ToString();
            pictureBox1.Image = objCh.ImgCanal;
            lbcanal.Show();
            lbCanal1.Show();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
