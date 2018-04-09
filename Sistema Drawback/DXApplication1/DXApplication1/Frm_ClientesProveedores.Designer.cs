namespace DXApplication1
{
    partial class Frm_ClientesProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ClientesProveedores));
            this.dtg_datos = new DevExpress.XtraGrid.GridControl();
            this.vista_datos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.COL_CODIGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_RAZONSOCIAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_IDTIPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_TIPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_ruc = new DevExpress.XtraEditors.TextEdit();
            this.txt_codigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_razonsocial = new DevExpress.XtraEditors.TextEdit();
            this.cbo_tipo = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.menu_opciones = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_nuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btn_editar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_guardar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_cancelar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_eliminar = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_salir = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ruc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_razonsocial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_tipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu_opciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_datos
            // 
            this.dtg_datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_datos.Location = new System.Drawing.Point(365, 51);
            this.dtg_datos.MainView = this.vista_datos;
            this.dtg_datos.Name = "dtg_datos";
            this.dtg_datos.Size = new System.Drawing.Size(653, 388);
            this.dtg_datos.TabIndex = 16;
            this.dtg_datos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vista_datos});
            this.dtg_datos.Click += new System.EventHandler(this.dtg_datos_Click);
            this.dtg_datos.DoubleClick += new System.EventHandler(this.dtg_datos_DoubleClick);
            // 
            // vista_datos
            // 
            this.vista_datos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.COL_CODIGO,
            this.COL_RAZONSOCIAL,
            this.RUC,
            this.COL_IDTIPO,
            this.COL_TIPO});
            this.vista_datos.GridControl = this.dtg_datos;
            this.vista_datos.Name = "vista_datos";
            this.vista_datos.OptionsView.ShowGroupPanel = false;
            // 
            // COL_CODIGO
            // 
            this.COL_CODIGO.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_CODIGO.AppearanceCell.Options.UseFont = true;
            this.COL_CODIGO.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_CODIGO.AppearanceHeader.Options.UseFont = true;
            this.COL_CODIGO.Caption = "Codigo";
            this.COL_CODIGO.FieldName = "CODIGO";
            this.COL_CODIGO.Name = "COL_CODIGO";
            this.COL_CODIGO.OptionsColumn.AllowEdit = false;
            this.COL_CODIGO.Visible = true;
            this.COL_CODIGO.VisibleIndex = 0;
            // 
            // COL_RAZONSOCIAL
            // 
            this.COL_RAZONSOCIAL.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_RAZONSOCIAL.AppearanceCell.Options.UseFont = true;
            this.COL_RAZONSOCIAL.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_RAZONSOCIAL.AppearanceHeader.Options.UseFont = true;
            this.COL_RAZONSOCIAL.Caption = "Razon Social";
            this.COL_RAZONSOCIAL.FieldName = "RAZONSOCIAL";
            this.COL_RAZONSOCIAL.Name = "COL_RAZONSOCIAL";
            this.COL_RAZONSOCIAL.OptionsColumn.AllowEdit = false;
            this.COL_RAZONSOCIAL.Visible = true;
            this.COL_RAZONSOCIAL.VisibleIndex = 1;
            // 
            // RUC
            // 
            this.RUC.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RUC.AppearanceCell.Options.UseFont = true;
            this.RUC.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RUC.AppearanceHeader.Options.UseFont = true;
            this.RUC.Caption = "Ruc";
            this.RUC.FieldName = "RUC";
            this.RUC.Name = "RUC";
            this.RUC.OptionsColumn.AllowEdit = false;
            this.RUC.Visible = true;
            this.RUC.VisibleIndex = 2;
            // 
            // COL_IDTIPO
            // 
            this.COL_IDTIPO.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_IDTIPO.AppearanceCell.Options.UseFont = true;
            this.COL_IDTIPO.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_IDTIPO.AppearanceHeader.Options.UseFont = true;
            this.COL_IDTIPO.Caption = "IDTIPO";
            this.COL_IDTIPO.FieldName = "IDTIPO";
            this.COL_IDTIPO.Name = "COL_IDTIPO";
            this.COL_IDTIPO.OptionsColumn.AllowEdit = false;
            this.COL_IDTIPO.Visible = true;
            this.COL_IDTIPO.VisibleIndex = 3;
            // 
            // COL_TIPO
            // 
            this.COL_TIPO.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_TIPO.AppearanceCell.Options.UseFont = true;
            this.COL_TIPO.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_TIPO.AppearanceHeader.Options.UseFont = true;
            this.COL_TIPO.Caption = "Tipo";
            this.COL_TIPO.FieldName = "TIPO";
            this.COL_TIPO.Name = "COL_TIPO";
            this.COL_TIPO.OptionsColumn.AllowEdit = false;
            this.COL_TIPO.Visible = true;
            this.COL_TIPO.VisibleIndex = 4;
            // 
            // txt_ruc
            // 
            this.txt_ruc.Location = new System.Drawing.Point(133, 188);
            this.txt_ruc.Name = "txt_ruc";
            this.txt_ruc.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_ruc.Properties.Appearance.Options.UseFont = true;
            this.txt_ruc.Properties.MaxLength = 11;
            this.txt_ruc.Size = new System.Drawing.Size(151, 24);
            this.txt_ruc.TabIndex = 14;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(133, 61);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_codigo.Properties.Appearance.Options.UseFont = true;
            this.txt_codigo.Properties.MaxLength = 20;
            this.txt_codigo.Size = new System.Drawing.Size(151, 24);
            this.txt_codigo.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 191);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(21, 17);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Ruc";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 17);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Codigo";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 145);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 17);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Razon Social";
            // 
            // txt_razonsocial
            // 
            this.txt_razonsocial.Location = new System.Drawing.Point(133, 142);
            this.txt_razonsocial.Name = "txt_razonsocial";
            this.txt_razonsocial.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_razonsocial.Properties.Appearance.Options.UseFont = true;
            this.txt_razonsocial.Properties.MaxLength = 250;
            this.txt_razonsocial.Size = new System.Drawing.Size(151, 24);
            this.txt_razonsocial.TabIndex = 18;
            // 
            // cbo_tipo
            // 
            this.cbo_tipo.Location = new System.Drawing.Point(133, 97);
            this.cbo_tipo.Name = "cbo_tipo";
            this.cbo_tipo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo_tipo.Properties.Appearance.Options.UseFont = true;
            this.cbo_tipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_tipo.Properties.NullText = "[Seleccionar]";
            this.cbo_tipo.Size = new System.Drawing.Size(151, 24);
            this.cbo_tipo.TabIndex = 22;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(13, 100);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(26, 17);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "Tipo";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.cbo_tipo);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txt_codigo);
            this.groupControl1.Controls.Add(this.txt_razonsocial);
            this.groupControl1.Controls.Add(this.txt_ruc);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Location = new System.Drawing.Point(2, 51);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(361, 388);
            this.groupControl1.TabIndex = 31;
            this.groupControl1.Text = "Detalles";
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_eliminar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            this.barDockControl1.Size = new System.Drawing.Size(1020, 48);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 442);
            this.barDockControl2.Manager = this.menu_opciones;
            this.barDockControl2.Size = new System.Drawing.Size(1020, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 48);
            this.barDockControl3.Manager = this.menu_opciones;
            this.barDockControl3.Size = new System.Drawing.Size(0, 394);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1020, 48);
            this.barDockControl4.Manager = this.menu_opciones;
            this.barDockControl4.Size = new System.Drawing.Size(0, 394);
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
            // Frm_ClientesProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 442);
            this.Controls.Add(this.dtg_datos);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "Frm_ClientesProveedores";
            this.Text = "Clientes-Proveedores";
            this.Load += new System.EventHandler(this.Frm_ClientesProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ruc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_razonsocial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_tipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu_opciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LookUpEdit cbo_tipo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_razonsocial;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl dtg_datos;
        private DevExpress.XtraGrid.Views.Grid.GridView vista_datos;
        private DevExpress.XtraEditors.TextEdit txt_ruc;
        private DevExpress.XtraEditors.TextEdit txt_codigo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn COL_CODIGO;
        private DevExpress.XtraGrid.Columns.GridColumn COL_RAZONSOCIAL;
        private DevExpress.XtraGrid.Columns.GridColumn RUC;
        private DevExpress.XtraGrid.Columns.GridColumn COL_IDTIPO;
        private DevExpress.XtraGrid.Columns.GridColumn COL_TIPO;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.BarManager menu_opciones;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_nuevo;
        private DevExpress.XtraBars.BarButtonItem btn_editar;
        private DevExpress.XtraBars.BarButtonItem btn_guardar;
        private DevExpress.XtraBars.BarButtonItem btn_cancelar;
        private DevExpress.XtraBars.BarButtonItem btn_eliminar;
        private DevExpress.XtraBars.BarButtonItem btn_salir;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
    }
}