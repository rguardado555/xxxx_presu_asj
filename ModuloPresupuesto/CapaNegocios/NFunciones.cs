using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocios
{
  public  class NFunciones
    {

        public static string ExecuteSQL(string SQL)
        {
            return new DFunciones().ExecuteSQL(SQL);
        }
        public static DataTable TABLADATOS(string SQL)
        {
            return new DFunciones().TABLADATOSPRESUPUESTO(SQL);
        }
        public static DataTable TABLADATOSNISIRA(string SQL)
        {
            return new DFunciones().TABLADATOSNISIRA(SQL);
        }
        public string ExisteValor(string tabla, string campo, string valorbuscado)
        {
            return new DFunciones().ExisteValor(tabla, campo, valorbuscado);
        }
    }
}
