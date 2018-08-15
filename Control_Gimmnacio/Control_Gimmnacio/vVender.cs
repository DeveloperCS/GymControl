using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Gimmnacio
{
    public partial class vVender : Form
    {
        public vVender()
        {
            InitializeComponent();
            string q = "select idProduc as ID, nomProduc as Nombre, precio as Precio from product";
            dataGridView1.DataSource = dts.consulta(q).Tables[0];
            dataGridView1.Columns["Precio"].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns["Precio"].DefaultCellStyle.NullValue = "0.00";
        }
        // Arrastrar formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        conexionDatos dts = new conexionDatos();
        private void vVender_Load(object sender, EventArgs e)
        {
            txtt.Enabled = false;
            numericUpDown1.Value = 1;
          
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal tot = 0;
            if (dataGridView1.CurrentRow.Cells[2].Value.ToString().Equals(null))
            {
                txtt.Text ="0.00";
            }
            else
            {
                tot = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value.ToString()) * Convert.ToDecimal(numericUpDown1.Value);
                txtt.Text = tot.ToString("N2");
            }
            

          
        }
    }
}
