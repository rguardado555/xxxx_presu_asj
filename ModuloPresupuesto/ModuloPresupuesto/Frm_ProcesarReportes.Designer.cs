namespace ModuloPresupuesto
{
    partial class Frm_ProcesarReportes
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.monoFlat_ThemeContainer1 = new MonoFlat.MonoFlat_ThemeContainer();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbo_presupuesto = new DevExpress.XtraEditors.LookUpEdit();
            this.bar_progreso = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.btn_procesar = new MonoFlat.MonoFlat_ButtonBlue();
            this.monoFlat_ControlBox1 = new MonoFlat.MonoFlat_ControlBox();
            this.monoFlat_Panel1 = new MonoFlat.MonoFlat_Panel();
            this.monoFlat_ThemeContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_presupuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_progreso.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.labelControl2);
            this.monoFlat_ThemeContainer1.Controls.Add(this.cbo_presupuesto);
            this.monoFlat_ThemeContainer1.Controls.Add(this.bar_progreso);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btn_procesar);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_ControlBox1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Panel1);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = true;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(354, 276);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.monoFlat_ThemeContainer1.TabIndex = 0;
            this.monoFlat_ThemeContainer1.Text = "Procesar Reportes";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(90, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(180, 21);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Seleccione Presupuesto";
            // 
            // cbo_presupuesto
            // 
            this.cbo_presupuesto.Location = new System.Drawing.Point(43, 116);
            this.cbo_presupuesto.Name = "cbo_presupuesto";
            this.cbo_presupuesto.Properties.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_presupuesto.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbo_presupuesto.Properties.Appearance.Options.UseFont = true;
            this.cbo_presupuesto.Properties.Appearance.Options.UseForeColor = true;
            this.cbo_presupuesto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_presupuesto.Properties.NullText = "[Seleccione..]";
            this.cbo_presupuesto.Size = new System.Drawing.Size(265, 22);
            this.cbo_presupuesto.TabIndex = 15;
            // 
            // bar_progreso
            // 
            this.bar_progreso.EditValue = "Cargando..";
            this.bar_progreso.Location = new System.Drawing.Point(0, 256);
            this.bar_progreso.Name = "bar_progreso";
            this.bar_progreso.Size = new System.Drawing.Size(354, 20);
            this.bar_progreso.TabIndex = 13;
            this.bar_progreso.Visible = false;
            // 
            // btn_procesar
            // 
            this.btn_procesar.BackColor = System.Drawing.Color.Transparent;
            this.btn_procesar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_procesar.Image = null;
            this.btn_procesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_procesar.Location = new System.Drawing.Point(43, 197);
            this.btn_procesar.Name = "btn_procesar";
            this.btn_procesar.Size = new System.Drawing.Size(265, 31);
            this.btn_procesar.TabIndex = 1;
            this.btn_procesar.Text = "Procesar";
            this.btn_procesar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_procesar.Click += new System.EventHandler(this.btn_procesar_Click);
            // 
            // monoFlat_ControlBox1
            // 
            this.monoFlat_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_ControlBox1.EnableHoverHighlight = false;
            this.monoFlat_ControlBox1.EnableMaximizeButton = true;
            this.monoFlat_ControlBox1.EnableMinimizeButton = true;
            this.monoFlat_ControlBox1.Location = new System.Drawing.Point(242, 15);
            this.monoFlat_ControlBox1.Name = "monoFlat_ControlBox1";
            this.monoFlat_ControlBox1.Size = new System.Drawing.Size(100, 25);
            this.monoFlat_ControlBox1.TabIndex = 0;
            this.monoFlat_ControlBox1.Text = "monoFlat_ControlBox1";
            // 
            // monoFlat_Panel1
            // 
            this.monoFlat_Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.monoFlat_Panel1.Location = new System.Drawing.Point(0, 46);
            this.monoFlat_Panel1.Name = "monoFlat_Panel1";
            this.monoFlat_Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.monoFlat_Panel1.Size = new System.Drawing.Size(354, 246);
            this.monoFlat_Panel1.TabIndex = 16;
            this.monoFlat_Panel1.Text = "monoFlat_Panel1";
            // 
            // Frm_ProcesarReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 276);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ProcesarReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesar Reportes";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Frm_ProcesarReportes_Load);
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            this.monoFlat_ThemeContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_presupuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_progreso.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        private MonoFlat.MonoFlat_ButtonBlue btn_procesar;
        private MonoFlat.MonoFlat_ControlBox monoFlat_ControlBox1;
        private DevExpress.XtraEditors.MarqueeProgressBarControl bar_progreso;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit cbo_presupuesto;
        private System.Windows.Forms.Timer timer1;
        private MonoFlat.MonoFlat_Panel monoFlat_Panel1;
    }
}