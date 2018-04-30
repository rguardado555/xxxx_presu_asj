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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors;
using DevExpress.Utils.Menu;
using DevExpress.XtraCharts.UI;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.BandedGrid;
using System.IO;
using DevExpress.XtraPivotGrid;
using System.Diagnostics;

namespace ModuloPresupuesto
{

    public partial class filtro_Editar_presupuesto : Form
    { string modo = "N";
        string ConsultaSql,tabla;
        public string idpresupuesto;
        DataTable tbgeneral;
        public filtro_Editar_presupuesto()
        {
            InitializeComponent();
        }
        void bloquearCombos(bool valor)
        {
            cbo_cultivo.Enabled = valor;
            cbo_variedad.Enabled = valor;
            cbo_estructura.Enabled = valor;
            cbo_item.Enabled = valor;
            cbo_fundo.Enabled = valor;
            cbo_actisub.Enabled = valor;
            cbo_labor.Enabled = valor;
            cbo_moneda.Enabled = valor;
            cbo_subitemcosto.Enabled = valor;
            cbo_tipocosto.Enabled = valor;
            btn_cerrar.Enabled = valor;
            btn_filtar.Enabled = valor;
            btn_actualizar.Enabled = valor;
            btn_cancelar.Enabled = valor;
        }

       private void HABILITARFILTROS(bool valor)
       {
            cbo_cultivo.ReadOnly = !valor;
            cbo_variedad.ReadOnly = !valor;
            cbo_estructura.ReadOnly = !valor;
            cbo_item.ReadOnly = !valor;

            cbo_actisub.ReadOnly = !valor;
            cbo_moneda.ReadOnly = !valor;
            cbo_estructura.ReadOnly = !valor;
            btn_filtar.Enabled = valor;
            chk_lote.ReadOnly = !valor;
            chk_variedad.ReadOnly = !valor;

            btn_cancelar.Enabled = valor;
            btn_actualizar.Enabled = valor;
            btn_cerrar.Enabled = valor;

        }

        private void btn_filtar_Click(object sender, EventArgs e)
        {
            
            if (!chk_lote.Checked && !chk_variedad.Checked)
            {
                MensajeError("Tiene que seleccioner la tabla a consultar !");
                return;
            }
            if (chk_lote.Checked)
            {
                if (cbo_lote.Text.Equals("[Seleccione..]"))
                {
                    MensajeError("Seleccione un Lote");
                    return;
                }
            }
            if (cbo_cultivo.Text.Equals("[Seleccione..]")){
                MensajeError("Seleccione Cultivo");
                return;
            }
            if (cbo_variedad.Text.Equals("[Seleccione..]"))
            {
                MensajeError("Seleccione Variedad");
                return;
            }
            if (cbo_estructura.Text.Equals("[Seleccione..]"))
            {
                MensajeError("Seleccione Estructura");
                return;
            }
            if (cbo_item.Text.Equals("[Seleccione..]"))
            {
                MensajeError("Seleccione Item Costo");
                return;
            }
            if (cbo_fundo.Text.Equals("[Seleccione..]"))
            {
                MensajeError("Seleccione Fundo");
                return;
            }
            tabla = chk_lote.Checked ? "V" : "L";

            barra_progreso.Visible = true;
           
            this.Height = 671;

            dtg_datos.DataSource = null;

            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            modo = "N";
            ConsultaSql = "";
            bloquearCombos(false);
            if (chk_lote.Checked)
            {
                Thread Hilo = new Thread(mostrarDatos_lote);
                Hilo.Start();
                timer1.Start();
            }
            else
            {
                Thread Hilo = new Thread(mostrarDatos_variedad);
                Hilo.Start();
                timer1.Start();
            }
            

        }
         private  void mostrarDatos_variedad()
        {
            try
            {
                tbgeneral = NFunciones.TABLADATOS("EXEC sp_FiltroPresupuesto_Variedad '"+idpresupuesto+"','"+Convert.ToString(cbo_cultivo.EditValue).Trim()+ "','" + Convert.ToString(cbo_variedad.EditValue).Trim() + "','" + Convert.ToString(cbo_estructura.EditValue).Trim() + "','" + Convert.ToString(cbo_item.EditValue).Trim() + "','" + Convert.ToString(cbo_fundo.EditValue).Trim() + "','" + Convert.ToString(cbo_actisub.EditValue).Trim() + "','" + Convert.ToString(cbo_labor.EditValue).Trim() + "','" + Convert.ToString(cbo_moneda.EditValue).Trim() + "','" + Convert.ToString(cbo_subitemcosto.EditValue).Trim() + "','" + Convert.ToString(cbo_tipocosto.EditValue).Trim() + "'");
                modo = "S";
            }
            catch(Exception ex)
            {
                MensajeError("Ocurrio un error, Consulte con Soporte"+"\n"+ex.Message);
                modo = "S";
            }
         
        }
        private void mostrarDatos_lote()
        {
            try
            {
               
                tbgeneral = NFunciones.TABLADATOS("EXEC sp_FiltroPresupuesto_Lote '" + idpresupuesto + "','" + Convert.ToString(cbo_cultivo.EditValue).Trim() + "','" + Convert.ToString(cbo_variedad.EditValue).Trim() + "','" + Convert.ToString(cbo_estructura.EditValue).Trim() + "','" + Convert.ToString(cbo_item.EditValue).Trim() + "','" + Convert.ToString(cbo_fundo.EditValue).Trim() + "','" + Convert.ToString(cbo_actisub.EditValue).Trim() + "','" + Convert.ToString(cbo_labor.EditValue).Trim() + "','" + Convert.ToString(cbo_moneda.EditValue).Trim() + "','" + Convert.ToString(cbo_lote.EditValue).Trim() + "','" + Convert.ToString(cbo_subitemcosto.EditValue).Trim() + "','" + Convert.ToString(cbo_tipocosto.EditValue).Trim() + "'");
                modo = "S";
            }
            catch (Exception ex)
            {
                MensajeError("Ocurrio un error, Consulte con Soporte" + "\n" + ex.Message);
                modo = "S";
            }

        }

        private void edit_mostrarDatos_variedad()
        {
            try
            {
                string errores = "";
                string rpta = "";


                ConsultaSql = ConsultaSql + "   EXEC MONEDAEQUIVALENTE '" + idpresupuesto + "'";
                ConsultaSql = ConsultaSql + "   EXEC ACTUALIZA_MONEDA_PRTLOTE '" + idpresupuesto + "'";
                rpta = NFunciones.ExecuteSQL(ConsultaSql);

                if (!rpta.Equals("Ok"))
                {
                    errores = "Se produjo un error consulte con soporte";
                    Console.Write(errores);
                }
                ConsultaSql = "";
                tbgeneral = NFunciones.TABLADATOS("EXEC sp_FiltroPresupuesto_Variedad '" + idpresupuesto + "','" + Convert.ToString(cbo_cultivo.EditValue).Trim() + "','" + Convert.ToString(cbo_variedad.EditValue).Trim() + "','" + Convert.ToString(cbo_estructura.EditValue).Trim() + "','" + Convert.ToString(cbo_item.EditValue).Trim() + "','" + Convert.ToString(cbo_fundo.EditValue).Trim() + "','" + Convert.ToString(cbo_actisub.EditValue).Trim() + "','" + Convert.ToString(cbo_labor.EditValue).Trim() + "','" + Convert.ToString(cbo_moneda.EditValue).Trim() + "'");
                modo = "S";
            }
            catch (Exception ex)
            {
                MensajeError("Ocurrio un error, Consulte con Soporte" + "\n" + ex.Message);
                modo = "S";
            }

        }
        private void edit_mostrarDatos_lote()
        {
            try
            {
                string errores = "";
                string rpta = "";

                ConsultaSql = ConsultaSql + "   EXEC MONEDAEQUIVALENTE '" + idpresupuesto + "'";
                ConsultaSql = ConsultaSql + "   EXEC ACTUALIZA_MONEDA_PRTLOTE '" + idpresupuesto + "'";

                rpta = NFunciones.ExecuteSQL(ConsultaSql);

                if (!rpta.Equals("Ok"))
                {
                    errores = "Se produjo un error consulte con soporte";
                    Console.Write(errores);
                }
                ConsultaSql = "";
                tbgeneral = NFunciones.TABLADATOS("EXEC sp_FiltroPresupuesto_Lote '" + idpresupuesto + "','" + Convert.ToString(cbo_cultivo.EditValue).Trim() + "','" + Convert.ToString(cbo_variedad.EditValue).Trim() + "','" + Convert.ToString(cbo_estructura.EditValue).Trim() + "','" + Convert.ToString(cbo_item.EditValue).Trim() + "','" + Convert.ToString(cbo_fundo.EditValue).Trim() + "','" + Convert.ToString(cbo_actisub.EditValue).Trim() + "','" + Convert.ToString(cbo_labor.EditValue).Trim() + "','" + Convert.ToString(cbo_moneda.EditValue).Trim() + "','" + Convert.ToString(cbo_lote.EditValue).Trim() + "'");
                modo = "S";
            }
            catch (Exception ex)
            {
                MensajeError("Ocurrio un error, Consulte con Soporte" + "\n" + ex.Message);
                modo = "S";
            }

        }



        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, @"Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void MensajeConfirmacion(string mensaje)
        {
            MessageBox.Show(mensaje, @"Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void filtro_ManoObra_Load(object sender, EventArgs e)
        {
            this.Height = 671;
            this.Height = 151;
            chk_variedad.Checked=true;
            tabla = "V";
            LlenarCultivos();
            LlenarEstructuras();
            LlenarItem();
            LlenarObjetivos();
            LlenarActiGrup();
            LlenarMoneda();
            LlenarTipoCosto();
            barra_progreso.Caption = @"Un Momento Consultando";
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Height = 151;
            //cbo_cultivo.Properties.DataSource = null;
            //cbo_variedad.Properties.DataSource = null;
            //cbo_estructura.Properties.DataSource = null;
            //cbo_item.Properties.DataSource = null;
            //cbo_fundo.Properties.DataSource = null;
            //cbo_actisub.Properties.DataSource = null;
            //cbo_labor.Properties.DataSource = null;
            //cbo_moneda.Properties.DataSource = null;

            //LlenarCultivos();
            //LlenarEstructuras();
            //LlenarItem();
            //LlenarObjetivos();
            //LlenarActiGrup();
            //LlenarMoneda();
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        void LlenarCultivos()
        {
            cbo_cultivo.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDCULTIVO ID,LTRIM(RTRIM(DESCRIPCION))DESCRIPCION FROM P_CULTIVOS ORDER BY IDCULTIVO ASC");
            cbo_cultivo.Properties.ValueMember = "ID";
            cbo_cultivo.Properties.DisplayMember = "DESCRIPCION";
        }
        void LlenarVariedades(string idcultivo)
        {
            cbo_variedad.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDVARIEDAD ID,LTRIM(RTRIM(DESCRIPCION))DESCRIPCION  FROM P_VARIEDADES_CULTIVOS WHERE IDCULTIVO='" + idcultivo+"'ORDER BY IDVARIEDAD ASC");
            cbo_variedad.Properties.ValueMember = "ID";
            cbo_variedad.Properties.DisplayMember = "DESCRIPCION";
        }
        void LlenarEstructuras()
        {
            cbo_estructura.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDESTRUCTURA ID , LTRIM(RTRIM(DESCRIPCION))DESCRIPCION FROM P_ESTRUCTURA ORDER BY IDESTRUCTURA ASC");
            cbo_estructura.Properties.ValueMember = "ID";
            cbo_estructura.Properties.DisplayMember = "DESCRIPCION";
        }
        void LlenarTipoCosto()
        {
            cbo_tipocosto.Properties.DataSource = NFunciones.TABLADATOS("SELECT IdTipoCosto ID,LTRIM(RTRIM(DESCRIPCION))DESCRIPCION FROM P_TCOSTO ORDER BY IdTipoCosto ASC");
            cbo_tipocosto.Properties.ValueMember = "ID";
            cbo_tipocosto.Properties.DisplayMember = "DESCRIPCION";
        }
        void LlenarItem()
        {
            cbo_item.Properties.DataSource = NFunciones.TABLADATOS("SELECT IdItemCosto ID, LTRIM(RTRIM(DESCRIPCION))DESCRIPCION  FROM P_ICOSTO ORDER BY IdItemCosto ASC");
            cbo_item.Properties.ValueMember = "ID";
            cbo_item.Properties.DisplayMember = "DESCRIPCION";
        }
        void LlenarObjetivos()
        {
            cbo_fundo.Properties.DataSource = NFunciones.TABLADATOS(" SELECT IDFUNDO ID,LTRIM(RTRIM(DESCRIPCION))DESCRIPCION FROM P_FUNDO ORDER BY IDFUNDO ASC");
            cbo_fundo.Properties.ValueMember = "ID";
            cbo_fundo.Properties.DisplayMember = "DESCRIPCION";
        }
        void LlenarActiGrup()
        {
            cbo_actisub.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDACTIVIDAD ID,DESCRIPCION,CASE ES_SUBGRUPO WHEN 0 THEN 'ACTIVADES' ELSE 'GRUPO PRODUCTOS' END TIPO FROM P_ACTIV ORDER BY ES_SUBGRUPO,IDACTIVIDAD ASC");
            cbo_actisub.Properties.ValueMember = "ID";
            cbo_actisub.Properties.DisplayMember = "DESCRIPCION";
        }
        void LlenarLotes(string idfundo)
        {
            cbo_lote.Properties.DataSource = NFunciones.TABLADATOS("SELECT IdLote ID , LTRIM(RTRIM(Descripción))DESCRIPCION FROM  P_LOTE WHERE ID_FUNDO='"+idfundo+"' ORDER BY ID_FUNDO,IDCULTIVO,Idparcela,IdLote ASC");
            cbo_lote.Properties.ValueMember = "ID";
            cbo_lote.Properties.DisplayMember = "DESCRIPCION";
        }
        void LlenarLaborpro(string idgrupo)
        {
            cbo_labor.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDLABORPROD ID,RTRIM(LTRIM(DESCRIPCION))DESCRIPCION FROM P_LABORPRODUCT WHERE IDACTIVIDAD='" + idgrupo + "' ORDER BY IDLABORPROD ASC");
            cbo_labor.Properties.ValueMember = "ID";
            cbo_labor.Properties.DisplayMember = "DESCRIPCION";
        }
        void LlenarMoneda()
        {
            cbo_moneda.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDMONEDA ID ,RTRIM(LTRIM(NOMBRE_CORTO))DESCRIPCION FROM P_MONEDAS ORDER BY IDMONEDA ASC");
            cbo_moneda.Properties.ValueMember = "ID";
            cbo_moneda.Properties.DisplayMember = "DESCRIPCION";
        }

        private void cbo_cultivo_EditValueChanged(object sender, EventArgs e)
        {
            LlenarVariedades(Convert.ToString(cbo_cultivo.EditValue));
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (modo.Equals("S"))
            {
                modo = "N";
                barra_progreso.Visible = false;
                dtg_datos.DataSource = tbgeneral;

                bloquearCombos(true);
                timer1.Stop();
            }
            else
            {
                barra_progreso.Visible = true;
            }
        }

        // combos detalles de grillas

        void LlenarCultivos_grilla()
        {
            cbo_cultivo_detalle.DataSource = NFunciones.TABLADATOS("SELECT IDCULTIVO ID,DESCRIPCION FROM P_CULTIVOS ORDER BY IDCULTIVO ASC");
            cbo_cultivo_detalle.ValueMember = "ID";
            cbo_cultivo_detalle.DisplayMember = "DESCRIPCION";
        }
        void LlenarVariedades_grilla(string idcultivo)
        {
            cbo_variedad_detalle.DataSource = NFunciones.TABLADATOS("SELECT IDVARIEDAD ID,DESCRIPCION  FROM P_VARIEDADES_CULTIVOS WHERE IDCULTIVO='" + idcultivo + "'ORDER BY IDVARIEDAD ASC");
            cbo_variedad_detalle.ValueMember = "ID";
            cbo_variedad_detalle.DisplayMember = "DESCRIPCION";
        }

        private void cbo_cultivo_detalle_EditValueChanged(object sender, EventArgs e)
        {
            string idcultivo = Convert.ToString(vista_datos2.GetFocusedRowCellValue("IdCultivo"));
            LlenarVariedades_grilla(idcultivo);
        }
        void LlenarEtapa_grilla()
        {
            cbo_etapa_detalle.DataSource = NFunciones.TABLADATOS("SELECT IDETAPA ID ,RTRIM(LTRIM(DESCRIPCION)) DESCRIPCION FROM P_ETAPA ORDER BY IDETAPA ASC");
            cbo_etapa_detalle.ValueMember = "ID";
            cbo_etapa_detalle.DisplayMember = "DESCRIPCION";
        }

        void Llenarobjetivo_grilla()
        {
            cbo_objetivos_detalle.DataSource = NFunciones.TABLADATOS("SELECT IDOBJETIVO ID , RTRIM(LTRIM(DESCRIPCION)) DESCRIPCION  FROM P_OBJETIVOS ORDER BY IDOBJETIVO ASC");
            cbo_objetivos_detalle.ValueMember = "ID";
            cbo_objetivos_detalle.DisplayMember = "DESCRIPCION";
        }
        void LlenarTipoCosto_grilla()
        {
            cbo_tipocosto_detalle.DataSource = NFunciones.TABLADATOS("SELECT IdItemCosto ID,RTRIM(LTRIM(DESCRIPCION)) DESCRIPCION  FROM P_ICOSTO ORDER BY IdItemCosto ASC");
            cbo_tipocosto_detalle.ValueMember = "ID";
            cbo_tipocosto_detalle.DisplayMember = "DESCRIPCION";
        }

        void LlenarEstructura_grilla()
        {
            cbo_estructura_detalle.DataSource = NFunciones.TABLADATOS("  SELECT IDESTRUCTURA ID,RTRIM(LTRIM(DESCRIPCION)) DESCRIPCION  FROM P_ESTRUCTURA ORDER BY IDESTRUCTURA ASC");
            cbo_estructura_detalle.ValueMember = "ID";
            cbo_estructura_detalle.DisplayMember = "DESCRIPCION";
        }

        private void vista_datos_ShownEditor(object sender, EventArgs e)
        {
            ColumnView view = (ColumnView)sender;
            if (view.FocusedColumn.FieldName == "idsubitemcosto")
            {
                LookUpEdit editor = (LookUpEdit)view.ActiveEditor;
                string tipocosto = Convert.ToString(view.GetFocusedRowCellValue("IdItemCosto"));
                editor.Properties.DataSource = NFunciones.TABLADATOS("SELECT IdSubItemCosto  ID,RTRIM(LTRIM(DESCRIPCION)) DESCRIPCION  FROM P_SUB_ICOSTO WHERE IdItemCosto='" + tipocosto + "'");
                editor.Properties.ValueMember = "ID";
                editor.Properties.DisplayMember = "DESCRIPCION";
            }
          if (view.FocusedColumn.FieldName == "IdLaborProducto")
            {
                LookUpEdit editor = (LookUpEdit)view.ActiveEditor;
                string actividad = Convert.ToString(view.GetFocusedRowCellValue("IdActividadSubGru"));
                editor.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDLABORPROD ID,RTRIM(LTRIM(DESCRIPCION)) DESCRIPCION  FROM P_LABORPRODUCT WHERE IDACTIVIDAD='" + actividad+"' ORDER BY IDLABORPROD ASC");
                editor.Properties.ValueMember = "ID";
                editor.Properties.DisplayMember = "DESCRIPCION";
            }
            

        }

        private void cbo_tipocosto_detalle_EditValueChanged(object sender, EventArgs e)
        {
            this.vista_datos2.PostEditor();
            this.vista_datos2.SetFocusedRowCellValue("idsubitemcosto", null);


        }

        void LlenarSubItemcostos_grilla()
        {
            cbo_subitem_detalle.DataSource = NFunciones.TABLADATOS("SELECT IdSubItemCosto  ID,RTRIM(LTRIM(DESCRIPCION)) DESCRIPCION  FROM P_SUB_ICOSTO ");
            cbo_subitem_detalle.ValueMember = "ID";
            cbo_subitem_detalle.DisplayMember = "DESCRIPCION";
        }
        void LlenarActividad_grilla()
        {
            cbo_actividad_detalle.DataSource = NFunciones.TABLADATOS("SELECT  IDACTIVIDAD ID , RTRIM(LTRIM(DESCRIPCION)) DESCRIPCION FROM P_ACTIV ORDER BY IDACTIVIDAD ASC");
            cbo_actividad_detalle.ValueMember = "ID";
            cbo_actividad_detalle.DisplayMember = "DESCRIPCION";
        }
        void Llenarsubitem(string item)
        {
            cbo_subitemcosto.Properties.DataSource = NFunciones.TABLADATOS("SELECT  IDSUBITEMCOSTO ID , RTRIM(LTRIM(DESCRIPCION)) DESCRIPCION FROM P_SUB_ICOSTO WHERE IDITEMCOSTO='" + item+"' ORDER BY IDSUBITEMCOSTO ASC");
            cbo_subitemcosto.Properties.ValueMember = "ID";
            cbo_subitemcosto.Properties.DisplayMember = "DESCRIPCION";
        }

        void LlenarLaborProc_grilla()
        {
            cbo_laborprod_detalle.DataSource = NFunciones.TABLADATOS("SELECT IDLABORPROD ID,RTRIM(LTRIM(DESCRIPCION)) DESCRIPCION FROM P_LABORPRODUCT ORDER BY IDLABORPROD ASC");
            cbo_laborprod_detalle.ValueMember = "ID";
            cbo_laborprod_detalle.DisplayMember = "DESCRIPCION";
        }
        void LlenarMoneda_grilla()
        {
            cbo_moneda_detalle.DataSource = NFunciones.TABLADATOS("SELECT IDMONEDA ID,RTRIM(LTRIM(NOMBRE_CORTO)) DESCRIPCION FROM P_MONEDAS ORDER BY IDMONEDA ASC");
            cbo_moneda_detalle.ValueMember = "ID";
            cbo_moneda_detalle.DisplayMember = "DESCRIPCION";
            
        }

        private void cbo_actividad_detalle_EditValueChanged(object sender, EventArgs e)
        {
            this.vista_datos2.PostEditor();
            this.vista_datos2.SetFocusedRowCellValue("IdLaborProducto", null);
        }

        private void vista_datos_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            GridView view = sender as GridView;
            // Check whether a row is right-clicked.
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                int rowHandle = e.HitInfo.RowHandle;
                // Delete existing menu items, if any.
                e.Menu.Items.Clear();
                // Add a submenu with a single menu item.
                e.Menu.Items.Add(CreateRowSubMenuGrafico(view, rowHandle));
                // Add a check menu item.
                // DXMenuItem item = CreateMergingEnabledMenuItem(view, rowHandle);
                //   item.BeginGroup = true;
                // e.Menu.Items.Add(item);
            }
        }

        DXMenuItem CreateRowSubMenuGrafico(GridView view, int rowHandle)
        {
            DXSubMenuItem subMenu = new DXSubMenuItem("Operaciones");

            DXMenuItem menuItemGrafico = new DXMenuItem("&Agregar Nuevo Detalle",
            new EventHandler(AgregarGrilla), imageCollection1.Images[0]);
            menuItemGrafico.Tag = new RowInfo(view, rowHandle);
            subMenu.Items.Add(menuItemGrafico);

           

            DXMenuItem menuItemGraficoLabor = new DXMenuItem("&Eliminar Detalle",
            new EventHandler(EliminarGrilla), imageCollection1.Images[1]);
            menuItemGraficoLabor.Tag = new RowInfo(view, rowHandle);
            subMenu.Items.Add(menuItemGraficoLabor);


            return subMenu;
        }
        //The handler for the MergingEnabled menu item
        void OnMergingEnabledClick(object sender, EventArgs e)
        {
            DXMenuCheckItem item = sender as DXMenuCheckItem;
            RowInfo info = item.Tag as RowInfo;
            info.View.OptionsView.AllowCellMerge = item.Checked;
        }

        class RowInfo
        {
            public RowInfo(GridView view, int rowHandle)
            {
                this.RowHandle = rowHandle;
                this.View = view;
            }
            public GridView View;
            public int RowHandle;
        }
        void AgregarGrilla(object sender, EventArgs e)
        {

        }
        void EliminarGrilla(object sender, EventArgs e)
        {

        }

        private void cbo_actisub_EditValueChanged(object sender, EventArgs e)
        {
            LlenarLaborpro(Convert.ToString(cbo_labor.EditValue));
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (vista_datos2.DataRowCount>0)
            {
               

                barra_progreso.Visible = true;
                barra_progreso.Caption = @"Actualizando";
                dtg_datos.DataSource = null;

                modo = "N";

                if (chk_lote.Checked)
                {
                    Thread Hilo = new Thread(edit_mostrarDatos_lote);
                    Hilo.Start();
                    timer1.Start();
                }
                else
                {
                    Thread Hilo = new Thread(edit_mostrarDatos_variedad);
                    Hilo.Start();
                    timer1.Start();
                }
            }


        }

        private void vista_datos_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;
            //MessageBox.Show(view == null ? "NO TIENE DETALLE" : "SI TIENE DETALLE");

            //if (e.Column.Caption != "CANTIDAD") return;

            if (view != null)
            {
                string id = view.GetRowCellValue(view.FocusedRowHandle, COL_ID).ToString();
                decimal cantidad = Convert.ToDecimal( view.GetRowCellValue(view.FocusedRowHandle, COL_CANTIDAD).ToString());
                decimal costo = Convert.ToDecimal(view.GetRowCellValue(view.FocusedRowHandle, COL_PRECIO).ToString());


                if (chk_variedad.Checked)
                {
                    ConsultaSql = ConsultaSql + "   UPDATE P_DPRESUPUESTO_RG SET CANTIDAD='"+cantidad+"', costo='"+costo+"' WHERE IDDETALLE='"+id+"'";
                    ConsultaSql = ConsultaSql + "   UPDATE P_PROCESADO_DPRESUPUESTO_RG SET CANTIDAD='" + cantidad + "', PRECIO_ORIGEN='" + costo + "' WHERE IDREF='" + id + "' AND TABLA='V'";
                   
                }
                if (chk_lote.Checked)
                {
                    ConsultaSql = ConsultaSql + "   UPDATE P_DPRESUPUESTO_LOTE SET CANTIDAD='" + cantidad + "', costo='" + costo + "' WHERE IDDETALLE='" + id + "'";
                    ConsultaSql = ConsultaSql + "   UPDATE P_PROCESADO_DPRESUPUESTO_RG SET CANTIDAD='" + cantidad + "', PRECIO_ORIGEN='" + costo + "' WHERE IDREF='" + id + "'  AND TABLA='L'";
                  
                }

               
            }

        }

        private void chk_variedad_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_variedad.Checked)
            {
                chk_lote.Checked = false;
                cbo_lote.Enabled = false;
                tabla = "V";
            }
        }

        private void chk_lote_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_lote.Checked)
            {
                chk_variedad.Checked = false;
                cbo_lote.Enabled = true;
                tabla = "L";

            }
        }

        private void cbo_fundo_EditValueChanged(object sender, EventArgs e)
        {
            LlenarLotes(Convert.ToString(cbo_fundo.EditValue));
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbo_item_EditValueChanged(object sender, EventArgs e)
        {
            Llenarsubitem(Convert.ToString(cbo_item.EditValue));
        }

        private void cbo_tipocosto_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cbo_subitemcosto_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            string ruta = "c:\\DATA";
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }



            DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.DataAware;
            var pivotExportOptions = new PivotXlsxExportOptions { ExportType = DevExpress.Export.ExportType.WYSIWYG };
            string doc = "c:\\DATA\\Tmpdetafiltro" + DateTime.Now.Millisecond.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + ".xlsx";
            dtg_datos.ExportToXlsx(doc, pivotExportOptions);


            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "EXCEL.EXE",
                Arguments = doc
            };
            Process.Start(startInfo);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Frm_ImportarDetallePresupuesto objform = new Frm_ImportarDetallePresupuesto();
            objform.ShowDialog();
        }

        private void vista_datos2_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {

        }
    }
}
