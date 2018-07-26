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
        private void registro_Load(object sender, EventArgs e)
        {
            llenaCb();
            llenaCbMem();
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
        private void btn_cerrar_mem_Click(object sender, EventArgs e)
        {
            this.Close();
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
