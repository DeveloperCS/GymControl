using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Gimmnacio
{
    class restricciones
    {
        public void sololetras(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false; // que si se escriba
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true; //que no se escriba
                }
            }
            catch (Exception ex)
            {

            }
        }
        public void letrassignos(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false; // que si se escriba
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSymbol(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true; //que no se escriba
                }
            }
            catch (Exception ex)
            {

            }
        }
        public void solonumerosEnteros(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false; // que si se escriba
                }
                else if (char.IsControl(e.KeyChar)) /*|| char.IsPunctuation(e.KeyChar))*/
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true; //que no se escriba
                }

            }
            catch (Exception ex)
            {

            }
        }
        public void solonumerosDecimal(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false; // que si se escriba
                }
                else if (char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true; //que no se escriba
                }

            }
            catch (Exception ex)
            {

            }
        }
        public void sinEspacio(KeyPressEventArgs e)
        {
            
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled =true;
                MessageBox.Show("No se permite espacios.","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }
    }
}
