using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Gimmnacio
{
    public partial class confVentana : Form
    {
        public confVentana()
        {
            InitializeComponent();
            //evitar modificar combobox
            cbDescuento.DropDownStyle = ComboBoxStyle.DropDownList;
            //deshabilita controles
            txtOtroProm.Visible = false;
            labelOtroProm.Visible = false;
        }

        private void cbDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDescuento.SelectedItem.ToString() != "Otro")
            {
                txtOtroProm.Visible = false;
                labelOtroProm.Visible = false;
            }
            else
            {
                txtOtroProm.Visible = true;
                labelOtroProm.Visible = true;
                //MessageBox.Show("Agrega otro");
            }
        }

        private void btnCancelarProm_Click(object sender, EventArgs e)
        {
            txtOtroProm.Visible = false;
            labelOtroProm.Visible = false;
            txtNomPromo.Text = "";
            cbDescuento.SelectedValue ="" ;
        }
        conexionDatos dts = new conexionDatos();
        private void btnAgreaMem_Click(object sender, EventArgs e)
        {

            
        }
     

        private void btnCancelarMem_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnAgregaProduc_Click(object sender, EventArgs e)
        {
          
        }

       
        public void limpiarT()
        {
            edit.txt1.Text = "";
            edit.txt2.Text = "";
            edit.txt3.Text = "";
            edit.num4.Value = 0;
        }
        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        ventanConfEdit edit = new ventanConfEdit();
        string q = "";
        private void verListaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            q = "select idProduc as Id,nomProduc as Producto,cantidad as Cantidad,precio as Precio from produc";
            edit.dataGridView1.DataSource = dts.consulta(q).Tables[0];
            edit.dataGridView1.Columns["Precio"].DefaultCellStyle.Format = "N2";
            edit.dataGridView1.Columns["Precio"].DefaultCellStyle.NullValue = "0.00";
            edit.lbTitulo.Text = "Productos Registrados";
            edit.lb1.Text = "ID";
            edit.lb2.Text = "Producto";
            edit.lb3.Text = "Precio";
            edit.lb4.Text = "Cantidad";
            edit.lbPN.Text = "MNX";
            edit.lb4.Visible = true;
            edit.num4.Visible = true;
            edit.caso = 2;
            edit.cPorcent = 0;
            edit.sctEle = 1;
            limpiarT();
            edit.bloquearTxt();
            edit.ShowDialog();
          
        }

        private void verListaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            q = "select idMem as Id, nomMem as Membresia,precioMem as Precio,dias as Dias from memb";
            edit.dataGridView1.DataSource = dts.consulta(q).Tables[0];
            edit.dataGridView1.Columns["Precio"].DefaultCellStyle.Format = "N2";
            edit.dataGridView1.Columns["Precio"].DefaultCellStyle.NullValue = "0.00";
            edit.lbTitulo.Text = "Membresias Registradas";
            edit.lb1.Text = "ID";
            edit.lb2.Text = "Membresia";
            edit.lb3.Text = "Precio";
            edit.lbPN.Text = "MNX";
            edit.lb4.Text = "Dias";
            edit.lb4.Visible = true;
            edit.num4.Visible = true;
            edit.caso = 2;
            edit.cPorcent = 0;
            edit.sctEle = 2;
            limpiarT();
            edit.bloquearTxt();
            edit.ShowDialog();
           
        }

        private void verListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Para transformar el procentaje y agregar el sigo % para que sea mas claro para el usuario*/
           // DataSet dataS = new DataSet();
            q = "Select idProm as Id,nomPromocion as Promocion,descuento as Descuento from prom";
           /* dataS = dts.consulta(q);
            DataTable dt2 = dataS.Tables[0];
            int por=0;
            double t=0;
            DataTable relleno = new DataTable();

            relleno.Columns.Add("Id", typeof(string));
            relleno.Columns.Add("Promocion", typeof(string));
            relleno.Columns.Add("Descuento", typeof(string));
            foreach (DataRow row in dt2.Rows)
            {
                t = Convert.ToDouble(row["Descuento"]);
                t = t * 100;
                por =Convert.ToInt32( t);
                relleno.Rows.Add(row["Id"].ToString(), row["Promocion"].ToString(),por.ToString()+ " %");

            }
            edit.dataGridView1.DataSource = relleno;*/
            edit.consultaPr(q);
            edit.lbTitulo.Text = "Promociones Registradas";
            edit.lb1.Text = "ID";
            edit.lb2.Text = "Promocion";
            edit.lb3.Text = "Descuento";
            edit.lbPN.Text = "%";
            edit.lb4.Visible = false;
            edit.num4.Visible = false;
            edit.caso = 1;
            edit.cPorcent = 1;
            limpiarT();
            edit.bloquearTxt();
            edit.ShowDialog();
            
        }
        #region AgregaMembresia
        public void limpiarM()
        {
            txtPMem.Text = "";
            txtNMem.Text = "";
            numDiasMem.Value = 0;
            /*txtNMem.ForeColor = Color.LightGray;
            txtPMem.ForeColor = Color.LightGray;*/
        }
        private void btnAMem_Click(object sender, EventArgs e)
        {

            
            if (txtNMem.Text == "" || txtPMem.Text == ""||numDiasMem.Value ==0)
            {
                MessageBox.Show("Falto llenar algun campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Desea Agregar?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry1 = "Insert into memb values('" + txtNMem.Text + "'," + Convert.ToDouble(txtPMem.Text) + ","+numDiasMem.Value+")";
                    if (dts.insertar(qry1) == true)
                    {
                        MessageBox.Show("Membresia Agregada", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarM();
                    }
                }
                
            }
        }

        private void btnCMem_Click(object sender, EventArgs e)
        {
            if (txtNMem.Text != "" && txtPMem.Text !="")
            {
                if (MessageBox.Show("¿Desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    limpiarM();
                }
            }
            else
            {
                limpiarM();
            }
        }
      
        #region PlaceHolders
        private void txtNMem_Enter(object sender, EventArgs e)
        {
           /* if (txtNMem.Text == "Nombre")
            {
                txtNMem.Text = "";
                txtNMem.ForeColor = Color.Black;
            }*/
        }

        private void txtNMem_Leave(object sender, EventArgs e)
        {
            /*if (txtNMem.Text == "")
            {
                txtNMem.Text = "Nombre";
                txtNMem.ForeColor = Color.LightGray;
                //txtUsuario.ForeColor = Color.LightGray;
            }*/
        }

        private void txtPMem_Leave(object sender, EventArgs e)
        {
           /* if (txtPMem.Text == "")
            {
                txtPMem.Text = "Precio";
                txtPMem.ForeColor = Color.LightGray;
                //txtUsuario.ForeColor = Color.DimGray;
            }*/
        }

        private void txtPMem_Enter(object sender, EventArgs e)
        {
           /* if (txtPMem.Text == "Precio")
            {
                txtPMem.Text = "";
                txtPMem.ForeColor = Color.Black;
                //txtUsuario.ForeColor = Color.DimGray;
            }*/
        }

        #endregion
      
        #endregion

        #region AgregaProductos
        public void limpiarP()
        {
            txtNombreProduc.Text = "";
            txtPrecioProduc.Text = "";
            cantProduc.Value = 0;
           /* txtNombreProduc.ForeColor = Color.LightGray;
            txtPrecioProduc.ForeColor = Color.LightGray;*/
        }
        private void btnAProduc_Click(object sender, EventArgs e)
        {

            if (txtNombreProduc.Text == "" || txtPrecioProduc.Text == "")
            {
                MessageBox.Show("Falto llenar algun campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cantProduc.Value == 0)
                {
                    MessageBox.Show("Agregue Cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("¿Desea Agregar?","Agregar",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        string qry2 = "insert into produc values('" + txtNombreProduc.Text + "'," + cantProduc.Value + "," + txtPrecioProduc.Text + ")";
                        if (dts.insertar(qry2) == true)
                        {
                            MessageBox.Show("Producto Agregado", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarP();
                        }
                    }
                   
                }
            }
        }

        private void btnCancelaProduc_Click(object sender, EventArgs e)
        {
            if (txtNombreProduc.Text != "" && txtPrecioProduc.Text != "" && cantProduc.Value !=0)
            {
                if (MessageBox.Show("¿Desea Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    limpiarP();
                }
            }
            else
            {
                limpiarP();
            }
        }
       
        #region Placeholder
        private void txtNombreProduc_Enter(object sender, EventArgs e)
        {

            /*if (txtNombreProduc.Text == "Nombre")
            {
                txtNombreProduc.Text = "";
                txtNombreProduc.ForeColor = Color.Black;
            }*/
        }
        private void txtNombreProduc_Leave(object sender, EventArgs e)
        {
            /*if (txtNombreProduc.Text == "")
            {
                txtNombreProduc.Text = "Nombre";
                txtNombreProduc.ForeColor = Color.LightGray;
            }*/
        }
        private void txtPrecioProduc_Enter(object sender, EventArgs e)
        {
            /*if (txtPrecioProduc.Text == "Precio")
            {
                txtPrecioProduc.Text = "";
                txtPrecioProduc.ForeColor = Color.Black;
            }*/
        }
        private void txtPrecioProduc_Leave(object sender, EventArgs e)
        {
            /*
            if (txtPrecioProduc.Text == "")
            {
                txtPrecioProduc.Text = "Precio";
                txtPrecioProduc.ForeColor = Color.LightGray;
            }*/
        }


        #endregion

        #endregion


        #region agregaPromocion
        public void limpiaProm()
        {
            txtNP1.Text = "";
            txtProcentProm.Text = "";
        }
        private void btnAProm_Click(object sender, EventArgs e)
        {
            string qu = "";
            double des;
            if (txtNP1.Text==""||txtProcentProm.Text=="")
            {
                MessageBox.Show("Algun capo vacio","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Desea agregar?","Agregar",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    des = Convert.ToDouble(txtProcentProm.Text)/100;
                    qu = "insert into prom values('"+ txtNP1.Text+"',"+des+")";
                    if (dts.insertar(qu)==true)
                    {
                        MessageBox.Show("Agregado!!","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        limpiaProm();
                    }
                }
            }
        }
        private void btnCProm_Click(object sender, EventArgs e)
        {
            if (txtNP1.Text != "" && txtProcentProm.Text != "")
            {
                if (MessageBox.Show("¿Desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    limpiaProm();
                }
            }
            else
            {
                limpiaProm();
            }
        }

        #endregion

        #region validacionesTextBox
       
        restricciones validaciones = new restricciones();
        private void txtProcentProm_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.solonumerosEnteros(e);
        }
        private void txtPMem_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.solonumerosDecimal(e);
        }
        private void txtPrecioProduc_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.solonumerosDecimal(e);
        }
        //validacion de letras mayus
        public void LetrasMayus(TextBox textBox)
        {
            //Letra despues de cada espacion en Mayuscula
            textBox.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox.Text);
            textBox.SelectionStart = textBox.Text.Length;
        }
        private void txtNMem_TextChanged(object sender, EventArgs e)
        {
            LetrasMayus(txtNMem);
        }
        private void txtNP1_TextChanged(object sender, EventArgs e)
        {
            LetrasMayus(txtNP1);
        }
        private void txtNombreProduc_TextChanged(object sender, EventArgs e)
        {
            LetrasMayus(txtNombreProduc);
        }
        #endregion


    }
}
