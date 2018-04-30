using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace ModuloPresupuesto
{
   public class VariablesGenerales
    {

        public static string ActualizarDetallePresupuesto = "N";
        public static string mostraralerta = "N";
        public static string idalerta = "";

        public static DataTable ImportarExcel(string FilePath, string ext,string hoja)
        {
            string connectionString = "";
            if (ext == ".xls")
            {   //de Excel 97-03
                connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = "+ FilePath + "; Extended Properties = 'Excel 8.0;HDR={1}'";
            }
            else if (ext == ".xlsx")
            {    //de Excel 07 para adelante
                connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = "+ FilePath + "; Extended Properties = 'Excel 8.0;HDR={1}'";
            }
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand oconn = new OleDbCommand("Select * From [" + hoja + "$]", con);
            con.Open();

            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            DataTable data = new DataTable();
            sda.Fill(data);

            return data;
        }
    }
}
