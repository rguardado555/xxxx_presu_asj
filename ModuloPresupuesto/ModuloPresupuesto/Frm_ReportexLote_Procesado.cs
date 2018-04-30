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
namespace ModuloPresupuesto
{
    public partial class Frm_ReportexLote_Procesado : DevExpress.XtraEditors.XtraForm
    {
        private string _idpresupuesto;
        private string _idestado;
        private new DataTable  _tbresultado;
        public Frm_ReportexLote_Procesado()
        {
            InitializeComponent();
        }

        private void Frm_ReportexLote_Procesado_Load(object sender, EventArgs e)
        {
            ListarPresupuestos();
        }
        private void ListarPresupuestos()
        {
            cbo_presupuesto.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDPRESUPUESTO,DESCRIPCION PRESUPUESTO FROM P_PRESUPUESTO WHERE ES_GF='0'");
            cbo_presupuesto.Properties.ValueMember = "IDPRESUPUESTO";
            cbo_presupuesto.Properties.DisplayMember = "PRESUPUESTO";
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(cbo_presupuesto.Text).Equals("[Seleccionar..]"))
            {
                MessageBox.Show(@"Debe Seleccionar un Presupuesto !", @"Alerta !", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            else
            {
                _idpresupuesto = Convert.ToString(cbo_presupuesto.EditValue);
                _idestado = "N";
                barrar_progreso.Visible = true;
                timer1.Start();
                Thread hilo = new Thread(new ThreadStart(CrearReporte));
                hilo.Start();
            }
        }

        private void CrearReporte()
        {
           _tbresultado=NFunciones.TABLADATOS("EXEC SP_REPORTE_LOTE '"+_idpresupuesto+"'");
           _idestado = "S";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(_idestado.Equals("S"))
            {
                _idestado = "N";
                //dtg_datos.DataSource = _tbresultado;

                MessageBox.Show( _tbresultado.Rows.Count.ToString());  
                barrar_progreso.Visible = false;
                timer1.Stop();
            }
        }
    }
}