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
   
    public partial class vAgregaMemS : Form
    {
        string fecheac1 = "";
        public vAgregaMemS()
        {
            InitializeComponent();
            cbTipoMem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProm.DropDownStyle = ComboBoxStyle.DropDownList;
            txtclave.Enabled = false;
            PickIni.Enabled = false;
            PickFin.Enabled = false;
            lbDesc.Visible = false;
            txtTotal.Enabled = false;
            cbProm.Visible = false;
            chekProm.Checked = false;
            fecheac1 = DateTime.Now.ToShortDateString();
            PickIni.Text = fecheac1;

        }
        // Arrastrar formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        conexionDatos dts = new conexionDatos();
        #region llenaCb
        public void llenaCb()
        {
            string q = "select * from prom order by descuento";

            cbProm.DataSource = dts.consulta(q).Tables[0];
            cbProm.DisplayMember = "Promocion";
            cbProm.ValueMember = "nomPromocion";

        }
        public void llenaCbMem()
        {
            string q1 = "select * from memb order by precioMem";
            cbTipoMem.DataSource = dts.consulta(q1).Tables[0];
            cbTipoMem.DisplayMember = "Membresia";
            cbTipoMem.ValueMember = "nomMem";
        }
        #endregion

        private void vAgregaMemS_Load(object sender, EventArgs e)
        {
            llenaCb();
            llenaCbMem();
        }
        string qyr1="";
        decimal t = 0;
        private void cbTipoMem_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dataC = new DataSet();
            qyr1 = "select precioMem as p,dias as d from memb where nomMem = '" + cbTipoMem.Text + "' ";
            dataC = dts.consulta(qyr1);
            DataTable dt2 = dataC.Tables[0];
            int dias = 0;
            foreach (DataRow row in dt2.Rows)
            {
                //
             
                t = Convert.ToDecimal(row["p"]);
                txtTotal.Text = t.ToString("N2");
                dias = Convert.ToInt32(row["d"].ToString());
            }
            PickFin.Value = PickIni.Value;
            PickFin.Value = DateTime.Now.AddDays(dias);
        }
        int con = 0;
        private void chekProm_CheckedChanged(object sender, EventArgs e)
        {
            if (chekProm.Checked == true)
            {
                lbDesc.Visible = true;
                cbProm.Visible = true;
                con = 1;
            }
            else
            {
                lbDesc.Visible = false;
                cbProm.Visible = false;
                con = 0;
            }
        }

        private void cbProm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chekProm.Checked == true)
            {
                /*saco los datos de membresias*/
                DataSet dataC = new DataSet();
                qyr1 = "select descuento as ds from prom where nomPromocion = '" + cbProm.Text + "' ";
                dataC = dts.consulta(qyr1);
                DataTable dt2 = dataC.Tables[0];
                decimal vT = 0, vO = 0, vTT = 0;
                vT = Convert.ToDecimal(t);
                foreach (DataRow row in dt2.Rows)
                {
                    //
                    vO = Convert.ToDecimal(row["ds"].ToString());
                    vTT = vT * vO;
                    decimal ttt = vT - vTT;
                    txtTotal.Text = ttt.ToString("N2");
                }
                con = 1;
            }
            else
            {
                con = 0;
            }
        }
        public TextBox txtnoms = new TextBox();
        public string idUPD = "",qrUPD="";
        string qm1= "";
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Agregar Membresia?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                /*Para generar id de Mem*/
                DataSet dataC1 = new DataSet();
                string qqAc = "select Max(idControl) as C1 from memSocio";
                dataC1 = dts.consulta(qqAc);
                DataTable dt2 = dataC1.Tables[0];
                string exten = "";
                foreach (DataRow row in dt2.Rows)
                {
                    exten = row["C1"].ToString();
                }
                int id = 0;
                if (exten == null||exten =="")
                {
                     id++;
                }
                else{
                     id = Convert.ToInt32(exten) + 1;
                }

                string qH = "";
                if (chekProm.Checked == true)
                {
                    qm1 = "insert into memSocio values('" + txtclave.Text + "','" + cbTipoMem.Text + "','" + PickIni.Value.ToString("yyyy/MM/dd") + "','" + PickFin.Value.ToString("yyyy/MM/dd") + "','" + cbProm.Text + "','" +Convert.ToDecimal(txtTotal.Text) + "','Vigente','"+id+"')";
                    if (dts.insertar(qm1) == true)
                    {
                        MessageBox.Show("Datos Agregados!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        qrUPD = "update memSocio set estado='Archivado' where idControl = '" + idUPD + "'and idMemS ='"+txtclave.Text+"' ";
                        if (dts.update(qrUPD) == true)
                        {
                            qH = "insert into historialS values('" + txtclave.Text + "','"+txtnoms.Text+"','" + cbTipoMem.Text + "','" + PickIni.Value.ToString("yyyy/MM/dd") + "','" + PickFin.Value.ToString("yyyy/MM/dd") + "','" + cbProm.Text + "','" + Convert.ToDecimal(txtTotal.Text) + "','Vigente')";
                            if (dts.insertar(qH) == true)
                            {
                                this.Close();

                            }
                           
                        }
                       // new vHistorialUs().consultaHistorial2(txtclave.Text);
                        
                      
                    }
                }
                else
                {
                    qm1 = "insert into memSocio values('" + txtclave.Text + "','" + cbTipoMem.Text + "','" + PickIni.Value.ToString("yyyy/MM/dd") + "','" + PickFin.Value.ToString("yyyy/MM/dd") + "','S/N','" + Convert.ToDecimal(txtTotal.Text) + "','Vigente','"+id+"')";
                    if (dts.insertar(qm1) == true)
                    {
                        MessageBox.Show("Datos Agregados!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //new vHistorialUs().consultaHistorial2(txtclave.Text);
                        qrUPD = "update memSocio set estado='Archivado' where idControl = '" + idUPD + "'";
                        if (dts.update(qrUPD) == true)
                        {
                            qH = "insert into historialS values('" + txtclave.Text + "','" + txtnoms.Text + "','" + cbTipoMem.Text + "','" + PickIni.Value.ToString("yyyy/MM/dd") + "','" + PickFin.Value.ToString("yyyy/MM/dd") + "','S/N','" + Convert.ToDecimal(txtTotal.Text) + "','Vigente')";
                            if (dts.insertar(qH) == true)
                            {
                                this.Close();

                            }
                        }

                    }
                }


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Cancelar?","Cancelar",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                idUPD = "";
                this.Close();
            }
        }
    }
}
