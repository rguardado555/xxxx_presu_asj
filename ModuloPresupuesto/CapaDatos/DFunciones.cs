using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class DFunciones
    {


        public string ExecuteSQL(string SQL)
        {
            string rpta = "";
            try
            {
                SqlConnection Cnn = new SqlConnection(Conexion.CnPresupuesto);
                Cnn.Open();
                SqlCommand cmd = new SqlCommand(SQL, Cnn);
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 5500;
                rpta = cmd.ExecuteNonQuery() > 0 ? "Ok" : "0";
                Cnn.Close();
            }
            catch(Exception ex)
            {
                rpta = "Error : "+ex.Message;
            }
            return rpta;
        }

 
        public string ExisteValor(string tabla, string campo, string valorbuscado)
        {
            string rpta = "";
            try
            {
                SqlConnection Cnn = new SqlConnection(Conexion.CnPresupuesto);
                Cnn.Open();
                string sql = "SELECT " + campo + " FROM " + tabla + " WHERE " + campo + "='" + valorbuscado + "' ";
                SqlCommand cmd = new SqlCommand(sql, Cnn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    rpta = Convert.ToString(dr[campo]);
                    Cnn.Close();
                }
                else
                {
                    rpta = null;
                    Cnn.Close();
                }
            }
            catch
            {
                rpta = null;
            }

            return rpta;

        }


        public DataTable TABLADATOSPRESUPUESTO(string CONSULTA)
        {
            DataTable dtResultado = new DataTable("Tabla");

            try
            {
                SqlDataAdapter Sqladapter = new SqlDataAdapter(CONSULTA, Conexion.CnPresupuesto);
                Sqladapter.SelectCommand.CommandTimeout = 2500;
                Sqladapter.Fill(dtResultado);

            }
            catch (Exception)
            {

                dtResultado = null;
            }

            return dtResultado;
        }
        public DataTable TABLADATOSNISIRA(string CONSULTA)
        {
            DataTable dtResultado = new DataTable("Nisira");
            try
            {
                SqlDataAdapter Sqladapter = new SqlDataAdapter(CONSULTA, Conexion.CnNisira);
                Sqladapter.SelectCommand.CommandTimeout = 2500;
                Sqladapter.Fill(dtResultado);

            }
            catch (Exception)
            {
                dtResultado = null;
            }

            return dtResultado;
        }





    }
}
