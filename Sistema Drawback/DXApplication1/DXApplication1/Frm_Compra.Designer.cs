namespace DXApplication1
{
    partial class Frm_Compra
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Compra));
            this.COL_SUBTOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.monoFlat_Panel1 = new MonoFlat.MonoFlat_Panel();
            this.txt_tc = new System.Windows.Forms.MaskedTextBox();
            this.monoFlat_Label9 = new MonoFlat.MonoFlat_Label();
            this.cbo_moneda = new DevExpress.XtraEditors.LookUpEdit();
            this.monoFlat_Label8 = new MonoFlat.MonoFlat_Label();
            this.txt_id = new DevExpress.XtraEditors.TextEdit();
            this.txt_operacion = new DevExpress.XtraEditors.TextEdit();
            this.txt_idoperacion = new DevExpress.XtraEditors.TextEdit();
            this.dtp_fechaoperacion = new DevExpress.XtraEditors.DateEdit();
            this.monoFlat_Label7 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label6 = new MonoFlat.MonoFlat_Label();
            this.dtp_fechadoc = new DevExpress.XtraEditors.DateEdit();
            this.cbo_clieprov = new DevExpress.XtraEditors.LookUpEdit();
            this.monoFlat_Label5 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label4 = new MonoFlat.MonoFlat_Label();
            this.txt_numero = new DevExpress.XtraEditors.TextEdit();
            this.txt_serie = new DevExpress.XtraEditors.TextEdit();
            this.cbo_documento = new DevExpress.XtraEditors.LookUpEdit();
            this.monoFlat_Label3 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label2 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Panel2 = new MonoFlat.MonoFlat_Panel();
            this.dtg_datos = new DevExpress.XtraGrid.GridControl();
            this.vista_datos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.COL_ITEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_IDPRODUCTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbo_productodetalle = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.COL_IMP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_IMPUESTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_PRECIOUNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_TOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_MEDIDA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_CANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_PRODUCTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cbo_medida = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.txt_medidadetalle = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.menu_opciones = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_nuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btn_editar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_guardar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_cancelar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_eliminar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_addDetalle = new DevExpress.XtraBars.BarButtonItem();
            this.btn_deleteDetalle = new DevExpress.XtraBars.BarButtonItem();
            this.btn_exit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_salir = new DevExpress.XtraBars.BarButtonItem();
            this.monoFlat_Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_moneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_operacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_idoperacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fechaoperacion.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fechaoperacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fechadoc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fechadoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_clieprov.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_numero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_serie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_documento.Properties)).BeginInit();
            this.monoFlat_Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_productodetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_medida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_medidadetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_opciones)).BeginInit();
            this.SuspendLayout();
            // 
            // COL_SUBTOTAL
            // 
            this.COL_SUBTOTAL.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_SUBTOTAL.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.COL_SUBTOTAL.AppearanceCell.Options.UseFont = true;
            this.COL_SUBTOTAL.AppearanceCell.Options.UseForeColor = true;
            this.COL_SUBTOTAL.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_SUBTOTAL.AppearanceHeader.Options.UseFont = true;
            this.COL_SUBTOTAL.Caption = "Sub Total";
            this.COL_SUBTOTAL.DisplayFormat.FormatString = "{0:n4}";
            this.COL_SUBTOTAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_SUBTOTAL.FieldName = "SUBTOTAL";
            this.COL_SUBTOTAL.Name = "COL_SUBTOTAL";
            this.COL_SUBTOTAL.OptionsColumn.AllowEdit = false;
            this.COL_SUBTOTAL.Visible = true;
            this.COL_SUBTOTAL.VisibleIndex = 6;
            this.COL_SUBTOTAL.Width = 85;
            // 
            // monoFlat_Panel1
            // 
            this.monoFlat_Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.monoFlat_Panel1.Controls.Add(this.txt_tc);
            this.monoFlat_Panel1.Controls.Add(this.monoFlat_Label9);
            this.monoFlat_Panel1.Controls.Add(this.cbo_moneda);
            this.monoFlat_Panel1.Controls.Add(this.monoFlat_Label8);
            this.monoFlat_Panel1.Controls.Add(this.txt_id);
            this.monoFlat_Panel1.Controls.Add(this.txt_operacion);
            this.monoFlat_Panel1.Controls.Add(this.txt_idoperacion);
            this.monoFlat_Panel1.Controls.Add(this.dtp_fechaoperacion);
            this.monoFlat_Panel1.Controls.Add(this.monoFlat_Label7);
            this.monoFlat_Panel1.Controls.Add(this.monoFlat_Label6);
            this.monoFlat_Panel1.Controls.Add(this.dtp_fechadoc);
            this.monoFlat_Panel1.Controls.Add(this.cbo_clieprov);
            this.monoFlat_Panel1.Controls.Add(this.monoFlat_Label5);
            this.monoFlat_Panel1.Controls.Add(this.monoFlat_Label4);
            this.monoFlat_Panel1.Controls.Add(this.txt_numero);
            this.monoFlat_Panel1.Controls.Add(this.txt_serie);
            this.monoFlat_Panel1.Controls.Add(this.cbo_documento);
            this.monoFlat_Panel1.Controls.Add(this.monoFlat_Label3);
            this.monoFlat_Panel1.Controls.Add(this.monoFlat_Label2);
            this.monoFlat_Panel1.Controls.Add(this.monoFlat_Label1);
            this.monoFlat_Panel1.Location = new System.Drawing.Point(2, 29);
            this.monoFlat_Panel1.Name = "monoFlat_Panel1";
            this.monoFlat_Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.monoFlat_Panel1.Size = new System.Drawing.Size(1072, 150);
            this.monoFlat_Panel1.TabIndex = 0;
            this.monoFlat_Panel1.Text = "monoFlat_Panel1";
            // 
            // txt_tc
            // 
            this.txt_tc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tc.Location = new System.Drawing.Point(565, 24);
            this.txt_tc.Mask = "#.####";
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(90, 23);
            this.txt_tc.TabIndex = 23;
            // 
            // monoFlat_Label9
            // 
            this.monoFlat_Label9.AutoSize = true;
            this.monoFlat_Label9.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label9.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label9.Location = new System.Drawing.Point(476, 24);
            this.monoFlat_Label9.Name = "monoFlat_Label9";
            this.monoFlat_Label9.Size = new System.Drawing.Size(83, 17);
            this.monoFlat_Label9.TabIndex = 21;
            this.monoFlat_Label9.Text = "Tipo Cambio";
            // 
            // cbo_moneda
            // 
            this.cbo_moneda.Location = new System.Drawing.Point(313, 21);
            this.cbo_moneda.Name = "cbo_moneda";
            this.cbo_moneda.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_moneda.Properties.Appearance.Options.UseFont = true;
            this.cbo_moneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_moneda.Properties.NullText = "[Seleccione]";
            this.cbo_moneda.Size = new System.Drawing.Size(119, 24);
            this.cbo_moneda.TabIndex = 20;
            // 
            // monoFlat_Label8
            // 
            this.monoFlat_Label8.AutoSize = true;
            this.monoFlat_Label8.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label8.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label8.Location = new System.Drawing.Point(249, 24);
            this.monoFlat_Label8.Name = "monoFlat_Label8";
            this.monoFlat_Label8.Size = new System.Drawing.Size(57, 17);
            this.monoFlat_Label8.TabIndex = 19;
            this.monoFlat_Label8.Text = "Moneda";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(1027, 118);
            this.txt_id.Name = "txt_id";
            this.txt_id.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Properties.Appearance.Options.UseFont = true;
            this.txt_id.Properties.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(27, 24);
            this.txt_id.TabIndex = 18;
            this.txt_id.Visible = false;
            // 
            // txt_operacion
            // 
            this.txt_operacion.Location = new System.Drawing.Point(164, 21);
            this.txt_operacion.Name = "txt_operacion";
            this.txt_operacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_operacion.Properties.Appearance.Options.UseFont = true;
            this.txt_operacion.Properties.ReadOnly = true;
            this.txt_operacion.Size = new System.Drawing.Size(80, 24);
            this.txt_operacion.TabIndex = 17;
            // 
            // txt_idoperacion
            // 
            this.txt_idoperacion.Location = new System.Drawing.Point(125, 21);
            this.txt_idoperacion.Name = "txt_idoperacion";
            this.txt_idoperacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idoperacion.Properties.Appearance.Options.UseFont = true;
            this.txt_idoperacion.Properties.ReadOnly = true;
            this.txt_idoperacion.Size = new System.Drawing.Size(33, 24);
            this.txt_idoperacion.TabIndex = 16;
            // 
            // dtp_fechaoperacion
            // 
            this.dtp_fechaoperacion.EditValue = null;
            this.dtp_fechaoperacion.Enabled = false;
            this.dtp_fechaoperacion.Location = new System.Drawing.Point(907, 8);
            this.dtp_fechaoperacion.Name = "dtp_fechaoperacion";
            this.dtp_fechaoperacion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechaoperacion.Properties.Appearance.Options.UseFont = true;
            this.dtp_fechaoperacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_fechaoperacion.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_fechaoperacion.Properties.ReadOnly = true;
            this.dtp_fechaoperacion.Size = new System.Drawing.Size(147, 24);
            this.dtp_fechaoperacion.TabIndex = 15;
            this.dtp_fechaoperacion.Visible = false;
            // 
            // monoFlat_Label7
            // 
            this.monoFlat_Label7.AutoSize = true;
            this.monoFlat_Label7.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label7.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label7.Location = new System.Drawing.Point(793, 11);
            this.monoFlat_Label7.Name = "monoFlat_Label7";
            this.monoFlat_Label7.Size = new System.Drawing.Size(106, 17);
            this.monoFlat_Label7.TabIndex = 14;
            this.monoFlat_Label7.Text = "Fecha Operación";
            this.monoFlat_Label7.Visible = false;
            // 
            // monoFlat_Label6
            // 
            this.monoFlat_Label6.AutoSize = true;
            this.monoFlat_Label6.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label6.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label6.Location = new System.Drawing.Point(531, 115);
            this.monoFlat_Label6.Name = "monoFlat_Label6";
            this.monoFlat_Label6.Size = new System.Drawing.Size(112, 17);
            this.monoFlat_Label6.TabIndex = 13;
            this.monoFlat_Label6.Text = "Fecha Documento";
            // 
            // dtp_fechadoc
            // 
            this.dtp_fechadoc.EditValue = null;
            this.dtp_fechadoc.Location = new System.Drawing.Point(653, 111);
            this.dtp_fechadoc.Name = "dtp_fechadoc";
            this.dtp_fechadoc.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechadoc.Properties.Appearance.Options.UseFont = true;
            this.dtp_fechadoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_fechadoc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_fechadoc.Size = new System.Drawing.Size(139, 24);
            this.dtp_fechadoc.TabIndex = 12;
            // 
            // cbo_clieprov
            // 
            this.cbo_clieprov.Location = new System.Drawing.Point(125, 65);
            this.cbo_clieprov.Name = "cbo_clieprov";
            this.cbo_clieprov.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_clieprov.Properties.Appearance.Options.UseFont = true;
            this.cbo_clieprov.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_clieprov.Properties.NullText = "[Seleccione]";
            this.cbo_clieprov.Size = new System.Drawing.Size(530, 24);
            this.cbo_clieprov.TabIndex = 11;
            // 
            // monoFlat_Label5
            // 
            this.monoFlat_Label5.AutoSize = true;
            this.monoFlat_Label5.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label5.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label5.Location = new System.Drawing.Point(10, 69);
            this.monoFlat_Label5.Name = "monoFlat_Label5";
            this.monoFlat_Label5.Size = new System.Drawing.Size(113, 17);
            this.monoFlat_Label5.TabIndex = 10;
            this.monoFlat_Label5.Text = "Cliente/Proveedor";
            // 
            // monoFlat_Label4
            // 
            this.monoFlat_Label4.AutoSize = true;
            this.monoFlat_Label4.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label4.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label4.Location = new System.Drawing.Point(10, 24);
            this.monoFlat_Label4.Name = "monoFlat_Label4";
            this.monoFlat_Label4.Size = new System.Drawing.Size(69, 17);
            this.monoFlat_Label4.TabIndex = 8;
            this.monoFlat_Label4.Text = "Operación";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(435, 112);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Properties.Appearance.Options.UseFont = true;
            this.txt_numero.Size = new System.Drawing.Size(90, 24);
            this.txt_numero.TabIndex = 7;
            // 
            // txt_serie
            // 
            this.txt_serie.Location = new System.Drawing.Point(282, 111);
            this.txt_serie.Name = "txt_serie";
            this.txt_serie.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serie.Properties.Appearance.Options.UseFont = true;
            this.txt_serie.Size = new System.Drawing.Size(90, 24);
            this.txt_serie.TabIndex = 6;
            // 
            // cbo_documento
            // 
            this.cbo_documento.Location = new System.Drawing.Point(125, 111);
            this.cbo_documento.Name = "cbo_documento";
            this.cbo_documento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_documento.Properties.Appearance.Options.UseFont = true;
            this.cbo_documento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_documento.Properties.NullText = "[Seleccione]";
            this.cbo_documento.Size = new System.Drawing.Size(119, 24);
            this.cbo_documento.TabIndex = 5;
            // 
            // monoFlat_Label3
            // 
            this.monoFlat_Label3.AutoSize = true;
            this.monoFlat_Label3.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label3.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label3.Location = new System.Drawing.Point(376, 116);
            this.monoFlat_Label3.Name = "monoFlat_Label3";
            this.monoFlat_Label3.Size = new System.Drawing.Size(56, 17);
            this.monoFlat_Label3.TabIndex = 2;
            this.monoFlat_Label3.Text = "Numero";
            this.monoFlat_Label3.Click += new System.EventHandler(this.monoFlat_Label3_Click);
            // 
            // monoFlat_Label2
            // 
            this.monoFlat_Label2.AutoSize = true;
            this.monoFlat_Label2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label2.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label2.Location = new System.Drawing.Point(244, 115);
            this.monoFlat_Label2.Name = "monoFlat_Label2";
            this.monoFlat_Label2.Size = new System.Drawing.Size(37, 17);
            this.monoFlat_Label2.TabIndex = 1;
            this.monoFlat_Label2.Text = "Serie";
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label1.Location = new System.Drawing.Point(10, 115);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(75, 17);
            this.monoFlat_Label1.TabIndex = 0;
            this.monoFlat_Label1.Text = "Documento";
            // 
            // monoFlat_Panel2
            // 
            this.monoFlat_Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.monoFlat_Panel2.Controls.Add(this.dtg_datos);
            this.monoFlat_Panel2.Location = new System.Drawing.Point(2, 181);
            this.monoFlat_Panel2.Name = "monoFlat_Panel2";
            this.monoFlat_Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.monoFlat_Panel2.Size = new System.Drawing.Size(1072, 325);
            this.monoFlat_Panel2.TabIndex = 1;
            this.monoFlat_Panel2.Text = "monoFlat_Panel2";
            // 
            // dtg_datos
            // 
            this.dtg_datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_datos.Location = new System.Drawing.Point(3, 4);
            this.dtg_datos.MainView = this.vista_datos;
            this.dtg_datos.Name = "dtg_datos";
            this.dtg_datos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.cbo_productodetalle,
            this.cbo_medida,
            this.txt_medidadetalle});
            this.dtg_datos.Size = new System.Drawing.Size(1064, 321);
            this.dtg_datos.TabIndex = 0;
            this.dtg_datos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vista_datos});
            // 
            // vista_datos
            // 
            this.vista_datos.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vista_datos.Appearance.FooterPanel.Options.UseFont = true;
            this.vista_datos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vista_datos.Appearance.HeaderPanel.Options.UseFont = true;
            this.vista_datos.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vista_datos.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vista_datos.Appearance.Row.Options.UseFont = true;
            this.vista_datos.Appearance.Row.Options.UseForeColor = true;
            this.vista_datos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.COL_SUBTOTAL,
            this.COL_ITEM,
            this.COL_IDPRODUCTO,
            this.COL_IMP,
            this.COL_IMPUESTO,
            this.COL_PRECIOUNIT,
            this.COL_TOTAL,
            this.COL_MEDIDA,
            this.COL_CANTIDAD,
            this.COL_PRODUCTO});
            gridFormatRule2.ColumnApplyTo = this.COL_SUBTOTAL;
            gridFormatRule2.Name = "Format0";
            formatConditionRuleExpression2.Expression = "[PRECIOUNIT] * [CANTIDAD]";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            this.vista_datos.FormatRules.Add(gridFormatRule2);
            this.vista_datos.GridControl = this.dtg_datos;
            this.vista_datos.Name = "vista_datos";
            this.vista_datos.OptionsView.ShowFooter = true;
            this.vista_datos.OptionsView.ShowGroupPanel = false;
            this.vista_datos.ShownEditor += new System.EventHandler(this.vista_datos_ShownEditor);
            this.vista_datos.ColumnChanged += new System.EventHandler(this.vista_datos_ColumnChanged);
            this.vista_datos.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.vista_datos_CellValueChanged);
            this.vista_datos.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.vista_datos_InvalidRowException);
            this.vista_datos.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.vista_datos_CustomUnboundColumnData);
            this.vista_datos.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.vista_datos_CustomColumnDisplayText);
            // 
            // COL_ITEM
            // 
            this.COL_ITEM.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_ITEM.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.COL_ITEM.AppearanceCell.Options.UseFont = true;
            this.COL_ITEM.AppearanceCell.Options.UseForeColor = true;
            this.COL_ITEM.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_ITEM.AppearanceHeader.Options.UseFont = true;
            this.COL_ITEM.Caption = "Item";
            this.COL_ITEM.FieldName = "ITEM";
            this.COL_ITEM.Name = "COL_ITEM";
            this.COL_ITEM.OptionsColumn.AllowEdit = false;
            this.COL_ITEM.Visible = true;
            this.COL_ITEM.VisibleIndex = 0;
            this.COL_ITEM.Width = 46;
            // 
            // COL_IDPRODUCTO
            // 
            this.COL_IDPRODUCTO.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_IDPRODUCTO.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.COL_IDPRODUCTO.AppearanceCell.Options.UseFont = true;
            this.COL_IDPRODUCTO.AppearanceCell.Options.UseForeColor = true;
            this.COL_IDPRODUCTO.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_IDPRODUCTO.AppearanceHeader.Options.UseFont = true;
            this.COL_IDPRODUCTO.Caption = "Codigo";
            this.COL_IDPRODUCTO.ColumnEdit = this.cbo_productodetalle;
            this.COL_IDPRODUCTO.FieldName = "IDPRODUCTO";
            this.COL_IDPRODUCTO.Name = "COL_IDPRODUCTO";
            this.COL_IDPRODUCTO.Visible = true;
            this.COL_IDPRODUCTO.VisibleIndex = 1;
            this.COL_IDPRODUCTO.Width = 147;
            // 
            // cbo_productodetalle
            // 
            this.cbo_productodetalle.AutoHeight = false;
            this.cbo_productodetalle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_productodetalle.Name = "cbo_productodetalle";
            this.cbo_productodetalle.NullText = "[Seleccionar]";
            this.cbo_productodetalle.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cbo_productodetalle_ButtonClick);
            this.cbo_productodetalle.EditValueChanged += new System.EventHandler(this.cbo_productodetalle_EditValueChanged);
            this.cbo_productodetalle.MouseLeave += new System.EventHandler(this.cbo_productodetalle_MouseLeave);
            // 
            // COL_IMP
            // 
            this.COL_IMP.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.COL_IMP.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_IMP.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.COL_IMP.AppearanceCell.Options.UseBackColor = true;
            this.COL_IMP.AppearanceCell.Options.UseFont = true;
            this.COL_IMP.AppearanceCell.Options.UseForeColor = true;
            this.COL_IMP.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_IMP.AppearanceHeader.Options.UseFont = true;
            this.COL_IMP.Caption = "% Imp";
            this.COL_IMP.DisplayFormat.FormatString = "{0:n4}";
            this.COL_IMP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_IMP.FieldName = "IMP";
            this.COL_IMP.Name = "COL_IMP";
            this.COL_IMP.Visible = true;
            this.COL_IMP.VisibleIndex = 7;
            this.COL_IMP.Width = 101;
            // 
            // COL_IMPUESTO
            // 
            this.COL_IMPUESTO.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_IMPUESTO.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.COL_IMPUESTO.AppearanceCell.Options.UseFont = true;
            this.COL_IMPUESTO.AppearanceCell.Options.UseForeColor = true;
            this.COL_IMPUESTO.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_IMPUESTO.AppearanceHeader.Options.UseFont = true;
            this.COL_IMPUESTO.Caption = "Impuesto";
            this.COL_IMPUESTO.DisplayFormat.FormatString = "{0:n4}";
            this.COL_IMPUESTO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_IMPUESTO.FieldName = "IMPUESTO";
            this.COL_IMPUESTO.Name = "COL_IMPUESTO";
            this.COL_IMPUESTO.OptionsColumn.AllowEdit = false;
            this.COL_IMPUESTO.Visible = true;
            this.COL_IMPUESTO.VisibleIndex = 8;
            this.COL_IMPUESTO.Width = 101;
            // 
            // COL_PRECIOUNIT
            // 
            this.COL_PRECIOUNIT.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.COL_PRECIOUNIT.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_PRECIOUNIT.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.COL_PRECIOUNIT.AppearanceCell.Options.UseBackColor = true;
            this.COL_PRECIOUNIT.AppearanceCell.Options.UseFont = true;
            this.COL_PRECIOUNIT.AppearanceCell.Options.UseForeColor = true;
            this.COL_PRECIOUNIT.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_PRECIOUNIT.AppearanceHeader.Options.UseFont = true;
            this.COL_PRECIOUNIT.Caption = "PrecioUnit";
            this.COL_PRECIOUNIT.DisplayFormat.FormatString = "{0:n4}";
            this.COL_PRECIOUNIT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_PRECIOUNIT.FieldName = "PRECIOUNIT";
            this.COL_PRECIOUNIT.Name = "COL_PRECIOUNIT";
            this.COL_PRECIOUNIT.Visible = true;
            this.COL_PRECIOUNIT.VisibleIndex = 5;
            // 
            // COL_TOTAL
            // 
            this.COL_TOTAL.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_TOTAL.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.COL_TOTAL.AppearanceCell.Options.UseFont = true;
            this.COL_TOTAL.AppearanceCell.Options.UseForeColor = true;
            this.COL_TOTAL.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_TOTAL.AppearanceHeader.Options.UseFont = true;
            this.COL_TOTAL.Caption = "Total";
            this.COL_TOTAL.DisplayFormat.FormatString = "{0:n4}";
            this.COL_TOTAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_TOTAL.FieldName = "TOTAL";
            this.COL_TOTAL.Name = "COL_TOTAL";
            this.COL_TOTAL.OptionsColumn.AllowEdit = false;
            this.COL_TOTAL.Visible = true;
            this.COL_TOTAL.VisibleIndex = 9;
            this.COL_TOTAL.Width = 181;
            // 
            // COL_MEDIDA
            // 
            this.COL_MEDIDA.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_MEDIDA.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.COL_MEDIDA.AppearanceCell.Options.UseFont = true;
            this.COL_MEDIDA.AppearanceCell.Options.UseForeColor = true;
            this.COL_MEDIDA.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_MEDIDA.AppearanceHeader.Options.UseFont = true;
            this.COL_MEDIDA.Caption = "Medida";
            this.COL_MEDIDA.FieldName = "IDMEDIDA";
            this.COL_MEDIDA.Name = "COL_MEDIDA";
            this.COL_MEDIDA.OptionsColumn.AllowEdit = false;
            this.COL_MEDIDA.Visible = true;
            this.COL_MEDIDA.VisibleIndex = 4;
            this.COL_MEDIDA.Width = 118;
            // 
            // COL_CANTIDAD
            // 
            this.COL_CANTIDAD.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.COL_CANTIDAD.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_CANTIDAD.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.COL_CANTIDAD.AppearanceCell.Options.UseBackColor = true;
            this.COL_CANTIDAD.AppearanceCell.Options.UseFont = true;
            this.COL_CANTIDAD.AppearanceCell.Options.UseForeColor = true;
            this.COL_CANTIDAD.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_CANTIDAD.AppearanceHeader.Options.UseFont = true;
            this.COL_CANTIDAD.Caption = "Cantidad";
            this.COL_CANTIDAD.DisplayFormat.FormatString = "{0:n4}";
            this.COL_CANTIDAD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_CANTIDAD.FieldName = "CANTIDAD";
            this.COL_CANTIDAD.Name = "COL_CANTIDAD";
            this.COL_CANTIDAD.Visible = true;
            this.COL_CANTIDAD.VisibleIndex = 3;
            this.COL_CANTIDAD.Width = 73;
            // 
            // COL_PRODUCTO
            // 
            this.COL_PRODUCTO.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_PRODUCTO.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.COL_PRODUCTO.AppearanceCell.Options.UseFont = true;
            this.COL_PRODUCTO.AppearanceCell.Options.UseForeColor = true;
            this.COL_PRODUCTO.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_PRODUCTO.AppearanceHeader.Options.UseFont = true;
            this.COL_PRODUCTO.Caption = "Producto";
            this.COL_PRODUCTO.FieldName = "PRODUCTO";
            this.COL_PRODUCTO.Name = "COL_PRODUCTO";
            this.COL_PRODUCTO.OptionsColumn.AllowEdit = false;
            this.COL_PRODUCTO.Visible = true;
            this.COL_PRODUCTO.VisibleIndex = 2;
            this.COL_PRODUCTO.Width = 119;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // cbo_medida
            // 
            this.cbo_medida.AutoHeight = false;
            this.cbo_medida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_medida.Name = "cbo_medida";
            this.cbo_medida.NullText = "[Seleccionar]";
            // 
            // txt_medidadetalle
            // 
            this.txt_medidadetalle.AutoHeight = false;
            this.txt_medidadetalle.Name = "txt_medidadetalle";
            // 
            // menu_opciones
            // 
            this.menu_opciones.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.menu_opciones.DockControls.Add(this.barDockControl1);
            this.menu_opciones.DockControls.Add(this.barDockControl2);
            this.menu_opciones.DockControls.Add(this.barDockControl3);
            this.menu_opciones.DockControls.Add(this.barDockControl4);
            this.menu_opciones.Form = this;
            this.menu_opciones.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_nuevo,
            this.barButtonItem12,
            this.btn_editar,
            this.btn_guardar,
            this.btn_cancelar,
            this.btn_eliminar,
            this.btn_salir,
            this.btn_exit,
            this.btn_addDetalle,
            this.btn_deleteDetalle});
            this.menu_opciones.MaxItemId = 10;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_nuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_editar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_guardar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_cancelar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_eliminar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_addDetalle, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_deleteDetalle, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_exit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Herramientas";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Caption = "&Nuevo";
            this.btn_nuevo.Id = 0;
            this.btn_nuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.ImageOptions.Image")));
            this.btn_nuevo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.ImageOptions.LargeImage")));
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_nuevo_ItemClick);
            // 
            // btn_editar
            // 
            this.btn_editar.Caption = "&Editar";
            this.btn_editar.Id = 2;
            this.btn_editar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.ImageOptions.Image")));
            this.btn_editar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_editar.ImageOptions.LargeImage")));
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_editar_ItemClick);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Caption = "&Guardar";
            this.btn_guardar.Id = 3;
            this.btn_guardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.ImageOptions.Image")));
            this.btn_guardar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_guardar.ImageOptions.LargeImage")));
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_guardar_ItemClick);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Caption = "&Cancelar";
            this.btn_cancelar.Id = 4;
            this.btn_cancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.ImageOptions.Image")));
            this.btn_cancelar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.ImageOptions.LargeImage")));
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_cancelar_ItemClick);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Caption = "&Eliminar";
            this.btn_eliminar.Id = 5;
            this.btn_eliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.ImageOptions.Image")));
            this.btn_eliminar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.ImageOptions.LargeImage")));
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_eliminar_ItemClick);
            // 
            // btn_addDetalle
            // 
            this.btn_addDetalle.Caption = "&Agregar Detalle";
            this.btn_addDetalle.Id = 8;
            this.btn_addDetalle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_addDetalle.ImageOptions.Image")));
            this.btn_addDetalle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_addDetalle.ImageOptions.LargeImage")));
            this.btn_addDetalle.Name = "btn_addDetalle";
            this.btn_addDetalle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_addDetalle_ItemClick);
            // 
            // btn_deleteDetalle
            // 
            this.btn_deleteDetalle.Caption = "&Quitar Detalle";
            this.btn_deleteDetalle.Id = 9;
            this.btn_deleteDetalle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteDetalle.ImageOptions.Image")));
            this.btn_deleteDetalle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_deleteDetalle.ImageOptions.LargeImage")));
            this.btn_deleteDetalle.Name = "btn_deleteDetalle";
            this.btn_deleteDetalle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_deleteDetalle_ItemClick);
            // 
            // btn_exit
            // 
            this.btn_exit.Caption = "&Salir";
            this.btn_exit.Id = 7;
            this.btn_exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.ImageOptions.Image")));
            this.btn_exit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.ImageOptions.LargeImage")));
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_exit_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.menu_opciones;
            this.barDockControl1.Size = new System.Drawing.Size(1076, 31);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 509);
            this.barDockControl2.Manager = this.menu_opciones;
            this.barDockControl2.Size = new System.Drawing.Size(1076, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 31);
            this.barDockControl3.Manager = this.menu_opciones;
            this.barDockControl3.Size = new System.Drawing.Size(0, 478);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1076, 31);
            this.barDockControl4.Manager = this.menu_opciones;
            this.barDockControl4.Size = new System.Drawing.Size(0, 478);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "barButtonItem2";
            this.barButtonItem12.Id = 1;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // btn_salir
            // 
            this.btn_salir.Caption = "&Salir";
            this.btn_salir.Id = 6;
            this.btn_salir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.ImageOptions.Image")));
            this.btn_salir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_salir.ImageOptions.LargeImage")));
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // Frm_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 509);
            this.ControlBox = false;
            this.Controls.Add(this.monoFlat_Panel2);
            this.Controls.Add(this.monoFlat_Panel1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Frm_Compra_Load);
            this.monoFlat_Panel1.ResumeLayout(false);
            this.monoFlat_Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_moneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_operacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_idoperacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fechaoperacion.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fechaoperacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fechadoc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fechadoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_clieprov.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_numero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_serie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_documento.Properties)).EndInit();
            this.monoFlat_Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_productodetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_medida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_medidadetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_opciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonoFlat.MonoFlat_Panel monoFlat_Panel1;
        private MonoFlat.MonoFlat_Label monoFlat_Label1;
        private MonoFlat.MonoFlat_Panel monoFlat_Panel2;
        private MonoFlat.MonoFlat_Label monoFlat_Label4;
        private DevExpress.XtraEditors.TextEdit txt_numero;
        private DevExpress.XtraEditors.TextEdit txt_serie;
        private DevExpress.XtraEditors.LookUpEdit cbo_documento;
        private MonoFlat.MonoFlat_Label monoFlat_Label3;
        private MonoFlat.MonoFlat_Label monoFlat_Label2;
        private DevExpress.XtraEditors.DateEdit dtp_fechaoperacion;
        private MonoFlat.MonoFlat_Label monoFlat_Label7;
        private MonoFlat.MonoFlat_Label monoFlat_Label6;
        private DevExpress.XtraEditors.DateEdit dtp_fechadoc;
        private DevExpress.XtraEditors.LookUpEdit cbo_clieprov;
        private MonoFlat.MonoFlat_Label monoFlat_Label5;
        private DevExpress.XtraGrid.GridControl dtg_datos;
        private DevExpress.XtraGrid.Views.Grid.GridView vista_datos;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.TextEdit txt_operacion;
        private DevExpress.XtraEditors.TextEdit txt_idoperacion;
        private DevExpress.XtraBars.BarManager menu_opciones;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_nuevo;
        private DevExpress.XtraBars.BarButtonItem btn_editar;
        private DevExpress.XtraBars.BarButtonItem btn_guardar;
        private DevExpress.XtraBars.BarButtonItem btn_cancelar;
        private DevExpress.XtraBars.BarButtonItem btn_eliminar;
        private DevExpress.XtraBars.BarButtonItem btn_exit;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem btn_salir;
        private DevExpress.XtraGrid.Columns.GridColumn COL_ITEM;
        private DevExpress.XtraGrid.Columns.GridColumn COL_IDPRODUCTO;
        private DevExpress.XtraGrid.Columns.GridColumn COL_IMP;
        private DevExpress.XtraGrid.Columns.GridColumn COL_IMPUESTO;
        private DevExpress.XtraGrid.Columns.GridColumn COL_PRECIOUNIT;
        private DevExpress.XtraGrid.Columns.GridColumn COL_TOTAL;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private DevExpress.XtraBars.BarButtonItem btn_addDetalle;
        private DevExpress.XtraBars.BarButtonItem btn_deleteDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn COL_SUBTOTAL;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbo_productodetalle;
        private DevExpress.XtraGrid.Columns.GridColumn COL_MEDIDA;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbo_medida;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txt_medidadetalle;
        private DevExpress.XtraGrid.Columns.GridColumn COL_CANTIDAD;
        private DevExpress.XtraGrid.Columns.GridColumn COL_PRODUCTO;
        private DevExpress.XtraEditors.LookUpEdit cbo_moneda;
        private MonoFlat.MonoFlat_Label monoFlat_Label8;
        private MonoFlat.MonoFlat_Label monoFlat_Label9;
        private System.Windows.Forms.MaskedTextBox txt_tc;
    }
}