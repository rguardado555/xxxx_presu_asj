namespace ModuloPresupuesto
{
    partial class Frm_Variables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Variables));
            this.dtg_datos = new DevExpress.XtraGrid.GridControl();
            this.vista_datos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.COL_IDVARIABLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_DESCRIPCION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_VALOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_SP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menu_opciones = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_nuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btn_editar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_guardar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_cancelar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_eliminar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_exit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_salir = new DevExpress.XtraBars.BarButtonItem();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_codigo = new DevExpress.XtraEditors.TextEdit();
            this.txt_descripcion = new DevExpress.XtraEditors.TextEdit();
            this.txt_sp = new DevExpress.XtraEditors.TextEdit();
            this.txt_valor = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_opciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_descripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_datos
            // 
            this.dtg_datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_datos.Location = new System.Drawing.Point(314, 34);
            this.dtg_datos.MainView = this.vista_datos;
            this.dtg_datos.Name = "dtg_datos";
            this.dtg_datos.Size = new System.Drawing.Size(587, 413);
            this.dtg_datos.TabIndex = 0;
            this.dtg_datos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vista_datos});
            this.dtg_datos.Click += new System.EventHandler(this.dtg_datos_Click);
            // 
            // vista_datos
            // 
            this.vista_datos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.COL_IDVARIABLE,
            this.COL_DESCRIPCION,
            this.COL_VALOR,
            this.COL_SP});
            this.vista_datos.GridControl = this.dtg_datos;
            this.vista_datos.Name = "vista_datos";
            this.vista_datos.OptionsView.ShowGroupPanel = false;
            // 
            // COL_IDVARIABLE
            // 
            this.COL_IDVARIABLE.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_IDVARIABLE.AppearanceCell.Options.UseFont = true;
            this.COL_IDVARIABLE.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_IDVARIABLE.AppearanceHeader.Options.UseFont = true;
            this.COL_IDVARIABLE.Caption = "CODIGO";
            this.COL_IDVARIABLE.FieldName = "IDVARIABLE";
            this.COL_IDVARIABLE.Name = "COL_IDVARIABLE";
            this.COL_IDVARIABLE.OptionsColumn.AllowEdit = false;
            this.COL_IDVARIABLE.Visible = true;
            this.COL_IDVARIABLE.VisibleIndex = 0;
            // 
            // COL_DESCRIPCION
            // 
            this.COL_DESCRIPCION.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_DESCRIPCION.AppearanceCell.Options.UseFont = true;
            this.COL_DESCRIPCION.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_DESCRIPCION.AppearanceHeader.Options.UseFont = true;
            this.COL_DESCRIPCION.Caption = "VARIABLE";
            this.COL_DESCRIPCION.FieldName = "DESCRIPCION";
            this.COL_DESCRIPCION.Name = "COL_DESCRIPCION";
            this.COL_DESCRIPCION.OptionsColumn.AllowEdit = false;
            this.COL_DESCRIPCION.Visible = true;
            this.COL_DESCRIPCION.VisibleIndex = 1;
            // 
            // COL_VALOR
            // 
            this.COL_VALOR.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_VALOR.AppearanceCell.Options.UseFont = true;
            this.COL_VALOR.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_VALOR.AppearanceHeader.Options.UseFont = true;
            this.COL_VALOR.Caption = "VALOR";
            this.COL_VALOR.FieldName = "VALOR";
            this.COL_VALOR.Name = "COL_VALOR";
            this.COL_VALOR.OptionsColumn.AllowEdit = false;
            this.COL_VALOR.Visible = true;
            this.COL_VALOR.VisibleIndex = 2;
            // 
            // COL_SP
            // 
            this.COL_SP.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_SP.AppearanceCell.Options.UseFont = true;
            this.COL_SP.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_SP.AppearanceHeader.Options.UseFont = true;
            this.COL_SP.Caption = "SP ASIGNADO";
            this.COL_SP.FieldName = "SP_ASIGNADO";
            this.COL_SP.Name = "COL_SP";
            this.COL_SP.OptionsColumn.AllowEdit = false;
            this.COL_SP.Visible = true;
            this.COL_SP.VisibleIndex = 3;
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
            this.btn_exit});
            this.menu_opciones.MaxItemId = 9;
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
            this.btn_nuevo.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.btn_nuevo.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_nuevo.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btn_nuevo.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_nuevo.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btn_nuevo.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_nuevo.ItemInMenuAppearance.Pressed.Options.UseFont = true;
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
            this.btn_eliminar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.barDockControl1.Size = new System.Drawing.Size(902, 28);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 449);
            this.barDockControl2.Manager = this.menu_opciones;
            this.barDockControl2.Size = new System.Drawing.Size(902, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 28);
            this.barDockControl3.Manager = this.menu_opciones;
            this.barDockControl3.Size = new System.Drawing.Size(0, 421);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(902, 28);
            this.barDockControl4.Manager = this.menu_opciones;
            this.barDockControl4.Size = new System.Drawing.Size(0, 421);
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
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 76);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 15);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "CODIGO";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 132);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 15);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "DESCRIPCIÓN";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 184);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 15);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "VALOR";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 233);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 15);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "SP ASIGNADO";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(12, 95);
            this.txt_codigo.MenuManager = this.menu_opciones;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Properties.Appearance.Options.UseFont = true;
            this.txt_codigo.Properties.MaxLength = 3;
            this.txt_codigo.Size = new System.Drawing.Size(136, 22);
            this.txt_codigo.TabIndex = 9;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(12, 153);
            this.txt_descripcion.MenuManager = this.menu_opciones;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Properties.Appearance.Options.UseFont = true;
            this.txt_descripcion.Size = new System.Drawing.Size(285, 22);
            this.txt_descripcion.TabIndex = 10;
            // 
            // txt_sp
            // 
            this.txt_sp.Location = new System.Drawing.Point(12, 254);
            this.txt_sp.MenuManager = this.menu_opciones;
            this.txt_sp.Name = "txt_sp";
            this.txt_sp.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sp.Properties.Appearance.Options.UseFont = true;
            this.txt_sp.Size = new System.Drawing.Size(285, 22);
            this.txt_sp.TabIndex = 12;
            // 
            // txt_valor
            // 
            this.txt_valor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(12, 205);
            this.txt_valor.Mask = "#.####";
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(136, 23);
            this.txt_valor.TabIndex = 24;
            // 
            // Frm_Variables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 449);
            this.ControlBox = false;
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_sp);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtg_datos);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Variables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Variables de Configuración";
            this.Load += new System.EventHandler(this.Frm_Variables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_opciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_descripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sp.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtg_datos;
        private DevExpress.XtraGrid.Views.Grid.GridView vista_datos;
        private DevExpress.XtraGrid.Columns.GridColumn COL_IDVARIABLE;
        private DevExpress.XtraGrid.Columns.GridColumn COL_DESCRIPCION;
        private DevExpress.XtraGrid.Columns.GridColumn COL_VALOR;
        private DevExpress.XtraGrid.Columns.GridColumn COL_SP;
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
        private DevExpress.XtraEditors.TextEdit txt_sp;
        private DevExpress.XtraEditors.TextEdit txt_descripcion;
        private DevExpress.XtraEditors.TextEdit txt_codigo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.MaskedTextBox txt_valor;
    }
}