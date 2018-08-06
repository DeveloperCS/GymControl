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
    public partial class vHistorialUs : Form
    {
        public vHistorialUs()
        {
            InitializeComponent();
            btnGuardarS.Enabled = false;
            btnEliminaMemS.Enabled = false;
            btnAgregaMemS.Enabled = false;
            consultaSocio();

        }
        private void vHistorialUs_Load(object sender, EventArgs e)
        {
          
            txtClaveS.Enabled = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region arrastrar
        // Arrastrar formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void vHistorialUs_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        conexionDatos dts = new conexionDatos();

        #region consultas
        string q1 = "";
        public void consultaSocio()
        {
            q1 = "Select idSocio as Clave, nombre as Nombre,tel as Telefono_de_Contacto, fb as Facebook  from socio";
            dGWSocios.DataSource = dts.consulta(q1).Tables[0];
        }
        public void consultaHistorial(string clave)
        {
            q1 = "select idMemS as Clave, tMem as Tipo, fechaIngreso as Fecha_Inicial, fechatermino as Fecha_Final,prom as Promocion, total as Monto_Pagado, estado as Estatus from memSocio where idMems = '"+clave+"'";
            dGWHistorial.DataSource = dts.consulta(q1).Tables[0];
        }
        #endregion
       
        private void btnSelecionarS_Click(object sender, EventArgs e)
        {
            string cl= dGWSocios.CurrentRow.Cells[0].Value.ToString();
            consultaHistorial(cl);
            btnGuardarS.Enabled = true;
            btnEliminaMemS.Enabled = true;
            btnAgregaMemS.Enabled = true;
            /*consulta de todo*/
            DataSet dataC = new DataSet();
            string qCompruena = "Select idSocio as c, nombre as n, fNacimiento as fn, sexo as s,dir as dr, tel as tl, fb as fb  from socio where idSocio ='"+cl+"'";
            dataC = dts.consulta(qCompruena);
            DataTable dt2 = dataC.Tables[0];
            string f = "";
            foreach (DataRow row in dt2.Rows)
            {
                txtClaveS.Text = row["c"].ToString();
                txtNomS.Text = row["n"].ToString();
                txtdir.Text = row["dr"].ToString();
                txtTel.Text = row["tl"].ToString();
                txtFB.Text = row["fb"].ToString();
                txtS.Text = row["s"].ToString();
                f = row["fn"].ToString();        
                DateTime myDateTime = DateTime.Parse(f);
                string dia = Convert.ToString(myDateTime.Day);
                string mes = Convert.ToString(myDateTime.Month);
                string ano = Convert.ToString(myDateTime.Year);
                txtD.Text = dia;
                txtM.Text = mes;
                txtAñoF.Text = ano;
            }


        }
        public void limpiar()
        {
            txtClaveS.Text = "";
            txtNomS.Text = "";
            txtdir.Text = "";
            txtTel.Text = "";
            txtFB.Text = "";
            txtS.Text = "";
            txtD.Text = "";
            txtM.Text = "";
            txtAñoF.Text = "";
            dGWHistorial.DataSource = null;
            btnGuardarS.Enabled = false;
            btnAgregaMemS.Enabled = false;
            btnEliminaMemS.Enabled = false;

        }
        private void btnLimpiarS_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnEliminarS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar?","Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                string c= dGWSocios.CurrentRow.Cells[0].Value.ToString();
                string qr = "delete from memSocio where idMemS= '"+c+"' ";
                if (dts.eliminar(qr)==true)
                {
                    string qr2 = "delete from socio where idSocio = '"+c+"' ";
                    if (dts.eliminar(qr2)==true)
                    {
                        MessageBox.Show("Socio Eliminado","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        consultaSocio();
                        limpiar();
                    }
                }
            }
        }

        private void btnGuardarS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Guardar?", "Guardar", MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                string fn = txtD.Text + "/" + txtM.Text + "/" + txtAñoF.Text;
               string qry = "update socio set nombre='"+txtNomS.Text+ "', fNacimiento='"+fn+ "', sexo='"+txtS.Text+"', dir ='"+txtdir.Text+"',tel = '"+txtTel.Text+"', fb='"+txtFB.Text+"' where idSocio='"+txtClaveS.Text+"' ";
                if (dts.update(qry)==true)
                {
                    /*qry = "update memSocio set ";
                    if (dts.update(qry)==true)
                    {*/
                        MessageBox.Show("Socio Actualizado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        consultaSocio();
                        limpiar();
                    /*}*/

                }
            }
        }
        vAgregaMemS vm = new vAgregaMemS();
        private void btnAgregaMemS_Click(object sender, EventArgs e)
        {
            if (dGWHistorial.RowCount>0)
            {
                if (dGWHistorial.CurrentRow.Cells[6].Value.ToString() == "Vigente")
                {
                    MessageBox.Show("Aun no puede agregar otro plan a este socio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (dGWHistorial.CurrentRow.Cells[6].Value.ToString() == "Expirado")
                {
                    vm.txtclave.Text = txtClaveS.Text;
                    vm.ShowDialog();
                }
            }
            else
            {
                vm.txtclave.Text = txtClaveS.Text;
                vm.ShowDialog();
            }
           
        }
        string q12 = "";
        private void btnEliminaMemS_Click(object sender, EventArgs e)
        {
            if (dGWHistorial.RowCount > 0)
            {
                if (dGWHistorial.CurrentRow.Cells[6].Value.ToString() == "Vigente")
                {
                    if(MessageBox.Show("La membresia esta vigente \n ¿Quiere eliminarla?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)==DialogResult.Yes)
                    {
                        q12 = "delete from memSocio where idMemS='"+dGWHistorial.CurrentRow.Cells[0].Value.ToString() + "' ";
                        if (dts.eliminar(q12)==true)
                        {
                            MessageBox.Show("Historial Actualizado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            consultaHistorial(txtClaveS.Text);
                        }
                    }
                }
                else if (dGWHistorial.CurrentRow.Cells[6].Value.ToString() == "Expirado")
                {
                    q12 = "delete from memSocio where idMemS='" + dGWHistorial.CurrentRow.Cells[0].Value.ToString() + "' ";
                    if (dts.eliminar(q12) == true)
                    {
                        MessageBox.Show("Historial Actualizado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        consultaHistorial(txtClaveS.Text);
                    }
                }
            }
            else
            {
                MessageBox.Show("No Cuenta con plan de Membresias", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            }
        }
    }
}
