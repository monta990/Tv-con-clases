namespace WindowsFormsApplication5
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbVol = new System.Windows.Forms.Label();
            this.lbVol1 = new System.Windows.Forms.Label();
            this.lbcanal = new System.Windows.Forms.Label();
            this.lbCanal1 = new System.Windows.Forms.Label();
            this.btnVol2 = new System.Windows.Forms.Button();
            this.btnCh1 = new System.Windows.Forms.Button();
            this.btnCh2 = new System.Windows.Forms.Button();
            this.btnVol1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEnc = new System.Windows.Forms.Button();
            this.pbTv = new System.Windows.Forms.PictureBox();
            this.btSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbVol
            // 
            this.lbVol.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbVol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbVol.Location = new System.Drawing.Point(467, 361);
            this.lbVol.Name = "lbVol";
            this.lbVol.Size = new System.Drawing.Size(62, 13);
            this.lbVol.TabIndex = 2;
            this.lbVol.Text = "VOLUMEN ";
            // 
            // lbVol1
            // 
            this.lbVol1.AutoSize = true;
            this.lbVol1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbVol1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbVol1.Location = new System.Drawing.Point(523, 361);
            this.lbVol1.Name = "lbVol1";
            this.lbVol1.Size = new System.Drawing.Size(19, 13);
            this.lbVol1.TabIndex = 3;
            this.lbVol1.Text = "50";
            // 
            // lbcanal
            // 
            this.lbcanal.AutoSize = true;
            this.lbcanal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbcanal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbcanal.Location = new System.Drawing.Point(53, 361);
            this.lbcanal.Name = "lbcanal";
            this.lbcanal.Size = new System.Drawing.Size(42, 13);
            this.lbcanal.TabIndex = 4;
            this.lbcanal.Text = "CANAL";
            // 
            // lbCanal1
            // 
            this.lbCanal1.AutoSize = true;
            this.lbCanal1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCanal1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbCanal1.Location = new System.Drawing.Point(91, 361);
            this.lbCanal1.Name = "lbCanal1";
            this.lbCanal1.Size = new System.Drawing.Size(13, 13);
            this.lbCanal1.TabIndex = 5;
            this.lbCanal1.Text = "2";
            // 
            // btnVol2
            // 
            this.btnVol2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVol2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVol2.Location = new System.Drawing.Point(373, 400);
            this.btnVol2.Name = "btnVol2";
            this.btnVol2.Size = new System.Drawing.Size(43, 22);
            this.btnVol2.TabIndex = 6;
            this.btnVol2.Text = "VOL-";
            this.btnVol2.UseVisualStyleBackColor = false;
            this.btnVol2.Click += new System.EventHandler(this.btnVol2_Click);
            // 
            // btnCh1
            // 
            this.btnCh1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCh1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCh1.Location = new System.Drawing.Point(422, 400);
            this.btnCh1.Name = "btnCh1";
            this.btnCh1.Size = new System.Drawing.Size(36, 22);
            this.btnCh1.TabIndex = 7;
            this.btnCh1.Text = "CH+";
            this.btnCh1.UseVisualStyleBackColor = false;
            this.btnCh1.Click += new System.EventHandler(this.btnCh1_Click);
            // 
            // btnCh2
            // 
            this.btnCh2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCh2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCh2.Location = new System.Drawing.Point(464, 400);
            this.btnCh2.Name = "btnCh2";
            this.btnCh2.Size = new System.Drawing.Size(36, 22);
            this.btnCh2.TabIndex = 8;
            this.btnCh2.Text = "CH-";
            this.btnCh2.UseVisualStyleBackColor = false;
            this.btnCh2.Click += new System.EventHandler(this.btnCh2_Click);
            // 
            // btnVol1
            // 
            this.btnVol1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVol1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVol1.Location = new System.Drawing.Point(325, 400);
            this.btnVol1.Name = "btnVol1";
            this.btnVol1.Size = new System.Drawing.Size(42, 22);
            this.btnVol1.TabIndex = 10;
            this.btnVol1.Text = "VOL+";
            this.btnVol1.UseVisualStyleBackColor = false;
            this.btnVol1.Click += new System.EventHandler(this.btnVol1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(471, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ENCENDIDO";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(731, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "CH+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(628, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 30);
            this.button2.TabIndex = 16;
            this.button2.Text = "CH-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(674, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 22);
            this.button3.TabIndex = 17;
            this.button3.Text = "VOL-";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(674, 116);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 22);
            this.button4.TabIndex = 18;
            this.button4.Text = "VOL+";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(740, 29);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(27, 26);
            this.button5.TabIndex = 19;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Image = global::WindowsFormsApplication5.Properties.Resources.remote_control_149842_640;
            this.pictureBox3.InitialImage = global::WindowsFormsApplication5.Properties.Resources.remote_control_149842_640;
            this.pictureBox3.Location = new System.Drawing.Point(604, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(185, 493);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication5.Properties.Resources.canal2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(46, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 337);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // btnEnc
            // 
            this.btnEnc.BackColor = System.Drawing.Color.Red;
            this.btnEnc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnc.Location = new System.Drawing.Point(506, 400);
            this.btnEnc.Name = "btnEnc";
            this.btnEnc.Size = new System.Drawing.Size(36, 22);
            this.btnEnc.TabIndex = 9;
            this.btnEnc.UseVisualStyleBackColor = false;
            this.btnEnc.Click += new System.EventHandler(this.btnEnc_Click);
            // 
            // pbTv
            // 
            this.pbTv.Image = ((System.Drawing.Image)(resources.GetObject("pbTv.Image")));
            this.pbTv.Location = new System.Drawing.Point(5, 2);
            this.pbTv.Name = "pbTv";
            this.pbTv.Size = new System.Drawing.Size(590, 480);
            this.pbTv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTv.TabIndex = 0;
            this.pbTv.TabStop = false;
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(631, 29);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(81, 26);
            this.btSalir.TabIndex = 20;
            this.btSalir.Text = "Desprogramar";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 508);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbVol1);
            this.Controls.Add(this.lbVol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCanal1);
            this.Controls.Add(this.lbcanal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVol1);
            this.Controls.Add(this.btnEnc);
            this.Controls.Add(this.btnCh2);
            this.Controls.Add(this.btnCh1);
            this.Controls.Add(this.btnVol2);
            this.Controls.Add(this.pbTv);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TV HD Generica con Control y Clases  ----  Imagenes de http://pixabay.com licenci" +
    "a CC0 Public Domain";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTv;
        private System.Windows.Forms.Label lbVol;
        private System.Windows.Forms.Label lbVol1;
        private System.Windows.Forms.Label lbcanal;
        private System.Windows.Forms.Label lbCanal1;
        private System.Windows.Forms.Button btnVol2;
        private System.Windows.Forms.Button btnCh1;
        private System.Windows.Forms.Button btnCh2;
        private System.Windows.Forms.Button btnEnc;
        private System.Windows.Forms.Button btnVol1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btSalir;
    }
}

