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
    public partial class agregaCantMes : Form
    {
        public agregaCantMes()
        {
            InitializeComponent();
            numMes.Value = 1;
        }
        conexionDatos dts = new conexionDatos();
        string q = "";
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (numMes.Value!=0)
            {
                q = "insert into visitante values('"+numMes.Value+"',SYSDATETIME())";
                if (dts.insertar(q)==true)
                {
                    MessageBox.Show("Visitante Agregado","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Agrega por lo menos un mes","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
