namespace ModuloPresupuesto
{
    partial class Frm_DescargarDeta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DescargarDeta));
            this.cbo_presupuesto = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_generarplantilla = new DevExpress.XtraEditors.SimpleButton();
            this.chk_lote = new DevExpress.XtraEditors.CheckEdit();
            this.chk_variedad = new DevExpress.XtraEditors.CheckEdit();
            this.bar_progreso = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtg_datos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_LOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lb_correlativo = new Ambiance.Ambiance_Label();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_presupuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_lote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_variedad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_progreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_presupuesto
            // 
            this.cbo_presupuesto.Location = new System.Drawing.Point(12, 47);
            this.cbo_presupuesto.Name = "cbo_presupuesto";
            this.cbo_presupuesto.Properties.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_presupuesto.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbo_presupuesto.Properties.Appearance.Options.UseFont = true;
            this.cbo_presupuesto.Properties.Appearance.Options.UseForeColor = true;
            this.cbo_presupuesto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_presupuesto.Properties.NullText = "[Seleccione..]";
            this.cbo_presupuesto.Size = new System.Drawing.Size(265, 22);
            this.cbo_presupuesto.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(89, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 15);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Presupuesto";
            // 
            // btn_generarplantilla
            // 
            this.btn_generarplantilla.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generarplantilla.Appearance.Options.UseFont = true;
            this.btn_generarplantilla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_generarplantilla.ImageOptions.Image")));
            this.btn_generarplantilla.Location = new System.Drawing.Point(30, 103);
            this.btn_generarplantilla.Name = "btn_generarplantilla";
            this.btn_generarplantilla.Size = new System.Drawing.Size(226, 43);
            this.btn_generarplantilla.TabIndex = 11;
            this.btn_generarplantilla.Text = "Generar archivo";
            this.btn_generarplantilla.Click += new System.EventHandler(this.btn_generarplantilla_Click);
            // 
            // chk_lote
            // 
            this.chk_lote.Location = new System.Drawing.Point(12, 137);
            this.chk_lote.Name = "chk_lote";
            this.chk_lote.Properties.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_lote.Properties.Appearance.Options.UseFont = true;
            this.chk_lote.Properties.Caption = "Detalle especifico por lote";
            this.chk_lote.Size = new System.Drawing.Size(227, 20);
            this.chk_lote.TabIndex = 10;
            this.chk_lote.Visible = false;
            this.chk_lote.CheckedChanged += new System.EventHandler(this.chk_lote_CheckedChanged);
            // 
            // chk_variedad
            // 
            this.chk_variedad.Location = new System.Drawing.Point(12, 101);
            this.chk_variedad.Name = "chk_variedad";
            this.chk_variedad.Properties.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_variedad.Properties.Appearance.Options.UseFont = true;
            this.chk_variedad.Properties.Caption = "Detalle por Variedad";
            this.chk_variedad.Size = new System.Drawing.Size(206, 20);
            this.chk_variedad.TabIndex = 9;
            this.chk_variedad.Visible = false;
            this.chk_variedad.CheckedChanged += new System.EventHandler(this.chk_variedad_CheckedChanged);
            // 
            // bar_progreso
            // 
            this.bar_progreso.EditValue = "Cargando..";
            this.bar_progreso.Location = new System.Drawing.Point(-4, 179);
            this.bar_progreso.Name = "bar_progreso";
            this.bar_progreso.Size = new System.Drawing.Size(288, 18);
            this.bar_progreso.TabIndex = 12;
            this.bar_progreso.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dtg_datos
            // 
            this.dtg_datos.Location = new System.Drawing.Point(12, 312);
            this.dtg_datos.MainView = this.gridView1;
            this.dtg_datos.Name = "dtg_datos";
            this.dtg_datos.Size = new System.Drawing.Size(904, 327);
            this.dtg_datos.TabIndex = 13;
            this.dtg_datos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn19,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn22,
            this.COL_LOTE});
            this.gridView1.GridControl = this.dtg_datos;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "ID";
            this.gridColumn19.FieldName = "IdDetalle";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 18;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "IDEMPRESA";
            this.gridColumn1.FieldName = "IdEmpresa";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "IDPRESUPUESTO";
            this.gridColumn2.FieldName = "idPresupuesto";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "IDCULTIVO";
            this.gridColumn3.FieldName = "IDCULTIVO";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "IDVARIABLE";
            this.gridColumn4.FieldName = "IdVariedad";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "IDETAPA";
            this.gridColumn5.FieldName = "IdEtapa";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "IDESTRUCTURA";
            this.gridColumn6.FieldName = "IdEstructura";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "IDTIPOCOSTO";
            this.gridColumn7.FieldName = "IdTipoCosto";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "IDITEMCOSTO";
            this.gridColumn8.FieldName = "IdItemCosto";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "IDACTIVIDADSUBGRUP";
            this.gridColumn9.FieldName = "IdActividadSubGru";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "IDLABORPRODUCTO";
            this.gridColumn10.FieldName = "IdLaborProducto";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "IDUNIDAD";
            this.gridColumn11.FieldName = "IdUnidad";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 10;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "CON_IGV";
            this.gridColumn12.FieldName = "con_igv";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 11;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "PERIODO";
            this.gridColumn13.FieldName = "Periodo";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 12;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "SEMANA";
            this.gridColumn14.FieldName = "semana";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 13;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "CANTIDAD";
            this.gridColumn15.FieldName = "Cantidad";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 14;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "COSTO";
            this.gridColumn16.FieldName = "Costo";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 15;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "IDMONEDA";
            this.gridColumn17.FieldName = "IdMoneda";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 16;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "DIAS_PAGO";
            this.gridColumn18.FieldName = "dias_pago";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 17;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "IDOBJETIVO";
            this.gridColumn20.FieldName = "IDOBJETIVO";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 19;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "IDSUBITEMCOSTO";
            this.gridColumn21.FieldName = "IdSubItemCosto";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 20;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "IDFUNDO";
            this.gridColumn22.FieldName = "IDFUNDO";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 21;
            // 
            // COL_LOTE
            // 
            this.COL_LOTE.Caption = "IDLOTE";
            this.COL_LOTE.FieldName = "IdLote";
            this.COL_LOTE.Name = "COL_LOTE";
            this.COL_LOTE.Visible = true;
            this.COL_LOTE.VisibleIndex = 22;
            // 
            // lb_correlativo
            // 
            this.lb_correlativo.AutoSize = true;
            this.lb_correlativo.BackColor = System.Drawing.Color.Transparent;
            this.lb_correlativo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lb_correlativo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lb_correlativo.Location = new System.Drawing.Point(85, 153);
            this.lb_correlativo.Name = "lb_correlativo";
            this.lb_correlativo.Size = new System.Drawing.Size(63, 20);
            this.lb_correlativo.TabIndex = 14;
            this.lb_correlativo.Text = "######";
            // 
            // Frm_DescargarDeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 193);
            this.Controls.Add(this.lb_correlativo);
            this.Controls.Add(this.dtg_datos);
            this.Controls.Add(this.bar_progreso);
            this.Controls.Add(this.btn_generarplantilla);
            this.Controls.Add(this.chk_lote);
            this.Controls.Add(this.chk_variedad);
            this.Controls.Add(this.cbo_presupuesto);
            this.Controls.Add(this.labelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_DescargarDeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descargar Detalle Presupuesto";
            this.Load += new System.EventHandler(this.Frm_DescargarDeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_presupuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_lote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_variedad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_progreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit cbo_presupuesto;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_generarplantilla;
        private DevExpress.XtraEditors.CheckEdit chk_lote;
        private DevExpress.XtraEditors.CheckEdit chk_variedad;
        private DevExpress.XtraEditors.MarqueeProgressBarControl bar_progreso;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraGrid.GridControl dtg_datos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn COL_LOTE;
        private Ambiance.Ambiance_Label lb_correlativo;
    }
}