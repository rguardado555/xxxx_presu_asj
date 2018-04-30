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
    public partial class Frm_detallePXQ : DevExpress.XtraEditors.XtraForm
    {
        string _idpresupuestod, _iditemd, _idmonedad,_estado;
        DataTable dtresultado = new DataTable();
        private void btn_exportarexcel_Click(object sender, EventArgs e)
        {
            try
            {
                /*pvt_datos2.ExportToXlsx("c:\\temp\\Tmp.xlsx"");
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "EXCEL.EXE";
                startInfo.Arguments = @"..\RespumenPXQ.xlsx";
                Process.Start(startInfo);*/
                string ruta = "c:\\DATA";
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }


                DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.DataAware;
                var pivotExportOptions = new PivotXlsxExportOptions { ExportType = DevExpress.Export.ExportType.WYSIWYG };
                string doc = "c:\\DATA\\Tmpdetapxq" + DateTime.Now.Millisecond.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + ".xlsx";
                dtg_datos.ExportToXlsx(doc, pivotExportOptions);


                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "EXCEL.EXE",
                    Arguments = doc
                };
                Process.Start(startInfo);

                //pvt_datos2.ShowPrintPreview();

            }
            catch (Exception ex)
            {
                MessageBox.Show(@"No se pudo exportar el archivo , error sugerido :" + "\n" + ex.Message, @"Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_estado.Equals("S"))
            {
                _estado = "N";

                if (dtresultado.Rows.Count > 0)
                {
                    vista_datos.Columns.Clear();
                    dtg_datos.DataSource = dtresultado;


                    int i = vista_datos.Columns.Count();
                    for (int f = 0; f < i; f++)
                    {
                        vista_datos.Columns[f].AppearanceCell.ForeColor = Color.Black;
                        vista_datos.Columns[f].AppearanceCell.Font = new Font("Segoe UI", 9);
                        vista_datos.Columns[f].OptionsColumn.AllowEdit = false;
                    }

                    vista_datos.Columns[i - 1].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    vista_datos.Columns[i - 1].DisplayFormat.FormatString = "#,###.00";
                    vista_datos.Columns[i - 1].AppearanceCell.ForeColor = Color.Black;
                    vista_datos.Columns[i - 1].AppearanceCell.BackColor = Color.Orange;
                    vista_datos.Columns[i - 1].AppearanceCell.BackColor2 = Color.DarkOrange;
                    vista_datos.Columns[i - 1].AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
                    vista_datos.Columns[i - 1].AppearanceCell.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                }
                else
                {
                    vista_datos.Columns.Clear();
                    lb_mensaje.Visible = true;

                }
                barrar_progreso.Visible = false;
                timer1.Stop();
            }
        }

        public Frm_detallePXQ(string _idpresupuesto, string _iditem, string _idmoneda)
        {
            InitializeComponent();
            _idpresupuestod = _idpresupuesto;
            _iditemd = _iditem;
            _idmonedad = _idmoneda;
        }

        private void Frm_detallePXQ_Load(object sender, EventArgs e)
        {
            _estado = "N";
            barrar_progreso.Visible = true;
            Thread hilo = new Thread(CargarDatos);
            hilo.Start();
            timer1.Start();
        }
        void CargarDatos()
        {

            if (_idmonedad.Equals("02"))
            {
                dtresultado = NFunciones.TABLADATOS("EXEC SP_MOSTRARDETALLEPXQ_DOL '" + _idpresupuestod + "','" + _iditemd + "','" + _idmonedad + "'");
                _estado = "S";
            }
            if (_idmonedad.Equals("01"))
            {
                dtresultado = NFunciones.TABLADATOS("EXEC SP_MOSTRARDETALLEPXQ_SOL '" + _idpresupuestod + "','" + _iditemd + "','" + _idmonedad + "'");
                _estado = "S";
            }
           
        } 
    }
}