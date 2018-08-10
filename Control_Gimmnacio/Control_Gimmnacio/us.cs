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
    public partial class us : Form
    {
        conexionDatos dts = new conexionDatos();
        public us()
        {
            InitializeComponent();
            //evitar modificar combobox
            recargaCb();
            cbTipoUs.DropDownStyle = ComboBoxStyle.DropDownList;
            consulta();
            btnGuardar.Visible = false;
            txtID.Visible = false;
        }
        DataView miFiltro;
        private void consulta()
        {
            
            string q = "select id as Numero,nombreUs as Nombre,usuario as Usuario,tipoUs as Tipo from usuarios where usuario !='root '";
            this.miFiltro = dts.consulta(q).Tables[0].DefaultView;
            dataGridView1.DataSource = miFiltro;
        }

        private void us_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombreUs.Text = "";
            txtConfirmPass.Text = "";
            txtPassUs.Text = "";
            txtUs.Text = "";
            cbTipoUs.Items.Clear();
            recargaCb();
           // idOptenido = 0;
            if (btnAgregaUs.Enabled == false){btnAgregaUs.Enabled = true;}
            if (btnGuardar.Visible==true) { btnGuardar.Visible = false; }
            if (btnEliminaUs.Enabled==false) { btnEliminaUs.Enabled = true; }
            if (txtID.Visible==true) { txtID.Visible = false; }
        }

        private void btnAgregaUs_Click(object sender, EventArgs e)
        {
            if (txtNombreUs.Text == ""||txtConfirmPass.Text == ""||txtPassUs.Text == ""||txtUs.Text == ""||cbTipoUs.Text == null)
            {
                MessageBox.Show("Debes llenar todos los campos","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                /*compruebo que los usuarios no esten ya repetidos*/
                DataSet dataC = new DataSet();
                string qCompruena = "Select usuario as us from usuarios";
                dataC = dts.consulta(qCompruena);
                DataTable dt2 = dataC.Tables[0];
                int cont=0;
                string usExist="";
                foreach (DataRow row in dt2.Rows)
                {
                    //
                    if (txtUs.Text==row["us"].ToString())
                    {
                        cont++;
                        usExist = row["us"].ToString();
                    }
                }
                if (cont > 0)
                {
                    MessageBox.Show("Usuario: " + usExist + " Ya Existe", "Alerta!!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    if (txtConfirmPass.Text.Equals(txtPassUs.Text))
                    {
                        string q2 = "INSERT into usuarios (nombreUs,usuario,pass,tipoUs)values('" + txtNombreUs.Text + "','" + txtUs.Text + "', HASHBYTES('SHA2_512', '" + txtPassUs.Text + "'),'" + cbTipoUs.SelectedItem.ToString() + "')";
                        if (MessageBox.Show("¿Desea agregar nuevo Usuario?", "Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (dts.insertar(q2) == true)
                            {
                                MessageBox.Show("Usuario agregado", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                consulta();
                                txtNombreUs.Text = "";
                                txtConfirmPass.Text = "";
                                txtPassUs.Text = "";
                                txtUs.Text = "";
                                cbTipoUs.Items.Clear();
                                recargaCb();
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coninciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtConfirmPass.Text = "";
                        txtPassUs.Text = "";
                    }
                }
                
            }
        }
        /* este metodo es para rellenar el cb*/
        private void recargaCb()
        {
            cbTipoUs.Items.Add("Administrador");
            cbTipoUs.Items.Add("Usuario");
        }

        private void btnEliminaUs_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("No hay usuarios ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Desea eliminar este usuario?", "Eliminar Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string q5 = "DELETE usuarios where id ='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                    if (dts.eliminar(q5) == true)
                    {
                        MessageBox.Show("Datos Eliminados", "Exito", MessageBoxButtons.OK);
                        consulta();
                    }

                }
            }
        }
        /*generar boton editar*/
        private void btnEditarUs_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount==0)
            {
                MessageBox.Show("No hay usuarios ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                txtID.Visible = true;
                txtID.Enabled = false;
                txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNombreUs.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtUs.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cbTipoUs.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                btnAgregaUs.Enabled = false;
                btnGuardar.Visible = true;
                btnEliminaUs.Enabled = false;
            }
           
          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*Comprueba si en caso de que el usuario se actualizado, este no este asignado a otro usuario*/
            DataSet dataUsC = new DataSet();
            string query = "Select nombreUs as nom , usuario as us from usuarios";
            dataUsC = dts.consulta(query);
            DataTable dtN = dataUsC.Tables[0];
            int contUS=0;
            foreach (DataRow row in dtN.Rows)
            {
                
                if (txtUs.Text == row["us"].ToString())
                {
                    
                    if (txtNombreUs.Text == row["nom"].ToString())
                    {
                        // MessageBox.Show("" + row["us"].ToString()+"\n"+ row["nom"].ToString());
                        contUS ++;
                    }
                    else
                    {
                        MessageBox.Show("Este Usuario ya esta registrado","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                    }
                }
            }

            if (contUS >0)
            {
                if (MessageBox.Show("¿Deseas guardar la edicion?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txtPassUs.Text == "" || txtConfirmPass.Text == "")
                    {
                        if (MessageBox.Show("¿Desea seguir sin Contraseña?\n \n -Solo se actualizará los demas datos-", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string q4 = "UPDATE usuarios SET nombreUs='" + txtNombreUs.Text + "',usuario='" + txtUs.Text + "',tipoUs='" + cbTipoUs.SelectedItem.ToString() + "' WHERE id='" + txtID.Text + "'";
                            if (dts.update(q4) == true)
                            {
                                if (MessageBox.Show("Datos Actualizados", "Exito", MessageBoxButtons.OK) == DialogResult.OK)
                                {
                                    txtNombreUs.Text = "";
                                    txtConfirmPass.Text = "";
                                    txtPassUs.Text = "";
                                    txtUs.Text = "";
                                    cbTipoUs.Items.Clear();
                                    recargaCb();
                                    consulta();
                                    if (btnAgregaUs.Enabled == false) { btnAgregaUs.Enabled = true; }
                                    if (btnGuardar.Visible == true) { btnGuardar.Visible = false; }
                                    if (btnEliminaUs.Enabled == false) { btnEliminaUs.Enabled = true; }
                                    if (txtID.Visible == true) { txtID.Visible = false; }
                                }

                            }
                            else
                            {
                                MessageBox.Show("ocurrio un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        string q3 = "UPDATE usuarios SET nombreUs='" + txtNombreUs.Text + "',usuario='" + txtUs.Text + "',pass=HASHBYTES('SHA2_512', '" + txtPassUs.Text + "'),tipoUs='" + cbTipoUs.SelectedItem.ToString() + "' WHERE id='" + txtID.Text + "'";
                        if (txtPassUs.Text.Equals(txtConfirmPass.Text))
                        {
                            if (dts.update(q3) == true)
                            {
                                if (MessageBox.Show("Datos Actualizados", "Exito", MessageBoxButtons.OK) == DialogResult.OK)
                                {
                                    txtNombreUs.Text = "";
                                    txtConfirmPass.Text = "";
                                    txtPassUs.Text = "";
                                    txtUs.Text = "";
                                    cbTipoUs.Items.Clear();
                                    recargaCb();
                                    consulta();
                                    if (btnAgregaUs.Enabled == false) { btnAgregaUs.Enabled = true; }
                                    if (btnGuardar.Visible == true) { btnGuardar.Visible = false; }
                                    if (btnEliminaUs.Enabled == false) { btnEliminaUs.Enabled = true; }
                                    if (txtID.Visible == true) { txtID.Visible = false; }
                                }

                            }
                            else
                            {
                                MessageBox.Show("ocurrio un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {

                }
            }
            
        }
      
        #region validaciones
        restricciones val = new restricciones();
        private void txtNombreUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.sololetras(e);
        }
        private void txtUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.sinEspacio(e);
        }

        private void txtPassUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.sinEspacio(e);
        }

        private void txtConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.sinEspacio(e);
        }
        private void txtNombreUs_TextChanged(object sender, EventArgs e)
        {
            //Letra despues de cada espacion en Mayuscula
            txtNombreUs.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNombreUs.Text);
            txtNombreUs.SelectionStart = txtNombreUs.Text.Length;
        }

        #endregion

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            string salida = "";
            string[] pBusqueda = this.textBox5.Text.Split(' ');
            foreach (string p in pBusqueda)
            {
                if(salida.Length ==0)
                {
                    salida = "(Nombre LIKE '% " + p+ "%' OR Nombre LIKE '" + p + "%' OR Usuario LIKE '%" + p+ "%' OR Usuario LIKE '" + p + "%' OR Tipo LIKE '%" + p+ "%' OR Tipo LIKE '" + p + "%' )";
                }
                else
                {
                    salida += "AND (Nombre LIKE '% " + p+ "%' OR Nombre LIKE '" + p + "%' OR Usuario LIKE '%" + p+ "%' OR Usuario LIKE '" + p + "%' OR Tipo LIKE '%" + p+ "%' OR Tipo LIKE '" + p + "%')";
                }
            }
            this.miFiltro.RowFilter = salida;
        }
    }
}
