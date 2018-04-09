using CapaDatos_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocios
{
    public class NFunciones
    {

        public static string ExecuteSQL(string SQL)
        {
            return new DFunciones().ExecuteSQL(SQL);
        }
        public static DataTable TABLASQL(string SQL)
        {
            return new DFunciones().TABLASQL(SQL);
        }
        public string ExisteValor(string tabla, string campo, string valorbuscado)
        {
            return new DFunciones().ExisteValor(tabla, campo, valorbuscado);
        }
    }
}
