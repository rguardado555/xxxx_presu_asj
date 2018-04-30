using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos_
{
   public class Conexion
    {
        public static string CnPresupuesto = ConfigurationManager.ConnectionStrings["SAP_RG"].ToString();
    }
}
