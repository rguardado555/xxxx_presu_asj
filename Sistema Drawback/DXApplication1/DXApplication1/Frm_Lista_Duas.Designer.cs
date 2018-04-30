namespace DXApplication1
{
    partial class Frm_Lista_Duas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Lista_Duas));
            this.menu_opciones = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_nuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btn_editar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_eliminar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_txt = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtg_datos = new DevExpress.XtraGrid.GridControl();
            this.vista_datos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.COL_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_DOCUMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_ESTADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_FECHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_FOB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_EXPORTACIONDOC = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.menu_opciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_opciones
            // 
            this.menu_opciones.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2});
            this.menu_opciones.DockControls.Add(this.barDockControlTop);
            this.menu_opciones.DockControls.Add(this.barDockControlBottom);
            this.menu_opciones.DockControls.Add(this.barDockControlLeft);
            this.menu_opciones.DockControls.Add(this.barDockControlRight);
            this.menu_opciones.Form = this;
            this.menu_opciones.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_nuevo,
            this.barButtonItem2,
            this.btn_editar,
            this.barButtonItem4,
            this.barButtonItem5,
            this.btn_eliminar,
            this.btn_txt});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_eliminar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_txt, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            this.btn_editar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btn_editar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_editar_ItemClick);
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
            // btn_txt
            // 
            this.btn_txt.Caption = "&Generar Txt Sunat";
            this.btn_txt.Id = 6;
            this.btn_txt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_txt.ImageOptions.Image")));
            this.btn_txt.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_txt.ImageOptions.LargeImage")));
            this.btn_txt.Name = "btn_txt";
            this.btn_txt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_txt_ItemClick);
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.menu_opciones;
            this.barDockControlTop.Size = new System.Drawing.Size(865, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 391);
            this.barDockControlBottom.Manager = this.menu_opciones;
            this.barDockControlBottom.Size = new System.Drawing.Size(865, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.menu_opciones;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 340);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(865, 51);
            this.barDockControlRight.Manager = this.menu_opciones;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 340);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "&Guardar";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "&Cancelar";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dtg_datos
            // 
            this.dtg_datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_datos.Location = new System.Drawing.Point(0, 50);
            this.dtg_datos.MainView = this.vista_datos;
            this.dtg_datos.Name = "dtg_datos";
            this.dtg_datos.Size = new System.Drawing.Size(865, 345);
            this.dtg_datos.TabIndex = 4;
            this.dtg_datos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vista_datos});
            this.dtg_datos.DoubleClick += new System.EventHandler(this.dtg_datos_DoubleClick);
            // 
            // vista_datos
            // 
            this.vista_datos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.COL_ID,
            this.COL_DOCUMENTO,
            this.COL_ESTADO,
            this.COL_FECHA,
            this.COL_FOB,
            this.COL_EXPORTACIONDOC});
            this.vista_datos.GridControl = this.dtg_datos;
            this.vista_datos.Name = "vista_datos";
            this.vista_datos.OptionsFind.AllowFindPanel = false;
            this.vista_datos.OptionsView.ShowGroupPanel = false;
            // 
            // COL_ID
            // 
            this.COL_ID.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_ID.AppearanceCell.Options.UseFont = true;
            this.COL_ID.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_ID.AppearanceHeader.Options.UseFont = true;
            this.COL_ID.Caption = "ID";
            this.COL_ID.FieldName = "ID";
            this.COL_ID.Name = "COL_ID";
            this.COL_ID.OptionsColumn.AllowEdit = false;
            this.COL_ID.Visible = true;
            this.COL_ID.VisibleIndex = 0;
            this.COL_ID.Width = 95;
            // 
            // COL_DOCUMENTO
            // 
            this.COL_DOCUMENTO.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_DOCUMENTO.AppearanceCell.Options.UseFont = true;
            this.COL_DOCUMENTO.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_DOCUMENTO.AppearanceHeader.Options.UseFont = true;
            this.COL_DOCUMENTO.Caption = "DUA";
            this.COL_DOCUMENTO.FieldName = "DUA";
            this.COL_DOCUMENTO.Name = "COL_DOCUMENTO";
            this.COL_DOCUMENTO.OptionsColumn.AllowEdit = false;
            this.COL_DOCUMENTO.Visible = true;
            this.COL_DOCUMENTO.VisibleIndex = 1;
            this.COL_DOCUMENTO.Width = 120;
            // 
            // COL_ESTADO
            // 
            this.COL_ESTADO.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_ESTADO.AppearanceCell.Options.UseFont = true;
            this.COL_ESTADO.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_ESTADO.AppearanceHeader.Options.UseFont = true;
            this.COL_ESTADO.Caption = "ESTADO";
            this.COL_ESTADO.FieldName = "ESTADO";
            this.COL_ESTADO.Name = "COL_ESTADO";
            this.COL_ESTADO.OptionsColumn.AllowEdit = false;
            this.COL_ESTADO.Visible = true;
            this.COL_ESTADO.VisibleIndex = 5;
            this.COL_ESTADO.Width = 136;
            // 
            // COL_FECHA
            // 
            this.COL_FECHA.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_FECHA.AppearanceCell.Options.UseFont = true;
            this.COL_FECHA.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_FECHA.AppearanceHeader.Options.UseFont = true;
            this.COL_FECHA.Caption = "FECHA";
            this.COL_FECHA.FieldName = "FECHA";
            this.COL_FECHA.Name = "COL_FECHA";
            this.COL_FECHA.OptionsColumn.AllowEdit = false;
            this.COL_FECHA.Visible = true;
            this.COL_FECHA.VisibleIndex = 2;
            this.COL_FECHA.Width = 159;
            // 
            // COL_FOB
            // 
            this.COL_FOB.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.COL_FOB.AppearanceCell.Options.UseFont = true;
            this.COL_FOB.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.COL_FOB.AppearanceHeader.Options.UseFont = true;
            this.COL_FOB.Caption = "FOB X RESTITUIR";
            this.COL_FOB.FieldName = "FOB";
            this.COL_FOB.Name = "COL_FOB";
            this.COL_FOB.OptionsColumn.AllowEdit = false;
            this.COL_FOB.Visible = true;
            this.COL_FOB.VisibleIndex = 4;
            this.COL_FOB.Width = 154;
            // 
            // COL_EXPORTACIONDOC
            // 
            this.COL_EXPORTACIONDOC.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.COL_EXPORTACIONDOC.AppearanceCell.Options.UseFont = true;
            this.COL_EXPORTACIONDOC.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.COL_EXPORTACIONDOC.AppearanceHeader.Options.UseFont = true;
            this.COL_EXPORTACIONDOC.Caption = "EXPORTACION";
            this.COL_EXPORTACIONDOC.FieldName = "REF";
            this.COL_EXPORTACIONDOC.Name = "COL_EXPORTACIONDOC";
            this.COL_EXPORTACIONDOC.OptionsColumn.AllowEdit = false;
            this.COL_EXPORTACIONDOC.Visible = true;
            this.COL_EXPORTACIONDOC.VisibleIndex = 3;
            this.COL_EXPORTACIONDOC.Width = 183;
            // 
            // Frm_Lista_Duas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 391);
            this.Controls.Add(this.dtg_datos);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_Lista_Duas";
            this.Text = "Listado de Duas";
            this.Load += new System.EventHandler(this.Frm_Lista_Duas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menu_opciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager menu_opciones;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_nuevo;
        private DevExpress.XtraBars.BarButtonItem btn_editar;
        private DevExpress.XtraBars.BarButtonItem btn_eliminar;
        private DevExpress.XtraBars.BarButtonItem btn_txt;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraGrid.GridControl dtg_datos;
        private DevExpress.XtraGrid.Views.Grid.GridView vista_datos;
        private DevExpress.XtraGrid.Columns.GridColumn COL_ID;
        private DevExpress.XtraGrid.Columns.GridColumn COL_DOCUMENTO;
        private DevExpress.XtraGrid.Columns.GridColumn COL_ESTADO;
        private DevExpress.XtraGrid.Columns.GridColumn COL_FECHA;
        private DevExpress.XtraGrid.Columns.GridColumn COL_FOB;
        private DevExpress.XtraGrid.Columns.GridColumn COL_EXPORTACIONDOC;
    }
}