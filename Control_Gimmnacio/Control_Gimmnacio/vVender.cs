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
            string q = "select  idProduc as id, cod as Codiogo, nomProduc as Nombre, precio as Precio from product where stock !=0 and stock >0";
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
            decimal tot = 0, a1, b1, b2;
            if (dataGridView1.RowCount ==0)
            {
                MessageBox.Show("No tiene productos disponibles \n Contacte a un Administrador");
            }
            else
            {
                string qCanti = "select stock as s from product where idProduc = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' AND cod='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'";
                DataSet dtSet = new DataSet();
                dtSet = dts.consulta(qCanti);
                DataTable tabla = dtSet.Tables[0];
                int cantidad = 0;
                foreach (DataRow row in tabla.Rows)
                {
                    cantidad = int.Parse(row["s"].ToString());
                }
                if (cantidad < numericUpDown1.Value)
                {
                    MessageBox.Show("No se cuenta con la suficiente cantidad en stock");
                    numericUpDown1.Value = 1;
                }
                else
                {
                    //error cuando no hay product
                    if (dataGridView1.CurrentRow.Cells[3].Value.ToString().Equals(null))
                    {
                        txtt.Text = "0.00";
                    }
                    else
                    {
                        if (txtR.Text == "" || txtR.Text == null)
                        {

                            tot = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value.ToString()) * Convert.ToDecimal(numericUpDown1.Value);
                            txtt.Text = tot.ToString("N2");
                        }
                        else
                        {
                            b1 = Convert.ToDecimal(txtR.Text);
                            tot = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value.ToString()) * Convert.ToDecimal(numericUpDown1.Value);
                            txtt.Text = tot.ToString("N2");
                            b2 = tot - b1;
                            if (b2 > 0)
                            {
                                txtC.Text = "0.00";
                            }
                            else
                            {
                                txtC.Text = b2.ToString("N2");
                            }

                        }

                    }
                }
            }
          
          
        }
        decimal a, b,c;
        decimal total, recibido, cambio;


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (dataGridView1.RowCount ==0)
            {

            }
            else
            {
                numericUpDown1.Value = 1;
                decimal to1 = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value.ToString()) * Convert.ToDecimal(numericUpDown1.Value);
                txtt.Text = to1.ToString("N2");
                txtC.Text = "0.00";
            }

        }

        private void txtR_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount ==0)
            {

            }
            else
            {
                if (txtR.Text == "" || txtR.Text == null)
                {
                    txtC.Text = "0.00";
                }
                else
                {

                    total = Convert.ToDecimal(txtt.Text);
                    recibido = Convert.ToDecimal(txtR.Text);

                    cambio = total - recibido;
                    if (cambio > 0)
                    {
                        txtC.Text = "0.00";
                    }
                    else
                    {
                        txtC.Text = cambio.ToString("N2");
                    }

                }
            }
           
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount ==0)
            {

            }
            else
            {
                string qCanti = "select stock as s from product where idProduc = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' AND cod='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'";
                DataSet dtSet = new DataSet();
                dtSet = dts.consulta(qCanti);
                DataTable tabla = dtSet.Tables[0];
                int cantidad = 0;
                foreach (DataRow row in tabla.Rows)
                {
                    cantidad = int.Parse(row["s"].ToString());
                }

                if (cantidad == 0 || numericUpDown1.Value > cantidad)
                {
                    MessageBox.Show("No se cuenta con la suficiente cantidad en stock");
                }
                else if (cantidad >= 1 && numericUpDown1.Value <= cantidad)
                {
                    if (numericUpDown1.Value == 0)
                    {
                        MessageBox.Show("No se ah agregado productos");
                    }
                    else
                    {
                        if (txtR.Text == "" || txtR.Text == null)
                        {
                            MessageBox.Show("No se a pagado aun");
                        }
                        else
                        {
                            a = Convert.ToDecimal(txtt.Text);
                            b = Convert.ToDecimal(txtR.Text);
                            c = Convert.ToDecimal(txtC.Text);
                            if (c <= 0 && b >= a)
                            {
                                string q = "insert into ventas values('" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "',GETDATE(),'" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "','" + numericUpDown1.Value + "','" + a + "')";
                                if (dts.insertar(q) == true)
                                {
                                    MessageBox.Show("Vendido");
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se ah completado el precio");
                            }
                        }

                    }
                }

            }


        }
        #region validaciones
        restricciones val = new restricciones();
        private void txtR_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.solonumerosDecimal(e);
        }
        #endregion
    }
}
