using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Control_Gimmnacio
{
    class conexionDatos
    {
        private string cadena = ConfigurationManager.ConnectionStrings["Control_Gimmnacio.Properties.Settings.controlGymConnectionString"].ConnectionString;

        #region Consulta
        public DataSet consulta(string Qr)
        {
            DataSet ds1 = new DataSet();
            //generamos la conexion
            SqlConnection conn = new SqlConnection(cadena);

            try
            {
                conn.Open();
                //ejecuta la instruccion
                SqlCommand command = new SqlCommand(Qr, conn);
                command.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds1);

            }
            catch (Exception s)
            {
               // MessageBox.Show(s.Message);
            }
            finally
            {
                conn.Close();
            }
            return ds1;

        }
       /* public SqlDataReader consultaCB(string qr1)
        {
            //generamos la conexion
            SqlConnection conn = new SqlConnection(cadena);
            bool res;
            SqlDataReader daR;
            try
            {
                conn.Open();
                //ejecuta la instruccion
                SqlCommand command = new SqlCommand(qr1, conn);
               // command.ExecuteReader();
                daR= command.ExecuteReader();
                daR.Read();
                res = true;
            }
            catch (Exception s)
            {
                // MessageBox.Show(s.Message);
                res = false;
            }
            finally
            {
                conn.Close();
            }
            return daR;
        }*/
        #endregion
        #region insertar
        ///<summary>
        ///insersio
        /// </summary>
        public bool insertar(string qr)
        {
            bool res;
            SqlConnection conn = new SqlConnection(cadena);
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(qr, conn);
                command.ExecuteNonQuery();
               
                res = true;
            }
            catch (Exception ex)
            {

              
                res = false;
            }
            finally
            {
                conn.Close();
            }
            return res;

        }
        #endregion
        #region update
        //update
        public bool update(string qr1)
        {
            bool res;
            SqlConnection conn = new SqlConnection(cadena);
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(qr1, conn);
                command.ExecuteNonQuery();
                
                res = true;
            }
            catch (Exception ex)
            {
               
                res = false;
            }
            finally { conn.Close(); }
            return res;

        }
        #endregion
        #region Eliminar
        public bool eliminar(string sql)
        {
            bool res;
            SqlConnection con = new SqlConnection(cadena);
            try
            {

                con.Open();
                SqlCommand comm = new SqlCommand(sql, con);
                comm.ExecuteNonQuery();
                // MessageBox.Show("Elemento Eliminado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                res = true;

            }
            catch (Exception ex)
            {
               // MessageBox.Show("Erro al eliminar" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            }
            finally
            {
                con.Close();
            }
            return res;

        }
        #endregion
    }
}
