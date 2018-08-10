using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Control_Gimmnacio
{
    public partial class Form_inicial : Form
    {
        
        public Form_inicial()
        {
            InitializeComponent();
            bnt_rest.Visible = false;
            txt_titulo.Text = "Inicio";
            AbrirFormInPanel(new Dashboard());
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (Menu_vertical.Width==250)
            {
                Menu_vertical.Width = 59;
            }
            else
            {
                Menu_vertical.Width = 250;
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_max_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            bnt_rest.Visible = true;
            btn_max.Visible = false;
        }

        private void bnt_rest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            bnt_rest.Visible = false;
            btn_max.Visible = true;
        }
        // Arrastrar formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void bara_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //abrir froms dentro de un panel
        private void AbrirFormInPanel(object formhijo)
        {
            if (this.panel_cont.Controls.Count>0)
            {
                this.panel_cont.Controls.RemoveAt(0);
            }
            Form fn = formhijo as Form;
            fn.TopLevel = false;
            fn.Dock = DockStyle.Fill;
            this.panel_cont.Controls.Add(fn);
            this.panel_cont.Tag = fn;
            fn.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new registro());
            txt_titulo.Text = "Socios";
        }
        // login_principal log = new login_principal();

        private void button7_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("¿Realmente desea Cerrar Sesion?","Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
          //      log.Show();
                //Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Dashboard());
            txt_titulo.Text = "Inicio";
        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new reportes());
            txt_titulo.Text = "Reportes";
        }

        private void btn_configUs_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new us());
            txt_titulo.Text = "Usuarios";
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new confVentana());
            txt_titulo.Text = "Configuraciones";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new vInfo().Show();
        }
    }
}
