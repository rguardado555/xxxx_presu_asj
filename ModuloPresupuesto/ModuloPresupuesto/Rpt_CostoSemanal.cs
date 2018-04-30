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
using DevExpress.XtraPivotGrid;
using System.Diagnostics;
using System.IO;

namespace ModuloPresupuesto
{
    public partial class Rpt_CostoSemanal : DevExpress.XtraEditors.XtraForm
    {
        string  fundo, parcela, lote;

        DataTable dtresultado = new DataTable();
        string mostrar = "N";
        public Rpt_CostoSemanal()
        {
            InitializeComponent();
        }

        private void Rpt_CostoSemanal_Load(object sender, EventArgs e)
        {
            llenarcultivo();
            llenarpresupuesto();
            llenarmoneda();
            llenaritemcosto();
            llenarfundo();
            COL_COSTO.Visible = false;
            COL_COSTOTOTAL.Visible = false;
        }

        void llenarcultivo()
        {
            cbo_cultivo.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDCULTIVO CODIGO,DESCRIPCION FROM P_CULTIVOS ORDER  BY IDCULTIVO ASC");
            cbo_cultivo.Properties.ValueMember = "CODIGO";
            cbo_cultivo.Properties.DisplayMember = "DESCRIPCION";

        }
        void llenarfundo()
        {
            cbo_select_fundo.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDFUNDO CODIGO,DESCRIPCION FROM P_FUNDO ORDER  BY IDFUNDO ASC");
            cbo_select_fundo.Properties.ValueMember = "CODIGO";
            cbo_select_fundo.Properties.DisplayMember = "DESCRIPCION";
        }
        void llenarparcela(string fundo)
        {
            cbo_select_Parcela.Properties.DataSource = NFunciones.TABLADATOS("SELECT Idparcela CODIGO,DESCRIPCION  FROM P_PARCELAS WHERE IDFUNDO IN ("+fundo+") ORDER BY Idparcela ASC");
            cbo_select_Parcela.Properties.ValueMember = "CODIGO";
            cbo_select_Parcela.Properties.DisplayMember = "DESCRIPCION";
        }
        void llenarlote(string parcela)
        {
            cbo_select_lote.Properties.DataSource = NFunciones.TABLADATOS("SELECT IdLote CODIGO,Descripción DESCRIPCION FROM P_LOTE  WHERE Idparcela IN ("+parcela+") ORDER BY IdLote ASC");
            cbo_select_lote.Properties.ValueMember = "CODIGO";
            cbo_select_lote.Properties.DisplayMember = "DESCRIPCION";
        }
        void llenarpresupuesto()
        {
            cbo_presupuesto.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDPRESUPUESTO CODIGO,DESCRIPCION FROM P_PRESUPUESTO ORDER BY IDPRESUPUESTO DESC");
            cbo_presupuesto.Properties.ValueMember = "CODIGO";
            cbo_presupuesto.Properties.DisplayMember = "DESCRIPCION";
        }
        void llenarmoneda()
        {
            cbo_moneda.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDMONEDA CODIGO,RTRIM(LTRIM(NOMBRE_CORTO))+' - ' +RTRIM(LTRIM(DESCRIPCION)) DESCRIPCION  FROM P_MONEDAS ORDER BY IDMONEDA ASC");
            cbo_moneda.Properties.ValueMember = "CODIGO";
            cbo_moneda.Properties.DisplayMember = "DESCRIPCION";
        }
        void llenaritemcosto()
        {
            cbo_itemcosto.Properties.DataSource = NFunciones.TABLADATOS("SELECT IdItemCosto CODIGO,DESCRIPCION FROM P_ICOSTO ORDER BY IdItemCosto ASC");
            cbo_itemcosto.Properties.ValueMember = "CODIGO";
            cbo_itemcosto.Properties.DisplayMember = "DESCRIPCION";
        }

        private void btn_consultarReporte_Click(object sender, EventArgs e)
        {


            if (Convert.ToString(cbo_presupuesto.EditValue).Equals(""))
            {
                MessageBox.Show(@"Debe Seleccionar un Presupuesto !", @"Alerta !", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToString(cbo_moneda.EditValue).Equals(""))
            {
                MessageBox.Show(@"Debe Seleccionar una Moneda !", @"Alerta !", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (Convert.ToString(cbo_cultivo.EditValue).Equals(""))
            {
                MessageBox.Show(@"Debe Seleccionar una Cultivo !", @"Alerta !", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (Convert.ToString(cbo_itemcosto.EditValue).Equals(""))
            {
                MessageBox.Show(@"Debe Seleccionar una Item Costo !", @"Alerta !", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (Convert.ToString(cbo_select_fundo.Text).Equals(""))
            {
                MessageBox.Show(@"Debe Seleccionar un Fundos !", @"Alerta !", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToString(cbo_select_Parcela.EditValue).Equals(""))
            {
                MessageBox.Show(@"Debe Seleccionar Parcelas !", @"Alerta !", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (Convert.ToString(cbo_select_lote.EditValue).Equals(""))
            {
                MessageBox.Show(@"Debe Seleccionar Lotes !", @"Alerta !", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }


            //------fundo

            fundo = "";

            for (int i = 0; i < cbo_select_fundo.Properties.Items.Count; i++)
            {

                if (cbo_select_fundo.Properties.Items[i].CheckState == CheckState.Checked)
                {
                    fundo = fundo + cbo_select_fundo.Properties.Items[i].Value.ToString() + ".";
                }

            }

            fundo = fundo.TrimEnd('.');

            //------parcela

             parcela = "";

            for (int i = 0; i < cbo_select_Parcela.Properties.Items.Count; i++)
            {

                if (cbo_select_Parcela.Properties.Items[i].CheckState == CheckState.Checked)
                {
                    parcela = parcela + cbo_select_Parcela.Properties.Items[i].Value.ToString() + ".";
                }

            }

            parcela = parcela.TrimEnd('.');

            //------lote

             lote = "";

            for (int i = 0; i < cbo_select_lote.Properties.Items.Count; i++)
            {

                if (cbo_select_lote.Properties.Items[i].CheckState == CheckState.Checked)
                {
                    lote = lote + cbo_select_lote.Properties.Items[i].Value.ToString() + ".";
                }

            }

            lote = lote.TrimEnd('.');


            mostrar = "N";
            Thread Hilo = new Thread(Consultar);
            Hilo.Start();
            timer1.Start();
            barrar_progreso.Visible = true;

        }
        private void Consultar()
        {
            dtresultado = NFunciones.TABLADATOS("EXEC SP_RPTCOSTOSEMANAL '"+cbo_presupuesto.EditValue.ToString()+"','"+cbo_cultivo.EditValue.ToString()+"','"+cbo_moneda.EditValue.ToString()+"','"+cbo_itemcosto.EditValue.ToString()+"','" + fundo + "','" + parcela + "', '" + lote + "'");
            mostrar = "S";
        }
        private void cbo_select_fundo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cbo_select_Parcela_EditValueChanged(object sender, EventArgs e)
        {
           
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mostrar.Equals("S"))
            {
                mostrar = "N";
                pvt_datos2.DataSource = dtresultado;
                barrar_progreso.Visible = false;
                timer1.Stop();
            }
      }

        private void cbo_select_fundo_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_editardetalle_Click(object sender, EventArgs e)
        {

        }

        private void btn_exportarexcel_Click(object sender, EventArgs e)
        {
            string ruta = "c:\\DATA";
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }

            var pivotExportOptions = new PivotXlsxExportOptions { ExportType = DevExpress.Export.ExportType.WYSIWYG };
            string doc = "c:\\DATA\\Tmpcostosemanal" + DateTime.Now.Millisecond.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + ".xlsx";
            pvt_datos2.ExportToXlsx(doc, pivotExportOptions);

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "EXCEL.EXE",
                Arguments = doc
            };
            Process.Start(startInfo);
        }

        private void chk_costouni_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_costouni.Checked)
            {
                COL_COSTO.Visible = true;
            }
            else
            {
                COL_COSTO.Visible = false;
            }

        }

        private void chk_costototal_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_costototal.Checked)
            {
                COL_COSTOTOTAL.Visible = true;
            }
            else
            {
                COL_COSTOTOTAL.Visible = false;
            }
        }

        private void cbo_select_fundo_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

            cbo_select_Parcela.Text = "";
            string valores = "";
            for (int i = 0; i < cbo_select_fundo.Properties.Items.Count; i++)
            {

                if (cbo_select_fundo.Properties.Items[i].CheckState == CheckState.Checked)
                {
                    valores = valores + "'" + cbo_select_fundo.Properties.Items[i].Value.ToString() + "',";
                }

            }
            valores = valores.TrimEnd(',');
            llenarparcela(valores);
        }

        private void cbo_select_Parcela_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            cbo_select_lote.Text = "";
            string valores = "";
            for (int i = 0; i < cbo_select_Parcela.Properties.Items.Count; i++)
            {

                if (cbo_select_Parcela.Properties.Items[i].CheckState == CheckState.Checked)
                {
                    valores = valores + "'" + cbo_select_Parcela.Properties.Items[i].Value.ToString() + "',";
                }

            }
            valores = valores.TrimEnd(',');
            llenarlote(valores);
        }
    }
}