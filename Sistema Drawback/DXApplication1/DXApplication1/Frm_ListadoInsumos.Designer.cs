namespace DXApplication1
{
    partial class Frm_ListadoInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListadoInsumos));
            this.btn_cancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_agregar = new DevExpress.XtraEditors.SimpleButton();
            this.dtg_insumos = new DevExpress.XtraGrid.GridControl();
            this.vista_insumos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.COL_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_DOCUMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_IDPROVEEDOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_PROVEEDOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_IDPRODUCTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_PRODUCTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_UNIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_CANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_SOLICITADA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_ITEM = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_insumos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_insumos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.ImageOptions.Image")));
            this.btn_cancelar.Location = new System.Drawing.Point(699, 369);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(89, 25);
            this.btn_cancelar.TabIndex = 32;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.ImageOptions.Image")));
            this.btn_agregar.Location = new System.Drawing.Point(794, 369);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(89, 25);
            this.btn_agregar.TabIndex = 31;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dtg_insumos
            // 
            this.dtg_insumos.Location = new System.Drawing.Point(1, 24);
            this.dtg_insumos.MainView = this.vista_insumos;
            this.dtg_insumos.Name = "dtg_insumos";
            this.dtg_insumos.Size = new System.Drawing.Size(882, 339);
            this.dtg_insumos.TabIndex = 41;
            this.dtg_insumos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vista_insumos});
            // 
            // vista_insumos
            // 
            this.vista_insumos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.COL_ID,
            this.COL_DOCUMENTO,
            this.COL_IDPROVEEDOR,
            this.COL_PROVEEDOR,
            this.COL_IDPRODUCTO,
            this.COL_PRODUCTO,
            this.COL_UNIDAD,
            this.COL_CANTIDAD,
            this.COL_SOLICITADA,
            this.COL_ITEM});
            this.vista_insumos.GridControl = this.dtg_insumos;
            this.vista_insumos.Name = "vista_insumos";
            this.vista_insumos.OptionsView.ShowGroupPanel = false;
            // 
            // COL_ID
            // 
            this.COL_ID.Caption = "ID";
            this.COL_ID.FieldName = "ID";
            this.COL_ID.Name = "COL_ID";
            this.COL_ID.Width = 33;
            // 
            // COL_DOCUMENTO
            // 
            this.COL_DOCUMENTO.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_DOCUMENTO.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.COL_DOCUMENTO.AppearanceCell.Options.UseFont = true;
            this.COL_DOCUMENTO.AppearanceCell.Options.UseForeColor = true;
            this.COL_DOCUMENTO.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_DOCUMENTO.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.COL_DOCUMENTO.AppearanceHeader.Options.UseFont = true;
            this.COL_DOCUMENTO.AppearanceHeader.Options.UseForeColor = true;
            this.COL_DOCUMENTO.Caption = "DOCUMENTO";
            this.COL_DOCUMENTO.FieldName = "DOCUMENTO";
            this.COL_DOCUMENTO.Name = "COL_DOCUMENTO";
            this.COL_DOCUMENTO.OptionsColumn.AllowEdit = false;
            this.COL_DOCUMENTO.Visible = true;
            this.COL_DOCUMENTO.VisibleIndex = 0;
            this.COL_DOCUMENTO.Width = 101;
            // 
            // COL_IDPROVEEDOR
            // 
            this.COL_IDPROVEEDOR.Caption = "IDPROVEEDOR";
            this.COL_IDPROVEEDOR.FieldName = "IDPROVEEDOR";
            this.COL_IDPROVEEDOR.Name = "COL_IDPROVEEDOR";
            this.COL_IDPROVEEDOR.OptionsColumn.AllowEdit = false;
            this.COL_IDPROVEEDOR.Width = 101;
            // 
            // COL_PROVEEDOR
            // 
            this.COL_PROVEEDOR.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_PROVEEDOR.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.COL_PROVEEDOR.AppearanceCell.Options.UseFont = true;
            this.COL_PROVEEDOR.AppearanceCell.Options.UseForeColor = true;
            this.COL_PROVEEDOR.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_PROVEEDOR.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.COL_PROVEEDOR.AppearanceHeader.Options.UseFont = true;
            this.COL_PROVEEDOR.AppearanceHeader.Options.UseForeColor = true;
            this.COL_PROVEEDOR.Caption = "PROVEEDOR";
            this.COL_PROVEEDOR.FieldName = "PROVEEDOR";
            this.COL_PROVEEDOR.Name = "COL_PROVEEDOR";
            this.COL_PROVEEDOR.OptionsColumn.AllowEdit = false;
            this.COL_PROVEEDOR.Visible = true;
            this.COL_PROVEEDOR.VisibleIndex = 1;
            this.COL_PROVEEDOR.Width = 101;
            // 
            // COL_IDPRODUCTO
            // 
            this.COL_IDPRODUCTO.Caption = "IDPRODUCTO";
            this.COL_IDPRODUCTO.FieldName = "IDPRODUCTO";
            this.COL_IDPRODUCTO.Name = "COL_IDPRODUCTO";
            this.COL_IDPRODUCTO.OptionsColumn.AllowEdit = false;
            this.COL_IDPRODUCTO.Width = 101;
            // 
            // COL_PRODUCTO
            // 
            this.COL_PRODUCTO.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_PRODUCTO.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.COL_PRODUCTO.AppearanceCell.Options.UseFont = true;
            this.COL_PRODUCTO.AppearanceCell.Options.UseForeColor = true;
            this.COL_PRODUCTO.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_PRODUCTO.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.COL_PRODUCTO.AppearanceHeader.Options.UseFont = true;
            this.COL_PRODUCTO.AppearanceHeader.Options.UseForeColor = true;
            this.COL_PRODUCTO.Caption = "PRODUCTO";
            this.COL_PRODUCTO.FieldName = "PRODUCTO";
            this.COL_PRODUCTO.Name = "COL_PRODUCTO";
            this.COL_PRODUCTO.OptionsColumn.AllowEdit = false;
            this.COL_PRODUCTO.Visible = true;
            this.COL_PRODUCTO.VisibleIndex = 3;
            this.COL_PRODUCTO.Width = 101;
            // 
            // COL_UNIDAD
            // 
            this.COL_UNIDAD.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_UNIDAD.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.COL_UNIDAD.AppearanceCell.Options.UseFont = true;
            this.COL_UNIDAD.AppearanceCell.Options.UseForeColor = true;
            this.COL_UNIDAD.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_UNIDAD.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.COL_UNIDAD.AppearanceHeader.Options.UseFont = true;
            this.COL_UNIDAD.AppearanceHeader.Options.UseForeColor = true;
            this.COL_UNIDAD.Caption = "UNIDAD";
            this.COL_UNIDAD.FieldName = "UNIDAD";
            this.COL_UNIDAD.Name = "COL_UNIDAD";
            this.COL_UNIDAD.OptionsColumn.AllowEdit = false;
            this.COL_UNIDAD.Visible = true;
            this.COL_UNIDAD.VisibleIndex = 4;
            this.COL_UNIDAD.Width = 101;
            // 
            // COL_CANTIDAD
            // 
            this.COL_CANTIDAD.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_CANTIDAD.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.COL_CANTIDAD.AppearanceCell.Options.UseFont = true;
            this.COL_CANTIDAD.AppearanceCell.Options.UseForeColor = true;
            this.COL_CANTIDAD.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_CANTIDAD.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.COL_CANTIDAD.AppearanceHeader.Options.UseFont = true;
            this.COL_CANTIDAD.AppearanceHeader.Options.UseForeColor = true;
            this.COL_CANTIDAD.Caption = "CANTIDAD";
            this.COL_CANTIDAD.DisplayFormat.FormatString = "{0:n4}";
            this.COL_CANTIDAD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_CANTIDAD.FieldName = "CANTIDAD";
            this.COL_CANTIDAD.Name = "COL_CANTIDAD";
            this.COL_CANTIDAD.OptionsColumn.AllowEdit = false;
            this.COL_CANTIDAD.Visible = true;
            this.COL_CANTIDAD.VisibleIndex = 5;
            this.COL_CANTIDAD.Width = 101;
            // 
            // COL_SOLICITADA
            // 
            this.COL_SOLICITADA.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_SOLICITADA.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.COL_SOLICITADA.AppearanceCell.Options.UseFont = true;
            this.COL_SOLICITADA.AppearanceCell.Options.UseForeColor = true;
            this.COL_SOLICITADA.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_SOLICITADA.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.COL_SOLICITADA.AppearanceHeader.Options.UseFont = true;
            this.COL_SOLICITADA.AppearanceHeader.Options.UseForeColor = true;
            this.COL_SOLICITADA.Caption = "SOLICITADA";
            this.COL_SOLICITADA.DisplayFormat.FormatString = "{0:n4}";
            this.COL_SOLICITADA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_SOLICITADA.FieldName = "SOLICITADA";
            this.COL_SOLICITADA.Name = "COL_SOLICITADA";
            this.COL_SOLICITADA.Visible = true;
            this.COL_SOLICITADA.VisibleIndex = 6;
            this.COL_SOLICITADA.Width = 114;
            // 
            // COL_ITEM
            // 
            this.COL_ITEM.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_ITEM.AppearanceCell.Options.UseFont = true;
            this.COL_ITEM.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL_ITEM.AppearanceHeader.Options.UseFont = true;
            this.COL_ITEM.Caption = "ITEM";
            this.COL_ITEM.FieldName = "ITEM";
            this.COL_ITEM.Name = "COL_ITEM";
            this.COL_ITEM.OptionsColumn.AllowEdit = false;
            this.COL_ITEM.Visible = true;
            this.COL_ITEM.VisibleIndex = 2;
            // 
            // Frm_ListadoInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 397);
            this.ControlBox = false;
            this.Controls.Add(this.dtg_insumos);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_ListadoInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Insumos disponibles";
            this.Load += new System.EventHandler(this.Frm_ListadoInsumos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_insumos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_insumos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_cancelar;
        private DevExpress.XtraEditors.SimpleButton btn_agregar;
        private DevExpress.XtraGrid.GridControl dtg_insumos;
        private DevExpress.XtraGrid.Views.Grid.GridView vista_insumos;
        private DevExpress.XtraGrid.Columns.GridColumn COL_ID;
        private DevExpress.XtraGrid.Columns.GridColumn COL_DOCUMENTO;
        private DevExpress.XtraGrid.Columns.GridColumn COL_IDPROVEEDOR;
        private DevExpress.XtraGrid.Columns.GridColumn COL_PROVEEDOR;
        private DevExpress.XtraGrid.Columns.GridColumn COL_IDPRODUCTO;
        private DevExpress.XtraGrid.Columns.GridColumn COL_PRODUCTO;
        private DevExpress.XtraGrid.Columns.GridColumn COL_UNIDAD;
        private DevExpress.XtraGrid.Columns.GridColumn COL_CANTIDAD;
        private DevExpress.XtraGrid.Columns.GridColumn COL_SOLICITADA;
        private DevExpress.XtraGrid.Columns.GridColumn COL_ITEM;
    }
}