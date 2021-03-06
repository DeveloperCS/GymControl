﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Gimmnacio
{
    public partial class ventanConfEdit : Form
    {
        public ventanConfEdit()
        {
            
            InitializeComponent();
            bloquearTxt();
            
           
        }
        //bloquear Text
        public void bloquearTxt()
        {
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
        public int cPorcent = 0,sctEle=0;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("No existen datos!! \n Agregelos desde Configuracion","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                btnEliminar.Enabled = false;
                if (lb4.Visible.Equals(false))
                {
                    if (cPorcent == 0)
                    {
                        // MessageBox.Show("entro con0");
                        bloqueaEliminar(1);
                        txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        txt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        txt3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        txt2.Enabled = true;
                        txt3.Enabled = true;
                    }
                    else if (cPorcent == 1)
                    {
                        //MessageBox.Show("entro con1");
                        bloqueaEliminar(1);
                        txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        txt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        String input = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        // separa el % del numero ya convertido
                        String pattern = @"%";
                        String[] elements = Regex.Split(input, pattern);
                        txt3.Text = elements[0];
                        txt2.Enabled = true;
                        txt3.Enabled = true;
                    }

                }
                else if (lb4.Visible.Equals(true))
                {
                    decimal numDec=0;
                    switch (sctEle)
                    {
                        case 1:
                            //productos
                            txt2.Enabled = true;
                            txt3.Enabled = true;
                            num4.Enabled = true;
                            txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                            txt2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                            numDec = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                            txt3.Text = numDec.ToString("N2");
                            // num4.Value = Convert.ToInt64(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                            num4.Value = 0;
                            break;
                        case 2:
                            //membresias 
                            txt2.Enabled = false;
                            txt3.Enabled = true;
                            num4.Enabled = false;
                            txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                            txt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString()+" "+ dataGridView1.CurrentRow.Cells[2].Value.ToString();
                            numDec =Convert.ToDecimal( dataGridView1.CurrentRow.Cells[3].Value.ToString());
                            txt3.Text = numDec.ToString("N2");
                           // num4.Value = Convert.ToInt64(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                            break;
                    }


                }
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
        public void consultaPr(string q1)
        {
            DataSet dataS = new DataSet();
            //q = "Select idProm as Id,nomPromocion as Promocion,descuento as Descuento from prom";
            dataS = dts.consulta(q1);
            DataTable dt2 = dataS.Tables[0];
            int por = 0;
            double t = 0;
            DataTable relleno = new DataTable();

            relleno.Columns.Add("Id", typeof(string));
            relleno.Columns.Add("Promocion", typeof(string));
            relleno.Columns.Add("Descuento", typeof(string));
            foreach (DataRow row in dt2.Rows)
            {
                t = Convert.ToDouble(row["Descuento"]);
                t = t * 100;
                por = Convert.ToInt32(t);
                relleno.Rows.Add(row["Id"].ToString(), row["Promocion"].ToString(), por.ToString() + " %");

            }
            dataGridView1.DataSource = relleno;
        }
        public void bloqueaEliminar(int c=0)
        {
            
            switch (c)
            {
                case 1:
                    btnEliminar.Enabled = false;
                    break;
                case 2:
                    btnEliminar.Enabled = true;
                    break;
            }
        }
        conexionDatos dts = new conexionDatos();
        #region BtnGuardayElimina
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
                        //sacar la cantidad de producto que hay
                        string q12 = "select stock as s from product where idProduc = '" + txt1.Text.Trim() + "'";
                        DataSet dtset = new DataSet();
                        dtset = dts.consulta(q12);
                        DataTable tD = dtset.Tables[0];
                        int cant = 0;
                        foreach (DataRow row in tD.Rows)
                        {
                            if (row["s"].ToString().Equals(""))
                            {
                                cant = 0;
                            }
                            else
                            {
                                cant = Convert.ToInt32(row["s"].ToString());
                            }
                        }
                        cant = cant + Convert.ToInt32( num4.Value);
                    
                        qry = "Update product set nomProduc ='" + txt2.Text.Trim() + "',stock=" + cant + ",precio=" +Convert.ToDecimal( txt3.Text.Trim()) + " where idProduc = " + txt1.Text.Trim() + "";
                        if (dts.update(qry) == true)
                        {
                            MessageBox.Show("Elemento Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                            q2 = "select idProduc as Id,cod as Codigo,nomProduc as Producto,stock as Cantidad,precio as Precio from product";
                            consultar(q2);
                            bloqueaEliminar(2);
                        }

                    }
                    if (lbTitulo.Text == "Membresias Registradas")
                    {
                        qry = "update memb set  precioMem=" + Convert.ToDecimal( txt3.Text.Trim()) + " where idMem=" + txt1.Text.Trim() + " ";
                        if (dts.update(qry) == true)
                        {
                            MessageBox.Show("Elemento Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                            q2 = "select idMem as Id, nomMem as Membresia,tipoPersona as [Tipo Persona],precioMem as Precio from memb";
                            consultar(q2);
                            bloqueaEliminar(2);
                        }
                    }
                    if (lbTitulo.Text== "Promociones Registradas")
                    {
                        double pCon=0;
                        pCon = Convert.ToDouble(txt3.Text)/100;
                        qry = "update prom set nomPromocion = '"+txt2.Text.Trim() + "',descuento = "+pCon+" where idProm ="+txt1.Text.Trim() + "";
                        if (dts.update(qry) == true)
                        {
                            MessageBox.Show("Elemento Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                            DataSet dataS = new DataSet();
                            q2 = "Select idProm as Id,nomPromocion as Promocion,descuento as Descuento from prom";
                            consultaPr(q2);
                            bloqueaEliminar(2);
                        }
                    }
                }
            }
            
            
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("No existen datos!! \n Agregelos desde Configuracion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string qry = "";
                string q2 = "";
                if (MessageBox.Show("¿Seguro que decea eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (lbTitulo.Text == "Productos Registrados")
                    {
                        qry = "Delete from product Where idProduc=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
                        if (dts.eliminar(qry) == true)
                        {
                            MessageBox.Show("Elemento Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                            q2 = "select idProduc as Id,cod as Codigo,nomProduc as Producto,stock as Cantidad,precio as Precio from product";
                            consultar(q2);
                        }

                    }
                    if (lbTitulo.Text == "Membresias Registradas")
                    {
                        qry = "Delete memb where idMem=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + " ";
                        if (dts.eliminar(qry) == true)
                        {
                            MessageBox.Show("Elemento Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                            q2 = "select idMem as Id, nomMem as Membresia,precioMem as Precio from memb";
                            consultar(q2);
                        }
                    }
                    if (lbTitulo.Text == "Promociones Registradas")
                    {
                        qry = "delete prom where idProm =" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + " ";
                        if (dts.eliminar(qry) == true)
                        {
                            MessageBox.Show("Elemento Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                            q2 = "Select idProm as Id,nomPromocion as Promocion,descuento as Descuento from prom";
                            consultaPr(q2);
                        }
                    }
                }
            }
            
        }
        #endregion
        #region validaciones
        restricciones vl = new restricciones();
        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            vl.letrassignos(e);
            vl.solonumerosEnteros(e);
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

        private void txt3_Leave(object sender, EventArgs e)
        {
            double d = Convert.ToDouble(txt3.Text, CultureInfo.InvariantCulture);
            txt3.Text = d.ToString("0000.00", CultureInfo.InvariantCulture);
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            //Letra despues de cada espacion en Mayuscula
            txt2.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt2.Text);
            txt2.SelectionStart = txt2.Text.Length;
        }
        #endregion


    }
}
