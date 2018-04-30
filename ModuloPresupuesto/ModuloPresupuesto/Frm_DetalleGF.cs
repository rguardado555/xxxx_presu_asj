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
using DevExpress.XtraPivotGrid;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace ModuloPresupuesto
{
    public partial class Frm_DetalleGF : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtresultado = new DataTable();
        string _item, _idpresupuesto, _estado;
        public Frm_DetalleGF(string idpresupuesto, string item)
        {
            InitializeComponent();
            _item = item;
            _idpresupuesto = idpresupuesto;
           
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
                string doc = "c:\\DATA\\Tmpdetagf" + DateTime.Now.Millisecond.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + ".xlsx";
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
        void CargarDatos()
        {

                dtresultado = NFunciones.TABLADATOS("EXEC SP_REPORTE_DETALLEGF '" + _idpresupuesto + "','" + _item + "'");
                _estado = "S";
            

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_estado.Equals("S"))
            {
                _estado = "N";

                if (dtresultado.Rows.Count > 0)
                {
                    
                    pvt_datos2.DataSource = dtresultado;
                }
                else
                {
                    lb_mensaje.Visible = true;
                }
                barrar_progreso.Visible = false;
                timer1.Stop();
            }
        }

        private void Frm_DetalleGF_Load(object sender, EventArgs e)
        {
            monoFlat_ThemeContainer1.Text = "Detalle Gasto Fijo : " + _item;
            _estado = "N";
            barrar_progreso.Visible = true;
            Thread hilo = new Thread(CargarDatos);
            hilo.Start();
            timer1.Start();

        }
    }
}