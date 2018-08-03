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
    public partial class registro : Form
    {
        string fecheac;
        public registro()
        {
            InitializeComponent();
            //evitar modificar combobox
            cbMesFecha.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNumeroFecha.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoMembrecia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDescProm.DropDownStyle = ComboBoxStyle.DropDownList;
            pickFin.Enabled = false;
            pickIni.Enabled = false;
            fecheac = DateTime.Now.ToShortDateString();
            pickIni.Text = fecheac;
        }
       
        private void registro_Load(object sender, EventArgs e)
        {
            llenaNumFech();
            llenaMesFehc();
            llenaSex();
            llenaCb();
            llenaCbMem();
            lbDesc.Visible = false;
            cbDescProm.Visible = false;
        }
        conexionDatos dts = new conexionDatos();
        public void llenaCb()
        {
            string q = "select * from prom order by descuento";
           
            cbDescProm.DataSource = dts.consulta(q).Tables[0]; 
            cbDescProm.DisplayMember = "Promocion";
            cbDescProm.ValueMember = "nomPromocion";
            
        }
        public void llenaCbMem()
        {
            string q1 = "select * from memb order by precioMem";
            cbTipoMembrecia.DataSource = dts.consulta(q1).Tables[0];
            cbTipoMembrecia.DisplayMember = "Membresia";
            cbTipoMembrecia.ValueMember = "nomMem";
        }

        #region llenarCB
        //llena cb 
        public void llenaNumFech()
        {
            for (int i = 1; i <= 31; i++)
            {
                if (i < 10)
                {
                    cbNumeroFecha.Items.Add("0" + i);
                }
                else
                {
                    cbNumeroFecha.Items.Add(i);
                }

            }


        }
        public void llenaMesFehc()
        {
            cbMesFecha.Items.Add("Ene");
            cbMesFecha.Items.Add("Feb");
            cbMesFecha.Items.Add("Mar");
            cbMesFecha.Items.Add("Abri");
            cbMesFecha.Items.Add("May");
            cbMesFecha.Items.Add("Jun");
            cbMesFecha.Items.Add("Jul");
            cbMesFecha.Items.Add("Ago");
            cbMesFecha.Items.Add("Sep");
            cbMesFecha.Items.Add("Oct");
            cbMesFecha.Items.Add("Nov");
            cbMesFecha.Items.Add("Dic");
        }
        public void llenaSex()
        {
            cbSexo.Items.Add("M");
            cbSexo.Items.Add("F");
        }
        #endregion
        private void btn_cerrar_mem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string qyr1 = "";
        double t = 0;
        private void cbTipoMembrecia_SelectedIndexChanged(object sender, EventArgs e)
        {

            /*if (checkDesc.Checked == true)
            {
               
                DataSet dataC = new DataSet();
                qyr1 = "select descuento as ds from prom where nomPromocion = '" + cbDescProm.Text + "' ";
                dataC = dts.consulta(qyr1);
                DataTable dt2 = dataC.Tables[0];
                double vT = 0, vO = 0, vTT = 0;
                vT = Convert.ToDouble(t);
                foreach (DataRow row in dt2.Rows)
                {
                    //
                    vO = Convert.ToDouble(row["ds"].ToString());
                    vTT = vT * vO;
                    lbTotal.Text = vT - vTT + ".00";
                }

            }
            else
            {*/
                DataSet dataC = new DataSet();
                qyr1 = "select precioMem as p,dias as d from memb where nomMem = '" + cbTipoMembrecia.Text + "' ";
                dataC = dts.consulta(qyr1);
                DataTable dt2 = dataC.Tables[0];
                int dias = 0;
                foreach (DataRow row in dt2.Rows)
                {
                    //
                    lbTotal.Text = row["p"].ToString();
                    t = Convert.ToDouble(row["p"]);
                    dias = Convert.ToInt32(row["d"].ToString());
                }
                pickFin.Value = pickIni.Value;
                pickFin.Value = DateTime.Now.AddDays(dias);
           // }
            /*saco los datos de membresias*/
           
        }

        private void agregaSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new vHistorialUs().ShowDialog();
        }

        private void checkDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDesc.Checked==true)
            {
                lbDesc.Visible = true;
                cbDescProm.Visible = true;
            }
            else
            {
                lbDesc.Visible = false;
                cbDescProm.Visible = false;
            }
        }

        private void cbDescProm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkDesc.Checked == true)
            {
                /*saco los datos de membresias*/
                DataSet dataC = new DataSet();
                qyr1 = "select descuento as ds from prom where nomPromocion = '" + cbDescProm.Text + "' ";
                dataC = dts.consulta(qyr1);
                DataTable dt2 = dataC.Tables[0];
                double vT=0, vO=0,vTT=0;
                vT = Convert.ToDouble(t);
                foreach (DataRow row in dt2.Rows)
                {
                    //
                    vO =Convert.ToDouble( row["ds"].ToString());
                    vTT= vT*vO;
                    lbTotal.Text = vT - vTT+".00";
                }
                
            }
            else
            {

            }
        }

        private void btnAgregaSocio_Click(object sender, EventArgs e)
        {
            if (txtNom.Text == "" || txtTel.Text == "" || txtAñoFecha.Text == "" || txtDireccion.Text == "" || txtFB.Text == "" || cbMesFecha.Text == ""||cbNumeroFecha.Text==""||cbSexo.Text=="")
            {
                MessageBox.Show("Flato llenar algunos Campos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                //pagar o no la membresia
            }
        }
    }
}
