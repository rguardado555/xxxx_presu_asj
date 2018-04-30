namespace ModuloPresupuesto
{
    partial class rpt_GastoFijo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_GastoFijo));
            this.barrar_progreso = new DevExpress.XtraWaitForm.ProgressPanel();
            this.LB_TITULO = new System.Windows.Forms.Label();
            this.cbo_moneda = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_presupuesto = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pvt_datos2 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.COL_CUENTA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_AREA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_FUNDO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_MONTO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_ITEM = new DevExpress.XtraPivotGrid.PivotGridField();
            this.btn_exportarexcel = new MonoFlat.MonoFlat_Button();
            this.btn_consultarReporte = new MonoFlat.MonoFlat_Button();
            this.COL_TIPO = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_moneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_presupuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvt_datos2)).BeginInit();
            this.SuspendLayout();
            // 
            // barrar_progreso
            // 
            this.barrar_progreso.Appearance.BackColor = System.Drawing.Color.White;
            this.barrar_progreso.Appearance.ForeColor = System.Drawing.Color.Black;
            this.barrar_progreso.Appearance.Options.UseBackColor = true;
            this.barrar_progreso.Appearance.Options.UseForeColor = true;
            this.barrar_progreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.barrar_progreso.BarAnimationElementThickness = 2;
            this.barrar_progreso.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barrar_progreso.Caption = "Un momento";
            this.barrar_progreso.CaptionToDescriptionDistance = 5;
            this.barrar_progreso.Description = "Cargando ...";
            this.barrar_progreso.FrameCount = 45000;
            this.barrar_progreso.FrameInterval = 1200;
            this.barrar_progreso.LineAnimationElementHeight = 30;
            this.barrar_progreso.LineAnimationElementType = DevExpress.Utils.Animation.LineAnimationElementType.Triangle;
            this.barrar_progreso.Location = new System.Drawing.Point(578, 333);
            this.barrar_progreso.Name = "barrar_progreso";
            this.barrar_progreso.RingAnimationDiameter = 60;
            this.barrar_progreso.Size = new System.Drawing.Size(166, 66);
            this.barrar_progreso.TabIndex = 156;
            this.barrar_progreso.Visible = false;
            this.barrar_progreso.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring;
            // 
            // LB_TITULO
            // 
            this.LB_TITULO.AutoSize = true;
            this.LB_TITULO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.LB_TITULO.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TITULO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_TITULO.Location = new System.Drawing.Point(461, 42);
            this.LB_TITULO.Name = "LB_TITULO";
            this.LB_TITULO.Size = new System.Drawing.Size(192, 30);
            this.LB_TITULO.TabIndex = 155;
            this.LB_TITULO.Text = "Reporte Gasto Fijo";
            // 
            // cbo_moneda
            // 
            this.cbo_moneda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_moneda.Location = new System.Drawing.Point(298, 10);
            this.cbo_moneda.Name = "cbo_moneda";
            this.cbo_moneda.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_moneda.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbo_moneda.Properties.Appearance.Options.UseFont = true;
            this.cbo_moneda.Properties.Appearance.Options.UseForeColor = true;
            this.cbo_moneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_moneda.Properties.NullText = "[Seleccionar..]";
            this.cbo_moneda.Size = new System.Drawing.Size(123, 24);
            this.cbo_moneda.TabIndex = 149;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(234, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 148;
            this.label3.Text = "Moneda";
            // 
            // cbo_presupuesto
            // 
            this.cbo_presupuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_presupuesto.Location = new System.Drawing.Point(104, 10);
            this.cbo_presupuesto.Name = "cbo_presupuesto";
            this.cbo_presupuesto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_presupuesto.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbo_presupuesto.Properties.Appearance.Options.UseFont = true;
            this.cbo_presupuesto.Properties.Appearance.Options.UseForeColor = true;
            this.cbo_presupuesto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_presupuesto.Properties.NullText = "[Seleccionar..]";
            this.cbo_presupuesto.Size = new System.Drawing.Size(124, 24);
            this.cbo_presupuesto.TabIndex = 146;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 145;
            this.label1.Text = "Presupuesto";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pvt_datos2
            // 
            this.pvt_datos2.ActiveFilterString = "";
            this.pvt_datos2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pvt_datos2.Appearance.Cell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvt_datos2.Appearance.Cell.Options.UseFont = true;
            this.pvt_datos2.Appearance.ColumnHeaderArea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvt_datos2.Appearance.ColumnHeaderArea.Options.UseFont = true;
            this.pvt_datos2.Appearance.FieldValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvt_datos2.Appearance.FieldValue.Options.UseFont = true;
            this.pvt_datos2.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.COL_CUENTA,
            this.COL_AREA,
            this.COL_FUNDO,
            this.COL_MONTO,
            this.COL_ITEM,
            this.COL_TIPO});
            this.pvt_datos2.ForeColor = System.Drawing.Color.Black;
            this.pvt_datos2.Location = new System.Drawing.Point(2, 92);
            this.pvt_datos2.Name = "pvt_datos2";
            this.pvt_datos2.Size = new System.Drawing.Size(1318, 638);
            this.pvt_datos2.TabIndex = 157;
            this.pvt_datos2.CellDoubleClick += new DevExpress.XtraPivotGrid.PivotCellEventHandler(this.pvt_datos2_CellDoubleClick);
            // 
            // COL_CUENTA
            // 
            this.COL_CUENTA.Appearance.Cell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_CUENTA.Appearance.Cell.ForeColor = System.Drawing.Color.Black;
            this.COL_CUENTA.Appearance.Cell.Options.UseFont = true;
            this.COL_CUENTA.Appearance.Cell.Options.UseForeColor = true;
            this.COL_CUENTA.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_CUENTA.AreaIndex = 2;
            this.COL_CUENTA.Caption = "CUENTA";
            this.COL_CUENTA.FieldName = "TCUENTA";
            this.COL_CUENTA.Name = "COL_CUENTA";
            this.COL_CUENTA.Width = 150;
            // 
            // COL_AREA
            // 
            this.COL_AREA.Appearance.Cell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_AREA.Appearance.Cell.ForeColor = System.Drawing.Color.Black;
            this.COL_AREA.Appearance.Cell.Options.UseFont = true;
            this.COL_AREA.Appearance.Cell.Options.UseForeColor = true;
            this.COL_AREA.Appearance.CellGrandTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_AREA.Appearance.CellGrandTotal.Options.UseFont = true;
            this.COL_AREA.Appearance.CellTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_AREA.Appearance.CellTotal.Options.UseFont = true;
            this.COL_AREA.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_AREA.Appearance.Header.Options.UseFont = true;
            this.COL_AREA.Appearance.Value.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_AREA.Appearance.Value.Options.UseFont = true;
            this.COL_AREA.Appearance.ValueGrandTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_AREA.Appearance.ValueGrandTotal.Options.UseFont = true;
            this.COL_AREA.Appearance.ValueTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_AREA.Appearance.ValueTotal.Options.UseFont = true;
            this.COL_AREA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_AREA.AreaIndex = 1;
            this.COL_AREA.Caption = "AREA";
            this.COL_AREA.FieldName = "AREA";
            this.COL_AREA.Name = "COL_AREA";
            this.COL_AREA.Width = 250;
            // 
            // COL_FUNDO
            // 
            this.COL_FUNDO.Appearance.Cell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_FUNDO.Appearance.Cell.ForeColor = System.Drawing.Color.Black;
            this.COL_FUNDO.Appearance.Cell.Options.UseFont = true;
            this.COL_FUNDO.Appearance.Cell.Options.UseForeColor = true;
            this.COL_FUNDO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_FUNDO.AreaIndex = 1;
            this.COL_FUNDO.Caption = "FUNDO";
            this.COL_FUNDO.FieldName = "FUNDO";
            this.COL_FUNDO.Name = "COL_FUNDO";
            this.COL_FUNDO.Width = 150;
            // 
            // COL_MONTO
            // 
            this.COL_MONTO.Appearance.Cell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_MONTO.Appearance.Cell.ForeColor = System.Drawing.Color.Black;
            this.COL_MONTO.Appearance.Cell.Options.UseFont = true;
            this.COL_MONTO.Appearance.Cell.Options.UseForeColor = true;
            this.COL_MONTO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.COL_MONTO.AreaIndex = 0;
            this.COL_MONTO.Caption = "MONTO";
            this.COL_MONTO.CellFormat.FormatString = "N2";
            this.COL_MONTO.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_MONTO.FieldName = "MONTO";
            this.COL_MONTO.GrandTotalCellFormat.FormatString = "N2";
            this.COL_MONTO.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_MONTO.Name = "COL_MONTO";
            this.COL_MONTO.TotalCellFormat.FormatString = "N2";
            this.COL_MONTO.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_MONTO.TotalValueFormat.FormatString = "N2";
            this.COL_MONTO.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_MONTO.ValueFormat.FormatString = "N2";
            this.COL_MONTO.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_MONTO.Width = 150;
            // 
            // COL_ITEM
            // 
            this.COL_ITEM.Appearance.Cell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_ITEM.Appearance.Cell.ForeColor = System.Drawing.Color.Black;
            this.COL_ITEM.Appearance.Cell.Options.UseFont = true;
            this.COL_ITEM.Appearance.Cell.Options.UseForeColor = true;
            this.COL_ITEM.Appearance.CellGrandTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_ITEM.Appearance.CellGrandTotal.ForeColor = System.Drawing.Color.Black;
            this.COL_ITEM.Appearance.CellGrandTotal.Options.UseFont = true;
            this.COL_ITEM.Appearance.CellGrandTotal.Options.UseForeColor = true;
            this.COL_ITEM.Appearance.CellTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_ITEM.Appearance.CellTotal.Options.UseFont = true;
            this.COL_ITEM.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_ITEM.Appearance.Header.Options.UseFont = true;
            this.COL_ITEM.Appearance.Value.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_ITEM.Appearance.Value.Options.UseFont = true;
            this.COL_ITEM.Appearance.ValueGrandTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_ITEM.Appearance.ValueGrandTotal.Options.UseFont = true;
            this.COL_ITEM.Appearance.ValueTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_ITEM.Appearance.ValueTotal.Options.UseFont = true;
            this.COL_ITEM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_ITEM.AreaIndex = 0;
            this.COL_ITEM.Caption = "ITEM";
            this.COL_ITEM.FieldName = "ITEM";
            this.COL_ITEM.Name = "COL_ITEM";
            this.COL_ITEM.Width = 250;
            // 
            // btn_exportarexcel
            // 
            this.btn_exportarexcel.BackColor = System.Drawing.Color.Transparent;
            this.btn_exportarexcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportarexcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportarexcel.Image = ((System.Drawing.Image)(resources.GetObject("btn_exportarexcel.Image")));
            this.btn_exportarexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exportarexcel.Location = new System.Drawing.Point(566, 9);
            this.btn_exportarexcel.Name = "btn_exportarexcel";
            this.btn_exportarexcel.Size = new System.Drawing.Size(120, 26);
            this.btn_exportarexcel.TabIndex = 154;
            this.btn_exportarexcel.Text = "Exportar";
            this.btn_exportarexcel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_exportarexcel.Click += new System.EventHandler(this.btn_exportarexcel_Click);
            // 
            // btn_consultarReporte
            // 
            this.btn_consultarReporte.BackColor = System.Drawing.Color.Transparent;
            this.btn_consultarReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consultarReporte.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultarReporte.Image = ((System.Drawing.Image)(resources.GetObject("btn_consultarReporte.Image")));
            this.btn_consultarReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consultarReporte.Location = new System.Drawing.Point(432, 9);
            this.btn_consultarReporte.Name = "btn_consultarReporte";
            this.btn_consultarReporte.Size = new System.Drawing.Size(128, 26);
            this.btn_consultarReporte.TabIndex = 152;
            this.btn_consultarReporte.Text = "Consultar";
            this.btn_consultarReporte.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_consultarReporte.Click += new System.EventHandler(this.btn_consultarReporte_Click);
            // 
            // COL_TIPO
            // 
            this.COL_TIPO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_TIPO.AreaIndex = 0;
            this.COL_TIPO.Caption = "TIPO";
            this.COL_TIPO.FieldName = "TIPO";
            this.COL_TIPO.Name = "COL_TIPO";
            // 
            // rpt_GastoFijo
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 732);
            this.Controls.Add(this.barrar_progreso);
            this.Controls.Add(this.LB_TITULO);
            this.Controls.Add(this.btn_exportarexcel);
            this.Controls.Add(this.btn_consultarReporte);
            this.Controls.Add(this.cbo_moneda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_presupuesto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pvt_datos2);
            this.Name = "rpt_GastoFijo";
            this.Text = "rpt_GastoFijo";
            this.Load += new System.EventHandler(this.rpt_GastoFijo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_moneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_presupuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvt_datos2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraWaitForm.ProgressPanel barrar_progreso;
        private System.Windows.Forms.Label LB_TITULO;
        private MonoFlat.MonoFlat_Button btn_exportarexcel;
        private MonoFlat.MonoFlat_Button btn_consultarReporte;
        private DevExpress.XtraEditors.LookUpEdit cbo_moneda;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LookUpEdit cbo_presupuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraPivotGrid.PivotGridControl pvt_datos2;
        private DevExpress.XtraPivotGrid.PivotGridField COL_CUENTA;
        private DevExpress.XtraPivotGrid.PivotGridField COL_AREA;
        private DevExpress.XtraPivotGrid.PivotGridField COL_FUNDO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_MONTO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_ITEM;
        private DevExpress.XtraPivotGrid.PivotGridField COL_TIPO;
    }
}