namespace ModuloPresupuesto
{
    partial class Rpt_CostoSemanal
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
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule1 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings formatRuleTotalTypeSettings1 = new DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings();
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule2 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rpt_CostoSemanal));
            DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings formatRuleTotalTypeSettings2 = new DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings();
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule3 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression3 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings formatRuleTotalTypeSettings3 = new DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings();
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule4 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression4 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings formatRuleTotalTypeSettings4 = new DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings();
            this.COL_UNIDADES = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pvt_datos2 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.COL_LABORPRODUCTO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_ACTIVIDADGRUPO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_CULTIVO2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_SEMANA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_FUNDO2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_LOTE = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_MEDIDA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_COSTO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_PERIODO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_COSTOTOTAL = new DevExpress.XtraPivotGrid.PivotGridField();
            this.cbo_moneda = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_presupuesto = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_cultivo = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_itemcosto = new DevExpress.XtraEditors.LookUpEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_select_fundo = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.cbo_select_Parcela = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_select_lote = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.barrar_progreso = new DevExpress.XtraWaitForm.ProgressPanel();
            this.chk_costouni = new DevExpress.XtraEditors.CheckEdit();
            this.chk_costototal = new DevExpress.XtraEditors.CheckEdit();
            this.btn_exportarexcel = new MonoFlat.MonoFlat_Button();
            this.btn_consultarReporte = new MonoFlat.MonoFlat_Button();
            ((System.ComponentModel.ISupportInitialize)(this.pvt_datos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_moneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_presupuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_cultivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_itemcosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_select_fundo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_select_Parcela.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_select_lote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_costouni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_costototal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // COL_UNIDADES
            // 
            this.COL_UNIDADES.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.COL_UNIDADES.AreaIndex = 0;
            this.COL_UNIDADES.Caption = "UNIDADES";
            this.COL_UNIDADES.CellFormat.FormatString = "{0:n4}";
            this.COL_UNIDADES.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_UNIDADES.FieldName = "UNIDADES";
            this.COL_UNIDADES.GrandTotalCellFormat.FormatString = "{0:n4}";
            this.COL_UNIDADES.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_UNIDADES.Name = "COL_UNIDADES";
            this.COL_UNIDADES.Options.ShowGrandTotal = false;
            this.COL_UNIDADES.Options.ShowTotals = false;
            this.COL_UNIDADES.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.COL_UNIDADES.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            this.COL_UNIDADES.TotalValueFormat.FormatString = "{0:n4}";
            this.COL_UNIDADES.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_UNIDADES.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.COL_UNIDADES.ValueFormat.FormatString = "{0:n4}";
            this.COL_UNIDADES.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
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
            this.COL_LABORPRODUCTO,
            this.COL_ACTIVIDADGRUPO,
            this.COL_UNIDADES,
            this.COL_CULTIVO2,
            this.COL_SEMANA,
            this.COL_FUNDO2,
            this.COL_LOTE,
            this.COL_MEDIDA,
            this.COL_COSTO,
            this.COL_PERIODO,
            this.COL_COSTOTOTAL});
            pivotGridFormatRule1.Measure = this.COL_UNIDADES;
            pivotGridFormatRule1.Name = "Format4";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            formatConditionRuleExpression1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            formatConditionRuleExpression1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            formatConditionRuleExpression1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            formatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.Black;
            formatConditionRuleExpression1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Appearance.Options.UseBorderColor = true;
            formatConditionRuleExpression1.Appearance.Options.UseFont = true;
            formatConditionRuleExpression1.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression1.Expression = "[VARIEDAD] = \'X.TOTAL\'";
            pivotGridFormatRule1.Rule = formatConditionRuleExpression1;
            pivotGridFormatRule1.Settings = formatRuleTotalTypeSettings1;
            pivotGridFormatRule2.Measure = this.COL_UNIDADES;
            pivotGridFormatRule2.Name = "Format10";
            formatConditionRuleExpression2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formatConditionRuleExpression2.Appearance.ForeColor = System.Drawing.Color.Black;
            formatConditionRuleExpression2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            formatConditionRuleExpression2.Appearance.Options.UseFont = true;
            formatConditionRuleExpression2.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression2.Expression = resources.GetString("formatConditionRuleExpression2.Expression");
            pivotGridFormatRule2.Rule = formatConditionRuleExpression2;
            pivotGridFormatRule2.Settings = formatRuleTotalTypeSettings2;
            pivotGridFormatRule3.Measure = this.COL_UNIDADES;
            pivotGridFormatRule3.Name = "Format0";
            formatConditionRuleExpression3.Appearance.BackColor = System.Drawing.Color.Gray;
            formatConditionRuleExpression3.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            formatConditionRuleExpression3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formatConditionRuleExpression3.Appearance.ForeColor = System.Drawing.Color.Black;
            formatConditionRuleExpression3.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            formatConditionRuleExpression3.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression3.Appearance.Options.UseFont = true;
            formatConditionRuleExpression3.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression3.Expression = "[ITEM] = \'61-COSTO PACKING \' Or [ITEM] = \'47-COSTO CAMPO \' Or [ITEM] = \'41-TOTAL " +
    "COSTO DIRECTO\' Or [ITEM] = \'41-TOTAL COSTO DIRECTO\'";
            pivotGridFormatRule3.Rule = formatConditionRuleExpression3;
            pivotGridFormatRule3.Settings = formatRuleTotalTypeSettings3;
            pivotGridFormatRule4.Measure = this.COL_COSTO;
            pivotGridFormatRule4.Name = "Format1";
            formatConditionRuleExpression4.Expression = "[COSTOTOTAL] / [UNIDADES]";
            pivotGridFormatRule4.Rule = formatConditionRuleExpression4;
            pivotGridFormatRule4.Settings = formatRuleTotalTypeSettings4;
            this.pvt_datos2.FormatRules.Add(pivotGridFormatRule1);
            this.pvt_datos2.FormatRules.Add(pivotGridFormatRule2);
            this.pvt_datos2.FormatRules.Add(pivotGridFormatRule3);
            this.pvt_datos2.FormatRules.Add(pivotGridFormatRule4);
            this.pvt_datos2.Location = new System.Drawing.Point(2, 92);
            this.pvt_datos2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.pvt_datos2.Name = "pvt_datos2";
            this.pvt_datos2.OptionsBehavior.UseAsyncMode = true;
            this.pvt_datos2.OptionsChartDataSource.AutoTransposeChart = true;
            this.pvt_datos2.OptionsCustomization.AllowEdit = false;
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
            this.pvt_datos2.OptionsView.ShowRowTotals = false;
            this.pvt_datos2.Size = new System.Drawing.Size(1330, 634);
            this.pvt_datos2.TabIndex = 101;
            // 
            // COL_LABORPRODUCTO
            // 
            this.COL_LABORPRODUCTO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_LABORPRODUCTO.AreaIndex = 3;
            this.COL_LABORPRODUCTO.Caption = "LABOR/PRODUCTO";
            this.COL_LABORPRODUCTO.FieldName = "LABORPRODUCTO";
            this.COL_LABORPRODUCTO.Name = "COL_LABORPRODUCTO";
            this.COL_LABORPRODUCTO.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.None;
            this.COL_LABORPRODUCTO.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            this.COL_LABORPRODUCTO.Width = 250;
            // 
            // COL_ACTIVIDADGRUPO
            // 
            this.COL_ACTIVIDADGRUPO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_ACTIVIDADGRUPO.AreaIndex = 2;
            this.COL_ACTIVIDADGRUPO.Caption = "ACTIVIDAD/GRUPO";
            this.COL_ACTIVIDADGRUPO.FieldName = "ACTIVIDADGRUPO";
            this.COL_ACTIVIDADGRUPO.Name = "COL_ACTIVIDADGRUPO";
            this.COL_ACTIVIDADGRUPO.Options.ShowGrandTotal = false;
            this.COL_ACTIVIDADGRUPO.Options.ShowTotals = false;
            this.COL_ACTIVIDADGRUPO.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.None;
            this.COL_ACTIVIDADGRUPO.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            this.COL_ACTIVIDADGRUPO.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.COL_ACTIVIDADGRUPO.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.COL_ACTIVIDADGRUPO.Width = 200;
            // 
            // COL_CULTIVO2
            // 
            this.COL_CULTIVO2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_CULTIVO2.AreaIndex = 2;
            this.COL_CULTIVO2.Caption = "CULTIVO";
            this.COL_CULTIVO2.FieldName = "CULTIVO";
            this.COL_CULTIVO2.Name = "COL_CULTIVO2";
            this.COL_CULTIVO2.Options.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.COL_CULTIVO2.Options.ShowGrandTotal = false;
            this.COL_CULTIVO2.Options.ShowTotals = false;
            this.COL_CULTIVO2.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            this.COL_CULTIVO2.Visible = false;
            // 
            // COL_SEMANA
            // 
            this.COL_SEMANA.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_SEMANA.AreaIndex = 1;
            this.COL_SEMANA.Caption = "SEMANA";
            this.COL_SEMANA.FieldName = "SEMANA";
            this.COL_SEMANA.Name = "COL_SEMANA";
            this.COL_SEMANA.Options.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.COL_SEMANA.Options.ShowGrandTotal = false;
            this.COL_SEMANA.Options.ShowTotals = false;
            this.COL_SEMANA.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            // 
            // COL_FUNDO2
            // 
            this.COL_FUNDO2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
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
            // COL_LOTE
            // 
            this.COL_LOTE.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_LOTE.AreaIndex = 1;
            this.COL_LOTE.Caption = "LOTE";
            this.COL_LOTE.FieldName = "LOTE";
            this.COL_LOTE.Name = "COL_LOTE";
            // 
            // COL_MEDIDA
            // 
            this.COL_MEDIDA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_MEDIDA.AreaIndex = 4;
            this.COL_MEDIDA.Caption = "MEDIDA";
            this.COL_MEDIDA.FieldName = "MEDIDA";
            this.COL_MEDIDA.Name = "COL_MEDIDA";
            // 
            // COL_COSTO
            // 
            this.COL_COSTO.Appearance.Cell.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.COL_COSTO.Appearance.Cell.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.COL_COSTO.Appearance.Cell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_COSTO.Appearance.Cell.Options.UseBackColor = true;
            this.COL_COSTO.Appearance.Cell.Options.UseFont = true;
            this.COL_COSTO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.COL_COSTO.AreaIndex = 1;
            this.COL_COSTO.Caption = "COSTO UNITARIO";
            this.COL_COSTO.CellFormat.FormatString = "{0:n4}";
            this.COL_COSTO.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_COSTO.FieldName = "COSTOUNI";
            this.COL_COSTO.GrandTotalCellFormat.FormatString = "{0:n4}";
            this.COL_COSTO.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_COSTO.Name = "COL_COSTO";
            this.COL_COSTO.Options.ShowGrandTotal = false;
            this.COL_COSTO.Options.ShowTotals = false;
            this.COL_COSTO.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            this.COL_COSTO.TotalCellFormat.FormatString = "{0:n4}";
            this.COL_COSTO.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_COSTO.TotalValueFormat.FormatString = "{0:n4}";
            this.COL_COSTO.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            // 
            // COL_PERIODO
            // 
            this.COL_PERIODO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_PERIODO.AreaIndex = 0;
            this.COL_PERIODO.Caption = "PERIODO";
            this.COL_PERIODO.FieldName = "PERIODO";
            this.COL_PERIODO.Name = "COL_PERIODO";
            // 
            // COL_COSTOTOTAL
            // 
            this.COL_COSTOTOTAL.Appearance.Cell.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.COL_COSTOTOTAL.Appearance.Cell.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.COL_COSTOTOTAL.Appearance.Cell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_COSTOTOTAL.Appearance.Cell.Options.UseBackColor = true;
            this.COL_COSTOTOTAL.Appearance.Cell.Options.UseFont = true;
            this.COL_COSTOTOTAL.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.COL_COSTOTOTAL.AreaIndex = 2;
            this.COL_COSTOTOTAL.Caption = "COSTO TOTAL";
            this.COL_COSTOTOTAL.CellFormat.FormatString = "{0:n4}";
            this.COL_COSTOTOTAL.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_COSTOTOTAL.FieldName = "COSTOTOTAL";
            this.COL_COSTOTOTAL.GrandTotalCellFormat.FormatString = "{0:n4}";
            this.COL_COSTOTOTAL.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_COSTOTOTAL.Name = "COL_COSTOTOTAL";
            this.COL_COSTOTOTAL.Options.ShowGrandTotal = false;
            this.COL_COSTOTOTAL.Options.ShowTotals = false;
            this.COL_COSTOTOTAL.TotalCellFormat.FormatString = "{0:n4}";
            this.COL_COSTOTOTAL.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_COSTOTOTAL.ValueFormat.FormatString = "{0:n4}";
            this.COL_COSTOTOTAL.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            // 
            // cbo_moneda
            // 
            this.cbo_moneda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_moneda.Location = new System.Drawing.Point(323, 11);
            this.cbo_moneda.Name = "cbo_moneda";
            this.cbo_moneda.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_moneda.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbo_moneda.Properties.Appearance.Options.UseFont = true;
            this.cbo_moneda.Properties.Appearance.Options.UseForeColor = true;
            this.cbo_moneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_moneda.Properties.NullText = "[Seleccionar..]";
            this.cbo_moneda.Size = new System.Drawing.Size(123, 24);
            this.cbo_moneda.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(232, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 110;
            this.label3.Text = "Moneda";
            // 
            // cbo_presupuesto
            // 
            this.cbo_presupuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_presupuesto.Location = new System.Drawing.Point(102, 11);
            this.cbo_presupuesto.Name = "cbo_presupuesto";
            this.cbo_presupuesto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_presupuesto.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbo_presupuesto.Properties.Appearance.Options.UseFont = true;
            this.cbo_presupuesto.Properties.Appearance.Options.UseForeColor = true;
            this.cbo_presupuesto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_presupuesto.Properties.NullText = "[Seleccionar..]";
            this.cbo_presupuesto.Size = new System.Drawing.Size(124, 24);
            this.cbo_presupuesto.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 108;
            this.label1.Text = "Presupuesto";
            // 
            // cbo_cultivo
            // 
            this.cbo_cultivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_cultivo.Location = new System.Drawing.Point(103, 41);
            this.cbo_cultivo.Name = "cbo_cultivo";
            this.cbo_cultivo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_cultivo.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbo_cultivo.Properties.Appearance.Options.UseFont = true;
            this.cbo_cultivo.Properties.Appearance.Options.UseForeColor = true;
            this.cbo_cultivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_cultivo.Properties.NullText = "[Seleccionar..]";
            this.cbo_cultivo.Size = new System.Drawing.Size(123, 24);
            this.cbo_cultivo.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 117;
            this.label2.Text = "Cultivo";
            // 
            // cbo_itemcosto
            // 
            this.cbo_itemcosto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_itemcosto.Location = new System.Drawing.Point(323, 41);
            this.cbo_itemcosto.Name = "cbo_itemcosto";
            this.cbo_itemcosto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_itemcosto.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbo_itemcosto.Properties.Appearance.Options.UseFont = true;
            this.cbo_itemcosto.Properties.Appearance.Options.UseForeColor = true;
            this.cbo_itemcosto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_itemcosto.Properties.NullText = "[Seleccionar..]";
            this.cbo_itemcosto.Size = new System.Drawing.Size(123, 24);
            this.cbo_itemcosto.TabIndex = 120;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(232, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 119;
            this.label4.Text = "Item Costo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(451, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 121;
            this.label5.Text = "Fundo";
            // 
            // cbo_select_fundo
            // 
            this.cbo_select_fundo.EditValue = "";
            this.cbo_select_fundo.Location = new System.Drawing.Point(507, 11);
            this.cbo_select_fundo.Name = "cbo_select_fundo";
            this.cbo_select_fundo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo_select_fundo.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbo_select_fundo.Properties.Appearance.Options.UseFont = true;
            this.cbo_select_fundo.Properties.Appearance.Options.UseForeColor = true;
            this.cbo_select_fundo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_select_fundo.Size = new System.Drawing.Size(138, 24);
            this.cbo_select_fundo.TabIndex = 134;
            this.cbo_select_fundo.EditValueChanged += new System.EventHandler(this.cbo_select_fundo_EditValueChanged);
            this.cbo_select_fundo.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.cbo_select_fundo_EditValueChanging);
            this.cbo_select_fundo.EnabledChanged += new System.EventHandler(this.cbo_select_fundo_EnabledChanged);
            // 
            // cbo_select_Parcela
            // 
            this.cbo_select_Parcela.EditValue = "";
            this.cbo_select_Parcela.Location = new System.Drawing.Point(507, 41);
            this.cbo_select_Parcela.Name = "cbo_select_Parcela";
            this.cbo_select_Parcela.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo_select_Parcela.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbo_select_Parcela.Properties.Appearance.Options.UseFont = true;
            this.cbo_select_Parcela.Properties.Appearance.Options.UseForeColor = true;
            this.cbo_select_Parcela.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_select_Parcela.Size = new System.Drawing.Size(138, 24);
            this.cbo_select_Parcela.TabIndex = 135;
            this.cbo_select_Parcela.EditValueChanged += new System.EventHandler(this.cbo_select_Parcela_EditValueChanged);
            this.cbo_select_Parcela.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.cbo_select_Parcela_EditValueChanging);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(452, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 136;
            this.label6.Text = "Parcela";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(651, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 138;
            this.label7.Text = "Lote";
            // 
            // cbo_select_lote
            // 
            this.cbo_select_lote.EditValue = "";
            this.cbo_select_lote.Location = new System.Drawing.Point(697, 11);
            this.cbo_select_lote.Name = "cbo_select_lote";
            this.cbo_select_lote.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo_select_lote.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbo_select_lote.Properties.Appearance.Options.UseFont = true;
            this.cbo_select_lote.Properties.Appearance.Options.UseForeColor = true;
            this.cbo_select_lote.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_select_lote.Size = new System.Drawing.Size(138, 24);
            this.cbo_select_lote.TabIndex = 137;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.barrar_progreso.Location = new System.Drawing.Point(584, 331);
            this.barrar_progreso.Name = "barrar_progreso";
            this.barrar_progreso.RingAnimationDiameter = 60;
            this.barrar_progreso.Size = new System.Drawing.Size(166, 66);
            this.barrar_progreso.TabIndex = 139;
            this.barrar_progreso.Visible = false;
            this.barrar_progreso.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring;
            // 
            // chk_costouni
            // 
            this.chk_costouni.Location = new System.Drawing.Point(655, 42);
            this.chk_costouni.Name = "chk_costouni";
            this.chk_costouni.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chk_costouni.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.chk_costouni.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.chk_costouni.Properties.Appearance.Options.UseBackColor = true;
            this.chk_costouni.Properties.Appearance.Options.UseFont = true;
            this.chk_costouni.Properties.Appearance.Options.UseForeColor = true;
            this.chk_costouni.Properties.Caption = "Mostrar Costo Unitario";
            this.chk_costouni.Size = new System.Drawing.Size(185, 24);
            this.chk_costouni.TabIndex = 140;
            this.chk_costouni.CheckedChanged += new System.EventHandler(this.chk_costouni_CheckedChanged);
            // 
            // chk_costototal
            // 
            this.chk_costototal.Location = new System.Drawing.Point(846, 42);
            this.chk_costototal.Name = "chk_costototal";
            this.chk_costototal.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chk_costototal.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.chk_costototal.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.chk_costototal.Properties.Appearance.Options.UseBackColor = true;
            this.chk_costototal.Properties.Appearance.Options.UseFont = true;
            this.chk_costototal.Properties.Appearance.Options.UseForeColor = true;
            this.chk_costototal.Properties.Caption = "Mostrar Costo Total";
            this.chk_costototal.Size = new System.Drawing.Size(185, 24);
            this.chk_costototal.TabIndex = 141;
            this.chk_costototal.CheckedChanged += new System.EventHandler(this.chk_costototal_CheckedChanged);
            // 
            // btn_exportarexcel
            // 
            this.btn_exportarexcel.BackColor = System.Drawing.Color.Transparent;
            this.btn_exportarexcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportarexcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportarexcel.Image = ((System.Drawing.Image)(resources.GetObject("btn_exportarexcel.Image")));
            this.btn_exportarexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exportarexcel.Location = new System.Drawing.Point(988, 9);
            this.btn_exportarexcel.Name = "btn_exportarexcel";
            this.btn_exportarexcel.Size = new System.Drawing.Size(120, 26);
            this.btn_exportarexcel.TabIndex = 116;
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
            this.btn_consultarReporte.Location = new System.Drawing.Point(854, 9);
            this.btn_consultarReporte.Name = "btn_consultarReporte";
            this.btn_consultarReporte.Size = new System.Drawing.Size(128, 26);
            this.btn_consultarReporte.TabIndex = 114;
            this.btn_consultarReporte.Text = "Consultar";
            this.btn_consultarReporte.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_consultarReporte.Click += new System.EventHandler(this.btn_consultarReporte_Click);
            // 
            // Rpt_CostoSemanal
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 728);
            this.Controls.Add(this.chk_costototal);
            this.Controls.Add(this.chk_costouni);
            this.Controls.Add(this.barrar_progreso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbo_select_lote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbo_select_Parcela);
            this.Controls.Add(this.cbo_select_fundo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbo_itemcosto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_cultivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_exportarexcel);
            this.Controls.Add(this.btn_consultarReporte);
            this.Controls.Add(this.cbo_moneda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_presupuesto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pvt_datos2);
            this.Name = "Rpt_CostoSemanal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rpt_CostoSemanal";
            this.Load += new System.EventHandler(this.Rpt_CostoSemanal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pvt_datos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_moneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_presupuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_cultivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_itemcosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_select_fundo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_select_Parcela.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_select_lote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_costouni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_costototal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraPivotGrid.PivotGridControl pvt_datos2;
        private DevExpress.XtraPivotGrid.PivotGridField COL_LABORPRODUCTO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_ACTIVIDADGRUPO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_UNIDADES;
        private DevExpress.XtraPivotGrid.PivotGridField COL_CULTIVO2;
        private DevExpress.XtraPivotGrid.PivotGridField COL_SEMANA;
        private DevExpress.XtraPivotGrid.PivotGridField COL_FUNDO2;
        private MonoFlat.MonoFlat_Button btn_exportarexcel;
        private MonoFlat.MonoFlat_Button btn_consultarReporte;
        private DevExpress.XtraEditors.LookUpEdit cbo_moneda;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LookUpEdit cbo_presupuesto;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit cbo_cultivo;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit cbo_itemcosto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cbo_select_fundo;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cbo_select_Parcela;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cbo_select_lote;
        private DevExpress.XtraPivotGrid.PivotGridField COL_LOTE;
        private DevExpress.XtraPivotGrid.PivotGridField COL_MEDIDA;
        private DevExpress.XtraPivotGrid.PivotGridField COL_COSTO;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraWaitForm.ProgressPanel barrar_progreso;
        private DevExpress.XtraPivotGrid.PivotGridField COL_PERIODO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_COSTOTOTAL;
        private DevExpress.XtraEditors.CheckEdit chk_costouni;
        private DevExpress.XtraEditors.CheckEdit chk_costototal;
    }
}