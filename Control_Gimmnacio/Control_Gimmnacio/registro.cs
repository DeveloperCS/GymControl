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
            txtTotal.Enabled = false;
           fecheac = DateTime.Now.ToShortDateString();
            pickIni.Text = fecheac;
            // lbTotal1.Caption = Format(lbTotal1.Caption, "#######.00");
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");


        }
       
        private void registro_Load(object sender, EventArgs e)
        {
            txtClaveM.Enabled = false;
            groupMembresia.Enabled = false;
            llenaNumFech();
            llenaMesFehc();
            llenaSex();
            llenaCb();
            llenaCbMem();
            lbDesc.Visible = false;
            cbDescProm.Visible = false;
        }
        conexionDatos dts = new conexionDatos();
        restricciones val = new restricciones();
        #region llenarCB
        public void llenaCb()
        {
            string q = "select * from prom order by descuento";
           
            cbDescProm.DataSource = dts.consulta(q).Tables[0]; 
            cbDescProm.DisplayMember = "Promocion";
            cbDescProm.ValueMember = "nomPromocion";
            
        }
        public void llenaCbMem()
        {
            string q1 = "select nomMem+'-'+tipoPersona as T from memb order by precioMem";
            cbTipoMembrecia.DataSource = dts.consulta(q1).Tables[0];
            cbTipoMembrecia.DisplayMember = "Membresia";
            cbTipoMembrecia.ValueMember = "T";
        }

       
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
            
            for (int i = 1; i <= 12; i++)
            {
                if (i < 10)
                {
                    cbMesFecha.Items.Add("0"+i);
                }
                else
                {
                    cbMesFecha.Items.Add(i);
                }

            }

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
        decimal t = 0;
        string sex = "";
        private void cbTipoMembrecia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cb = cbTipoMembrecia.Text;
            string[] res = cb.Split('-');
           
                DataSet dataC = new DataSet();
                qyr1 = "select precioMem as p,tipoPersona as tp from memb where nomMem = '" + res[0] + "' ";
                dataC = dts.consulta(qyr1);
                DataTable dt2 = dataC.Tables[0];
                int dias = 0,mes =0, anio=0;
                pickFin.Value = pickIni.Value;
                int diasPlus = 0, mesP =0;
                dias = pickFin.Value.Day;
                mes = pickFin.Value.Month;
                anio=pickFin.Value.Year;
         
                foreach (DataRow row in dt2.Rows)
                {
                //
                        t = Convert.ToDecimal(row["p"]);
                        txtTotal.Text = t.ToString("N2");
                    if (dias == 28 && mes == 2)
                    {
                        //diasPlus = dias;
                         if (res[0] == "Mensual")
                         {
                            mesP++;
                            pickFin.Value = DateTime.Now.AddMonths(mesP);
                            break;
                         }
                         else if (res[0] == "Semanal")
                         {
                            diasPlus = 7;
                            pickFin.Value = DateTime.Now.AddDays(diasPlus);
                            break;
                         }
                    }
                    else if(mes !=2)
                    {
                        if (res[0] == "Mensual")
                        {
                            mesP++;
                            pickFin.Value = DateTime.Now.AddMonths(mesP);
                            break;
                        }
                        else if (res[0] == "Semanal")
                        {
                            diasPlus = 7;
                            pickFin.Value = DateTime.Now.AddDays(diasPlus);
                            break;
                        }
                      
                    }   
                   // dias = Convert.ToInt32(row["d"].ToString());
                }
               
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
                con = 1;
            }
            else
            {
                lbDesc.Visible = false;
                cbDescProm.Visible = false;
                con = 0;
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
                decimal vT=0, vO=0,vTT=0;
                vT = Convert.ToDecimal(t);
                decimal ttt;
                foreach (DataRow row in dt2.Rows)
                {
                    //
                    vO =Convert.ToDecimal( row["ds"].ToString());
                    vTT= vT*vO;
                    ttt = vT - vTT;
                    txtTotal.Text = ttt.ToString("N2");
                }
                con = 1;
            }
            else
            {
                con = 0;
            }
        }
        #region AgregaMEm
        int con = 0;
        string qs = "",qm1 = "",clave ="",nombres="";

        private void btnPagaMem_Click(object sender, EventArgs e)
        {
            if (cbSexo.Text.Equals(sex))
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
                    if (exten == null || exten == "")
                    {
                        id++;
                    }
                    else
                    {
                        id = Convert.ToInt32(exten) + 1;
                    }
                    string qH = "";
                    if (checkDesc.Checked == true)
                    {
                        qm1 = "insert into memSocio values('" + txtClaveM.Text + "','" + cbTipoMembrecia.Text + "','" + pickIni.Value.ToString("yyyy/MM/dd") + "','" + pickFin.Value.ToString("yyyy/MM/dd") + "','" + cbDescProm.Text + "','" + Convert.ToDecimal(txtTotal.Text) + "','Vigente','" + id + "')";
                        if (dts.insertar(qm1) == true)
                        {
                            qH = "insert into historialS values('" + txtClaveM.Text + "','" + txtNom.Text + "','" + cbTipoMembrecia.Text + "','" + pickIni.Value.ToString("yyyy/MM/dd") + "','" + pickFin.Value.ToString("yyyy/MM/dd") + "','" + cbDescProm.Text + "','" + Convert.ToDecimal(txtTotal.Text) + "','Vigente')";
                            if (dts.insertar(qH) == true)
                            {
                                MessageBox.Show("Datos Agregados!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiaSocio();
                                limpiaMem();

                            }

                        }
                    }
                    else
                    {
                        qm1 = "insert into memSocio values('" + txtClaveM.Text + "','" + cbTipoMembrecia.Text + "','" + pickIni.Value.ToString("yyyy/MM/dd") + "','" + pickFin.Value.ToString("yyyy/MM/dd") + "','S/N','" + Convert.ToDecimal(txtTotal.Text) + "','Vigente','" + id + "')";
                        if (dts.insertar(qm1) == true)
                        {
                            qH = "insert into historialS values('" + txtClaveM.Text + "','" + txtNom.Text + "','" + cbTipoMembrecia.Text + "','" + pickIni.Value.ToString("yyyy/MM/dd") + "','" + pickFin.Value.ToString("yyyy/MM/dd") + "','S/N','" + Convert.ToDecimal(txtTotal.Text) + "','Vigente')";
                            if (dts.insertar(qH) == true)
                            {
                                MessageBox.Show("Datos Agregados!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiaSocio();
                                limpiaMem();

                            }
                        }
                    }


                }
            }
            else
            {
                MessageBox.Show("Memebresia no compatible con el sexo del socio \n \n Eliga otra membresia","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
            
        }
        #region validacion
        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.sololetras(e);
        }
        private void txtAñoFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.solonumerosEnteros(e);
        }
        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.solonumerosEnteros(e);
        }
        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            //Letra despues de cada espacion en Mayuscula
            txtNom.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNom.Text);
            txtNom.SelectionStart = txtNom.Text.Length;
        }
        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

            //Letra despues de cada espacion en Mayuscula
            txtDireccion.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtDireccion.Text);
            txtDireccion.SelectionStart = txtDireccion.Text.Length;

        }


        #endregion

        private void btnCancelaSocio_Click(object sender, EventArgs e)
        {
            limpiaSocio();
        }

        private void btnCancelarMem_Click(object sender, EventArgs e)
        {
            limpiaSocio();
            limpiaMem();
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
                //string nombre = "Michael Jose Jackson del Carmen";
                string nombre="";
                nombre = txtNom.Text;
                var datos = (from c in nombre.Split(' ') where Char.IsUpper(Convert.ToChar(c.Substring(0, 1))) select c.Substring(0, 1));
                // Ahora probamos que funcione...
                clave = "";
                foreach (string s in datos)
                {
                    clave += s;
                }
                nombres = clave + txtAñoFecha.Text;
                if (MessageBox.Show("¿Agregar Socio?","Agregar",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    string fechaT = cbNumeroFecha.SelectedItem.ToString()+ "/"+ cbMesFecha.SelectedItem.ToString()+"/"+ txtAñoFecha.Text;

                    qs = "insert into socio values('S-"+nombres+"','"+txtNom.Text+"','"+fechaT+"','"+cbSexo.SelectedItem.ToString() + "','"+txtDireccion.Text+"','"+txtTel.Text+"','"+txtFB.Text+"')";
                    
                    if (dts.insertar(qs)==true)
                    {

                        MessageBox.Show("Datos Agregados!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("¿Agregar Membresia?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            txtClaveM.Text = "S-" + nombres;
                            btnAgregaSocio.Enabled = false;
                            groupMembresia.Enabled = true;
                           
                        }
                        else
                        {
                            limpiaSocio();
                        }
                          
                    }
                   

                }
                else
                {
                  
                }
            }
        }
        #endregion
        #region LimpiarTxt
        public void limpiaSocio()
        {
            nombres = "";
            txtNom.Text = "";
            txtAñoFecha.Text = "";
            txtDireccion.Text = "";
            txtFB.Text = "";
            txtTel.Text = "";
            cbSexo.Items.Clear();
            cbMesFecha.Items.Clear();
            cbNumeroFecha.Items.Clear();
            llenaMesFehc();
            llenaNumFech();
            llenaSex();
        }
        public void limpiaMem()
        {
            nombres = "";
            txtClaveM.Text = "";
            //lbTotal1.Text = "0.00";
            txtTotal.Text = "";
            cbDescProm.Refresh();
            cbTipoMembrecia.Refresh();
            checkDesc.Checked = false;
            groupMembresia.Enabled = false;
            btnAgregaSocio.Enabled = true;
        }
        #endregion
    }
}
