namespace DXApplication1
{
    partial class Frm_ReporteFacturasPendientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ReporteFacturasPendientes));
            this.pvt_datos = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.COL_ID = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_DOCUMENTO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_IDPROVEEDOR = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_PROVEEDOR = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_IDPRODUCTO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_PRODUCTO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.COL_UNIDAD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.btn_mostrar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_excel = new DevExpress.XtraEditors.SimpleButton();
            this.COL_STOCK = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pvt_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // pvt_datos
            // 
            this.pvt_datos.ActiveFilterString = "";
            this.pvt_datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pvt_datos.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.COL_ID,
            this.COL_DOCUMENTO,
            this.COL_IDPROVEEDOR,
            this.COL_PROVEEDOR,
            this.COL_IDPRODUCTO,
            this.COL_PRODUCTO,
            this.COL_UNIDAD,
            this.COL_STOCK});
            this.pvt_datos.Location = new System.Drawing.Point(0, 46);
            this.pvt_datos.Name = "pvt_datos";
            this.pvt_datos.Size = new System.Drawing.Size(1045, 433);
            this.pvt_datos.TabIndex = 0;
            // 
            // COL_ID
            // 
            this.COL_ID.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_ID.AreaIndex = 0;
            this.COL_ID.Caption = "IDDOC";
            this.COL_ID.FieldName = "ID";
            this.COL_ID.Name = "COL_ID";
            // 
            // COL_DOCUMENTO
            // 
            this.COL_DOCUMENTO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_DOCUMENTO.AreaIndex = 1;
            this.COL_DOCUMENTO.Caption = "DOCUMENTO";
            this.COL_DOCUMENTO.FieldName = "DOCUMENTO";
            this.COL_DOCUMENTO.Name = "COL_DOCUMENTO";
            this.COL_DOCUMENTO.Width = 150;
            // 
            // COL_IDPROVEEDOR
            // 
            this.COL_IDPROVEEDOR.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_IDPROVEEDOR.AreaIndex = 2;
            this.COL_IDPROVEEDOR.Caption = "IDPROVEEDOR";
            this.COL_IDPROVEEDOR.FieldName = "IDPROVEEDOR";
            this.COL_IDPROVEEDOR.Name = "COL_IDPROVEEDOR";
            // 
            // COL_PROVEEDOR
            // 
            this.COL_PROVEEDOR.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_PROVEEDOR.AreaIndex = 3;
            this.COL_PROVEEDOR.Caption = "PROVEEDOR";
            this.COL_PROVEEDOR.FieldName = "PROVEEDOR";
            this.COL_PROVEEDOR.Name = "COL_PROVEEDOR";
            this.COL_PROVEEDOR.Width = 150;
            // 
            // COL_IDPRODUCTO
            // 
            this.COL_IDPRODUCTO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_IDPRODUCTO.AreaIndex = 4;
            this.COL_IDPRODUCTO.Caption = "IDPRODUCTO";
            this.COL_IDPRODUCTO.FieldName = "IDPRODUCTO";
            this.COL_IDPRODUCTO.Name = "COL_IDPRODUCTO";
            // 
            // COL_PRODUCTO
            // 
            this.COL_PRODUCTO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_PRODUCTO.AreaIndex = 5;
            this.COL_PRODUCTO.Caption = "PRODUCTO";
            this.COL_PRODUCTO.FieldName = "PRODUCTO";
            this.COL_PRODUCTO.Name = "COL_PRODUCTO";
            this.COL_PRODUCTO.Width = 150;
            // 
            // COL_UNIDAD
            // 
            this.COL_UNIDAD.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.COL_UNIDAD.AreaIndex = 6;
            this.COL_UNIDAD.Caption = "UNIDAD";
            this.COL_UNIDAD.FieldName = "UNIDAD";
            this.COL_UNIDAD.Name = "COL_UNIDAD";
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mostrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_mostrar.ImageOptions.Image")));
            this.btn_mostrar.Location = new System.Drawing.Point(853, 3);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(93, 37);
            this.btn_mostrar.TabIndex = 1;
            this.btn_mostrar.Text = "Actualizar";
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_excel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_excel.ImageOptions.Image")));
            this.btn_excel.Location = new System.Drawing.Point(952, 3);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(93, 37);
            this.btn_excel.TabIndex = 2;
            this.btn_excel.Text = "Excel";
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // COL_STOCK
            // 
            this.COL_STOCK.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.COL_STOCK.AreaIndex = 0;
            this.COL_STOCK.Caption = "STOCK";
            this.COL_STOCK.CellFormat.FormatString = "N2";
            this.COL_STOCK.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_STOCK.FieldName = "CANTIDAD";
            this.COL_STOCK.GrandTotalCellFormat.FormatString = "N2";
            this.COL_STOCK.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_STOCK.Name = "COL_STOCK";
            this.COL_STOCK.TotalCellFormat.FormatString = "N2";
            this.COL_STOCK.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.COL_STOCK.TotalValueFormat.FormatString = "N2";
            this.COL_STOCK.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            // 
            // Frm_ReporteFacturasPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 479);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.pvt_datos);
            this.Name = "Frm_ReporteFacturasPendientes";
            this.Text = "Reporte Insumos Pendientes";
            this.Load += new System.EventHandler(this.Frm_ReporteFacturasPendientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pvt_datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pvt_datos;
        private DevExpress.XtraEditors.SimpleButton btn_mostrar;
        private DevExpress.XtraEditors.SimpleButton btn_excel;
        private DevExpress.XtraPivotGrid.PivotGridField COL_ID;
        private DevExpress.XtraPivotGrid.PivotGridField COL_DOCUMENTO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_IDPROVEEDOR;
        private DevExpress.XtraPivotGrid.PivotGridField COL_PROVEEDOR;
        private DevExpress.XtraPivotGrid.PivotGridField COL_IDPRODUCTO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_PRODUCTO;
        private DevExpress.XtraPivotGrid.PivotGridField COL_UNIDAD;
        private DevExpress.XtraPivotGrid.PivotGridField COL_STOCK;
    }
}