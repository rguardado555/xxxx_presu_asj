using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CapaNegocios;
using DevExpress.DataAccess.ConnectionParameters;

namespace ModuloPresupuesto
{
    public partial class Panel_principal : DevExpress.XtraEditors.XtraForm
    {
        private string _presupuesto,idmoneda;
        private DataTable _TBINDICADORES= new DataTable();
        private DataTable _TBEJECUTADO = new DataTable();
        private DataTable _TBEJECUTADOMES = new DataTable();

        public Panel_principal()
        {
            InitializeComponent();
        }

        private void Panel_principal_Load(object sender, EventArgs e)
        {

            Listarmoneda();
            Thread hilo = new Thread(new ThreadStart(Llamargrafico));
            hilo.Start();
            idmoneda = "02";
            Llamargrafico();
        }

        private void Listarmoneda()
        {
            Invoke((Action)delegate
            {
                cbo_moneda.Properties.DataSource=NFunciones.TABLADATOS("SELECT IDMONEDA,RTRIM(LTRIM(NOMBRE_CORTO))+ '- '+DESCRIPCION MONEDA FROM P_MONEDAS ORDER BY IDMONEDA ASC");
                cbo_moneda.Properties.ValueMember = "IDMONEDA";
                cbo_moneda.Properties.DisplayMember = "MONEDA";
            });
        }

         void Llamargrafico()
        {
            Invoke((Action)delegate
            {
                dashboardViewer1.LoadDashboard(@"..\..\reportes\panel_prinicpal.xml");

            });
        }

        private void dashboardViewer1_ConfigureDataConnection(object sender, DevExpress.DashboardCommon.DashboardConfigureDataConnectionEventArgs e)
        {
            if (e.DataSourceName == "localhost_PRESUPUESTO_Connection")
            {

                // Gets the connection parameters used to establish a connection to the database.
                     Access97ConnectionParameters parameters =
                    (Access97ConnectionParameters)e.ConnectionParameters;

                // Specifies the user name used to access the database file. 
                parameters.UserName = "sa";
                // Specifies the password used to access the database file.
                parameters.Password = "amadeus2010";
            }
        }

        private void chrt_ejecutadovspresupuestado_Click(object sender, EventArgs e)
        {
            
        }

        //void Indicadores ()
        //{
        //    _TBINDICADORES =
        //        NFunciones.TABLADATOS(
        //            "SELECT P.*,I.DESCRIPCION,PR.DESCRIPCION PRESUPUESTO FROM P_PRESUVSEJEC_KPI P INNER JOIN P_ICOSTO I ON I.IdItemCosto=P.IDITEM INNER JOIN P_PRESUPUESTO PR ON PR.IDPRESUPUESTO=P.IDPRESUPUESTO AND PR.ES_GF='0' AND AÑO= YEAR(GETDATE()) WHERE  IDMONEDA='"+idmoneda+"'");


        //    _TBEJECUTADO =
        //        NFunciones.TABLADATOS(
        //            "SELECT  SUM(VALORPRESUPUESTADO)PRESUPUESTADO, SUM(VALOREJECUTADO)EJECUTADO,SUM(VALORPRESUPUESTADO-VALOREJECUTADO)DESVIACION FROM P_PRESUVSEJEC_KPI P INNER JOIN P_ICOSTO I ON I.IdItemCosto=P.IDITEM INNER JOIN P_PRESUPUESTO PR ON PR.IDPRESUPUESTO=P.IDPRESUPUESTO AND PR.ES_GF='0' AND AÑO= YEAR(GETDATE()) WHERE  IDMONEDA='"+idmoneda+"'");

        //    string periodo = DateTime.Now.ToString("yyyyMM");

        //    _TBEJECUTADOMES =
        //       NFunciones.TABLADATOS(
        //           "SELECT  SUM(VALORPRESUPUESTADO)PRESUPUESTADO, SUM(VALOREJECUTADO)EJECUTADO,SUM(VALORPRESUPUESTADO-VALOREJECUTADO)DESVIACION FROM P_PRESUVSEJEC_KPI P INNER JOIN P_ICOSTO I ON I.IdItemCosto=P.IDITEM INNER JOIN P_PRESUPUESTO PR ON PR.IDPRESUPUESTO=P.IDPRESUPUESTO AND PR.ES_GF='0' AND AÑO= YEAR(GETDATE()) WHERE  IDMONEDA='"+idmoneda+"' AND PERIODO='"+periodo+"'");


        //    Invoke((Action)delegate
        //    {

        //        if (_TBINDICADORES.Rows.Count>0)
        //        {
        //            pvt_datos.DataSource = _TBINDICADORES;
        //        }

        //        if (_TBEJECUTADO.Rows.Count > 0)
        //        {
        //            string ejecutado = _TBEJECUTADO.Rows[0]["EJECUTADO"].ToString();
        //            string presupuestado = _TBEJECUTADO.Rows[0]["PRESUPUESTADO"].ToString();
        //            string desviacion = _TBEJECUTADO.Rows[0]["DESVIACION"].ToString();

        //            pic_ejecutado.Image = Convert.ToDecimal(desviacion) > 0
        //                ? Properties.Resources.caret_flecha_hacia_arriba
        //                :  Properties.Resources.flecha_abajo;


        //            lb_ejecutado.Text = ejecutado;
        //            lb_desviacion.Text = desviacion;
        //            lb_presupuestado.Text = presupuestado;

        //        }
        //        else
        //        {
        //            lb_ejecutado.Text = @"#";
        //            lb_desviacion.Text = @"#";
        //            lb_presupuestado.Text = @"#";
        //        }

        //        if (_TBEJECUTADOMES.Rows.Count > 0)
        //        {
        //            string ejecutado = _TBEJECUTADOMES.Rows[0]["EJECUTADO"].ToString();
        //            string presupuestado = _TBEJECUTADOMES.Rows[0]["PRESUPUESTADO"].ToString();
        //            string desviacion = _TBEJECUTADOMES.Rows[0]["DESVIACION"].ToString();

        //            pic_ejecutado_mes.Image = Convert.ToDecimal(desviacion) > 0
        //                ? Properties.Resources.caret_flecha_hacia_arriba
        //                : Properties.Resources.flecha_abajo;


        //            lb_ejecutado_mes.Text = ejecutado;
        //            lb_desviacion_mes.Text = desviacion;
        //            lb_presupuestado_mes.Text = presupuestado;

        //        }
        //        else
        //        {
        //            lb_ejecutado_mes.Text = @"#";
        //            lb_desviacion_mes.Text = @"#";
        //            lb_presupuestado_mes.Text = @"#";
        //        }

        //    });

        //}
    }
}