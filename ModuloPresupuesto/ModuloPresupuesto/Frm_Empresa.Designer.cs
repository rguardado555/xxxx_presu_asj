﻿namespace ModuloPresupuesto
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_nuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btn_editar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_cancelar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_guardar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_eliminar = new DevExpress.XtraBars.BarButtonItem();
            this.btn_exportar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dtg_datos = new DevExpress.XtraGrid.GridControl();
            this.vista_datos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_descripcion = new DevExpress.XtraEditors.TextEdit();
            this.txt_codigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lb_codigo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_descripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_nuevo,
            this.btn_editar,
            this.btn_cancelar,
            this.btn_guardar,
            this.btn_eliminar,
            this.btn_exportar});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_nuevo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_editar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_cancelar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_guardar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_eliminar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_exportar)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Caption = "&Nuevo";
            this.btn_nuevo.Id = 0;
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_nuevo_ItemClick);
            // 
            // btn_editar
            // 
            this.btn_editar.Caption = "&Editar";
            this.btn_editar.Id = 1;
            this.btn_editar.Name = "btn_editar";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Caption = "&Cancelar";
            this.btn_cancelar.Id = 2;
            this.btn_cancelar.Name = "btn_cancelar";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Caption = "&Guardar";
            this.btn_guardar.Id = 3;
            this.btn_guardar.Name = "btn_guardar";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Caption = "&Eliminar";
            this.btn_eliminar.Id = 4;
            this.btn_eliminar.Name = "btn_eliminar";
            // 
            // btn_exportar
            // 
            this.btn_exportar.Caption = "&Exportar";
            this.btn_exportar.Id = 5;
            this.btn_exportar.Name = "btn_exportar";
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(623, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 298);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(623, 18);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 272);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(623, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 272);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dtg_datos);
            this.panelControl1.Controls.Add(this.txt_descripcion);
            this.panelControl1.Controls.Add(this.txt_codigo);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.lb_codigo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 26);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(623, 272);
            this.panelControl1.TabIndex = 4;
            // 
            // dtg_datos
            // 
            this.dtg_datos.Location = new System.Drawing.Point(211, 5);
            this.dtg_datos.MainView = this.vista_datos;
            this.dtg_datos.MenuManager = this.barManager1;
            this.dtg_datos.Name = "dtg_datos";
            this.dtg_datos.Size = new System.Drawing.Size(407, 260);
            this.dtg_datos.TabIndex = 4;
            this.dtg_datos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vista_datos});
            // 
            // vista_datos
            // 
            this.vista_datos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.vista_datos.GridControl = this.dtg_datos;
            this.vista_datos.Name = "vista_datos";
            this.vista_datos.OptionsView.ShowAutoFilterRow = true;
            this.vista_datos.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Codigo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 95;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Descripción";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 291;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(12, 111);
            this.txt_descripcion.MenuManager = this.barManager1;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(177, 20);
            this.txt_descripcion.TabIndex = 3;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(12, 52);
            this.txt_codigo.MenuManager = this.barManager1;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Descripción";
            // 
            // lb_codigo
            // 
            this.lb_codigo.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_codigo.Appearance.Options.UseFont = true;
            this.lb_codigo.Location = new System.Drawing.Point(12, 32);
            this.lb_codigo.Name = "lb_codigo";
            this.lb_codigo.Size = new System.Drawing.Size(42, 14);
            this.lb_codigo.TabIndex = 0;
            this.lb_codigo.Text = "Codigo";
            // 
            // Frm_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 316);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_Empresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Empresa";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_descripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btn_nuevo;
        private DevExpress.XtraBars.BarButtonItem btn_editar;
        private DevExpress.XtraBars.BarButtonItem btn_cancelar;
        private DevExpress.XtraBars.BarButtonItem btn_guardar;
        private DevExpress.XtraBars.BarButtonItem btn_eliminar;
        private DevExpress.XtraBars.BarButtonItem btn_exportar;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl dtg_datos;
        private DevExpress.XtraGrid.Views.Grid.GridView vista_datos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.TextEdit txt_descripcion;
        private DevExpress.XtraEditors.TextEdit txt_codigo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lb_codigo;
    }
}