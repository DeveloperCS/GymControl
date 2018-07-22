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
        public registro()
        {
            InitializeComponent();
            //evitar modificar combobox
            cbMesFecha.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNumeroFecha.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoMembrecia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDescProm.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btn_cerrar_mem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registro_Load(object sender, EventArgs e)
        {

        }

        private void cbTipoMembrecia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoMembrecia.SelectedItem.ToString()=="Mensual")
            {
                new agregaCantMes().ShowDialog();
            }
        }
    }
}
