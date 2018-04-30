namespace ModuloPresupuesto
{
    partial class Rpt_xLote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rpt_xLote));
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_consultar = new DevExpress.XtraEditors.SimpleButton();
            this.cbo_presupuesto = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chk_fundo = new DevExpress.XtraEditors.CheckEdit();
            this.chk_parcela = new DevExpress.XtraEditors.CheckEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.barra_progreso = new DevExpress.XtraWaitForm.ProgressPanel();
            this.pvt_datos = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.COL_PARCELA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_LOTE = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_HA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_PERIODO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_ITEM = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_FUNDO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_USD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_CULTIVO = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_presupuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_fundo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_parcela.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvt_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_edit
            // 
            this.btn_edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.ImageOptions.Image")));
            this.btn_edit.Location = new System.Drawing.Point(806, 5);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(107, 23);
            this.btn_edit.TabIndex = 88;
            this.btn_edit.Text = "Editar Detalle";
            // 
            // btn_consultar
            // 
            this.btn_consultar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_consultar.ImageOptions.Image")));
            this.btn_consultar.Location = new System.Drawing.Point(693, 5);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(107, 23);
            this.btn_consultar.TabIndex = 83;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // cbo_presupuesto
            // 
            this.cbo_presupuesto.Location = new System.Drawing.Point(122, 7);
            this.cbo_presupuesto.Name = "cbo_presupuesto";
            this.cbo_presupuesto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_presupuesto.Properties.NullText = "[Seleccionar..]";
            this.cbo_presupuesto.Size = new System.Drawing.Size(124, 20);
            this.cbo_presupuesto.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 81;
            this.label1.Text = "Presupuesto";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(-4, -1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1046, 33);
            this.textBox1.TabIndex = 79;
            // 
            // chk_fundo
            // 
            this.chk_fundo.Location = new System.Drawing.Point(282, 8);
            this.chk_fundo.Name = "chk_fundo";
            this.chk_fundo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.chk_fundo.Properties.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_fundo.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.chk_fundo.Properties.Appearance.Options.UseBackColor = true;
            this.chk_fundo.Properties.Appearance.Options.UseFont = true;
            this.chk_fundo.Properties.Appearance.Options.UseForeColor = true;
            this.chk_fundo.Properties.Caption = "Mostrar Fundo";
            this.chk_fundo.Size = new System.Drawing.Size(126, 19);
            this.chk_fundo.TabIndex = 89;
            this.chk_fundo.CheckedChanged += new System.EventHandler(this.chk_fundo_CheckedChanged);
            // 
            // chk_parcela
            // 
            this.chk_parcela.Location = new System.Drawing.Point(424, 8);
            this.chk_parcela.Name = "chk_parcela";
            this.chk_parcela.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.chk_parcela.Properties.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_parcela.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.chk_parcela.Properties.Appearance.Options.UseBackColor = true;
            this.chk_parcela.Properties.Appearance.Options.UseFont = true;
            this.chk_parcela.Properties.Appearance.Options.UseForeColor = true;
            this.chk_parcela.Properties.Caption = "Mostrar Parcela";
            this.chk_parcela.Size = new System.Drawing.Size(126, 19);
            this.chk_parcela.TabIndex = 90;
            this.chk_parcela.CheckedChanged += new System.EventHandler(this.chk_parcela_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // barra_progreso
            // 
            this.barra_progreso.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.barra_progreso.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.barra_progreso.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.barra_progreso.Appearance.Options.UseBackColor = true;
            this.barra_progreso.Appearance.Options.UseBorderColor = true;
            this.barra_progreso.Appearance.Options.UseForeColor = true;
            this.barra_progreso.BarAnimationElementThickness = 2;
            this.barra_progreso.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.barra_progreso.Caption = "Un Momento Consultando";
            this.barra_progreso.Description = "Cargando ...";
            this.barra_progreso.LineAnimationElementType = DevExpress.Utils.Animation.LineAnimationElementType.Triangle;
            this.barra_progreso.Location = new System.Drawing.Point(424, 212);
            this.barra_progreso.Name = "barra_progreso";
            this.barra_progreso.Size = new System.Drawing.Size(232, 76);
            this.barra_progreso.TabIndex = 91;
            this.barra_progreso.Text = "progressPanel1";
            this.barra_progreso.Visible = false;
            // 
            // pvt_datos
            // 
            this.pvt_datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pvt_datos.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.COL_PARCELA,
            this.COL_LOTE,
            this.COL_HA,
            this.COL_PERIODO,
            this.COL_ITEM,
            this.COL_FUNDO,
            this.COL_USD,
            this.COL_CULTIVO});
            this.pvt_datos.Location = new System.Drawing.Point(0, 33);
            this.pvt_datos.Name = "pvt_datos";
            this.pvt_datos.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.LegacyOptimized;
            this.pvt_datos.Size = new System.Drawing.Size(1038, 468);
            this.pvt_datos.TabIndex = 92;
            // 
            // COL_PARCELA
            // 
            this.COL_PARCELA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_PARCELA.AreaIndex = 1;
            this.COL_PARCELA.Caption = "PARCELA";
            this.COL_PARCELA.FieldName = "PARCELA";
            this.COL_PARCELA.Name = "COL_PARCELA";
            this.COL_PARCELA.Width = 200;
            // 
            // COL_LOTE
            // 
            this.COL_LOTE.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_LOTE.AreaIndex = 3;
            this.COL_LOTE.Caption = "LOTE";
            this.COL_LOTE.FieldName = "LOTE";
            this.COL_LOTE.Name = "COL_LOTE";
            this.COL_LOTE.Width = 200;
            // 
            // COL_HA
            // 
            this.COL_HA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_HA.AreaIndex = 4;
            this.COL_HA.Caption = "HA";
            this.COL_HA.FieldName = "HA";
            this.COL_HA.Name = "COL_HA";
            // 
            // COL_PERIODO
            // 
            this.COL_PERIODO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_PERIODO.AreaIndex = 1;
            this.COL_PERIODO.Caption = "PERIODO";
            this.COL_PERIODO.FieldName = "PERIODO";
            this.COL_PERIODO.Name = "COL_PERIODO";
            // 
            // COL_ITEM
            // 
            this.COL_ITEM.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_ITEM.AreaIndex = 0;
            this.COL_ITEM.Caption = "ITEM";
            this.COL_ITEM.FieldName = "ITEMCOSTO";
            this.COL_ITEM.Name = "COL_ITEM";
            // 
            // COL_FUNDO
            // 
            this.COL_FUNDO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_FUNDO.AreaIndex = 0;
            this.COL_FUNDO.Caption = "FUNDO";
            this.COL_FUNDO.FieldName = "FUNDO";
            this.COL_FUNDO.Name = "COL_FUNDO";
            this.COL_FUNDO.Width = 200;
            // 
            // COL_USD
            // 
            this.COL_USD.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.COL_USD.AreaIndex = 0;
            this.COL_USD.Caption = "USD";
            this.COL_USD.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.COL_USD.FieldName = "USDHA";
            this.COL_USD.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.COL_USD.Name = "COL_USD";
            this.COL_USD.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.COL_USD.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.COL_USD.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // COL_CULTIVO
            // 
            this.COL_CULTIVO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_CULTIVO.AreaIndex = 2;
            this.COL_CULTIVO.Caption = "CULTIVO";
            this.COL_CULTIVO.FieldName = "CULTIVO";
            this.COL_CULTIVO.Name = "COL_CULTIVO";
            this.COL_CULTIVO.Width = 150;
            // 
            // Rpt_xLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 502);
            this.Controls.Add(this.barra_progreso);
            this.Controls.Add(this.chk_parcela);
            this.Controls.Add(this.chk_fundo);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.cbo_presupuesto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pvt_datos);
            this.Name = "Rpt_xLote";
            this.Text = "Rpt_xLote";
            this.Load += new System.EventHandler(this.Rpt_xLote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_presupuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_fundo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_parcela.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvt_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_consultar;
        private DevExpress.XtraEditors.LookUpEdit cbo_presupuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.CheckEdit chk_fundo;
        private DevExpress.XtraEditors.CheckEdit chk_parcela;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraWaitForm.ProgressPanel barra_progreso;
        private DevExpress.XtraPivotGrid.PivotGridControl pvt_datos;
        private DevExpress.XtraPivotGrid.PivotGridField COL_PARCELA;
        private DevExpress.XtraPivotGrid.PivotGridField COL_LOTE;
        private DevExpress.XtraPivotGrid.PivotGridField COL_HA;
        private DevExpress.XtraPivotGrid.PivotGridField COL_PERIODO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_ITEM;
        private DevExpress.XtraPivotGrid.PivotGridField COL_FUNDO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_USD;
        private DevExpress.XtraPivotGrid.PivotGridField COL_CULTIVO;
    }
}