namespace ModuloPresupuesto
{
    partial class Panel_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_principal));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.bunifuCards4 = new Bunifu.Framework.UI.BunifuCards();
            this.dashboardViewer1 = new DevExpress.DashboardWin.DashboardViewer(this.components);
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbo_moneda = new DevExpress.XtraEditors.LookUpEdit();
            this.bunifuTileButton8 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuCustomLabel20 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards5 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuTileButton4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuCustomLabel21 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.officeNavigationBar1 = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.ImportarUnidades = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.ProcesarEjecutado = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.ImportarGastoFijo = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.DistribuirGF = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.bunifuCards4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_moneda.Properties)).BeginInit();
            this.bunifuCards5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards4
            // 
            this.bunifuCards4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards4.BackColor = System.Drawing.Color.White;
            this.bunifuCards4.BorderRadius = 5;
            this.bunifuCards4.BottomSahddow = true;
            this.bunifuCards4.color = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.bunifuCards4.Controls.Add(this.dashboardViewer1);
            this.bunifuCards4.Controls.Add(this.bunifuCustomLabel8);
            this.bunifuCards4.Controls.Add(this.cbo_moneda);
            this.bunifuCards4.Controls.Add(this.bunifuTileButton8);
            this.bunifuCards4.Controls.Add(this.bunifuCustomLabel20);
            this.bunifuCards4.LeftSahddow = false;
            this.bunifuCards4.Location = new System.Drawing.Point(234, 12);
            this.bunifuCards4.Name = "bunifuCards4";
            this.bunifuCards4.RightSahddow = true;
            this.bunifuCards4.ShadowDepth = 20;
            this.bunifuCards4.Size = new System.Drawing.Size(1124, 686);
            this.bunifuCards4.TabIndex = 7;
            // 
            // dashboardViewer1
            // 
            this.dashboardViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboardViewer1.Location = new System.Drawing.Point(7, 41);
            this.dashboardViewer1.Name = "dashboardViewer1";
            this.dashboardViewer1.Size = new System.Drawing.Size(1105, 633);
            this.dashboardViewer1.TabIndex = 10;
            this.dashboardViewer1.ConfigureDataConnection += new DevExpress.DashboardCommon.DashboardConfigureDataConnectionEventHandler(this.dashboardViewer1_ConfigureDataConnection);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(916, 13);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(60, 16);
            this.bunifuCustomLabel8.TabIndex = 13;
            this.bunifuCustomLabel8.Text = "MONEDA";
            // 
            // cbo_moneda
            // 
            this.cbo_moneda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_moneda.Location = new System.Drawing.Point(982, 12);
            this.cbo_moneda.Name = "cbo_moneda";
            this.cbo_moneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_moneda.Properties.NullText = "[Seleccione..]";
            this.cbo_moneda.Size = new System.Drawing.Size(121, 20);
            this.cbo_moneda.TabIndex = 11;
            // 
            // bunifuTileButton8
            // 
            this.bunifuTileButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.bunifuTileButton8.color = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.bunifuTileButton8.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.bunifuTileButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton8.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton8.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton8.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton8.Image")));
            this.bunifuTileButton8.ImagePosition = 0;
            this.bunifuTileButton8.ImageZoom = 80;
            this.bunifuTileButton8.LabelPosition = 0;
            this.bunifuTileButton8.LabelText = "";
            this.bunifuTileButton8.Location = new System.Drawing.Point(200, 13);
            this.bunifuTileButton8.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton8.Name = "bunifuTileButton8";
            this.bunifuTileButton8.Size = new System.Drawing.Size(25, 19);
            this.bunifuTileButton8.TabIndex = 9;
            // 
            // bunifuCustomLabel20
            // 
            this.bunifuCustomLabel20.AutoSize = true;
            this.bunifuCustomLabel20.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel20.Location = new System.Drawing.Point(3, 13);
            this.bunifuCustomLabel20.Name = "bunifuCustomLabel20";
            this.bunifuCustomLabel20.Size = new System.Drawing.Size(171, 19);
            this.bunifuCustomLabel20.TabIndex = 1;
            this.bunifuCustomLabel20.Text = "EJECUTADO MENSUAL";
            // 
            // bunifuCards5
            // 
            this.bunifuCards5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuCards5.BackColor = System.Drawing.Color.White;
            this.bunifuCards5.BorderRadius = 5;
            this.bunifuCards5.BottomSahddow = true;
            this.bunifuCards5.color = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.bunifuCards5.Controls.Add(this.bunifuTileButton4);
            this.bunifuCards5.Controls.Add(this.bunifuTileButton3);
            this.bunifuCards5.Controls.Add(this.bunifuTileButton2);
            this.bunifuCards5.Controls.Add(this.bunifuTileButton1);
            this.bunifuCards5.Controls.Add(this.bunifuCustomLabel21);
            this.bunifuCards5.LeftSahddow = false;
            this.bunifuCards5.Location = new System.Drawing.Point(3, 12);
            this.bunifuCards5.Name = "bunifuCards5";
            this.bunifuCards5.RightSahddow = true;
            this.bunifuCards5.ShadowDepth = 20;
            this.bunifuCards5.Size = new System.Drawing.Size(225, 686);
            this.bunifuCards5.TabIndex = 8;
            // 
            // bunifuTileButton4
            // 
            this.bunifuTileButton4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTileButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.bunifuTileButton4.color = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.bunifuTileButton4.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.bunifuTileButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton4.Image")));
            this.bunifuTileButton4.ImagePosition = 0;
            this.bunifuTileButton4.ImageZoom = 15;
            this.bunifuTileButton4.LabelPosition = 19;
            this.bunifuTileButton4.LabelText = "DISTRIBUIR GASTO FIJO";
            this.bunifuTileButton4.Location = new System.Drawing.Point(15, 218);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(201, 57);
            this.bunifuTileButton4.TabIndex = 5;
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTileButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.bunifuTileButton3.color = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.bunifuTileButton3.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton3.Image")));
            this.bunifuTileButton3.ImagePosition = 0;
            this.bunifuTileButton3.ImageZoom = 15;
            this.bunifuTileButton3.LabelPosition = 19;
            this.bunifuTileButton3.LabelText = "IMPORTAR GASTO FIJO";
            this.bunifuTileButton3.Location = new System.Drawing.Point(15, 158);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(201, 57);
            this.bunifuTileButton3.TabIndex = 4;
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTileButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.bunifuTileButton2.color = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.bunifuTileButton2.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
            this.bunifuTileButton2.ImagePosition = 0;
            this.bunifuTileButton2.ImageZoom = 15;
            this.bunifuTileButton2.LabelPosition = 19;
            this.bunifuTileButton2.LabelText = "IMPORTAR UNIDADES";
            this.bunifuTileButton2.Location = new System.Drawing.Point(15, 38);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(201, 57);
            this.bunifuTileButton2.TabIndex = 3;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 0;
            this.bunifuTileButton1.ImageZoom = 15;
            this.bunifuTileButton1.LabelPosition = 19;
            this.bunifuTileButton1.LabelText = "PROCESAR EJECUTADO";
            this.bunifuTileButton1.Location = new System.Drawing.Point(15, 98);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(201, 57);
            this.bunifuTileButton1.TabIndex = 2;
            // 
            // bunifuCustomLabel21
            // 
            this.bunifuCustomLabel21.AutoSize = true;
            this.bunifuCustomLabel21.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel21.Location = new System.Drawing.Point(31, 15);
            this.bunifuCustomLabel21.Name = "bunifuCustomLabel21";
            this.bunifuCustomLabel21.Size = new System.Drawing.Size(147, 19);
            this.bunifuCustomLabel21.TabIndex = 1;
            this.bunifuCustomLabel21.Text = "ACCESOS RAPIDOS";
            // 
            // officeNavigationBar1
            // 
            this.officeNavigationBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.officeNavigationBar1.Items.AddRange(new DevExpress.XtraBars.Navigation.NavigationBarItem[] {
            this.ImportarUnidades,
            this.ProcesarEjecutado,
            this.ImportarGastoFijo,
            this.DistribuirGF});
            this.officeNavigationBar1.Location = new System.Drawing.Point(0, 710);
            this.officeNavigationBar1.Name = "officeNavigationBar1";
            this.officeNavigationBar1.Size = new System.Drawing.Size(1370, 39);
            this.officeNavigationBar1.TabIndex = 9;
            this.officeNavigationBar1.Text = "officeNavigationBar1";
            // 
            // ImportarUnidades
            // 
            this.ImportarUnidades.Name = "ImportarUnidades";
            toolTipTitleItem1.Text = "Importar Unidades";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Se importan las unidades de mano de obra y otros item de costos para procesar el " +
    "presupuesto.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.ImportarUnidades.SuperTip = superToolTip1;
            this.ImportarUnidades.Text = "Importar Unidades";
            // 
            // ProcesarEjecutado
            // 
            this.ProcesarEjecutado.Name = "ProcesarEjecutado";
            toolTipTitleItem2.Text = "Procesar Ejecutado";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Opción valida para procesar el ejecutado de Nisira ERP y compararlo con el Presup" +
    "uesto.";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.ProcesarEjecutado.SuperTip = superToolTip2;
            this.ProcesarEjecutado.Text = "Procesar Ejecutado";
            // 
            // ImportarGastoFijo
            // 
            this.ImportarGastoFijo.Name = "ImportarGastoFijo";
            toolTipTitleItem3.Text = "Importar Gasto Fijo";
            toolTipItem3.LeftIndent = 6;
            toolTipItem3.Text = "Opción valida para importar el gasto fijo de Nisira ERP y comprarlo con el presup" +
    "uesto GF";
            superToolTip3.Items.Add(toolTipTitleItem3);
            superToolTip3.Items.Add(toolTipItem3);
            this.ImportarGastoFijo.SuperTip = superToolTip3;
            this.ImportarGastoFijo.Text = "Importar Gasto Fijo";
            // 
            // DistribuirGF
            // 
            this.DistribuirGF.Name = "DistribuirGF";
            this.DistribuirGF.Text = "Distribuir GF";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "PRESUPUESTO";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "SP_KPI_PRINCIPAL";
            queryParameter1.Name = "@IDMONEDA";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = "02";
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "SP_KPI_PRINCIPAL";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // Panel_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.officeNavigationBar1);
            this.Controls.Add(this.bunifuCards5);
            this.Controls.Add(this.bunifuCards4);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.Name = "Panel_principal";
            this.Text = "Panel_principal";
            this.Load += new System.EventHandler(this.Panel_principal_Load);
            this.bunifuCards4.ResumeLayout(false);
            this.bunifuCards4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_moneda.Properties)).EndInit();
            this.bunifuCards5.ResumeLayout(false);
            this.bunifuCards5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCards bunifuCards4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel20;
        private Bunifu.Framework.UI.BunifuCards bunifuCards5;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel21;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton8;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton4;
        private DevExpress.XtraEditors.LookUpEdit cbo_moneda;
        private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar1;
        private DevExpress.XtraBars.Navigation.NavigationBarItem ImportarUnidades;
        private DevExpress.XtraBars.Navigation.NavigationBarItem ProcesarEjecutado;
        private DevExpress.XtraBars.Navigation.NavigationBarItem ImportarGastoFijo;
        private DevExpress.XtraBars.Navigation.NavigationBarItem DistribuirGF;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private DevExpress.DashboardWin.DashboardViewer dashboardViewer1;
    }
}