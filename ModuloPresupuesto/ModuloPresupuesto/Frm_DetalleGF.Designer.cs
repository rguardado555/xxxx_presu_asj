namespace ModuloPresupuesto
{
    partial class Frm_DetalleGF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DetalleGF));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.monoFlat_ThemeContainer1 = new MonoFlat.MonoFlat_ThemeContainer();
            this.lb_mensaje = new System.Windows.Forms.Label();
            this.barrar_progreso = new DevExpress.XtraWaitForm.ProgressPanel();
            this.monoFlat_ControlBox1 = new MonoFlat.MonoFlat_ControlBox();
            this.btn_exportarexcel = new MonoFlat.MonoFlat_Button();
            this.pvt_datos2 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.COL_CUENTA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_AREA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_FUNDO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_SOLES = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_PARTIDADIR = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_DOLARES = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_PRECIOORIGEN = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_RESPONSABLE = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_CULTIVO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_TGASTO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.monoFlat_ThemeContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pvt_datos2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField1.AreaIndex = 1;
            this.pivotGridField1.Caption = "COL_DOLARES";
            this.pivotGridField1.FieldName = "PRECIO_DOL";
            this.pivotGridField1.Name = "pivotGridField1";
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField3.AreaIndex = 1;
            this.pivotGridField3.Caption = "COL_DOLARES";
            this.pivotGridField3.FieldName = "PRECIO_DOL";
            this.pivotGridField3.Name = "pivotGridField3";
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.lb_mensaje);
            this.monoFlat_ThemeContainer1.Controls.Add(this.barrar_progreso);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_ControlBox1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btn_exportarexcel);
            this.monoFlat_ThemeContainer1.Controls.Add(this.pvt_datos2);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = true;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(1097, 633);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.monoFlat_ThemeContainer1.TabIndex = 110;
            this.monoFlat_ThemeContainer1.Text = "Detalle Gasto Fijo";
            // 
            // lb_mensaje
            // 
            this.lb_mensaje.AutoSize = true;
            this.lb_mensaje.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mensaje.ForeColor = System.Drawing.Color.Red;
            this.lb_mensaje.Location = new System.Drawing.Point(470, 335);
            this.lb_mensaje.Name = "lb_mensaje";
            this.lb_mensaje.Size = new System.Drawing.Size(186, 20);
            this.lb_mensaje.TabIndex = 111;
            this.lb_mensaje.Text = "No hay datos para mostrar";
            this.lb_mensaje.Visible = false;
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
            this.barrar_progreso.Location = new System.Drawing.Point(474, 305);
            this.barrar_progreso.Name = "barrar_progreso";
            this.barrar_progreso.RingAnimationDiameter = 60;
            this.barrar_progreso.Size = new System.Drawing.Size(166, 72);
            this.barrar_progreso.TabIndex = 112;
            this.barrar_progreso.Visible = false;
            this.barrar_progreso.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring;
            // 
            // monoFlat_ControlBox1
            // 
            this.monoFlat_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_ControlBox1.EnableHoverHighlight = false;
            this.monoFlat_ControlBox1.EnableMaximizeButton = true;
            this.monoFlat_ControlBox1.EnableMinimizeButton = true;
            this.monoFlat_ControlBox1.Location = new System.Drawing.Point(985, 15);
            this.monoFlat_ControlBox1.Name = "monoFlat_ControlBox1";
            this.monoFlat_ControlBox1.Size = new System.Drawing.Size(100, 25);
            this.monoFlat_ControlBox1.TabIndex = 110;
            this.monoFlat_ControlBox1.Text = "monoFlat_ControlBox1";
            // 
            // btn_exportarexcel
            // 
            this.btn_exportarexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exportarexcel.BackColor = System.Drawing.Color.Transparent;
            this.btn_exportarexcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportarexcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportarexcel.Image = ((System.Drawing.Image)(resources.GetObject("btn_exportarexcel.Image")));
            this.btn_exportarexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exportarexcel.Location = new System.Drawing.Point(964, 67);
            this.btn_exportarexcel.Name = "btn_exportarexcel";
            this.btn_exportarexcel.Size = new System.Drawing.Size(120, 26);
            this.btn_exportarexcel.TabIndex = 109;
            this.btn_exportarexcel.Text = "Exportar";
            this.btn_exportarexcel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_exportarexcel.Click += new System.EventHandler(this.btn_exportarexcel_Click);
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
            this.COL_SOLES,
            this.COL_PARTIDADIR,
            this.COL_DOLARES,
            this.COL_PRECIOORIGEN,
            this.COL_RESPONSABLE,
            this.COL_CULTIVO,
            this.COL_TGASTO});
            this.pvt_datos2.ForeColor = System.Drawing.Color.Black;
            this.pvt_datos2.Location = new System.Drawing.Point(4, 99);
            this.pvt_datos2.Name = "pvt_datos2";
            this.pvt_datos2.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pvt_datos2.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pvt_datos2.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pvt_datos2.OptionsPrint.PrintHorzLines = DevExpress.Utils.DefaultBoolean.True;
            this.pvt_datos2.Size = new System.Drawing.Size(1085, 528);
            this.pvt_datos2.TabIndex = 158;
            // 
            // COL_CUENTA
            // 
            this.COL_CUENTA.Appearance.Cell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_CUENTA.Appearance.Cell.ForeColor = System.Drawing.Color.Black;
            this.COL_CUENTA.Appearance.Cell.Options.UseFont = true;
            this.COL_CUENTA.Appearance.Cell.Options.UseForeColor = true;
            this.COL_CUENTA.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_CUENTA.AreaIndex = 0;
            this.COL_CUENTA.Caption = "CUENTA";
            this.COL_CUENTA.FieldName = "TIPO_CUENTA";
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
            this.COL_AREA.AreaIndex = 0;
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
            // COL_SOLES
            // 
            this.COL_SOLES.Appearance.Cell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_SOLES.Appearance.Cell.ForeColor = System.Drawing.Color.Black;
            this.COL_SOLES.Appearance.Cell.Options.UseFont = true;
            this.COL_SOLES.Appearance.Cell.Options.UseForeColor = true;
            this.COL_SOLES.AreaIndex = 2;
            this.COL_SOLES.Caption = "SOLES";
            this.COL_SOLES.CellFormat.FormatString = "N2";
            this.COL_SOLES.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_SOLES.FieldName = "PRECIO_SOL";
            this.COL_SOLES.GrandTotalCellFormat.FormatString = "N2";
            this.COL_SOLES.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_SOLES.Name = "COL_SOLES";
            this.COL_SOLES.TotalCellFormat.FormatString = "N2";
            this.COL_SOLES.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_SOLES.TotalValueFormat.FormatString = "N2";
            this.COL_SOLES.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_SOLES.ValueFormat.FormatString = "N2";
            this.COL_SOLES.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_SOLES.Width = 123;
            // 
            // COL_PARTIDADIR
            // 
            this.COL_PARTIDADIR.Appearance.Cell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_PARTIDADIR.Appearance.Cell.ForeColor = System.Drawing.Color.Black;
            this.COL_PARTIDADIR.Appearance.Cell.Options.UseFont = true;
            this.COL_PARTIDADIR.Appearance.Cell.Options.UseForeColor = true;
            this.COL_PARTIDADIR.Appearance.CellGrandTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_PARTIDADIR.Appearance.CellGrandTotal.ForeColor = System.Drawing.Color.Black;
            this.COL_PARTIDADIR.Appearance.CellGrandTotal.Options.UseFont = true;
            this.COL_PARTIDADIR.Appearance.CellGrandTotal.Options.UseForeColor = true;
            this.COL_PARTIDADIR.Appearance.CellTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_PARTIDADIR.Appearance.CellTotal.Options.UseFont = true;
            this.COL_PARTIDADIR.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_PARTIDADIR.Appearance.Header.Options.UseFont = true;
            this.COL_PARTIDADIR.Appearance.Value.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_PARTIDADIR.Appearance.Value.Options.UseFont = true;
            this.COL_PARTIDADIR.Appearance.ValueGrandTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_PARTIDADIR.Appearance.ValueGrandTotal.Options.UseFont = true;
            this.COL_PARTIDADIR.Appearance.ValueTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_PARTIDADIR.Appearance.ValueTotal.Options.UseFont = true;
            this.COL_PARTIDADIR.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_PARTIDADIR.AreaIndex = 0;
            this.COL_PARTIDADIR.Caption = "PARTIDA DIRECTORIO";
            this.COL_PARTIDADIR.FieldName = "PARTIDA_DIRECTORIO";
            this.COL_PARTIDADIR.Name = "COL_PARTIDADIR";
            this.COL_PARTIDADIR.Width = 250;
            // 
            // COL_DOLARES
            // 
            this.COL_DOLARES.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.COL_DOLARES.AreaIndex = 0;
            this.COL_DOLARES.Caption = "DOLARES";
            this.COL_DOLARES.CellFormat.FormatString = "N2";
            this.COL_DOLARES.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_DOLARES.FieldName = "PRECIO_DOL";
            this.COL_DOLARES.GrandTotalCellFormat.FormatString = "N2";
            this.COL_DOLARES.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_DOLARES.Name = "COL_DOLARES";
            this.COL_DOLARES.TotalCellFormat.FormatString = "N2";
            this.COL_DOLARES.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_DOLARES.TotalValueFormat.FormatString = "N2";
            this.COL_DOLARES.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_DOLARES.ValueFormat.FormatString = "N2";
            this.COL_DOLARES.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_DOLARES.Width = 118;
            // 
            // COL_PRECIOORIGEN
            // 
            this.COL_PRECIOORIGEN.AreaIndex = 1;
            this.COL_PRECIOORIGEN.Caption = "PRECIO ORIGEN";
            this.COL_PRECIOORIGEN.CellFormat.FormatString = "N2";
            this.COL_PRECIOORIGEN.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_PRECIOORIGEN.FieldName = "PRECIO_ORIGEN";
            this.COL_PRECIOORIGEN.GrandTotalCellFormat.FormatString = "N2";
            this.COL_PRECIOORIGEN.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_PRECIOORIGEN.Name = "COL_PRECIOORIGEN";
            this.COL_PRECIOORIGEN.TotalCellFormat.FormatString = "N2";
            this.COL_PRECIOORIGEN.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_PRECIOORIGEN.TotalValueFormat.FormatString = "N2";
            this.COL_PRECIOORIGEN.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_PRECIOORIGEN.UseNativeFormat = DevExpress.Utils.DefaultBoolean.True;
            this.COL_PRECIOORIGEN.ValueFormat.FormatString = "N2";
            this.COL_PRECIOORIGEN.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_PRECIOORIGEN.Width = 129;
            // 
            // COL_RESPONSABLE
            // 
            this.COL_RESPONSABLE.AreaIndex = 3;
            this.COL_RESPONSABLE.Caption = "RESPONSABLE";
            this.COL_RESPONSABLE.FieldName = "RESPONSABLE";
            this.COL_RESPONSABLE.Name = "COL_RESPONSABLE";
            // 
            // COL_CULTIVO
            // 
            this.COL_CULTIVO.AreaIndex = 4;
            this.COL_CULTIVO.Caption = "CULTIVO";
            this.COL_CULTIVO.FieldName = "CULTIVO";
            this.COL_CULTIVO.Name = "COL_CULTIVO";
            // 
            // COL_TGASTO
            // 
            this.COL_TGASTO.AreaIndex = 5;
            this.COL_TGASTO.Caption = "TIPO GASTO";
            this.COL_TGASTO.FieldName = "TIPOGASTO";
            this.COL_TGASTO.Name = "COL_TGASTO";
            // 
            // Frm_DetalleGF
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 633);
            this.ControlBox = false;
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_DetalleGF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Gasto Fijo";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_DetalleGF_Load);
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            this.monoFlat_ThemeContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pvt_datos2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_mensaje;
        private DevExpress.XtraWaitForm.ProgressPanel barrar_progreso;
        private System.Windows.Forms.Timer timer1;
        private MonoFlat.MonoFlat_Button btn_exportarexcel;
        private MonoFlat.MonoFlat_ControlBox monoFlat_ControlBox1;
        private MonoFlat.MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        private DevExpress.XtraPivotGrid.PivotGridControl pvt_datos2;
        private DevExpress.XtraPivotGrid.PivotGridField COL_CUENTA;
        private DevExpress.XtraPivotGrid.PivotGridField COL_AREA;
        private DevExpress.XtraPivotGrid.PivotGridField COL_FUNDO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_SOLES;
        private DevExpress.XtraPivotGrid.PivotGridField COL_PARTIDADIR;
        private DevExpress.XtraPivotGrid.PivotGridField COL_DOLARES;
        private DevExpress.XtraPivotGrid.PivotGridField COL_PRECIOORIGEN;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraPivotGrid.PivotGridField COL_RESPONSABLE;
        private DevExpress.XtraPivotGrid.PivotGridField COL_CULTIVO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_TGASTO;
    }
}