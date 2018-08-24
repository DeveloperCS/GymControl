using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Control_Gimmnacio
{
    public partial class login_principal : Form
    {
        public login_principal()
        {
            InitializeComponent();
        }
        Form_inicial IN = new Form_inicial();
        //Placeholder de textbox
        private void txt_Us_Enter(object sender, EventArgs e)
        {
            
        }

        private void txt_Us_Leave(object sender, EventArgs e)
        {
           
        }

        private void txt_Pw_Enter(object sender, EventArgs e)
        {
           
        }

        private void txt_Pw_Leave(object sender, EventArgs e)
        {
            
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            
        }

        // Arrastrar formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void login_principal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_cerrar_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_MouseHover(object sender, EventArgs e)
        {

        }

        conexionDatos dts = new conexionDatos();
        
        private void btn_Acc_Click(object sender, EventArgs e)
        {
           
            
            
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string qry = "select cast(case when pass = HASHBYTES('SHA2_512', '" + txtPass.Text.Trim() + "') then 1 else 0 end as bit) FlagPwdCorrecto from usuarios where usuario = '" + txtUsuario.Text.Trim() + "'";
            if (txtPass.Text == "" || txtUsuario.Text == "" || txtUsuario.Text == "Usuario" | txtPass.Text == "Contraseña")
            {
                MessageBox.Show("Falto llenar un campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cambiaColor();
            }
            else
            {
                if (dts.consulta(qry).Tables[0].Rows[0][0].Equals(true))
                {


                    /*Sacar el nombre de usuario y tipo de usuario*/
                    DataSet dataC = new DataSet();
                    string qry2 = "Select nombreUs as nom, tipoUs as tipo from usuarios where usuario = '" + txtUsuario.Text.Trim() + "'";
                    dataC = dts.consulta(qry2);
                    DataTable dt2 = dataC.Tables[0];

                    string usEn = "", tipoEn = "";
                    foreach (DataRow row in dt2.Rows)
                    {
                        usEn = row["nom"].ToString();
                        tipoEn = row["tipo"].ToString();
                    }
                    /*Acceso dependiendo el tipo de usuario*/
                    if (tipoEn == "Administrador")
                    {
                        IN.Show();
                        IN.lbCon.Text = "Usuario: "+txtUsuario.Text ;
                        IN.lbNomUS.Text = usEn;
                        this.Hide();
                    }
                    else if (tipoEn == "Usuario")
                    {
                        IN.Show();
                        IN.lbCon.Text = "Usuario: " + txtUsuario.Text;
                        IN.lbNomUS.Text = usEn;
                        IN.btn_configUs.Visible = false;
                        IN.btnConfigurar.Visible = false;
                        IN.btn_cerrar_sesion.Location=new Point( -3, 392);
                        this.Hide();
                    }


                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cambiaColor();
                }
            }
        }
        public void cambiaColor()
        {
            txtUsuario.ForeColor = Color.DarkRed;
            txtPass.ForeColor = Color.DarkRed;
            
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsuario_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void txtUsuario_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void txtPass_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void txtPass_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if(txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
          /*  if (txtPass.UseSystemPasswordChar == true)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
           // txtPass.Focus();*/
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (txtPass.Text == "Contraseña")
                {

                }
                else
                {
                    txtPass.UseSystemPasswordChar = false;
                }
               
            }
            else if (checkBox1.Checked == false)
            {
                if (txtPass.Text == "Contraseña")
                {

                }
                else
                {
                    txtPass.UseSystemPasswordChar = true;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new Informacion().Show();
        }
    }
}
