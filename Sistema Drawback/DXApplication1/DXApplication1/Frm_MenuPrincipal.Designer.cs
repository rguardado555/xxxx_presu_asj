namespace DXApplication1
{
    partial class Frm_MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MenuPrincipal));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.bar_menu = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btn_clieprov = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.btn_grupopro = new DevExpress.XtraBars.BarButtonItem();
            this.btn_subgrupo = new DevExpress.XtraBars.BarButtonItem();
            this.btn_productos = new DevExpress.XtraBars.BarButtonItem();
            this.btn_empresas = new DevExpress.XtraBars.BarButtonItem();
            this.btn_procesos = new DevExpress.XtraBars.BarSubItem();
            this.btn_compras = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ventas = new DevExpress.XtraBars.BarButtonItem();
            this.btn_duas = new DevExpress.XtraBars.BarButtonItem();
            this.btn_txt = new DevExpress.XtraBars.BarButtonItem();
            this.btn_reportes = new DevExpress.XtraBars.BarSubItem();
            this.btn_rpt_saldos = new DevExpress.XtraBars.BarButtonItem();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.lb_empresaseleccionada = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.lb_fecha = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.lb_empresa = new DevExpress.XtraBars.BarStaticItem();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panel_contenedor = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bar_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_contenedor)).BeginInit();
            this.panel_contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
            // 
            // bar_menu
            // 
            this.bar_menu.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.bar_menu.DockControls.Add(this.barDockControlTop);
            this.bar_menu.DockControls.Add(this.barDockControlBottom);
            this.bar_menu.DockControls.Add(this.barDockControlLeft);
            this.bar_menu.DockControls.Add(this.barDockControlRight);
            this.bar_menu.Form = this;
            this.bar_menu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barButtonItem1,
            this.btn_procesos,
            this.btn_reportes,
            this.skinBarSubItem1,
            this.btn_compras,
            this.btn_ventas,
            this.btn_duas,
            this.btn_rpt_saldos,
            this.btn_clieprov,
            this.barButtonItem3,
            this.barSubItem2,
            this.btn_grupopro,
            this.btn_subgrupo,
            this.btn_productos,
            this.btn_empresas,
            this.btn_txt,
            this.lb_empresa,
            this.lb_fecha,
            this.lb_empresaseleccionada,
            this.barStaticItem3});
            this.bar_menu.MainMenu = this.bar2;
            this.bar_menu.MaxItemId = 24;
            this.bar_menu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.bar_menu.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Herramientas";
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_procesos, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_reportes, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.skinBarSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Tablas";
            this.barSubItem1.Id = 0;
            this.barSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.Image")));
            this.barSubItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.LargeImage")));
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_clieprov),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_empresas)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btn_clieprov
            // 
            this.btn_clieprov.Caption = "Clientes/Proveedores";
            this.btn_clieprov.Id = 9;
            this.btn_clieprov.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_clieprov.ImageOptions.Image")));
            this.btn_clieprov.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_clieprov.ImageOptions.LargeImage")));
            this.btn_clieprov.Name = "btn_clieprov";
            this.btn_clieprov.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_clieprov_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Productos";
            this.barSubItem2.Id = 11;
            this.barSubItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem2.ImageOptions.Image")));
            this.barSubItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem2.ImageOptions.LargeImage")));
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_grupopro),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_subgrupo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_productos)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // btn_grupopro
            // 
            this.btn_grupopro.Caption = "Grupos";
            this.btn_grupopro.Id = 12;
            this.btn_grupopro.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_grupopro.ImageOptions.Image")));
            this.btn_grupopro.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_grupopro.ImageOptions.LargeImage")));
            this.btn_grupopro.Name = "btn_grupopro";
            this.btn_grupopro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_grupopro_ItemClick);
            // 
            // btn_subgrupo
            // 
            this.btn_subgrupo.Caption = "SubGrupos";
            this.btn_subgrupo.Id = 13;
            this.btn_subgrupo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_subgrupo.ImageOptions.Image")));
            this.btn_subgrupo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_subgrupo.ImageOptions.LargeImage")));
            this.btn_subgrupo.Name = "btn_subgrupo";
            this.btn_subgrupo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_subgrupo_ItemClick);
            // 
            // btn_productos
            // 
            this.btn_productos.Caption = "Productos";
            this.btn_productos.Id = 14;
            this.btn_productos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_productos.ImageOptions.Image")));
            this.btn_productos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_productos.ImageOptions.LargeImage")));
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_productos_ItemClick);
            // 
            // btn_empresas
            // 
            this.btn_empresas.Caption = "Empresas";
            this.btn_empresas.Id = 15;
            this.btn_empresas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_empresas.ImageOptions.Image")));
            this.btn_empresas.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_empresas.ImageOptions.LargeImage")));
            this.btn_empresas.Name = "btn_empresas";
            this.btn_empresas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_empresas_ItemClick);
            // 
            // btn_procesos
            // 
            this.btn_procesos.Caption = "Procesos";
            this.btn_procesos.Id = 2;
            this.btn_procesos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_procesos.ImageOptions.Image")));
            this.btn_procesos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_procesos.ImageOptions.LargeImage")));
            this.btn_procesos.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_compras),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_ventas),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_duas),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_txt)});
            this.btn_procesos.Name = "btn_procesos";
            // 
            // btn_compras
            // 
            this.btn_compras.Caption = "Compras";
            this.btn_compras.Id = 5;
            this.btn_compras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_compras.ImageOptions.Image")));
            this.btn_compras.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_compras.ImageOptions.LargeImage")));
            this.btn_compras.Name = "btn_compras";
            this.btn_compras.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_compras_ItemClick);
            // 
            // btn_ventas
            // 
            this.btn_ventas.Caption = "Ventas";
            this.btn_ventas.Id = 6;
            this.btn_ventas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ventas.ImageOptions.Image")));
            this.btn_ventas.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_ventas.ImageOptions.LargeImage")));
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ventas_ItemClick);
            // 
            // btn_duas
            // 
            this.btn_duas.Caption = "Duas";
            this.btn_duas.Id = 7;
            this.btn_duas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_duas.ImageOptions.Image")));
            this.btn_duas.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_duas.ImageOptions.LargeImage")));
            this.btn_duas.Name = "btn_duas";
            this.btn_duas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_duas_ItemClick);
            // 
            // btn_txt
            // 
            this.btn_txt.Caption = "Generar Txt";
            this.btn_txt.Id = 16;
            this.btn_txt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_txt.ImageOptions.Image")));
            this.btn_txt.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_txt.ImageOptions.LargeImage")));
            this.btn_txt.Name = "btn_txt";
            this.btn_txt.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btn_txt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_txt_ItemClick);
            // 
            // btn_reportes
            // 
            this.btn_reportes.Caption = "Reportes";
            this.btn_reportes.Id = 3;
            this.btn_reportes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_reportes.ImageOptions.Image")));
            this.btn_reportes.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_rpt_saldos)});
            this.btn_reportes.Name = "btn_reportes";
            // 
            // btn_rpt_saldos
            // 
            this.btn_rpt_saldos.Caption = "Documentos con Saldo para Liquidar";
            this.btn_rpt_saldos.Id = 8;
            this.btn_rpt_saldos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_rpt_saldos.ImageOptions.Image")));
            this.btn_rpt_saldos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_rpt_saldos.ImageOptions.LargeImage")));
            this.btn_rpt_saldos.Name = "btn_rpt_saldos";
            this.btn_rpt_saldos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_rpt_saldos_ItemClick);
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Temas";
            this.skinBarSubItem1.Id = 4;
            this.skinBarSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("skinBarSubItem1.ImageOptions.Image")));
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.lb_empresaseleccionada, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.lb_fecha)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // lb_empresaseleccionada
            // 
            this.lb_empresaseleccionada.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lb_empresaseleccionada.Caption = "EMPRESA SELECCIONADA : NINGUNA";
            this.lb_empresaseleccionada.Id = 22;
            this.lb_empresaseleccionada.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lb_empresaseleccionada.ImageOptions.Image")));
            this.lb_empresaseleccionada.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("lb_empresaseleccionada.ImageOptions.LargeImage")));
            this.lb_empresaseleccionada.Name = "lb_empresaseleccionada";
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barStaticItem3.Caption = "                        ";
            this.barStaticItem3.Id = 23;
            this.barStaticItem3.Name = "barStaticItem3";
            // 
            // lb_fecha
            // 
            this.lb_fecha.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lb_fecha.Caption = "fecha";
            this.lb_fecha.Id = 21;
            this.lb_fecha.Name = "lb_fecha";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.bar_menu;
            this.barDockControlTop.Size = new System.Drawing.Size(1139, 70);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 540);
            this.barDockControlBottom.Manager = this.bar_menu;
            this.barDockControlBottom.Size = new System.Drawing.Size(1139, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 70);
            this.barDockControlLeft.Manager = this.bar_menu;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 470);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1139, 70);
            this.barDockControlRight.Manager = this.bar_menu;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 470);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 10;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // lb_empresa
            // 
            this.lb_empresa.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lb_empresa.Caption = "....Empresa Seleccionada";
            this.lb_empresa.Id = 17;
            this.lb_empresa.Name = "lb_empresa";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "[Seleccione]";
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.Appearance.BackColor = System.Drawing.Color.White;
            this.panel_contenedor.Appearance.Options.UseBackColor = true;
            this.panel_contenedor.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel_contenedor.Controls.Add(this.label4);
            this.panel_contenedor.Controls.Add(this.label3);
            this.panel_contenedor.Controls.Add(this.label2);
            this.panel_contenedor.Controls.Add(this.label1);
            this.panel_contenedor.Controls.Add(this.pictureBox1);
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(0, 70);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(1139, 470);
            this.panel_contenedor.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            this.xtraTabbedMdiManager1.PageAdded += new DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(this.xtraTabbedMdiManager1_PageAdded);
            this.xtraTabbedMdiManager1.PageRemoved += new DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(this.xtraTabbedMdiManager1_PageRemoved);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Soluciones ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(171, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informaticas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "a tu medida !";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail: rguardado.rsoft@gmail.com";
            // 
            // Frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 567);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "Frm_MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema DrawBack";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_contenedor)).EndInit();
            this.panel_contenedor.ResumeLayout(false);
            this.panel_contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarManager bar_menu;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem btn_procesos;
        private DevExpress.XtraBars.BarSubItem btn_reportes;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.PanelControl panel_contenedor;
        private DevExpress.XtraBars.BarButtonItem btn_compras;
        private DevExpress.XtraBars.BarButtonItem btn_ventas;
        private DevExpress.XtraBars.BarButtonItem btn_duas;
        private DevExpress.XtraBars.BarButtonItem btn_rpt_saldos;
        private DevExpress.XtraBars.BarButtonItem btn_clieprov;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem btn_grupopro;
        private DevExpress.XtraBars.BarButtonItem btn_subgrupo;
        private DevExpress.XtraBars.BarButtonItem btn_productos;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btn_empresas;
        private DevExpress.XtraBars.BarButtonItem btn_txt;
        private DevExpress.XtraBars.BarStaticItem lb_empresa;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraBars.BarStaticItem lb_fecha;
        private DevExpress.XtraBars.BarStaticItem lb_empresaseleccionada;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}