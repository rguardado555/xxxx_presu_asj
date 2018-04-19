using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1
{
  public  class VariablesGenerales
    {
        public static string tipooperacion = "";
        public static string Empresa = "001";
        public static string refrescompras = "N";
        public static string refresventas = "N";
        static DataTable GetTable(DataTable tb)
        {
            // Here we create a DataTable with four columns.
            DataTable table = new DataTable();
  
            table.Columns.Add("ID",typeof(string));
            table.Columns.Add("DOCUMENTO", typeof(string));
            table.Columns.Add("IDPROVEEDOR", typeof(string));
            table.Columns.Add("PROVEEDOR", typeof(string));
            table.Columns.Add("IDPRODUCTO", typeof(string));
            table.Columns.Add("PRODUCTO", typeof(string));
            table.Columns.Add("UNIDAD", typeof(string));
            table.Columns.Add("CANTIDAD", typeof(decimal));

            table = tb;
            return table;
        }

    }
}
