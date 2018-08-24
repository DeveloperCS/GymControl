using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Control_Gimmnacio
{
    public partial class Informacion : Form
    {
        public Informacion()
        {
            InitializeComponent();
        }

        private void vInfo_Load(object sender, EventArgs e)
        {
            label4.Text = "Copyright © 2018 CJ-Developer´s. Todos los derechos reservados.";
        }
        // Arrastrar formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox2_Paint(object sender, PaintEventArgs e) 
        {
          /*  GraphicsPath figura = new GraphicsPath();

            int x, y, ancho, alto;
            ancho = 260;
            alto = 260;
            x = (pictureBox2.Width - ancho) / 2;
            y = (pictureBox2.Height - alto) / 2;
            figura.AddEllipse(new Rectangle(x, y, ancho, alto));
            pictureBox2.Region = new Region(figura);*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
