using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CapaNegocios;
using System.Threading;
using System.IO;
using DevExpress.XtraPivotGrid;
using System.Diagnostics;

namespace ModuloPresupuesto
{
    public partial class rpt_GastoFijo : DevExpress.XtraEditors.XtraForm
    {
        private DataTable _dtresultado = new DataTable();
        private string _mostrar = "N";
        private string _moneda = "";
        private string _idpresupuesto;
        public rpt_GastoFijo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_mostrar.Equals("S"))
            {
                _mostrar = "N";

                barrar_progreso.Visible = false;
                timer1.Stop();
            }
            else
            {
                barrar_progreso.Caption = @"UN MOMENTO...";
            }
        }

        private void rpt_GastoFijo_Load(object sender, EventArgs e)
        {
            ListarPresupuestos();
            ListarMonedas();
            barrar_progreso.Top = ((this.Height - barrar_progreso.Height) / 2);
            barrar_progreso.Left = ((this.Width - barrar_progreso.Width) / 2);
            LB_TITULO.Left = ((this.Width - LB_TITULO.Width) / 2);

            barrar_progreso.Location =
            new Point(ClientSize.Width / 2 - barrar_progreso.Size.Width / 2,
            ClientSize.Height / 2 - barrar_progreso.Size.Height / 2);
        }
        private void ListarPresupuestos()
        {
            cbo_presupuesto.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDPRESUPUESTO,DESCRIPCION PRESUPUESTO FROM P_PRESUPUESTO WHERE ES_GF='0'");
            cbo_presupuesto.Properties.ValueMember = "IDPRESUPUESTO";
            cbo_presupuesto.Properties.DisplayMember = "PRESUPUESTO";
        }

        private void ListarMonedas()
        {
            cbo_moneda.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDMONEDA ID , RTRIM(LTRIM( NOMBRE_CORTO)) +' - ' +RTRIM(LTRIM(DESCRIPCION)) AS MONEDA FROM  P_MONEDAS ORDER BY IDMONEDA ASC");
            cbo_moneda.Properties.ValueMember = "ID";
            cbo_moneda.Properties.DisplayMember = "MONEDA";

        }

        private void MostrarDatos()
        {

            //_dtresultado = NFunciones.TABLADATOS("SELECT COUNT(*)AS NREGISTROS FROM P_RPT_PXQ WHERE IDPRESUPUESTO='"+_idpresupuesto+"'");
            _dtresultado = NFunciones.TABLADATOS("EXEC SP_REPORTE_GF '" + _idpresupuesto + "','" + _moneda + "'");
            //MessageBox.Show(Convert.ToString(cbo_moneda.EditValue));

            Invoke((Action)delegate
            {
                pvt_datos2.DataSource = _dtresultado;

            });

            _mostrar = "S";
        }

        private void btn_consultarReporte_Click(object sender, EventArgs e)
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
            }

            if (Convert.ToString(cbo_moneda.Text).Equals("[Seleccionar..]"))
            {
                MessageBox.Show(@"Debe Seleccionar Tipo de Moneda !", @"Alerta !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                _moneda = Convert.ToString(cbo_moneda.EditValue);
            }

            barrar_progreso.Visible = true;
            _mostrar = "N";
            Thread Hilo = new Thread(MostrarDatos);
            Hilo.Start();
            timer1.Start();
        }

        private void btn_exportarexcel_Click(object sender, EventArgs e)
        {
            try
            {
                
                string ruta = "c:\\DATA";
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }



                DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.DataAware;
                var pivotExportOptions = new PivotXlsxExportOptions { ExportType = DevExpress.Export.ExportType.WYSIWYG };
                string doc = "c:\\DATA\\TmpGF" + DateTime.Now.Millisecond.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + ".xlsx";
                pvt_datos2.ExportToXlsx(doc, pivotExportOptions);


                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "EXCEL.EXE",
                    Arguments = doc
                };
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"No se pudo exportar el archivo , error sugerido :" + "\n" + ex.Message, @"Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void pvt_datos2_CellDoubleClick(object sender, PivotCellEventArgs e)
        {
            try
            {
                string item = pvt_datos2.GetFieldValue(COL_ITEM, e.RowIndex).ToString();
                Frm_DetalleGF ObjdetGF = new Frm_DetalleGF(_idpresupuesto, item);
                ObjdetGF.ShowDialog();
            }
            catch (Exception ex)
            {

            }
        }
    }
}