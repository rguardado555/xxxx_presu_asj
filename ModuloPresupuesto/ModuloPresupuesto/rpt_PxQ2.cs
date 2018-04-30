using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using DevExpress.XtraPivotGrid;
using System.Collections;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace ModuloPresupuesto
{
    public partial class rpt_PxQ2 : Form
    {
       private DataTable _dtresultado = new DataTable();
       private   string _mostrar="N";
       private string _moneda = "";
       private string _idpresupuesto;
        public rpt_PxQ2()
        {
            InitializeComponent();

          /*  pvt_datos2.CustomUnboundFieldData += PivotGridControl1_CustomUnboundFieldData;

            PivotGridField fieldExtendedPrice = new PivotGridField() { Caption = "Promedio", Area = PivotArea.ColumnArea };
            fieldExtendedPrice.UnboundFieldName = "COL_PROMEDIO";
            fieldExtendedPrice.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;

            pvt_datos2.Fields.Add(fieldExtendedPrice);*/

        }

        private void PivotGridControl1_CustomUnboundFieldData(object sender, CustomFieldDataEventArgs e)
        {
            switch (e.Field.UnboundFieldName)
            {
                case "COL_PROMEDIO":
                    decimal unitPrice = Convert.ToDecimal(e.GetListSourceColumnValue(COL_VALOR2.ExpressionFieldName));

                    e.Value = unitPrice;
                    break;
            }
        }

        private void rpt_PxQ2_Load(object sender, EventArgs e)
        {


            ListarPresupuestos();
            ListarMonedas();
            barrar_progreso.Top = ((this.Height - barrar_progreso.Height) / 2);
            barrar_progreso.Left = ((this.Width - barrar_progreso.Width) / 2);
            LB_TITULO.Left = ((this.Width - LB_TITULO.Width) / 2);


            btn_fundovariedad.Enabled = false;
            btn_fundocultivo.Enabled = false;
            btn_fundoestructura.Enabled = false;

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

        private void btn_consultar_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }
      private  void MostrarDatos()
        {
           
            //_dtresultado = NFunciones.TABLADATOS("SELECT COUNT(*)AS NREGISTROS FROM P_RPT_PXQ WHERE IDPRESUPUESTO='"+_idpresupuesto+"'");
            _dtresultado = NFunciones.TABLADATOS("EXEC SP_PROCESAR_PXQ '" + _idpresupuesto + "','" + _moneda + "'");
            //MessageBox.Show(Convert.ToString(cbo_moneda.EditValue));

            Invoke((Action)delegate
            {
                pvt_datos2.DataSource = _dtresultado;

            });

                _mostrar = "S";
        }

        private void MostrarPorVariedad()
        {
            _dtresultado = NFunciones.TABLADATOS("EXEC SP_PROCESAR_PXQ_VARIEDADES'" +
                                     _idpresupuesto + "','" +
                                     _moneda + "'");

            Invoke((Action)delegate
            {
                pvt_datos2.DataSource = _dtresultado;

            });

            _mostrar = "S";
        }
        private void MostrarPorFundo()
        {
            _dtresultado = NFunciones.TABLADATOS("EXEC SP_PROCESAR_PXQ_TOTALES'" +
                                     _idpresupuesto + "','" +
                                     _moneda + "'");

            Invoke((Action)delegate
            {
                pvt_datos2.DataSource = _dtresultado;

            });

            _mostrar = "S";
        }
        private void MostrarPorEstrucutra()
        {

        }
        private void habilitarbotones(bool valor)
        {
            cbo_presupuesto.Enabled = valor;
            cbo_moneda.Enabled = valor;
            btn_consultarReporte.Enabled = valor;
            btn_editardetalle.Enabled = valor;
            btn_exportarexcel.Enabled = valor;
            btn_fundocultivo.Enabled = valor;
            btn_fundovariedad.Enabled = valor;
            btn_fundoestructura.Enabled = valor;
            btn_procesarconsultar.Enabled = valor;
            barrar_progreso.Visible = !valor;

            Invoke((Action)delegate
            {

                barrar_progreso.Location =
              new Point(ClientSize.Width / 2 - barrar_progreso.Size.Width / 2,
              ClientSize.Height / 2 - barrar_progreso.Size.Height / 2);
            });

        }

        private void pvt_datos2_CustomCellValue(object sender, PivotCellValueEventArgs e)
        {
            if (e.RowValueType == PivotGridValueType.Total)
            {
                e.Value = null;
              /*  for (int index = e.RowIndex - 1; index >= 0 && e.Value == null; index--)
                {
                    if (!Comparer.Equals(pvt_datos2.GetFieldValueType(false, index), PivotGridValueType.Value))  break;
                    e.Value = e.GetCellValue(e.ColumnIndex, index);
                }
                */
            }
        }

        private void pvt_datos2_FieldValueDisplayText(object sender, PivotFieldDisplayTextEventArgs e)
        {
          /*  if (e.Field == COL_GRUPO && e.ValueType == PivotGridValueType.Total)
            {
                e.DisplayText = "TOTAL";
            }
            */
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_mostrar.Equals("S"))
            {
                _mostrar = "N";
           
                habilitarbotones(true);
                timer1.Stop();
            }
            else
            {
                barrar_progreso.Caption = @"UN MOMENTO...";
            }
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbo_presupuesto_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_cultivo_Click(object sender, EventArgs e)
        {

        }

        private void btn_variedad_Click(object sender, EventArgs e)
        {

        }

        private void btn_estructura_Click(object sender, EventArgs e)
        {

        }

        private void btn_fundocultivo_Click(object sender, EventArgs e)
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

            habilitarbotones(false);
            _mostrar = "N";
            Thread Hilo = new Thread(MostrarPorFundo);
            Hilo.Start();
            timer1.Start();
        }

        private void btn_fundovariedad_Click(object sender, EventArgs e)
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

            habilitarbotones(false);
            _mostrar = "N";
            Thread Hilo = new Thread(MostrarPorVariedad);
            Hilo.Start();
            timer1.Start();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

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

            habilitarbotones(false);
            _mostrar = "N";
            Thread Hilo = new Thread(MostrarPorVariedad);
            Hilo.Start();
            timer1.Start();
        }

        private void btn_editardetalle_Click(object sender, EventArgs e)
        {
            if (!Convert.ToString(cbo_presupuesto.Text).Equals("[Seleccionar..]"))
            {
                filtro_Editar_presupuesto Hoj1 = new filtro_Editar_presupuesto();
                Hoj1.idpresupuesto = Convert.ToString(cbo_presupuesto.EditValue);
                Hoj1.ShowDialog();
            }
        }

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
                string doc = "c:\\DATA\\Tmp" + DateTime.Now.Millisecond.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + ".xlsx";
                pvt_datos2.ExportToXlsx(doc, pivotExportOptions);


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

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void btn_procesarconsultar_Click(object sender, EventArgs e)
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

            habilitarbotones(false);
            _mostrar = "N";
            Thread Hilo = new Thread(MostrarDatos);
            Hilo.Start();
            timer1.Start();
   
        }

        private void cbo_moneda_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void rpt_PxQ2_Resize(object sender, EventArgs e)
        {
            LB_TITULO.Left = ((this.Width - LB_TITULO.Width) / 2);
        }

        private void rpt_PxQ2_ResizeEnd(object sender, EventArgs e)
        {
            LB_TITULO.Left = ((this.Width - LB_TITULO.Width) / 2);
        }

        private void pvt_datos2_Click(object sender, EventArgs e)
        {

        }

        private void pvt_datos2_CustomDrawFieldValue(object sender, PivotCustomDrawFieldValueEventArgs e)
        {

            //if (e.Area == DevExpress.XtraPivotGrid.PivotArea.ColumnArea)
            //{
            //    Rectangle rect = e.Bounds;
            //    ControlPaint.DrawBorder3D(e.Graphics, e.Bounds);
            //    Brush brush = e.GraphicsCache.GetSolidBrush(Color.LightYellow);
            //    rect.Inflate(-1, -1);
            //    e.Graphics.FillRectangle(brush, rect);
            //    e.Appearance.DrawString(e.GraphicsCache, e.Info.Caption, e.Info.CaptionRect);
            //    e.Painter.DrawIndicator(e.Info);
            //    e.Handled = true;
            //}
            //else if (e.Area == DevExpress.XtraPivotGrid.PivotArea.RowArea)
            //{
            //    e.Painter.DrawObject(e.Info);
            //    e.Painter.DrawIndicator(e.Info);
            //    e.Graphics.FillRectangle(e.GraphicsCache.GetSolidBrush(Color.FromArgb(50, 0, 0, 200)), e.Bounds);
            //    e.Handled = true;
            //}



        }

        private void pvt_datos2_CellDoubleClick(object sender, PivotCellEventArgs e)
        {

            try
            {
                //string fundo = pvt_datos2.GetFieldValue(COL_FUNDO2, e.RowIndex).ToString();
                //string cultivo= pvt_datos2.GetFieldValue(COL_IDCULTIVO2, e.RowIndex).ToString();
                //string variedad= pvt_datos2.GetFieldValue(COL_IDVARIEDAD2, e.RowIndex).ToString();
                string item = pvt_datos2.GetFieldValue(COL_ITEM2, e.RowIndex).ToString();
                string retString = null;
                retString = item.Substring(0, 2);
                Frm_detallePXQ ObjdetPXQ = new Frm_detallePXQ(_idpresupuesto, retString, _moneda);
                ObjdetPXQ.ShowDialog();
            }
            catch(Exception ex)
            {

            }
            
        }
    }
}
