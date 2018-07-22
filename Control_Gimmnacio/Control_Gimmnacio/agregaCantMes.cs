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
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (numMes.Value!=0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Agrega por lo menos un mes","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
