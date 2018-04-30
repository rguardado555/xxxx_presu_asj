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
using System.Threading;
using DevExpress.XtraPivotGrid;
using System.Diagnostics;
using DevExpress.XtraEditors.Repository;

namespace ModuloPresupuesto
{
    
    public partial class Rpt_PYG : Form

    {
      private  string valores = "";
      private   string cultivos = "";

        DataTable dtresultado = new DataTable();
        string mostrar = "N";
        private string idpresupuesto, idmoneda, idcultivo, idfundo;

        public Rpt_PYG()
        {
            InitializeComponent();
        }

        private void Rpt_PYG_Load(object sender, EventArgs e)
        {
            dtg.Columns.Clear();
            ListarPresupuestos();
            ListarMonedas();
            ListarCultivo();
            ListarFundo();
            barrar_progreso.Top = ((this.Height - barrar_progreso.Height) / 2);
            barrar_progreso.Left = ((this.Width - barrar_progreso.Width) / 2);
            LB_TITULO.Left = ((this.Width - LB_TITULO.Width) / 2);
        }
        //void altercoloresdatagrid(DataGridView dgv,int item)
        //{

        //    dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
        //    dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        //    dgv.Columns[0].HeaderCell.Style.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        //    dgv.Columns[0].DefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        //    dgv.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
        //    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
          

        //    for (int f = 1; f < item; f++)
        //    {
        //        dgv.Columns[f].DefaultCellStyle.Format = "N2";
        //        dgv.Columns[f].HeaderCell.Style.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        //        dgv.Columns[f].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
        //        dgv.Columns[f].DefaultCellStyle.Font = new Font("Segoe UI", 9.75F);
        //        dgv.Columns[f].DefaultCellStyle.ForeColor = Color.Black;
        //        dgv.Columns[f].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


        //    }

        //}


        void ListarPresupuestos()
        {
            cbo_presu.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDPRESUPUESTO,DESCRIPCION PRESUPUESTO FROM P_PRESUPUESTO WHERE ES_GF='0'");
            cbo_presu.Properties.ValueMember = "IDPRESUPUESTO";
            cbo_presu.Properties.DisplayMember = "PRESUPUESTO";
        }
        private void ListarMonedas()
        {
            cbo_mon.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDMONEDA ID , RTRIM(LTRIM( NOMBRE_CORTO)) +' - ' +RTRIM(LTRIM(DESCRIPCION)) AS MONEDA FROM  P_MONEDAS ORDER BY IDMONEDA ASC");
            cbo_mon.Properties.ValueMember = "ID";
            cbo_mon.Properties.DisplayMember = "MONEDA";
        }
        private void ListarFundo()
        {
            cbo_fun.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDFUNDO ID ,RTRIM(LTRIM(DESCRIPCION)) DESCRIPCION FROM P_FUNDO ORDER BY IDFUNDO ASC ");
            cbo_fun.Properties.ValueMember = "ID";
            cbo_fun.Properties.DisplayMember = "DESCRIPCION";

            cbo_select_fundo.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDFUNDO ID ,RTRIM(LTRIM(DESCRIPCION)) DESCRIPCION FROM P_FUNDO ORDER BY IDFUNDO ASC ");
            cbo_select_fundo.Properties.ValueMember = "ID";
            cbo_select_fundo.Properties.DisplayMember = "DESCRIPCION";
        }
        private void ListarCultivo()
        {
            cbo_cult.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDCULTIVO ID,RTRIM(LTRIM(DESCRIPCION)) DESCRIPCION  FROM P_CULTIVOS ORDER BY IDCULTIVO ASC");
            cbo_cult.Properties.ValueMember = "ID";
            cbo_cult.Properties.DisplayMember = "DESCRIPCION";

            cbo_select_cult.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDCULTIVO ID,RTRIM(LTRIM(DESCRIPCION)) DESCRIPCION  FROM P_CULTIVOS ORDER BY IDCULTIVO ASC");
            cbo_select_cult.Properties.ValueMember = "ID";
            cbo_select_cult.Properties.DisplayMember = "DESCRIPCION";

        }

        //private void btn_consultar_Click(object sender, EventArgs e)
        //{
        //    if (Convert.ToString(cbo_presupuesto.Text).Equals("[Seleccionar..]"))
        //    {
        //        MessageBox.Show(@"Debe Seleccionar un Presupuesto !", @"Alerta !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }
        //    mostrar = "N";
        //    Thread Hilo = new Thread(MostrarDatos);
        //    Hilo.Start();
        //    timer1.Start();
        //    barrar_progreso.Visible = true;
        //}

        //void MostrarDatos()
        //{

        //    dtresultado = NFunciones.TABLADATOS(" EXEC SP_PROCESARPXG '" + Convert.ToString(cbo_presupuesto.EditValue) + "'");
        //    mostrar = "S";

        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mostrar.Equals("S"))
            {
                //mostrar = "N";

                //dtg.DataSource= dtresultado;
                //drig.DataSource = dtresultado;

                //vista_drig.Columns[0].AppearanceCell.ForeColor = Color.Black;
                //vista_drig.Columns[0].AppearanceCell.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                //vista_drig.Columns[0].AppearanceCell.BackColor = Color.FromArgb(213, 212, 210);
                //vista_drig.Columns[0].OptionsColumn.AllowEdit = false;



                //if (dtresultado.Rows.Count>0)
                //{
                //    int i = vista_drig.Columns.Count();
                //    for (int f = 1; f < i; f++)
                //    {
                //        vista_drig.Columns[f].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                //        vista_drig.Columns[f].DisplayFormat.FormatString = "#,###.00";
                //        vista_drig.Columns[f].AppearanceCell.ForeColor = Color.Black;
                //        vista_drig.Columns[f].AppearanceCell.Font = new Font("Segoe UI", 9);
                //        vista_drig.Columns[f].OptionsColumn.AllowEdit = false;
                //    }



                //    vista_drig.Columns[i-1].AppearanceCell.BackColor = Color.FromArgb(226, 167, 14);
                //    vista_drig.Columns[i-1].AppearanceCell.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                //    vista_drig.Columns[i-1].OptionsColumn.AllowEdit = false;
                //}

                //dtg.ReadOnly = true;


                pvt_datos2.DataSource = dtresultado;

                barrar_progreso.Visible = false;
                int ix = dtg.Columns.Count;
                //altercoloresdatagrid(dtg,ix);
                timer1.Stop();

            }
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            try
            {
                /*pvt_datos2.ExportToXlsx(@"..\RespumenPXQ.xlsx");
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "EXCEL.EXE";
                startInfo.Arguments = @"..\RespumenPXQ.xlsx";
                Process.Start(startInfo);*/
                //pvt_datos2.ShowPrintPreview();

            }
            catch (Exception ex)
            {
                MessageBox.Show(@"No se pudo exportar el archivo , error sugerido :" + "\n" + ex.Message, @"Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btn_consultarReporte_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(cbo_presu.EditValue).Equals(""))
            {
                MessageBox.Show(@"Debe Seleccionar un Presupuesto !", @"Alerta !", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToString(cbo_mon.EditValue).Equals(""))
            {
                MessageBox.Show(@"Debe Seleccionar una Moneda !", @"Alerta !", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToString(cbo_select_cult.Text).Equals(""))
            {
                MessageBox.Show(@"Debe Seleccionar un Cultivos !", @"Alerta !", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToString(cbo_select_fundo.EditValue).Equals(""))
            {
                MessageBox.Show(@"Debe Seleccionar Fundos !", @"Alerta !", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            //int item = dtg.ColumnCount;
            //for (int f = 0; f < item ; f++)
            //{
            //    dtg.Columns.RemoveAt(dtg.Columns[f].Index);
            //}
            dtg.Columns.Clear();
            vista_drig.Columns.Clear();

            idpresupuesto = Convert.ToString(cbo_presu.EditValue);
            idmoneda = Convert.ToString(cbo_mon.EditValue);
            //idfundo = Convert.ToString(cbo_fun.EditValue);
            idcultivo= Convert.ToString(cbo_cult.EditValue);

            //---------------fundos
            valores = "";

            for (int i = 0; i < cbo_select_fundo.Properties.Items.Count; i++)
            {

                if (cbo_select_fundo.Properties.Items[i].CheckState == CheckState.Checked)
                {
                    valores = valores + cbo_select_fundo.Properties.Items[i].Value.ToString() + ".";
                }

            }

            valores = valores.TrimEnd('.');
            //---------cultivos

            cultivos = "";

            for (int i = 0; i < cbo_select_cult.Properties.Items.Count; i++)
            {

                if (cbo_select_cult.Properties.Items[i].CheckState == CheckState.Checked)
                {
                    cultivos = cultivos + cbo_select_cult.Properties.Items[i].Value.ToString() + ".";
                }

            }

            cultivos = cultivos.TrimEnd('.');


            mostrar = "N";
            Thread Hilo = new Thread(Consultar);
            Hilo.Start();
            timer1.Start();
            barrar_progreso.Visible = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void dtg_datos_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void cbo_presu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_cult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_fun_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Rpt_PYG_Resize(object sender, EventArgs e)
        {
            LB_TITULO.Left = ((this.Width - LB_TITULO.Width) / 2);
            barrar_progreso.Top = ((this.Height - barrar_progreso.Height) / 2);
            barrar_progreso.Left = ((this.Width - barrar_progreso.Width) / 2);

        }

        private void Rpt_PYG_ResizeEnd(object sender, EventArgs e)
        {
            LB_TITULO.Left = ((this.Width - LB_TITULO.Width) / 2);
            barrar_progreso.Top = ((this.Height - barrar_progreso.Height) / 2);
            barrar_progreso.Left = ((this.Width - barrar_progreso.Width) / 2);

        }

        private void btn_exportarexcel_Click(object sender, EventArgs e)
        {
            var pivotExportOptions = new PivotXlsxExportOptions { ExportType = DevExpress.Export.ExportType.WYSIWYG };
            string doc = "c:\\DATA\\Tmppyg" + DateTime.Now.Millisecond.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + ".xlsx";
            pvt_datos2.ExportToXlsx(doc , pivotExportOptions);
            
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "EXCEL.EXE",
                Arguments = doc
            };
            Process.Start(startInfo);
        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            //removeCombinedFlags(cbo_select_fundo.Properties);

            valores = "";
           
            for (int i = 0; i < cbo_select_fundo.Properties.Items.Count ; i++)
            {

                if (cbo_select_fundo.Properties.Items[i].CheckState == CheckState.Checked)
                {
                  valores = valores  + cbo_select_fundo.Properties.Items[i].Value.ToString() + ".";
                }

            }

            valores = valores.TrimEnd('.');
            //MessageBox.Show(valores);


            idpresupuesto = Convert.ToString(cbo_presu.EditValue);
            idmoneda = Convert.ToString(cbo_mon.EditValue);
            idcultivo = Convert.ToString(cbo_cult.EditValue);


            dtresultado =  NFunciones.TABLADATOS(" EXEC SP_REPORTE_PYG'" + idpresupuesto + "','" + idmoneda + "','" + valores + "','" + idcultivo + "'");
            pvt_datos2.DataSource = dtresultado;

        }

        private void cbo_select_fundo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cbo_select_cult_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Consultar()
        {
            DataTable tbregistros = new DataTable();
            tbregistros = NFunciones.TABLADATOS("SELECT COUNT(*)NREGISTROS FROM P_RPT_PYG WHERE IDPRESUPUESTO='" + idpresupuesto+ "'");

            if (Convert.ToInt32(tbregistros.Rows[0]["NREGISTROS"]) == 0)
            {
                string rpta = NFunciones.ExecuteSQL("EXEC SP_CALCULAR_PYG_DOL'" + idpresupuesto + "','" + idmoneda+ "'");
            }
            dtresultado = NFunciones.TABLADATOS(" EXEC SP_REPORTE_PYG'" + idpresupuesto + "','" + idmoneda + "','" + valores + "','" + cultivos + "'");
            mostrar = "S";
        }
        private void ProcesarConsultar()
        {
            string rpta = NFunciones.ExecuteSQL("EXEC SP_CALCULAR_PYG_DOL'" + idpresupuesto + "','" + idmoneda + "'");
            dtresultado =
              NFunciones.TABLADATOS(" EXEC SP_REPORTE_PYG'" + idpresupuesto + "','" +
                                    idmoneda + "','" + idfundo +
                                    "','" + idcultivo + "'");
            mostrar = "S";
        }

        private void btn_procesarconsultar_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(cbo_presu.EditValue).Equals(""))
            {
                MessageBox.Show(@"Debe Seleccionar un Presupuesto !", @"Alerta !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToString(cbo_mon.EditValue).Equals(""))
            {
                MessageBox.Show(@"Debe Seleccionar una Moneda !", @"Alerta !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToString(cbo_presu.EditValue).Equals(""))
            {
                MessageBox.Show(@"Debe Seleccionar un Presupuesto !", @"Alerta !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToString(cbo_presu.EditValue).Equals(""))
            {
                MessageBox.Show(@"Debe Seleccionar un Presupuesto !", @"Alerta !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            mostrar = "N";
            Thread Hilo = new Thread(ProcesarConsultar);
            Hilo.Start();
            timer1.Start();
            barrar_progreso.Visible = true;
        }
    }
}
