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
    public partial class ventanConfEdit : Form
    {
        public ventanConfEdit()
        {
            
            InitializeComponent();
            txt1.Enabled = false;
            txt2.Enabled = false;
            txt3.Enabled = false;
            num4.Enabled = false;
        }
        // Arrastrar formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void lbCerrar_Click(object sender, EventArgs e)
        {
            
            if (txt1.Text!="")
            {
                if (MessageBox.Show("Aun no guarda los datos!! \n ¿Desea Salir?","Atencion",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lb4.Visible.Equals(false))
            {
                txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt2.Enabled = true;
                txt3.Enabled = true;
            }
            else if (lb4.Visible.Equals(true))
            {
                txt2.Enabled = true;
                txt3.Enabled = true;
                num4.Enabled = true;
                txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                num4.Value = Convert.ToInt64(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                
            }
        }
        public void limpiar()
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            num4.Value = 0;
        }
        public void consultar(string q)
        {
            dataGridView1.DataSource = dts.consulta(q).Tables[0];
        }
        conexionDatos dts = new conexionDatos();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string qry = "";
            string q2="";
            if (txt1.Text == "" || txt2.Text == "" || txt3.Text == "")
            {
                MessageBox.Show("Los campos estan vacions","Alto",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {
                if (MessageBox.Show("¿Desea guardar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (lbTitulo.Text == "Productos Registrados")
                    {
                        qry = "Update produc set nomProduc ='" + txt2.Text + "',cantidad=" + num4.Value + ",precio=" + txt3.Text + " where idProduc = " + txt1.Text + "";
                        if (dts.update(qry) == true)
                        {
                            MessageBox.Show("Elemento Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                            q2 = "select idProduc as Id,nomProduc as Producto,cantidad as Cantidad,precio as Precio from produc";
                            consultar(q2);
                        }

                    }
                    if (lbTitulo.Text == "Membresias Registradas")
                    {
                        qry = "update memb set nomMem='" + txt2.Text + "',precioMem=" + txt3.Text + " where idMem=" + txt1.Text + " ";
                        if (dts.update(qry) == true)
                        {
                            MessageBox.Show("Elemento Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                            q2 = "select idMem as Id, nomMem as Membresia,precioMem as Precio from memb";
                            consultar(q2);
                        }
                    }
                }
            }
            
            
        }
        #region validaciones
        restricciones vl = new restricciones();
        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            vl.letrassignos(e);
        }
       public int caso = 0;
        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            switch (caso)
            {
                case 1:
                    vl.solonumerosEnteros(e);
                    break;
                case 2:
                    vl.solonumerosDecimal(e);
                    break;
                
            }
        }
        #endregion
    }
}
