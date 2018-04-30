using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Capa_Datos
{
    public class Conexion
    {
        public static string CnPresupuesto = ConfigurationManager.ConnectionStrings["PRESUPUESTO"].ToString();
        public static string CnNisira = ConfigurationManager.ConnectionStrings["NISIRA"].ToString();
    }
}
