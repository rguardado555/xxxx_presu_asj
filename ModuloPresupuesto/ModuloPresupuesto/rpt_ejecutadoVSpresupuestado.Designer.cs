namespace ModuloPresupuesto
{
    partial class rpt_ejecutadoVSpresupuestado
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
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule13 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression13 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings formatRuleTotalTypeSettings13 = new DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings();
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule14 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression14 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_ejecutadoVSpresupuestado));
            DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings formatRuleTotalTypeSettings14 = new DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings();
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule15 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression15 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings formatRuleTotalTypeSettings15 = new DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings();
            this.LB_TITULO = new System.Windows.Forms.Label();
            this.btn_fundocultivo = new MonoFlat.MonoFlat_Button();
            this.btn_fundovariedad = new MonoFlat.MonoFlat_Button();
            this.cbo_moneda = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.pvt_datos2 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.COL_IDPRESUPUESTO2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_IDITEM2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_ITEM2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_IDGRUPO2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_GRUPO2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_TIPO2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_VALOR2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_IDCULTIVO2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_CULTIVO2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_IDVARIEDAD2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_VARIEDAD2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_IDFUNDO2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_FUNDO2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.TOTAL = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_ESTRUCTURA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.cbo_presupuesto = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exportarexcel = new MonoFlat.MonoFlat_Button();
            this.btn_editardetalle = new MonoFlat.MonoFlat_Button();
            this.btn_consultarReporte = new MonoFlat.MonoFlat_Button();
            this.barrar_progreso = new DevExpress.XtraWaitForm.ProgressPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_moneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvt_datos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_presupuesto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_TITULO
            // 
            this.LB_TITULO.AutoSize = true;
            this.LB_TITULO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.LB_TITULO.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TITULO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_TITULO.Location = new System.Drawing.Point(461, 42);
            this.LB_TITULO.Name = "LB_TITULO";
            this.LB_TITULO.Size = new System.Drawing.Size(346, 30);
            this.LB_TITULO.TabIndex = 143;
            this.LB_TITULO.Text = "Reporte Precio por Cantidad - PxQ";
            // 
            // btn_fundocultivo
            // 
            this.btn_fundocultivo.BackColor = System.Drawing.Color.Transparent;
            this.btn_fundocultivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fundocultivo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fundocultivo.Image = null;
            this.btn_fundocultivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fundocultivo.Location = new System.Drawing.Point(950, 9);
            this.btn_fundocultivo.Name = "btn_fundocultivo";
            this.btn_fundocultivo.Size = new System.Drawing.Size(120, 26);
            this.btn_fundocultivo.TabIndex = 139;
            this.btn_fundocultivo.Text = "Fundo y Cultivo";
            this.btn_fundocultivo.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_fundovariedad
            // 
            this.btn_fundovariedad.BackColor = System.Drawing.Color.Transparent;
            this.btn_fundovariedad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fundovariedad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fundovariedad.Image = null;
            this.btn_fundovariedad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fundovariedad.Location = new System.Drawing.Point(825, 9);
            this.btn_fundovariedad.Name = "btn_fundovariedad";
            this.btn_fundovariedad.Size = new System.Drawing.Size(120, 26);
            this.btn_fundovariedad.TabIndex = 138;
            this.btn_fundovariedad.Text = "Fundo y Variedad";
            this.btn_fundovariedad.TextAlignment = System.Drawing.StringAlignment.Center;
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
            this.cbo_moneda.TabIndex = 137;
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
            this.label3.TabIndex = 136;
            this.label3.Text = "Moneda";
            // 
            // pvt_datos2
            // 
            this.pvt_datos2.ActiveFilterString = "";
            this.pvt_datos2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pvt_datos2.Appearance.Cell.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.pvt_datos2.Appearance.Cell.ForeColor = System.Drawing.Color.Black;
            this.pvt_datos2.Appearance.Cell.Options.UseFont = true;
            this.pvt_datos2.Appearance.Cell.Options.UseForeColor = true;
            this.pvt_datos2.Appearance.FieldHeader.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.pvt_datos2.Appearance.FieldHeader.ForeColor = System.Drawing.Color.Black;
            this.pvt_datos2.Appearance.FieldHeader.Options.UseFont = true;
            this.pvt_datos2.Appearance.FieldHeader.Options.UseForeColor = true;
            this.pvt_datos2.Appearance.FieldValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pvt_datos2.Appearance.FieldValue.ForeColor = System.Drawing.Color.Black;
            this.pvt_datos2.Appearance.FieldValue.Options.UseFont = true;
            this.pvt_datos2.Appearance.FieldValue.Options.UseForeColor = true;
            this.pvt_datos2.Appearance.FilterHeaderArea.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pvt_datos2.Appearance.FilterHeaderArea.Options.UseFont = true;
            this.pvt_datos2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pvt_datos2.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.COL_IDPRESUPUESTO2,
            this.COL_IDITEM2,
            this.COL_ITEM2,
            this.COL_IDGRUPO2,
            this.COL_GRUPO2,
            this.COL_TIPO2,
            this.COL_VALOR2,
            this.COL_IDCULTIVO2,
            this.COL_CULTIVO2,
            this.COL_IDVARIEDAD2,
            this.COL_VARIEDAD2,
            this.COL_IDFUNDO2,
            this.COL_FUNDO2,
            this.TOTAL,
            this.COL_ESTRUCTURA});
            pivotGridFormatRule13.Measure = this.COL_VALOR2;
            pivotGridFormatRule13.Name = "Format4";
            formatConditionRuleExpression13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            formatConditionRuleExpression13.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            formatConditionRuleExpression13.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            formatConditionRuleExpression13.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            formatConditionRuleExpression13.Appearance.ForeColor = System.Drawing.Color.Black;
            formatConditionRuleExpression13.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            formatConditionRuleExpression13.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression13.Appearance.Options.UseBorderColor = true;
            formatConditionRuleExpression13.Appearance.Options.UseFont = true;
            formatConditionRuleExpression13.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression13.Expression = "[VARIEDAD] = \'X.TOTAL\'";
            pivotGridFormatRule13.Rule = formatConditionRuleExpression13;
            pivotGridFormatRule13.Settings = formatRuleTotalTypeSettings13;
            pivotGridFormatRule14.Measure = this.COL_VALOR2;
            pivotGridFormatRule14.Name = "Format10";
            formatConditionRuleExpression14.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formatConditionRuleExpression14.Appearance.ForeColor = System.Drawing.Color.Black;
            formatConditionRuleExpression14.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            formatConditionRuleExpression14.Appearance.Options.UseFont = true;
            formatConditionRuleExpression14.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression14.Expression = resources.GetString("formatConditionRuleExpression14.Expression");
            pivotGridFormatRule14.Rule = formatConditionRuleExpression14;
            pivotGridFormatRule14.Settings = formatRuleTotalTypeSettings14;
            pivotGridFormatRule15.Measure = this.COL_VALOR2;
            pivotGridFormatRule15.Name = "Format0";
            formatConditionRuleExpression15.Appearance.BackColor = System.Drawing.Color.Gray;
            formatConditionRuleExpression15.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            formatConditionRuleExpression15.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formatConditionRuleExpression15.Appearance.ForeColor = System.Drawing.Color.Black;
            formatConditionRuleExpression15.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            formatConditionRuleExpression15.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression15.Appearance.Options.UseFont = true;
            formatConditionRuleExpression15.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression15.Expression = "[ITEM] = \'61-COSTO PACKING \' Or [ITEM] = \'47-COSTO CAMPO \' Or [ITEM] = \'41-TOTAL " +
    "COSTO DIRECTO\' Or [ITEM] = \'41-TOTAL COSTO DIRECTO\'";
            pivotGridFormatRule15.Rule = formatConditionRuleExpression15;
            pivotGridFormatRule15.Settings = formatRuleTotalTypeSettings15;
            this.pvt_datos2.FormatRules.Add(pivotGridFormatRule13);
            this.pvt_datos2.FormatRules.Add(pivotGridFormatRule14);
            this.pvt_datos2.FormatRules.Add(pivotGridFormatRule15);
            this.pvt_datos2.Location = new System.Drawing.Point(2, 93);
            this.pvt_datos2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.pvt_datos2.Name = "pvt_datos2";
            this.pvt_datos2.OptionsBehavior.UseAsyncMode = true;
            this.pvt_datos2.OptionsChartDataSource.AutoTransposeChart = true;
            this.pvt_datos2.OptionsCustomization.AllowDrag = false;
            this.pvt_datos2.OptionsCustomization.AllowEdit = false;
            this.pvt_datos2.OptionsCustomization.AllowExpand = false;
            this.pvt_datos2.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.LegacyOptimized;
            this.pvt_datos2.OptionsFilterPopup.ShowOnlyAvailableItems = true;
            this.pvt_datos2.OptionsMenu.EnableFormatRulesMenu = true;
            this.pvt_datos2.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pvt_datos2.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pvt_datos2.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pvt_datos2.OptionsPrint.PrintHorzLines = DevExpress.Utils.DefaultBoolean.True;
            this.pvt_datos2.OptionsPrint.PrintRowHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pvt_datos2.OptionsPrint.PrintVertLines = DevExpress.Utils.DefaultBoolean.True;
            this.pvt_datos2.OptionsView.AllowGlyphSkinning = true;
            this.pvt_datos2.OptionsView.ShowColumnGrandTotalHeader = false;
            this.pvt_datos2.OptionsView.ShowColumnGrandTotals = false;
            this.pvt_datos2.OptionsView.ShowColumnTotals = false;
            this.pvt_datos2.OptionsView.ShowFilterHeaders = false;
            this.pvt_datos2.OptionsView.ShowRowGrandTotalHeader = false;
            this.pvt_datos2.OptionsView.ShowRowGrandTotals = false;
            this.pvt_datos2.OptionsView.ShowRowTotals = false;
            this.pvt_datos2.Size = new System.Drawing.Size(1318, 638);
            this.pvt_datos2.TabIndex = 135;
            // 
            // COL_IDPRESUPUESTO2
            // 
            this.COL_IDPRESUPUESTO2.AreaIndex = 0;
            this.COL_IDPRESUPUESTO2.Caption = "IDPRESUPUESTO";
            this.COL_IDPRESUPUESTO2.FieldName = "IDPRESUPUESTO";
            this.COL_IDPRESUPUESTO2.Name = "COL_IDPRESUPUESTO2";
            this.COL_IDPRESUPUESTO2.Visible = false;
            // 
            // COL_IDITEM2
            // 
            this.COL_IDITEM2.Appearance.Cell.BackColor = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.Cell.BackColor2 = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.Cell.BorderColor = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.Cell.ForeColor = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.Cell.Options.UseBackColor = true;
            this.COL_IDITEM2.Appearance.Cell.Options.UseBorderColor = true;
            this.COL_IDITEM2.Appearance.Cell.Options.UseForeColor = true;
            this.COL_IDITEM2.Appearance.CellGrandTotal.BackColor = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.CellGrandTotal.BackColor2 = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.CellGrandTotal.BorderColor = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.CellGrandTotal.ForeColor = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.CellGrandTotal.Options.UseBackColor = true;
            this.COL_IDITEM2.Appearance.CellGrandTotal.Options.UseBorderColor = true;
            this.COL_IDITEM2.Appearance.CellGrandTotal.Options.UseForeColor = true;
            this.COL_IDITEM2.Appearance.CellTotal.BackColor = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.CellTotal.BackColor2 = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.CellTotal.BorderColor = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.CellTotal.ForeColor = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.CellTotal.Options.UseBackColor = true;
            this.COL_IDITEM2.Appearance.CellTotal.Options.UseBorderColor = true;
            this.COL_IDITEM2.Appearance.CellTotal.Options.UseForeColor = true;
            this.COL_IDITEM2.Appearance.Header.BackColor = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.Header.BackColor2 = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.Header.BorderColor = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.Header.ForeColor = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.Header.Options.UseBackColor = true;
            this.COL_IDITEM2.Appearance.Header.Options.UseBorderColor = true;
            this.COL_IDITEM2.Appearance.Header.Options.UseForeColor = true;
            this.COL_IDITEM2.Appearance.Value.BackColor = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.Value.BackColor2 = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.Value.BorderColor = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.Value.ForeColor = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.Value.Options.UseBackColor = true;
            this.COL_IDITEM2.Appearance.Value.Options.UseBorderColor = true;
            this.COL_IDITEM2.Appearance.Value.Options.UseForeColor = true;
            this.COL_IDITEM2.Appearance.ValueGrandTotal.BackColor = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.ValueGrandTotal.BackColor2 = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.ValueGrandTotal.BorderColor = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.ValueGrandTotal.ForeColor = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.ValueGrandTotal.Options.UseBackColor = true;
            this.COL_IDITEM2.Appearance.ValueGrandTotal.Options.UseBorderColor = true;
            this.COL_IDITEM2.Appearance.ValueGrandTotal.Options.UseForeColor = true;
            this.COL_IDITEM2.Appearance.ValueTotal.BackColor = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.ValueTotal.BackColor2 = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.ValueTotal.BorderColor = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.ValueTotal.ForeColor = System.Drawing.Color.Transparent;
            this.COL_IDITEM2.Appearance.ValueTotal.Options.UseBackColor = true;
            this.COL_IDITEM2.Appearance.ValueTotal.Options.UseBorderColor = true;
            this.COL_IDITEM2.Appearance.ValueTotal.Options.UseForeColor = true;
            this.COL_IDITEM2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_IDITEM2.AreaIndex = 2;
            this.COL_IDITEM2.Caption = "IDITEM";
            this.COL_IDITEM2.FieldName = "IDITEM";
            this.COL_IDITEM2.Name = "COL_IDITEM2";
            this.COL_IDITEM2.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            this.COL_IDITEM2.Visible = false;
            this.COL_IDITEM2.Width = 20;
            // 
            // COL_ITEM2
            // 
            this.COL_ITEM2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_ITEM2.AreaIndex = 1;
            this.COL_ITEM2.Caption = "ITEM";
            this.COL_ITEM2.FieldName = "ITEM";
            this.COL_ITEM2.Name = "COL_ITEM2";
            this.COL_ITEM2.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.None;
            this.COL_ITEM2.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            this.COL_ITEM2.Width = 250;
            // 
            // COL_IDGRUPO2
            // 
            this.COL_IDGRUPO2.Appearance.Cell.BackColor = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.Cell.BackColor2 = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.Cell.BorderColor = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.Cell.ForeColor = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.Cell.Options.UseBackColor = true;
            this.COL_IDGRUPO2.Appearance.Cell.Options.UseBorderColor = true;
            this.COL_IDGRUPO2.Appearance.Cell.Options.UseForeColor = true;
            this.COL_IDGRUPO2.Appearance.CellGrandTotal.BackColor = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.CellGrandTotal.BackColor2 = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.CellGrandTotal.BorderColor = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.CellGrandTotal.ForeColor = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.CellGrandTotal.Options.UseBackColor = true;
            this.COL_IDGRUPO2.Appearance.CellGrandTotal.Options.UseBorderColor = true;
            this.COL_IDGRUPO2.Appearance.CellGrandTotal.Options.UseForeColor = true;
            this.COL_IDGRUPO2.Appearance.CellTotal.BackColor = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.CellTotal.BackColor2 = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.CellTotal.BorderColor = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.CellTotal.ForeColor = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.CellTotal.Options.UseBackColor = true;
            this.COL_IDGRUPO2.Appearance.CellTotal.Options.UseBorderColor = true;
            this.COL_IDGRUPO2.Appearance.CellTotal.Options.UseForeColor = true;
            this.COL_IDGRUPO2.Appearance.Header.BackColor = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.Header.BackColor2 = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.Header.BorderColor = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.Header.ForeColor = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.Header.Options.UseBackColor = true;
            this.COL_IDGRUPO2.Appearance.Header.Options.UseBorderColor = true;
            this.COL_IDGRUPO2.Appearance.Header.Options.UseForeColor = true;
            this.COL_IDGRUPO2.Appearance.Value.BackColor = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.Value.BackColor2 = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.Value.BorderColor = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.Value.ForeColor = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.Value.Options.UseBackColor = true;
            this.COL_IDGRUPO2.Appearance.Value.Options.UseBorderColor = true;
            this.COL_IDGRUPO2.Appearance.Value.Options.UseForeColor = true;
            this.COL_IDGRUPO2.Appearance.ValueGrandTotal.BackColor = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.ValueGrandTotal.BackColor2 = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.ValueGrandTotal.BorderColor = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.ValueGrandTotal.ForeColor = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.ValueGrandTotal.Options.UseBackColor = true;
            this.COL_IDGRUPO2.Appearance.ValueGrandTotal.Options.UseBorderColor = true;
            this.COL_IDGRUPO2.Appearance.ValueGrandTotal.Options.UseForeColor = true;
            this.COL_IDGRUPO2.Appearance.ValueTotal.BackColor = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.ValueTotal.BackColor2 = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.ValueTotal.BorderColor = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.ValueTotal.ForeColor = System.Drawing.Color.Transparent;
            this.COL_IDGRUPO2.Appearance.ValueTotal.Options.UseBackColor = true;
            this.COL_IDGRUPO2.Appearance.ValueTotal.Options.UseBorderColor = true;
            this.COL_IDGRUPO2.Appearance.ValueTotal.Options.UseForeColor = true;
            this.COL_IDGRUPO2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_IDGRUPO2.AreaIndex = 0;
            this.COL_IDGRUPO2.Caption = "IDGRUPO";
            this.COL_IDGRUPO2.FieldName = "IDGRUPO";
            this.COL_IDGRUPO2.Name = "COL_IDGRUPO2";
            this.COL_IDGRUPO2.Options.ShowButtonMode = DevExpress.XtraPivotGrid.PivotShowButtonModeEnum.ShowAlways;
            this.COL_IDGRUPO2.Options.ShowCustomTotals = false;
            this.COL_IDGRUPO2.Options.ShowGrandTotal = false;
            this.COL_IDGRUPO2.Options.ShowInCustomizationForm = false;
            this.COL_IDGRUPO2.Options.ShowTotals = false;
            this.COL_IDGRUPO2.Options.ShowValues = false;
            this.COL_IDGRUPO2.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            this.COL_IDGRUPO2.Visible = false;
            this.COL_IDGRUPO2.Width = 20;
            // 
            // COL_GRUPO2
            // 
            this.COL_GRUPO2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_GRUPO2.AreaIndex = 0;
            this.COL_GRUPO2.Caption = "GRUPO";
            this.COL_GRUPO2.FieldName = "GRUPO";
            this.COL_GRUPO2.Name = "COL_GRUPO2";
            this.COL_GRUPO2.Options.ShowGrandTotal = false;
            this.COL_GRUPO2.Options.ShowTotals = false;
            this.COL_GRUPO2.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.None;
            this.COL_GRUPO2.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            this.COL_GRUPO2.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.COL_GRUPO2.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.COL_GRUPO2.Width = 200;
            // 
            // COL_TIPO2
            // 
            this.COL_TIPO2.Appearance.Cell.BackColor = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.Cell.BackColor2 = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.Cell.BorderColor = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.Cell.ForeColor = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.Cell.Options.UseBackColor = true;
            this.COL_TIPO2.Appearance.Cell.Options.UseBorderColor = true;
            this.COL_TIPO2.Appearance.Cell.Options.UseForeColor = true;
            this.COL_TIPO2.Appearance.CellGrandTotal.BackColor = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.CellGrandTotal.BackColor2 = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.CellGrandTotal.BorderColor = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.CellGrandTotal.ForeColor = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.CellGrandTotal.Options.UseBackColor = true;
            this.COL_TIPO2.Appearance.CellGrandTotal.Options.UseBorderColor = true;
            this.COL_TIPO2.Appearance.CellGrandTotal.Options.UseForeColor = true;
            this.COL_TIPO2.Appearance.CellTotal.BackColor = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.CellTotal.BackColor2 = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.CellTotal.BorderColor = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.CellTotal.ForeColor = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.CellTotal.Options.UseBackColor = true;
            this.COL_TIPO2.Appearance.CellTotal.Options.UseBorderColor = true;
            this.COL_TIPO2.Appearance.CellTotal.Options.UseForeColor = true;
            this.COL_TIPO2.Appearance.Header.BackColor = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.Header.BackColor2 = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.Header.BorderColor = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.Header.ForeColor = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.Header.Options.UseBackColor = true;
            this.COL_TIPO2.Appearance.Header.Options.UseBorderColor = true;
            this.COL_TIPO2.Appearance.Header.Options.UseForeColor = true;
            this.COL_TIPO2.Appearance.Value.BackColor = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.Value.BackColor2 = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.Value.BorderColor = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.Value.ForeColor = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.Value.Options.UseBackColor = true;
            this.COL_TIPO2.Appearance.Value.Options.UseBorderColor = true;
            this.COL_TIPO2.Appearance.Value.Options.UseForeColor = true;
            this.COL_TIPO2.Appearance.ValueGrandTotal.BackColor = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.ValueGrandTotal.BackColor2 = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.ValueGrandTotal.BorderColor = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.ValueGrandTotal.ForeColor = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.ValueGrandTotal.Options.UseBackColor = true;
            this.COL_TIPO2.Appearance.ValueGrandTotal.Options.UseBorderColor = true;
            this.COL_TIPO2.Appearance.ValueGrandTotal.Options.UseForeColor = true;
            this.COL_TIPO2.Appearance.ValueTotal.BackColor = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.ValueTotal.BackColor2 = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.ValueTotal.BorderColor = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.ValueTotal.ForeColor = System.Drawing.Color.Transparent;
            this.COL_TIPO2.Appearance.ValueTotal.Options.UseBackColor = true;
            this.COL_TIPO2.Appearance.ValueTotal.Options.UseBorderColor = true;
            this.COL_TIPO2.Appearance.ValueTotal.Options.UseForeColor = true;
            this.COL_TIPO2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_TIPO2.AreaIndex = 3;
            this.COL_TIPO2.Caption = "TIPO";
            this.COL_TIPO2.FieldName = "TIPO";
            this.COL_TIPO2.Name = "COL_TIPO2";
            this.COL_TIPO2.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            this.COL_TIPO2.Visible = false;
            this.COL_TIPO2.Width = 20;
            // 
            // COL_VALOR2
            // 
            this.COL_VALOR2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.COL_VALOR2.AreaIndex = 0;
            this.COL_VALOR2.Caption = "VALOR";
            this.COL_VALOR2.CellFormat.FormatString = "N2";
            this.COL_VALOR2.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_VALOR2.FieldName = "VALOR";
            this.COL_VALOR2.GrandTotalCellFormat.FormatString = "{0:0.0000}";
            this.COL_VALOR2.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_VALOR2.Name = "COL_VALOR2";
            this.COL_VALOR2.Options.ShowGrandTotal = false;
            this.COL_VALOR2.Options.ShowTotals = false;
            this.COL_VALOR2.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.COL_VALOR2.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            this.COL_VALOR2.TotalValueFormat.FormatString = "N2";
            this.COL_VALOR2.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_VALOR2.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.COL_VALOR2.ValueFormat.FormatString = "N2";
            this.COL_VALOR2.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            // 
            // COL_IDCULTIVO2
            // 
            this.COL_IDCULTIVO2.AreaIndex = 0;
            this.COL_IDCULTIVO2.Caption = "IDCULTIVO";
            this.COL_IDCULTIVO2.FieldName = "IDCULTIVO";
            this.COL_IDCULTIVO2.Name = "COL_IDCULTIVO2";
            this.COL_IDCULTIVO2.Visible = false;
            // 
            // COL_CULTIVO2
            // 
            this.COL_CULTIVO2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_CULTIVO2.AreaIndex = 1;
            this.COL_CULTIVO2.Caption = "CULTIVO";
            this.COL_CULTIVO2.FieldName = "CULTIVO";
            this.COL_CULTIVO2.Name = "COL_CULTIVO2";
            this.COL_CULTIVO2.Options.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.COL_CULTIVO2.Options.ShowGrandTotal = false;
            this.COL_CULTIVO2.Options.ShowTotals = false;
            this.COL_CULTIVO2.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            // 
            // COL_IDVARIEDAD2
            // 
            this.COL_IDVARIEDAD2.AreaIndex = 0;
            this.COL_IDVARIEDAD2.Caption = "IDVARIEDAD";
            this.COL_IDVARIEDAD2.FieldName = "IDVARIEDAD";
            this.COL_IDVARIEDAD2.Name = "COL_IDVARIEDAD2";
            this.COL_IDVARIEDAD2.Visible = false;
            // 
            // COL_VARIEDAD2
            // 
            this.COL_VARIEDAD2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_VARIEDAD2.AreaIndex = 2;
            this.COL_VARIEDAD2.Caption = "VARIEDAD";
            this.COL_VARIEDAD2.FieldName = "VARIEDAD";
            this.COL_VARIEDAD2.Name = "COL_VARIEDAD2";
            this.COL_VARIEDAD2.Options.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.COL_VARIEDAD2.Options.ShowGrandTotal = false;
            this.COL_VARIEDAD2.Options.ShowTotals = false;
            this.COL_VARIEDAD2.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            // 
            // COL_IDFUNDO2
            // 
            this.COL_IDFUNDO2.AreaIndex = 0;
            this.COL_IDFUNDO2.Caption = "IDFUNDO";
            this.COL_IDFUNDO2.FieldName = "IDFUNDO";
            this.COL_IDFUNDO2.Name = "COL_IDFUNDO2";
            this.COL_IDFUNDO2.Visible = false;
            // 
            // COL_FUNDO2
            // 
            this.COL_FUNDO2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_FUNDO2.AreaIndex = 0;
            this.COL_FUNDO2.Caption = "FUNDO";
            this.COL_FUNDO2.FieldName = "FUNDO";
            this.COL_FUNDO2.Name = "COL_FUNDO2";
            this.COL_FUNDO2.Options.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.COL_FUNDO2.Options.ShowGrandTotal = false;
            this.COL_FUNDO2.Options.ShowTotals = false;
            this.COL_FUNDO2.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            this.COL_FUNDO2.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            this.COL_FUNDO2.UnboundExpression = "[VALOR]";
            // 
            // TOTAL
            // 
            this.TOTAL.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.TOTAL.AreaIndex = 6;
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Visible = false;
            // 
            // COL_ESTRUCTURA
            // 
            this.COL_ESTRUCTURA.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_ESTRUCTURA.AreaIndex = 3;
            this.COL_ESTRUCTURA.Caption = "ESTRUCTURA";
            this.COL_ESTRUCTURA.FieldName = "ESTRUCTURA";
            this.COL_ESTRUCTURA.Name = "COL_ESTRUCTURA";
            this.COL_ESTRUCTURA.Visible = false;
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
            this.cbo_presupuesto.TabIndex = 134;
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
            this.label1.TabIndex = 133;
            this.label1.Text = "Presupuesto";
            // 
            // btn_exportarexcel
            // 
            this.btn_exportarexcel.BackColor = System.Drawing.Color.Transparent;
            this.btn_exportarexcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportarexcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportarexcel.Image = ((System.Drawing.Image)(resources.GetObject("btn_exportarexcel.Image")));
            this.btn_exportarexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exportarexcel.Location = new System.Drawing.Point(700, 9);
            this.btn_exportarexcel.Name = "btn_exportarexcel";
            this.btn_exportarexcel.Size = new System.Drawing.Size(120, 26);
            this.btn_exportarexcel.TabIndex = 142;
            this.btn_exportarexcel.Text = "Exportar";
            this.btn_exportarexcel.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_editardetalle
            // 
            this.btn_editardetalle.BackColor = System.Drawing.Color.Transparent;
            this.btn_editardetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editardetalle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editardetalle.Image = ((System.Drawing.Image)(resources.GetObject("btn_editardetalle.Image")));
            this.btn_editardetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editardetalle.Location = new System.Drawing.Point(566, 9);
            this.btn_editardetalle.Name = "btn_editardetalle";
            this.btn_editardetalle.Size = new System.Drawing.Size(128, 26);
            this.btn_editardetalle.TabIndex = 141;
            this.btn_editardetalle.Text = "Editar Detalle";
            this.btn_editardetalle.TextAlignment = System.Drawing.StringAlignment.Center;
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
            this.btn_consultarReporte.TabIndex = 140;
            this.btn_consultarReporte.Text = "Consultar";
            this.btn_consultarReporte.TextAlignment = System.Drawing.StringAlignment.Center;
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
            this.barrar_progreso.TabIndex = 144;
            this.barrar_progreso.Visible = false;
            this.barrar_progreso.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring;
            this.barrar_progreso.Click += new System.EventHandler(this.barrar_progreso_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // rpt_ejecutadoVSpresupuestado
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 732);
            this.Controls.Add(this.barrar_progreso);
            this.Controls.Add(this.LB_TITULO);
            this.Controls.Add(this.btn_exportarexcel);
            this.Controls.Add(this.btn_editardetalle);
            this.Controls.Add(this.btn_consultarReporte);
            this.Controls.Add(this.btn_fundocultivo);
            this.Controls.Add(this.btn_fundovariedad);
            this.Controls.Add(this.cbo_moneda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pvt_datos2);
            this.Controls.Add(this.cbo_presupuesto);
            this.Controls.Add(this.label1);
            this.Name = "rpt_ejecutadoVSpresupuestado";
            this.Text = "rpt_ejecutadoVSpresupuestado";
            ((System.ComponentModel.ISupportInitialize)(this.cbo_moneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvt_datos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_presupuesto.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_TITULO;
        private MonoFlat.MonoFlat_Button btn_exportarexcel;
        private MonoFlat.MonoFlat_Button btn_editardetalle;
        private MonoFlat.MonoFlat_Button btn_consultarReporte;
        private MonoFlat.MonoFlat_Button btn_fundocultivo;
        private MonoFlat.MonoFlat_Button btn_fundovariedad;
        private DevExpress.XtraEditors.LookUpEdit cbo_moneda;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraPivotGrid.PivotGridControl pvt_datos2;
        private DevExpress.XtraPivotGrid.PivotGridField COL_IDPRESUPUESTO2;
        private DevExpress.XtraPivotGrid.PivotGridField COL_IDITEM2;
        private DevExpress.XtraPivotGrid.PivotGridField COL_ITEM2;
        private DevExpress.XtraPivotGrid.PivotGridField COL_IDGRUPO2;
        private DevExpress.XtraPivotGrid.PivotGridField COL_GRUPO2;
        private DevExpress.XtraPivotGrid.PivotGridField COL_TIPO2;
        private DevExpress.XtraPivotGrid.PivotGridField COL_VALOR2;
        private DevExpress.XtraPivotGrid.PivotGridField COL_IDCULTIVO2;
        private DevExpress.XtraPivotGrid.PivotGridField COL_CULTIVO2;
        private DevExpress.XtraPivotGrid.PivotGridField COL_IDVARIEDAD2;
        private DevExpress.XtraPivotGrid.PivotGridField COL_VARIEDAD2;
        private DevExpress.XtraPivotGrid.PivotGridField COL_IDFUNDO2;
        private DevExpress.XtraPivotGrid.PivotGridField COL_FUNDO2;
        private DevExpress.XtraPivotGrid.PivotGridField TOTAL;
        private DevExpress.XtraPivotGrid.PivotGridField COL_ESTRUCTURA;
        private DevExpress.XtraEditors.LookUpEdit cbo_presupuesto;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraWaitForm.ProgressPanel barrar_progreso;
        private System.Windows.Forms.Timer timer1;
    }
}