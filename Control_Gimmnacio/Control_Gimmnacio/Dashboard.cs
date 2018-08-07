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
    public partial class Dashboard : Form
    {
       // Form_inicial fm = new Form_inicial();
        public Dashboard()
        {
            InitializeComponent();
            //lbNomDash.Text = lbCon.Text;
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
        string qVis = "";
        private void timChecar_Tick(object sender, EventArgs e)
        {
           
            /*compruebo total visitantes*/
            DataSet dataC = new DataSet();
            qVis = "SELECT COUNT(id) as T FROM visitante";
            dataC = dts.consulta(qVis);
            DataTable dt2 = dataC.Tables[0];
            int cont = 0;
            string usExist = "";
            foreach (DataRow row in dt2.Rows)
            {
                lbTotalVis.Text = row["T"].ToString();
            }
            //compruebo los que hoy 
            qVis = " SELECT COUNT(id) as H FROM visitante where fecha = CONVERT(date, SYSDATETIME())";
            DataSet dataC2 = new DataSet();
           
            dataC2 = dts.consulta(qVis);
            DataTable dt22 = dataC2.Tables[0];
            
            foreach (DataRow row in dt22.Rows)
            {
                lbTHoy.Text = row["H"].ToString();
            }
            //comprueb en mes 
            qVis = "select count(id) as M from visitante where  MONTH(fecha) = Month(CONVERT (date, SYSDATETIME()))";
            DataSet dataC3 = new DataSet();

            dataC3 = dts.consulta(qVis);
            DataTable dt3 = dataC3.Tables[0];

            foreach (DataRow row in dt3.Rows)
            {
                lbMes.Text = row["M"].ToString();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timChecar.Enabled = true;
            timChecar.Interval = 25;

        }
        agregaCantMes vis = new agregaCantMes();
        private void btnNuevoVis_Click(object sender, EventArgs e)
        {
            vis.ShowDialog();
        }
    }
}
