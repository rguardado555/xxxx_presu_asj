namespace DXApplication1
{
    partial class Frm_Empresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Empresa));
            this.menu_opciones = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_nuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btn_editar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_guardar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_cancelar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_eliminar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_salir = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_regimen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txt_codigoaduanas = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txt_tcambio = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_telefono = new DevExpress.XtraEditors.TextEdit();
            this.txt_email = new DevExpress.XtraEditors.TextEdit();
            this.txt_ruc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_codempresa = new DevExpress.XtraEditors.TextEdit();
            this.txt_direccion = new DevExpress.XtraEditors.TextEdit();
            this.txt_razonsocial = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtg_datos = new DevExpress.XtraGrid.GridControl();
            this.vista_datos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_razonsocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_direccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_telefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ruc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_tc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_codigoaduanas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_codregimen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_porc_drawback = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.col_porcDrawBack = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.menu_opciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_regimen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigoaduanas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tcambio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_telefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ruc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codempresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_direccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_razonsocial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_porc_drawback.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_opciones
            // 
            this.menu_opciones.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2});
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
            this.btn_salir});
            this.menu_opciones.MainMenu = this.bar2;
            this.menu_opciones.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_nuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_editar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_guardar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_cancelar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_eliminar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_salir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.menu_opciones;
            this.barDockControl1.Size = new System.Drawing.Size(1225, 51);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 543);
            this.barDockControl2.Manager = this.menu_opciones;
            this.barDockControl2.Size = new System.Drawing.Size(1225, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 51);
            this.barDockControl3.Manager = this.menu_opciones;
            this.barDockControl3.Size = new System.Drawing.Size(0, 492);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1225, 51);
            this.barDockControl4.Manager = this.menu_opciones;
            this.barDockControl4.Size = new System.Drawing.Size(0, 492);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "barButtonItem2";
            this.barButtonItem12.Id = 1;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.txt_porc_drawback);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.txt_regimen);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.txt_codigoaduanas);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txt_tcambio);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txt_telefono);
            this.groupControl1.Controls.Add(this.txt_email);
            this.groupControl1.Controls.Add(this.txt_ruc);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txt_codempresa);
            this.groupControl1.Controls.Add(this.txt_direccion);
            this.groupControl1.Controls.Add(this.txt_razonsocial);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Location = new System.Drawing.Point(3, 51);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(360, 489);
            this.groupControl1.TabIndex = 32;
            this.groupControl1.Text = "Detalles";
            // 
            // txt_regimen
            // 
            this.txt_regimen.Location = new System.Drawing.Point(133, 414);
            this.txt_regimen.Name = "txt_regimen";
            this.txt_regimen.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_regimen.Properties.Appearance.Options.UseFont = true;
            this.txt_regimen.Properties.MaxLength = 10;
            this.txt_regimen.Size = new System.Drawing.Size(91, 24);
            this.txt_regimen.TabIndex = 32;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(23, 417);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(51, 17);
            this.labelControl10.TabIndex = 31;
            this.labelControl10.Text = "Regimen";
            // 
            // txt_codigoaduanas
            // 
            this.txt_codigoaduanas.Location = new System.Drawing.Point(133, 377);
            this.txt_codigoaduanas.Name = "txt_codigoaduanas";
            this.txt_codigoaduanas.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_codigoaduanas.Properties.Appearance.Options.UseFont = true;
            this.txt_codigoaduanas.Properties.MaxLength = 10;
            this.txt_codigoaduanas.Size = new System.Drawing.Size(91, 24);
            this.txt_codigoaduanas.TabIndex = 30;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(23, 380);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(91, 17);
            this.labelControl9.TabIndex = 29;
            this.labelControl9.Text = "Codigo Aduana";
            // 
            // txt_tcambio
            // 
            this.txt_tcambio.Location = new System.Drawing.Point(133, 337);
            this.txt_tcambio.Name = "txt_tcambio";
            this.txt_tcambio.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_tcambio.Properties.Appearance.Options.UseFont = true;
            this.txt_tcambio.Properties.MaxLength = 10;
            this.txt_tcambio.Size = new System.Drawing.Size(91, 24);
            this.txt_tcambio.TabIndex = 28;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(23, 340);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(95, 17);
            this.labelControl8.TabIndex = 27;
            this.labelControl8.Text = "Tipo De Cambio";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(23, 310);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(101, 17);
            this.labelControl7.TabIndex = 26;
            this.labelControl7.Text = "Datos DrawBack";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(133, 260);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_telefono.Properties.Appearance.Options.UseFont = true;
            this.txt_telefono.Properties.MaxLength = 10;
            this.txt_telefono.Size = new System.Drawing.Size(199, 24);
            this.txt_telefono.TabIndex = 25;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(133, 217);
            this.txt_email.Name = "txt_email";
            this.txt_email.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_email.Properties.Appearance.Options.UseFont = true;
            this.txt_email.Properties.MaxLength = 250;
            this.txt_email.Size = new System.Drawing.Size(199, 24);
            this.txt_email.TabIndex = 24;
            // 
            // txt_ruc
            // 
            this.txt_ruc.Location = new System.Drawing.Point(133, 137);
            this.txt_ruc.Name = "txt_ruc";
            this.txt_ruc.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_ruc.Properties.Appearance.Options.UseFont = true;
            this.txt_ruc.Properties.MaxLength = 11;
            this.txt_ruc.Size = new System.Drawing.Size(199, 24);
            this.txt_ruc.TabIndex = 23;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(20, 140);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(21, 17);
            this.labelControl6.TabIndex = 22;
            this.labelControl6.Text = "Ruc";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(20, 100);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(78, 17);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "Razon Social ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(19, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 17);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Cod Empresa";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(20, 177);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 17);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Dirección";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(23, 220);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 17);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Email";
            // 
            // txt_codempresa
            // 
            this.txt_codempresa.Location = new System.Drawing.Point(133, 61);
            this.txt_codempresa.Name = "txt_codempresa";
            this.txt_codempresa.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_codempresa.Properties.Appearance.Options.UseFont = true;
            this.txt_codempresa.Properties.MaxLength = 3;
            this.txt_codempresa.Size = new System.Drawing.Size(91, 24);
            this.txt_codempresa.TabIndex = 13;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(133, 174);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_direccion.Properties.Appearance.Options.UseFont = true;
            this.txt_direccion.Properties.MaxLength = 500;
            this.txt_direccion.Size = new System.Drawing.Size(199, 24);
            this.txt_direccion.TabIndex = 18;
            // 
            // txt_razonsocial
            // 
            this.txt_razonsocial.Location = new System.Drawing.Point(133, 97);
            this.txt_razonsocial.Name = "txt_razonsocial";
            this.txt_razonsocial.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_razonsocial.Properties.Appearance.Options.UseFont = true;
            this.txt_razonsocial.Properties.MaxLength = 500;
            this.txt_razonsocial.Size = new System.Drawing.Size(199, 24);
            this.txt_razonsocial.TabIndex = 14;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(23, 263);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 17);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Telefono";
            // 
            // dtg_datos
            // 
            this.dtg_datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_datos.Location = new System.Drawing.Point(367, 50);
            this.dtg_datos.MainView = this.vista_datos;
            this.dtg_datos.Name = "dtg_datos";
            this.dtg_datos.Size = new System.Drawing.Size(856, 490);
            this.dtg_datos.TabIndex = 33;
            this.dtg_datos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vista_datos});
            this.dtg_datos.Click += new System.EventHandler(this.dtg_datos_Click);
            this.dtg_datos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtg_datos_MouseClick);
            // 
            // vista_datos
            // 
            this.vista_datos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vista_datos.Appearance.HeaderPanel.Options.UseFont = true;
            this.vista_datos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_codigo,
            this.col_razonsocial,
            this.col_direccion,
            this.col_telefono,
            this.col_email,
            this.col_ruc,
            this.gridColumn7,
            this.gridColumn8,
            this.col_tc,
            this.col_codigoaduanas,
            this.col_codregimen,
            this.col_porcDrawBack});
            this.vista_datos.GridControl = this.dtg_datos;
            this.vista_datos.Name = "vista_datos";
            this.vista_datos.OptionsView.ShowAutoFilterRow = true;
            this.vista_datos.OptionsView.ShowGroupPanel = false;
            // 
            // col_codigo
            // 
            this.col_codigo.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.col_codigo.AppearanceCell.Options.UseFont = true;
            this.col_codigo.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_codigo.AppearanceHeader.Options.UseFont = true;
            this.col_codigo.Caption = "Codigo";
            this.col_codigo.FieldName = "IDEMPRESA";
            this.col_codigo.Name = "col_codigo";
            this.col_codigo.OptionsColumn.AllowEdit = false;
            this.col_codigo.Visible = true;
            this.col_codigo.VisibleIndex = 0;
            // 
            // col_razonsocial
            // 
            this.col_razonsocial.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.col_razonsocial.AppearanceCell.Options.UseFont = true;
            this.col_razonsocial.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_razonsocial.AppearanceHeader.Options.UseFont = true;
            this.col_razonsocial.Caption = "Razon Social";
            this.col_razonsocial.FieldName = "RAZONSOCIAL";
            this.col_razonsocial.Name = "col_razonsocial";
            this.col_razonsocial.OptionsColumn.AllowEdit = false;
            this.col_razonsocial.Visible = true;
            this.col_razonsocial.VisibleIndex = 1;
            // 
            // col_direccion
            // 
            this.col_direccion.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.col_direccion.AppearanceCell.Options.UseFont = true;
            this.col_direccion.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_direccion.AppearanceHeader.Options.UseFont = true;
            this.col_direccion.Caption = "Direccion";
            this.col_direccion.FieldName = "DIRECCION";
            this.col_direccion.Name = "col_direccion";
            this.col_direccion.OptionsColumn.AllowEdit = false;
            this.col_direccion.Visible = true;
            this.col_direccion.VisibleIndex = 2;
            // 
            // col_telefono
            // 
            this.col_telefono.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.col_telefono.AppearanceCell.Options.UseFont = true;
            this.col_telefono.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_telefono.AppearanceHeader.Options.UseFont = true;
            this.col_telefono.Caption = "Telefono";
            this.col_telefono.FieldName = "TELEFONO";
            this.col_telefono.Name = "col_telefono";
            this.col_telefono.OptionsColumn.AllowEdit = false;
            this.col_telefono.Visible = true;
            this.col_telefono.VisibleIndex = 3;
            // 
            // col_email
            // 
            this.col_email.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.col_email.AppearanceCell.Options.UseFont = true;
            this.col_email.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_email.AppearanceHeader.Options.UseFont = true;
            this.col_email.Caption = "Email";
            this.col_email.FieldName = "EMAIL";
            this.col_email.Name = "col_email";
            this.col_email.OptionsColumn.AllowEdit = false;
            this.col_email.Visible = true;
            this.col_email.VisibleIndex = 4;
            // 
            // col_ruc
            // 
            this.col_ruc.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.col_ruc.AppearanceCell.Options.UseFont = true;
            this.col_ruc.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_ruc.AppearanceHeader.Options.UseFont = true;
            this.col_ruc.Caption = "Ruc";
            this.col_ruc.FieldName = "RUC";
            this.col_ruc.Name = "col_ruc";
            this.col_ruc.OptionsColumn.AllowEdit = false;
            this.col_ruc.Visible = true;
            this.col_ruc.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "idestado";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Estado";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            // 
            // col_tc
            // 
            this.col_tc.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_tc.AppearanceCell.Options.UseFont = true;
            this.col_tc.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_tc.AppearanceHeader.Options.UseFont = true;
            this.col_tc.Caption = "Tipo de Cambio";
            this.col_tc.FieldName = "TC";
            this.col_tc.Name = "col_tc";
            this.col_tc.OptionsColumn.AllowEdit = false;
            this.col_tc.Visible = true;
            this.col_tc.VisibleIndex = 6;
            // 
            // col_codigoaduanas
            // 
            this.col_codigoaduanas.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_codigoaduanas.AppearanceCell.Options.UseFont = true;
            this.col_codigoaduanas.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_codigoaduanas.AppearanceHeader.Options.UseFont = true;
            this.col_codigoaduanas.Caption = "Codigo Aduanas";
            this.col_codigoaduanas.FieldName = "CODIGOADUANAS";
            this.col_codigoaduanas.Name = "col_codigoaduanas";
            this.col_codigoaduanas.OptionsColumn.AllowEdit = false;
            this.col_codigoaduanas.Visible = true;
            this.col_codigoaduanas.VisibleIndex = 7;
            // 
            // col_codregimen
            // 
            this.col_codregimen.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_codregimen.AppearanceCell.Options.UseFont = true;
            this.col_codregimen.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_codregimen.AppearanceHeader.Options.UseFont = true;
            this.col_codregimen.Caption = "Cod Regimen";
            this.col_codregimen.FieldName = "CODIGOREGIMEN";
            this.col_codregimen.Name = "col_codregimen";
            this.col_codregimen.OptionsColumn.AllowEdit = false;
            this.col_codregimen.Visible = true;
            this.col_codregimen.VisibleIndex = 8;
            // 
            // txt_porc_drawback
            // 
            this.txt_porc_drawback.Location = new System.Drawing.Point(133, 453);
            this.txt_porc_drawback.Name = "txt_porc_drawback";
            this.txt_porc_drawback.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_porc_drawback.Properties.Appearance.Options.UseFont = true;
            this.txt_porc_drawback.Properties.MaxLength = 10;
            this.txt_porc_drawback.Size = new System.Drawing.Size(91, 24);
            this.txt_porc_drawback.TabIndex = 34;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(23, 456);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(72, 17);
            this.labelControl11.TabIndex = 33;
            this.labelControl11.Text = "% DrawBack";
            // 
            // col_porcDrawBack
            // 
            this.col_porcDrawBack.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_porcDrawBack.AppearanceCell.Options.UseFont = true;
            this.col_porcDrawBack.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col_porcDrawBack.AppearanceHeader.Options.UseFont = true;
            this.col_porcDrawBack.Caption = "% DrawBack";
            this.col_porcDrawBack.FieldName = "porc_drawback";
            this.col_porcDrawBack.Name = "col_porcDrawBack";
            this.col_porcDrawBack.OptionsColumn.AllowEdit = false;
            this.col_porcDrawBack.Visible = true;
            this.col_porcDrawBack.VisibleIndex = 9;
            // 
            // Frm_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 543);
            this.Controls.Add(this.dtg_datos);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Empresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.Frm_Empresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menu_opciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_regimen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigoaduanas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tcambio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_telefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ruc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codempresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_direccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_razonsocial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_porc_drawback.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager menu_opciones;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_nuevo;
        private DevExpress.XtraBars.BarButtonItem btn_editar;
        private DevExpress.XtraBars.BarButtonItem btn_guardar;
        private DevExpress.XtraBars.BarButtonItem btn_cancelar;
        private DevExpress.XtraBars.BarButtonItem btn_eliminar;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem btn_salir;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txt_telefono;
        private DevExpress.XtraEditors.TextEdit txt_email;
        private DevExpress.XtraEditors.TextEdit txt_ruc;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_codempresa;
        private DevExpress.XtraEditors.TextEdit txt_direccion;
        private DevExpress.XtraEditors.TextEdit txt_razonsocial;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl dtg_datos;
        private DevExpress.XtraGrid.Views.Grid.GridView vista_datos;
        private DevExpress.XtraGrid.Columns.GridColumn col_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn col_razonsocial;
        private DevExpress.XtraGrid.Columns.GridColumn col_direccion;
        private DevExpress.XtraGrid.Columns.GridColumn col_telefono;
        private DevExpress.XtraGrid.Columns.GridColumn col_email;
        private DevExpress.XtraGrid.Columns.GridColumn col_ruc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.TextEdit txt_regimen;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txt_codigoaduanas;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txt_tcambio;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Columns.GridColumn col_tc;
        private DevExpress.XtraGrid.Columns.GridColumn col_codigoaduanas;
        private DevExpress.XtraGrid.Columns.GridColumn col_codregimen;
        private DevExpress.XtraEditors.TextEdit txt_porc_drawback;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraGrid.Columns.GridColumn col_porcDrawBack;
    }
}