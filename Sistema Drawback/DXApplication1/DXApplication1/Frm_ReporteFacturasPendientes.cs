using CapaNegocios;
using DevExpress.XtraPivotGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Frm_ReporteFacturasPendientes : Form
    {
        public Frm_ReporteFacturasPendientes()
        {
            InitializeComponent();
        }

        private void Frm_ReporteFacturasPendientes_Load(object sender, EventArgs e)
        {
            llenarInsumos();
        }
        void llenarInsumos()
        {
            pvt_datos.DataSource = NFunciones.TABLASQL("SELECT X.idcobrarpagardoc ID,C.iddocumento+' '+C.serie+' - '+C.numero DOCUMENTO,C.idclieprov IDPROVEEDOR,C.razonsocial PROVEEDOR,X.idproducto IDPRODUCTO,X.descripcion PRODUCTO,X.idunidad UNIDAD,X.stock CANTIDAD FROM (SELECT SUM(cantidad*factor) stock,idcobrarpagardoc,idproducto,descripcion,idunidad FROM tb_movcobrarpagardoc_drakback M where SUBSTRING(idcobrarpagardoc,1,1)='C' AND idempresa='" + VariablesGenerales.Empresa + "' group by idcobrarpagardoc,idproducto,descripcion,idunidad)X INNER JOIN tb_cobrarpagardoc C ON X.idcobrarpagardoc=C.idcobrarpagardoc WHERE X.stock>0 AND C.idempresa='" + VariablesGenerales.Empresa + "'");
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            llenarInsumos();
        }

        private void btn_excel_Click(object sender, EventArgs e)
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
                string doc = "c:\\DATA\\Tmp" + DateTime.Now.Millisecond.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + ".xlsx";
                pvt_datos.ExportToXlsx(doc, pivotExportOptions);

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
    }
}
