using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace ModuloPresupuesto
{
    public partial class Frm_MenuPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public Frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Frm_MenuPrincipal_Load(object sender, EventArgs e)
        {
            //panelInicial();
        }

        //private void panelInicial()
        //{
        //    if (this.panel_contenedor.Controls.Count > 0)
        //        this.panel_contenedor.Controls.RemoveAt(0);
        //    Panel_principal hijo1 = new Panel_principal();
        //    hijo1.TopLevel = false;
        //    hijo1.FormBorderStyle = FormBorderStyle.None;
        //    hijo1.Dock = DockStyle.Fill;
        //    this.panel_contenedor.Controls.Add(hijo1);
        //    this.panel_contenedor.Tag = hijo1;
        //    hijo1.Show();
        //}
        private void Gestionarfondo()
        {
            panel_contenedor.Visible = xtraTabbedMdiManager1.Pages.Count <= 0;
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            rpt_PxQ2 PXQ = new rpt_PxQ2();
            PXQ.MdiParent = this;
            PXQ.Show();
           
        }

        private void xtraTabbedMdiManager1_PageAdded(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            Gestionarfondo();
        }

        private void xtraTabbedMdiManager1_PageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            Gestionarfondo();

        }

        private void mnu_actualizarTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_UpdateTipoCambio FMRTC = new Frm_UpdateTipoCambio();
            FMRTC.ShowDialog();
        }

        private void mnu_semanaspresupuesto_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmGenerarPeriodos periodos = new FrmGenerarPeriodos();
            periodos.ShowDialog();
        }

        private void radialMenu1_ItemClick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
     
        }

        private void mnu_detallepresu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ImportarDetallePresupuesto detpres = new Frm_ImportarDetallePresupuesto();
            detpres.ShowDialog();

        }

        private void mnu_generardetallexlote_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmGenerarDetallePorLote detlote = new FrmGenerarDetallePorLote();
            detlote.ShowDialog();
        }

        private void mnu_exportdetalle_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_DescargarDeta detdata = new Frm_DescargarDeta();
            detdata.ShowDialog();
        }

        private void mnu_editmanual_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_EditDetallePresupuesto edtdata = new Frm_EditDetallePresupuesto();
            edtdata.ShowDialog();
        }

        private void Frm_MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Frm_MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mnu_fundos_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Fundo edtdata = new Frm_Fundo();
            edtdata.ShowDialog();
        }

        private void mnu_parcelas_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Parcela parc = new Frm_Parcela();
            parc.ShowDialog();
        }

        private void mnu_responsables_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Responsables resp = new Frm_Responsables();
            resp.ShowDialog();

        }

        private void btn_reportdesigner_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReportDesigner resp = new ReportDesigner();
            resp.ShowDialog();
        }

        private void btn_rpt_semana_ItemClick(object sender, ItemClickEventArgs e)
        {
           Rpt_CostoSemanal objCostoSemana = new Rpt_CostoSemanal();
            objCostoSemana.MdiParent = this;
            objCostoSemana.Show();
        }

        private void btn_rptPYG_ItemClick(object sender, ItemClickEventArgs e)
        {
            Rpt_PYG objPyG = new Rpt_PYG();
            objPyG.MdiParent = this;
            objPyG.Show();
        }

        private void btn_rpt_GF_general_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void btn_procesarreporte_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_ProcesarReportes ObjRptGF = new Frm_ProcesarReportes();
            ObjRptGF.ShowDialog();
        }

        private void btn_conf_individuales_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_EditarVariablesIndivuduales Objconf = new Frm_EditarVariablesIndivuduales();
            Objconf.ShowDialog();
        }

        private void btn_variables_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Variables ObjVariables = new Frm_Variables();
            ObjVariables.ShowDialog();
        }

        private void btn_rptgeneralGF_ItemClick(object sender, ItemClickEventArgs e)
        {
            rpt_GastoFijo ObjGF = new rpt_GastoFijo();
            ObjGF.MdiParent = this;
            ObjGF.Show();
        }
    }
}