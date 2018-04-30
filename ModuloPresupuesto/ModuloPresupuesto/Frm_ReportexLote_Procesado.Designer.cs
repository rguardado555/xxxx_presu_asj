namespace ModuloPresupuesto
{
    partial class Frm_ReportexLote_Procesado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ReportexLote_Procesado));
            this.btn_consultar = new DevExpress.XtraEditors.SimpleButton();
            this.cbo_presupuesto = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_exportar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.dtg_datos = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.COL_IDPARCELA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_PARCELA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_IDFUNDO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_FUNDO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_IDITEMCOSTO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_ITEMCOSTO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_IDLOTE = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_LOTE = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_HA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_IDCULTIVO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_CULTIVO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_IDVARIEDAD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_VARIEDAD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_IDETAPA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_ETAPA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_SEMANA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_PERIODO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_CANTIDAD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_IDSUBITEMCOSTO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_COSTOUNI_SOL = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_COSTOUNI_DOL = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_PRECIO_ORIGEN = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_MONEDA_ORIGEN = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_CON_IGV = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_DIAS_PAGO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_IDACTIVIDADSUBGRU = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_IDLABORPRODUCTO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_IDUNIDAD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_TC = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_IDTIPOCOSTO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_IDESTRUCTURA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_TABLA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_TIPOCOSTO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_ESTRUCTURA = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_SUBITEMCOSTO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_ACTIVIDADSUBGRUPO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.barrar_progreso = new DevExpress.XtraWaitForm.ProgressPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_presupuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_consultar
            // 
            this.btn_consultar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_consultar.ImageOptions.Image")));
            this.btn_consultar.Location = new System.Drawing.Point(236, 5);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(107, 23);
            this.btn_consultar.TabIndex = 92;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // cbo_presupuesto
            // 
            this.cbo_presupuesto.Location = new System.Drawing.Point(104, 7);
            this.cbo_presupuesto.Name = "cbo_presupuesto";
            this.cbo_presupuesto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_presupuesto.Properties.NullText = "[Seleccionar..]";
            this.cbo_presupuesto.Size = new System.Drawing.Size(124, 20);
            this.cbo_presupuesto.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 90;
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
            this.textBox1.Location = new System.Drawing.Point(-1, -1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1081, 33);
            this.textBox1.TabIndex = 89;
            // 
            // btn_exportar
            // 
            this.btn_exportar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_exportar.ImageOptions.Image")));
            this.btn_exportar.Location = new System.Drawing.Point(462, 5);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(107, 23);
            this.btn_exportar.TabIndex = 95;
            this.btn_exportar.Text = "Exportar";
            // 
            // btn_edit
            // 
            this.btn_edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.ImageOptions.Image")));
            this.btn_edit.Location = new System.Drawing.Point(349, 5);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(107, 23);
            this.btn_edit.TabIndex = 96;
            this.btn_edit.Text = "Editar Detalle";
            // 
            // dtg_datos
            // 
            this.dtg_datos.ActiveFilterString = "";
            this.dtg_datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_datos.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.COL_IDPARCELA,
            this.COL_PARCELA,
            this.COL_IDFUNDO,
            this.COL_FUNDO,
            this.COL_IDITEMCOSTO,
            this.COL_ITEMCOSTO,
            this.COL_IDLOTE,
            this.COL_LOTE,
            this.COL_HA,
            this.COL_IDCULTIVO,
            this.COL_CULTIVO,
            this.COL_IDVARIEDAD,
            this.COL_VARIEDAD,
            this.COL_IDETAPA,
            this.COL_ETAPA,
            this.COL_SEMANA,
            this.COL_PERIODO,
            this.COL_CANTIDAD,
            this.COL_IDSUBITEMCOSTO,
            this.COL_COSTOUNI_SOL,
            this.COL_COSTOUNI_DOL,
            this.COL_PRECIO_ORIGEN,
            this.COL_MONEDA_ORIGEN,
            this.COL_CON_IGV,
            this.COL_DIAS_PAGO,
            this.COL_IDACTIVIDADSUBGRU,
            this.COL_IDLABORPRODUCTO,
            this.COL_IDUNIDAD,
            this.COL_TC,
            this.COL_IDTIPOCOSTO,
            this.COL_IDESTRUCTURA,
            this.COL_TABLA,
            this.COL_TIPOCOSTO,
            this.COL_ESTRUCTURA,
            this.COL_SUBITEMCOSTO,
            this.COL_ACTIVIDADSUBGRUPO});
            this.dtg_datos.Location = new System.Drawing.Point(-1, 33);
            this.dtg_datos.Name = "dtg_datos";
            this.dtg_datos.Size = new System.Drawing.Size(1076, 461);
            this.dtg_datos.TabIndex = 97;
            // 
            // COL_IDPARCELA
            // 
            this.COL_IDPARCELA.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_IDPARCELA.AreaIndex = 0;
            this.COL_IDPARCELA.Caption = "IDPARCELA";
            this.COL_IDPARCELA.FieldName = "IDPARCELA";
            this.COL_IDPARCELA.Name = "COL_IDPARCELA";
            // 
            // COL_PARCELA
            // 
            this.COL_PARCELA.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_PARCELA.AreaIndex = 1;
            this.COL_PARCELA.Caption = "PARCELA";
            this.COL_PARCELA.FieldName = "PARCELA";
            this.COL_PARCELA.Name = "COL_PARCELA";
            // 
            // COL_IDFUNDO
            // 
            this.COL_IDFUNDO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_IDFUNDO.AreaIndex = 2;
            this.COL_IDFUNDO.Caption = "IDFUNDO";
            this.COL_IDFUNDO.FieldName = "IDFUNDO";
            this.COL_IDFUNDO.Name = "COL_IDFUNDO";
            // 
            // COL_FUNDO
            // 
            this.COL_FUNDO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_FUNDO.AreaIndex = 3;
            this.COL_FUNDO.Caption = "FUNDO";
            this.COL_FUNDO.FieldName = "FUNDO";
            this.COL_FUNDO.Name = "COL_FUNDO";
            // 
            // COL_IDITEMCOSTO
            // 
            this.COL_IDITEMCOSTO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_IDITEMCOSTO.AreaIndex = 4;
            this.COL_IDITEMCOSTO.Caption = "IDITEMCOSTO";
            this.COL_IDITEMCOSTO.FieldName = "IDITEMCOSTO";
            this.COL_IDITEMCOSTO.Name = "COL_IDITEMCOSTO";
            // 
            // COL_ITEMCOSTO
            // 
            this.COL_ITEMCOSTO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_ITEMCOSTO.AreaIndex = 5;
            this.COL_ITEMCOSTO.Caption = "ITEMCOSTO";
            this.COL_ITEMCOSTO.FieldName = "ITEMCOSTO";
            this.COL_ITEMCOSTO.Name = "COL_ITEMCOSTO";
            // 
            // COL_IDLOTE
            // 
            this.COL_IDLOTE.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_IDLOTE.AreaIndex = 6;
            this.COL_IDLOTE.Caption = "IDLOTE";
            this.COL_IDLOTE.FieldName = "IDLOTE";
            this.COL_IDLOTE.Name = "COL_IDLOTE";
            // 
            // COL_LOTE
            // 
            this.COL_LOTE.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_LOTE.AreaIndex = 7;
            this.COL_LOTE.Caption = "LOTE";
            this.COL_LOTE.FieldName = "LOTE";
            this.COL_LOTE.Name = "COL_LOTE";
            // 
            // COL_HA
            // 
            this.COL_HA.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_HA.AreaIndex = 8;
            this.COL_HA.Caption = "HA";
            this.COL_HA.FieldName = "HA";
            this.COL_HA.Name = "COL_HA";
            // 
            // COL_IDCULTIVO
            // 
            this.COL_IDCULTIVO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_IDCULTIVO.AreaIndex = 9;
            this.COL_IDCULTIVO.Caption = "IDCULTIVO";
            this.COL_IDCULTIVO.FieldName = "IDCULTIVO";
            this.COL_IDCULTIVO.Name = "COL_IDCULTIVO";
            // 
            // COL_CULTIVO
            // 
            this.COL_CULTIVO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_CULTIVO.AreaIndex = 10;
            this.COL_CULTIVO.Caption = "CULTIVO";
            this.COL_CULTIVO.FieldName = "CULTIVO";
            this.COL_CULTIVO.Name = "COL_CULTIVO";
            // 
            // COL_IDVARIEDAD
            // 
            this.COL_IDVARIEDAD.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_IDVARIEDAD.AreaIndex = 11;
            this.COL_IDVARIEDAD.Caption = "IDVARIEDAD";
            this.COL_IDVARIEDAD.FieldName = "IDVARIEDAD";
            this.COL_IDVARIEDAD.Name = "COL_IDVARIEDAD";
            // 
            // COL_VARIEDAD
            // 
            this.COL_VARIEDAD.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_VARIEDAD.AreaIndex = 12;
            this.COL_VARIEDAD.Caption = "VARIEDAD";
            this.COL_VARIEDAD.FieldName = "VARIEDAD";
            this.COL_VARIEDAD.Name = "COL_VARIEDAD";
            // 
            // COL_IDETAPA
            // 
            this.COL_IDETAPA.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_IDETAPA.AreaIndex = 13;
            this.COL_IDETAPA.Caption = "IDETAPA";
            this.COL_IDETAPA.FieldName = "IDETAPA";
            this.COL_IDETAPA.Name = "COL_IDETAPA";
            // 
            // COL_ETAPA
            // 
            this.COL_ETAPA.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_ETAPA.AreaIndex = 14;
            this.COL_ETAPA.Caption = "ETAPA";
            this.COL_ETAPA.FieldName = "ETAPA";
            this.COL_ETAPA.Name = "COL_ETAPA";
            // 
            // COL_SEMANA
            // 
            this.COL_SEMANA.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_SEMANA.AreaIndex = 15;
            this.COL_SEMANA.Caption = "SEMANA";
            this.COL_SEMANA.FieldName = "SEMANA";
            this.COL_SEMANA.Name = "COL_SEMANA";
            // 
            // COL_PERIODO
            // 
            this.COL_PERIODO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_PERIODO.AreaIndex = 16;
            this.COL_PERIODO.Caption = "PERIODO";
            this.COL_PERIODO.FieldName = "PERIODO";
            this.COL_PERIODO.Name = "COL_PERIODO";
            // 
            // COL_CANTIDAD
            // 
            this.COL_CANTIDAD.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_CANTIDAD.AreaIndex = 17;
            this.COL_CANTIDAD.Caption = "CANTIDAD";
            this.COL_CANTIDAD.FieldName = "CANTIDAD";
            this.COL_CANTIDAD.Name = "COL_CANTIDAD";
            // 
            // COL_IDSUBITEMCOSTO
            // 
            this.COL_IDSUBITEMCOSTO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_IDSUBITEMCOSTO.AreaIndex = 18;
            this.COL_IDSUBITEMCOSTO.Caption = "IDSUBITEMCOSTO";
            this.COL_IDSUBITEMCOSTO.FieldName = "IDSUBITEMCOSTO";
            this.COL_IDSUBITEMCOSTO.Name = "COL_IDSUBITEMCOSTO";
            // 
            // COL_COSTOUNI_SOL
            // 
            this.COL_COSTOUNI_SOL.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_COSTOUNI_SOL.AreaIndex = 23;
            this.COL_COSTOUNI_SOL.Caption = "COSTOUNI_SOL";
            this.COL_COSTOUNI_SOL.FieldName = "COSTOUNI_SOL";
            this.COL_COSTOUNI_SOL.Name = "COL_COSTOUNI_SOL";
            // 
            // COL_COSTOUNI_DOL
            // 
            this.COL_COSTOUNI_DOL.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_COSTOUNI_DOL.AreaIndex = 19;
            this.COL_COSTOUNI_DOL.Caption = "COSTOUNI_DOL";
            this.COL_COSTOUNI_DOL.FieldName = "COSTOUNI_DOL";
            this.COL_COSTOUNI_DOL.Name = "COL_COSTOUNI_DOL";
            // 
            // COL_PRECIO_ORIGEN
            // 
            this.COL_PRECIO_ORIGEN.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_PRECIO_ORIGEN.AreaIndex = 20;
            this.COL_PRECIO_ORIGEN.Caption = "PRECIO_ORIGEN";
            this.COL_PRECIO_ORIGEN.FieldName = "PRECIO_ORIGEN";
            this.COL_PRECIO_ORIGEN.Name = "COL_PRECIO_ORIGEN";
            // 
            // COL_MONEDA_ORIGEN
            // 
            this.COL_MONEDA_ORIGEN.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_MONEDA_ORIGEN.AreaIndex = 21;
            this.COL_MONEDA_ORIGEN.Caption = "MONEDA_ORIGEN";
            this.COL_MONEDA_ORIGEN.FieldName = "MONEDA_ORIGEN";
            this.COL_MONEDA_ORIGEN.Name = "COL_MONEDA_ORIGEN";
            // 
            // COL_CON_IGV
            // 
            this.COL_CON_IGV.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_CON_IGV.AreaIndex = 22;
            this.COL_CON_IGV.Caption = "CON_IGV";
            this.COL_CON_IGV.FieldName = "con_igv";
            this.COL_CON_IGV.Name = "COL_CON_IGV";
            // 
            // COL_DIAS_PAGO
            // 
            this.COL_DIAS_PAGO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_DIAS_PAGO.AreaIndex = 24;
            this.COL_DIAS_PAGO.Caption = "DIAS PAGO";
            this.COL_DIAS_PAGO.FieldName = "dias_pago";
            this.COL_DIAS_PAGO.Name = "COL_DIAS_PAGO";
            // 
            // COL_IDACTIVIDADSUBGRU
            // 
            this.COL_IDACTIVIDADSUBGRU.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_IDACTIVIDADSUBGRU.AreaIndex = 25;
            this.COL_IDACTIVIDADSUBGRU.Caption = "IDACTIVIDADSUBGRU";
            this.COL_IDACTIVIDADSUBGRU.FieldName = "IDACTIVIDADSUBGRU";
            this.COL_IDACTIVIDADSUBGRU.Name = "COL_IDACTIVIDADSUBGRU";
            // 
            // COL_IDLABORPRODUCTO
            // 
            this.COL_IDLABORPRODUCTO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_IDLABORPRODUCTO.AreaIndex = 26;
            this.COL_IDLABORPRODUCTO.Caption = "IDLABORPRODUCTO";
            this.COL_IDLABORPRODUCTO.FieldName = "IDLABORPRODUCTO";
            this.COL_IDLABORPRODUCTO.Name = "COL_IDLABORPRODUCTO";
            // 
            // COL_IDUNIDAD
            // 
            this.COL_IDUNIDAD.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_IDUNIDAD.AreaIndex = 27;
            this.COL_IDUNIDAD.Caption = "IDUNIDAD";
            this.COL_IDUNIDAD.FieldName = "IDUNIDAD";
            this.COL_IDUNIDAD.Name = "COL_IDUNIDAD";
            // 
            // COL_TC
            // 
            this.COL_TC.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_TC.AreaIndex = 28;
            this.COL_TC.Caption = "TIPO CAMBIO";
            this.COL_TC.FieldName = "TC";
            this.COL_TC.Name = "COL_TC";
            // 
            // COL_IDTIPOCOSTO
            // 
            this.COL_IDTIPOCOSTO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_IDTIPOCOSTO.AreaIndex = 29;
            this.COL_IDTIPOCOSTO.Caption = "IDTIPOCOSTO";
            this.COL_IDTIPOCOSTO.FieldName = "IDTIPOCOSTO";
            this.COL_IDTIPOCOSTO.Name = "COL_IDTIPOCOSTO";
            // 
            // COL_IDESTRUCTURA
            // 
            this.COL_IDESTRUCTURA.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_IDESTRUCTURA.AreaIndex = 30;
            this.COL_IDESTRUCTURA.Caption = "IDESTRUCTURA";
            this.COL_IDESTRUCTURA.FieldName = "IDESTRUCTURA";
            this.COL_IDESTRUCTURA.Name = "COL_IDESTRUCTURA";
            // 
            // COL_TABLA
            // 
            this.COL_TABLA.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_TABLA.AreaIndex = 31;
            this.COL_TABLA.Caption = "TABLA";
            this.COL_TABLA.FieldName = "TABLA";
            this.COL_TABLA.Name = "COL_TABLA";
            // 
            // COL_TIPOCOSTO
            // 
            this.COL_TIPOCOSTO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_TIPOCOSTO.AreaIndex = 32;
            this.COL_TIPOCOSTO.Caption = "TIPOCOSTO";
            this.COL_TIPOCOSTO.FieldName = "TIPOCOSTO";
            this.COL_TIPOCOSTO.Name = "COL_TIPOCOSTO";
            // 
            // COL_ESTRUCTURA
            // 
            this.COL_ESTRUCTURA.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_ESTRUCTURA.AreaIndex = 33;
            this.COL_ESTRUCTURA.Caption = "ESTRUCTURA";
            this.COL_ESTRUCTURA.FieldName = "ESTRUCTURA";
            this.COL_ESTRUCTURA.Name = "COL_ESTRUCTURA";
            // 
            // COL_SUBITEMCOSTO
            // 
            this.COL_SUBITEMCOSTO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_SUBITEMCOSTO.AreaIndex = 34;
            this.COL_SUBITEMCOSTO.Caption = "SUBITEMCOSTO";
            this.COL_SUBITEMCOSTO.FieldName = "SUBITEMCOSTO";
            this.COL_SUBITEMCOSTO.Name = "COL_SUBITEMCOSTO";
            // 
            // COL_ACTIVIDADSUBGRUPO
            // 
            this.COL_ACTIVIDADSUBGRUPO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.COL_ACTIVIDADSUBGRUPO.AreaIndex = 35;
            this.COL_ACTIVIDADSUBGRUPO.Caption = "ACTIVIDADSUBGRUPO";
            this.COL_ACTIVIDADSUBGRUPO.FieldName = "ACTIVIDADSUBGRUPO";
            this.COL_ACTIVIDADSUBGRUPO.Name = "COL_ACTIVIDADSUBGRUPO";
            // 
            // barrar_progreso
            // 
            this.barrar_progreso.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.barrar_progreso.Appearance.Options.UseBackColor = true;
            this.barrar_progreso.BarAnimationElementThickness = 2;
            this.barrar_progreso.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.barrar_progreso.Caption = "         Un momento";
            this.barrar_progreso.Description = "              Cargando ...";
            this.barrar_progreso.Location = new System.Drawing.Point(427, 264);
            this.barrar_progreso.Name = "barrar_progreso";
            this.barrar_progreso.Size = new System.Drawing.Size(166, 66);
            this.barrar_progreso.TabIndex = 98;
            this.barrar_progreso.Text = "progressPanel1";
            this.barrar_progreso.Visible = false;
            this.barrar_progreso.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_ReportexLote_Procesado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 492);
            this.Controls.Add(this.barrar_progreso);
            this.Controls.Add(this.dtg_datos);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.cbo_presupuesto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Frm_ReportexLote_Procesado";
            this.Text = "Frm_ReportexLote_Procesado";
            this.Load += new System.EventHandler(this.Frm_ReportexLote_Procesado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_presupuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_consultar;
        private DevExpress.XtraEditors.LookUpEdit cbo_presupuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton btn_exportar;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraPivotGrid.PivotGridControl dtg_datos;
        private DevExpress.XtraPivotGrid.PivotGridField COL_IDPARCELA;
        private DevExpress.XtraPivotGrid.PivotGridField COL_PARCELA;
        private DevExpress.XtraPivotGrid.PivotGridField COL_IDFUNDO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_FUNDO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_IDITEMCOSTO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_ITEMCOSTO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_IDLOTE;
        private DevExpress.XtraPivotGrid.PivotGridField COL_LOTE;
        private DevExpress.XtraPivotGrid.PivotGridField COL_HA;
        private DevExpress.XtraPivotGrid.PivotGridField COL_IDCULTIVO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_CULTIVO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_IDVARIEDAD;
        private DevExpress.XtraPivotGrid.PivotGridField COL_VARIEDAD;
        private DevExpress.XtraPivotGrid.PivotGridField COL_IDETAPA;
        private DevExpress.XtraPivotGrid.PivotGridField COL_ETAPA;
        private DevExpress.XtraPivotGrid.PivotGridField COL_SEMANA;
        private DevExpress.XtraPivotGrid.PivotGridField COL_PERIODO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_CANTIDAD;
        private DevExpress.XtraPivotGrid.PivotGridField COL_IDSUBITEMCOSTO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_COSTOUNI_SOL;
        private DevExpress.XtraPivotGrid.PivotGridField COL_COSTOUNI_DOL;
        private DevExpress.XtraPivotGrid.PivotGridField COL_PRECIO_ORIGEN;
        private DevExpress.XtraPivotGrid.PivotGridField COL_MONEDA_ORIGEN;
        private DevExpress.XtraPivotGrid.PivotGridField COL_CON_IGV;
        private DevExpress.XtraPivotGrid.PivotGridField COL_DIAS_PAGO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_IDACTIVIDADSUBGRU;
        private DevExpress.XtraPivotGrid.PivotGridField COL_IDLABORPRODUCTO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_IDUNIDAD;
        private DevExpress.XtraPivotGrid.PivotGridField COL_TC;
        private DevExpress.XtraPivotGrid.PivotGridField COL_IDTIPOCOSTO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_IDESTRUCTURA;
        private DevExpress.XtraPivotGrid.PivotGridField COL_TABLA;
        private DevExpress.XtraPivotGrid.PivotGridField COL_TIPOCOSTO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_ESTRUCTURA;
        private DevExpress.XtraPivotGrid.PivotGridField COL_SUBITEMCOSTO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_ACTIVIDADSUBGRUPO;
        private DevExpress.XtraWaitForm.ProgressPanel barrar_progreso;
        private System.Windows.Forms.Timer timer1;
    }
}