namespace ModuloPresupuesto
{
    partial class Frm_detallePXQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_detallePXQ));
            this.dtg_datos = new DevExpress.XtraGrid.GridControl();
            this.vista_datos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lb_mensaje = new System.Windows.Forms.Label();
            this.btn_exportarexcel = new MonoFlat.MonoFlat_Button();
            this.monoFlat_ThemeContainer1 = new MonoFlat.MonoFlat_ThemeContainer();
            this.barrar_progreso = new DevExpress.XtraWaitForm.ProgressPanel();
            this.monoFlat_ControlBox1 = new MonoFlat.MonoFlat_ControlBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_datos)).BeginInit();
            this.monoFlat_ThemeContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_datos
            // 
            this.dtg_datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_datos.Location = new System.Drawing.Point(4, 95);
            this.dtg_datos.MainView = this.vista_datos;
            this.dtg_datos.Name = "dtg_datos";
            this.dtg_datos.Size = new System.Drawing.Size(1032, 498);
            this.dtg_datos.TabIndex = 0;
            this.dtg_datos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vista_datos});
            // 
            // vista_datos
            // 
            this.vista_datos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.vista_datos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.vista_datos.Appearance.GroupPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.vista_datos.Appearance.GroupPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vista_datos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.vista_datos.Appearance.GroupPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.vista_datos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.vista_datos.Appearance.GroupPanel.Options.UseBorderColor = true;
            this.vista_datos.Appearance.GroupPanel.Options.UseFont = true;
            this.vista_datos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.vista_datos.GridControl = this.dtg_datos;
            this.vista_datos.Name = "vista_datos";
            this.vista_datos.OptionsFind.AlwaysVisible = true;
            // 
            // lb_mensaje
            // 
            this.lb_mensaje.AutoSize = true;
            this.lb_mensaje.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mensaje.ForeColor = System.Drawing.Color.Red;
            this.lb_mensaje.Location = new System.Drawing.Point(441, 321);
            this.lb_mensaje.Name = "lb_mensaje";
            this.lb_mensaje.Size = new System.Drawing.Size(186, 20);
            this.lb_mensaje.TabIndex = 1;
            this.lb_mensaje.Text = "No hay datos para mostrar";
            this.lb_mensaje.Visible = false;
            // 
            // btn_exportarexcel
            // 
            this.btn_exportarexcel.BackColor = System.Drawing.Color.Transparent;
            this.btn_exportarexcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportarexcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportarexcel.Image = ((System.Drawing.Image)(resources.GetObject("btn_exportarexcel.Image")));
            this.btn_exportarexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exportarexcel.Location = new System.Drawing.Point(916, 63);
            this.btn_exportarexcel.Name = "btn_exportarexcel";
            this.btn_exportarexcel.Size = new System.Drawing.Size(120, 26);
            this.btn_exportarexcel.TabIndex = 108;
            this.btn_exportarexcel.Text = "Exportar";
            this.btn_exportarexcel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_exportarexcel.Click += new System.EventHandler(this.btn_exportarexcel_Click);
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.barrar_progreso);
            this.monoFlat_ThemeContainer1.Controls.Add(this.dtg_datos);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_ControlBox1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btn_exportarexcel);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = true;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(1042, 597);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.monoFlat_ThemeContainer1.TabIndex = 109;
            this.monoFlat_ThemeContainer1.Text = "Detalle PxQ";
            // 
            // barrar_progreso
            // 
            this.barrar_progreso.Appearance.BackColor = System.Drawing.Color.White;
            this.barrar_progreso.Appearance.ForeColor = System.Drawing.Color.Black;
            this.barrar_progreso.Appearance.Options.UseBackColor = true;
            this.barrar_progreso.Appearance.Options.UseForeColor = true;
            this.barrar_progreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.barrar_progreso.BarAnimationElementThickness = 2;
            this.barrar_progreso.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barrar_progreso.Caption = "Un momento";
            this.barrar_progreso.CaptionToDescriptionDistance = 5;
            this.barrar_progreso.Description = "Cargando ...";
            this.barrar_progreso.FrameCount = 45000;
            this.barrar_progreso.FrameInterval = 1200;
            this.barrar_progreso.LineAnimationElementHeight = 30;
            this.barrar_progreso.LineAnimationElementType = DevExpress.Utils.Animation.LineAnimationElementType.Triangle;
            this.barrar_progreso.Location = new System.Drawing.Point(445, 291);
            this.barrar_progreso.Name = "barrar_progreso";
            this.barrar_progreso.RingAnimationDiameter = 60;
            this.barrar_progreso.Size = new System.Drawing.Size(166, 72);
            this.barrar_progreso.TabIndex = 110;
            this.barrar_progreso.Visible = false;
            this.barrar_progreso.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring;
            // 
            // monoFlat_ControlBox1
            // 
            this.monoFlat_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_ControlBox1.EnableHoverHighlight = false;
            this.monoFlat_ControlBox1.EnableMaximizeButton = false;
            this.monoFlat_ControlBox1.EnableMinimizeButton = false;
            this.monoFlat_ControlBox1.Location = new System.Drawing.Point(930, 15);
            this.monoFlat_ControlBox1.Name = "monoFlat_ControlBox1";
            this.monoFlat_ControlBox1.Size = new System.Drawing.Size(100, 25);
            this.monoFlat_ControlBox1.TabIndex = 109;
            this.monoFlat_ControlBox1.Text = "monoFlat_ControlBox1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_detallePXQ
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 597);
            this.Controls.Add(this.lb_mensaje);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_detallePXQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle PxQ";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Frm_detallePXQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_datos)).EndInit();
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtg_datos;
        private DevExpress.XtraGrid.Views.Grid.GridView vista_datos;
        private System.Windows.Forms.Label lb_mensaje;
        private MonoFlat.MonoFlat_Button btn_exportarexcel;
        private MonoFlat.MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        private MonoFlat.MonoFlat_ControlBox monoFlat_ControlBox1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraWaitForm.ProgressPanel barrar_progreso;
    }
}