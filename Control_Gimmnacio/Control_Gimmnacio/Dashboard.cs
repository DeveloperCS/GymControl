using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Gimmnacio
{
    public partial class Dashboard : Form
    {
       // Form_inicial fm = new Form_inicial();
        public Dashboard()
        {
            InitializeComponent();
            //lbNomDash.Text = lbCon.Text;
            DoubleBuffered = true;
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
        //Cambiar de color los panel
        private void panel4_MouseEnter(object sender, EventArgs e)
        {
           /* p_Mem.BackColor = Color.LightSalmon;
            p_Mem_ti.BackColor= Color.DimGray;*/
           
        }

        private void p_Mem_MouseHover(object sender, EventArgs e)
        {

        }

        private void p_Mem_MouseLeave(object sender, EventArgs e)
        {
          /*  p_Mem.BackColor = Color.DarkOrange;
            p_Mem_ti.BackColor = Color.Black;*/
        }

        private void p_Mem_ti_MouseEnter(object sender, EventArgs e)
        {
           /* p_Mem.BackColor = Color.LightSalmon;
            p_Mem_ti.BackColor = Color.DimGray;*/
        }

        private void p_Mem_ti_MouseLeave(object sender, EventArgs e)
        {
           /* p_Mem.BackColor = Color.DarkOrange;
            p_Mem_ti.BackColor = Color.Black;*/
        }

        private void p_Visitante_MouseEnter(object sender, EventArgs e)
        {
            //p_Visitante.BackColor = Color.LightSteelBlue;
        }

        private void p_Visitante_MouseLeave(object sender, EventArgs e)
        {
           // p_Visitante.BackColor = Color.DarkSlateBlue;
        }

        private void p_VenderProduc_MouseEnter(object sender, EventArgs e)
        {
          //  p_VenderProduc.BackColor = Color.PaleGreen;
        }

        private void p_VenderProduc_MouseLeave(object sender, EventArgs e)
        {
            //p_VenderProduc.BackColor = Color.Chartreuse;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
           // p_Visitante.BackColor = Color.LightSteelBlue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            //p_Visitante.BackColor = Color.DarkSlateBlue;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
           // p_VenderProduc.BackColor = Color.PaleGreen;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
           // p_VenderProduc.BackColor = Color.Chartreuse;
        }

        private void p_finger_MouseEnter(object sender, EventArgs e)
        {
            //p_finger.BackColor = Color.Violet;
        }
        private void picture_fing_MouseEnter(object sender, EventArgs e)
        {
            //p_finger.BackColor = Color.Violet;
        }
        private void p_finger_MouseLeave(object sender, EventArgs e)
        {
            //p_finger.BackColor = Color.Purple;
        }
        private void picture_fing_MouseLeave(object sender, EventArgs e)
        {
         ///   p_finger.BackColor = Color.Purple;
        }
        private void label16_MouseEnter(object sender, EventArgs e)
        {
            //p_finger.BackColor = Color.Violet;
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            //p_finger.BackColor = Color.Purple;
        }
        //eventos clic
        private void p_Mem_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void p_Mem_MouseDown(object sender, MouseEventArgs e)
        {
         /*   p_Mem.BackColor = Color.DarkOrange;
            p_Mem_ti.BackColor = Color.Black;
            */
        }

        private void p_Mem_MouseUp(object sender, MouseEventArgs e)
        {
          /*  p_Mem.BackColor = Color.LightSalmon;
            p_Mem_ti.BackColor = Color.DimGray;*/
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            
        }
        conexionDatos dts = new conexionDatos();
        string qVis = "",qMem="";
        private void timChecar_Tick(object sender, EventArgs e)
        {
            #region visitantes
            /*compruebo total visitantes*/
            DataSet dataC = new DataSet();
            qVis = "SELECT Sum(cantidad) as T FROM visitante";
            dataC = dts.consulta(qVis);
            DataTable dt2 = dataC.Tables[0];
            int cont = 0;
            string usExist = "";
            foreach (DataRow row in dt2.Rows)
            {
                if (row["T"].ToString().Equals(""))
                {
                    lbTotalVis.Text ="0";
                }
                else
                {
                    lbTotalVis.Text = row["T"].ToString();
                }
                
            }
            //compruebo los que hoy 
            qVis = " SELECT Sum(cantidad) as H FROM visitante where fecha = CONVERT(date, SYSDATETIME())";
            DataSet dataC2 = new DataSet();
            dataC2 = dts.consulta(qVis);
            DataTable dt22 = dataC2.Tables[0];

            foreach (DataRow row in dt22.Rows)
            {
                
                if (row["H"].ToString().Equals(""))
                {
                    lbTHoy.Text = "0";
                }
                else
                {
                    lbTHoy.Text = row["H"].ToString();
                }
            }
            //comprueb en mes 
            qVis = "select Sum(cantidad) as M from visitante where  MONTH(fecha) = Month(CONVERT (date, SYSDATETIME()))";
            DataSet dataC3 = new DataSet();
            dataC3 = dts.consulta(qVis);
            DataTable dt3 = dataC3.Tables[0];
            foreach (DataRow row in dt3.Rows)
            {
                
                if (row["M"].ToString().Equals(""))
                {
                    lbMes.Text = "0";
                }
                else
                {
                    lbMes.Text = row["M"].ToString();
                }
            }
            #endregion

            #region Memebresias
            /*compruebo total Mem*/
            DataSet dataM = new DataSet();
            qMem = "select count(*) as M, idMemS as d from memSocio group by idMemS";
            dataM = dts.consulta(qMem);
            DataTable dtM = dataM.Tables[0];
            int conR = 0, conNR = 0;
            foreach (DataRow row in dtM.Rows)
            {
                //lbTotalMem.Text = row["M"].ToString();
                if (Convert.ToInt32(row["M"].ToString())==1)
                {
                    conNR++;
                }
                else if (Convert.ToInt32(row["M"].ToString())>=2)
                {
                    conR++;
                }
            }
            int t = conNR + conR;
            lbTotalMem.Text = t.ToString();
             //compruebo las membresias vigentes
             List <String> listaVigentes = new List<string>();
            qMem = "select count(*) as V, idMemS as id from memSocio where estado='Vigente'group by idMemS";
            DataSet dataVig = new DataSet();
            dataVig = dts.consulta(qMem);
            DataTable dtVig = dataVig.Tables[0];
            int con = 0;
            foreach (DataRow row in dtVig.Rows)
            {
                //con =Convert.ToInt32( row["V"].ToString());
                con++;
                lbMemVigentes.Text = con.ToString();
                listaVigentes.Add(row["id"].ToString());
            }

            //compruebo las membresias expiradas 
            qMem = "select count(*) as Ex,idMemS as idEx from memSocio where estado = 'Expirado' group by idMemS";
            DataSet dataMex = new DataSet();
            dataMex = dts.consulta(qMem);
            DataTable dtEx = dataMex.Tables[0];
            int conEx = 0;
            string idRec = "";
            foreach (DataRow row in dtEx.Rows)
            {
                lbMemEx.Text=row["Ex"].ToString();  
            }
            #endregion

           
        }
        #region consultaMemEx
        string qEx1 = "";
        public void memEx()
        {
            //agregar boton ver dentro del DGV
            DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
            btnVer.Name = "Ver";
            dtGWMemEx.Columns.Add(btnVer);
            qEx1 = "select M.idMemS as [Clave Socio/Memebresia],(select S.nombre as Nombre from socio S where S.idSocio=idMems) Socio, M.idControl as [ID Membresia],M.tMem as Tipo, M.fechaIngreso as Inicio,M.fechatermino as Termino, M.prom as Promocion, M.estado as Estatus from memSocio M  where M.estado = 'Expirado'";
            dtGWMemEx.DataSource = dts.consulta(qEx1).Tables[0];
            
        }
        private void dtGWMemEx_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dtGWMemEx.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex>=0)
            {
                e.Paint(e.CellBounds,DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = this.dtGWMemEx.Rows[e.RowIndex].Cells["Ver"] as DataGridViewButtonCell;
                Icon iconAtomic = new Icon(Environment.CurrentDirectory + @"\\editar.ico");
              /*  string str = "Control_Gimmnacio.editar.ico";
                Stream s = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(str);
                Icon iconAtomic = new Icon(s);*/

                e.Graphics.DrawIcon(iconAtomic,e.CellBounds.Left + 3,e.CellBounds.Top +3);

                this.dtGWMemEx.Rows[e.RowIndex].Height = iconAtomic.Height + 8;
                this.dtGWMemEx.Columns[e.ColumnIndex].Width = iconAtomic.Width + 8;
                e.Handled = true;
            }
        }
        #endregion
        private void Dashboard_Load(object sender, EventArgs e)
        {
            memEx();
            timer1.Enabled = true;
            timer1.Start();
            timChecar.Enabled = true;
            timChecar.Interval = 25;

        }
        agregaCantMes vis = new agregaCantMes();

        private void dtGWMemEx_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dtGWMemEx.Columns[e.ColumnIndex].Name == "Estatus")
            {
                if (e.Value.ToString() == "0")
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.BackColor = Color.LightGreen;

                }
                else if (e.Value.ToString() == "Expirado")
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.BackColor = Color.Salmon;
                }
            }

        }
        vHistorialUs vH = new vHistorialUs();
        private void dtGWMemEx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dtGWMemEx.Columns[e.ColumnIndex].Name=="Ver" )
            {
                string c = dtGWMemEx.CurrentRow.Cells[1].Value.ToString();
                vH.consultaSocio2(c);
                vH.consultaHistorial2(c);
                vH.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region ComprueboExpiraciones
            /*compruebo Expiraciones*/
            string qActualiza = "";
            DataSet dataC1 = new DataSet();
            string qqAc = "select fechatermino as C1, idMemS as Id, estado as E,idControl as Control from memSocio";
            dataC1 = dts.consulta(qqAc);
            DataTable dt2A = dataC1.Tables[0];
            string compara = "", idAc = "",estado="",idCo="";
            foreach (DataRow row in dt2A.Rows)
            {
                compara = row["C1"].ToString();
                idAc = row["Id"].ToString();
                estado = row["E"].ToString();
                idCo = row["Control"].ToString();
                DateTime fechaF = Convert.ToDateTime(compara).Date;
                DateTime FechAc = DateTime.Now.Date;
                if (fechaF <= FechAc && estado == "Vigente") // Si la fecha indicada es menor o igual a la fecha actual
                {
                    //Operación Expirada
                   // timer1.Stop();
                    qActualiza = "update memSocio set estado='Expirado' where idMemS = '" + idAc + "' and idControl ='" + idCo + "'";
                    if (dts.update(qActualiza) == true)
                    {
                        //  MessageBox.Show("Se Econtraron Membresias Expiradas!!", "Expirado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        // consultaHistorial(txtClaveS.Text);
                       // timer1.Stop();
                    }
                }
                else
                {

                    //Operación Aun Vigente
                   // timer1.Stop();
                    //MessageBox.Show("Aun Vigente");

                }
            }
            
            #endregion
        }

        private void btnVenderProdc_Click(object sender, EventArgs e)
        {
            new vVender().ShowDialog();
        }

        private void btnNuevoVis_Click(object sender, EventArgs e)
        {
            vis.ShowDialog();
        }
    }
}
