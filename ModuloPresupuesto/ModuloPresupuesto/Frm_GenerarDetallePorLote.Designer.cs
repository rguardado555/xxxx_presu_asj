namespace ModuloPresupuesto
{
    partial class FrmGenerarDetallePorLote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerarDetallePorLote));
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.monoFlat_ThemeContainer1 = new MonoFlat.MonoFlat_ThemeContainer();
            this.monoFlat_ControlBox1 = new MonoFlat.MonoFlat_ControlBox();
            this.bar_progreso = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.monoFlat_Panel1 = new MonoFlat.MonoFlat_Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_update = new MonoFlat.MonoFlat_Button();
            this.lb_coronometro = new DevExpress.XtraEditors.LabelControl();
            this.cbo_presupuesto = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.monoFlat_ThemeContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_progreso.Properties)).BeginInit();
            this.monoFlat_Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_presupuesto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "67cd2d14-cb90-4bfe-9f53-543407d6fa3b";
            this.toastNotificationsManager1.ApplicationName = "ModuloPresupuesto";
            this.toastNotificationsManager1.CreateApplicationShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("b8f13174-ce27-447f-bbc8-0a01d50a20c0", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "Actualización Tipo Cambio", "Proceso Exitoso", "Se Actualizo correctamente el Tipo de Cambio.", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText04),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("6436515a-e246-4b15-9e4d-ef31e664b80e", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications1"))), "Actualización Tipo Cambio", "Error en el Proceso", "No se pudo Actualizar el Tipo de Cambio , consulte con soporte.", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText04),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("74429c0e-578a-4827-9151-f95670c91026", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications2"))), "Procesar Presupuesto", "Proceso Exitoso", "Se Actualizo correctamente el Detalle del Presupuesto.", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText04),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("0b6276bc-ec2e-41cc-96ca-aa75f42c9765", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications3"))), "Procesar Presupuesto", "Error en el Proceso", "No se pudo Procesar el Presupuesto, consulte con soporte.", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText04)});
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_ControlBox1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.bar_progreso);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Panel1);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = true;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(345, 344);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.monoFlat_ThemeContainer1.TabIndex = 17;
            this.monoFlat_ThemeContainer1.Text = "Generar Detalle por Lote ";
            // 
            // monoFlat_ControlBox1
            // 
            this.monoFlat_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_ControlBox1.EnableHoverHighlight = false;
            this.monoFlat_ControlBox1.EnableMaximizeButton = false;
            this.monoFlat_ControlBox1.EnableMinimizeButton = false;
            this.monoFlat_ControlBox1.Location = new System.Drawing.Point(233, 15);
            this.monoFlat_ControlBox1.Name = "monoFlat_ControlBox1";
            this.monoFlat_ControlBox1.Size = new System.Drawing.Size(100, 25);
            this.monoFlat_ControlBox1.TabIndex = 12;
            this.monoFlat_ControlBox1.Text = "monoFlat_ControlBox1";
            // 
            // bar_progreso
            // 
            this.bar_progreso.EditValue = "Cargando..";
            this.bar_progreso.Location = new System.Drawing.Point(0, 324);
            this.bar_progreso.Name = "bar_progreso";
            this.bar_progreso.Size = new System.Drawing.Size(345, 20);
            this.bar_progreso.TabIndex = 12;
            this.bar_progreso.Visible = false;
            // 
            // monoFlat_Panel1
            // 
            this.monoFlat_Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.monoFlat_Panel1.Controls.Add(this.labelControl2);
            this.monoFlat_Panel1.Controls.Add(this.btn_update);
            this.monoFlat_Panel1.Controls.Add(this.lb_coronometro);
            this.monoFlat_Panel1.Controls.Add(this.cbo_presupuesto);
            this.monoFlat_Panel1.Controls.Add(this.labelControl1);
            this.monoFlat_Panel1.Location = new System.Drawing.Point(0, 59);
            this.monoFlat_Panel1.Name = "monoFlat_Panel1";
            this.monoFlat_Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.monoFlat_Panel1.Size = new System.Drawing.Size(348, 285);
            this.monoFlat_Panel1.TabIndex = 17;
            this.monoFlat_Panel1.Text = "monoFlat_Panel1";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(82, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(180, 21);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Seleccione Presupuesto";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_update.Image = null;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(79, 143);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(182, 41);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Actualizar";
            this.btn_update.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // lb_coronometro
            // 
            this.lb_coronometro.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.lb_coronometro.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_coronometro.Appearance.ForeColor = System.Drawing.Color.White;
            this.lb_coronometro.Appearance.Options.UseBackColor = true;
            this.lb_coronometro.Appearance.Options.UseFont = true;
            this.lb_coronometro.Appearance.Options.UseForeColor = true;
            this.lb_coronometro.Location = new System.Drawing.Point(157, 209);
            this.lb_coronometro.Name = "lb_coronometro";
            this.lb_coronometro.Size = new System.Drawing.Size(20, 17);
            this.lb_coronometro.TabIndex = 15;
            this.lb_coronometro.Text = ".....";
            this.lb_coronometro.Visible = false;
            // 
            // cbo_presupuesto
            // 
            this.cbo_presupuesto.Location = new System.Drawing.Point(41, 73);
            this.cbo_presupuesto.Name = "cbo_presupuesto";
            this.cbo_presupuesto.Properties.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_presupuesto.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbo_presupuesto.Properties.Appearance.Options.UseFont = true;
            this.cbo_presupuesto.Properties.Appearance.Options.UseForeColor = true;
            this.cbo_presupuesto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_presupuesto.Properties.NullText = "[Seleccione..]";
            this.cbo_presupuesto.Size = new System.Drawing.Size(265, 22);
            this.cbo_presupuesto.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(30, 228);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(267, 17);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "* Este Proceso Puede Demorar de 2 a 5 Min";
            // 
            // FrmGenerarDetallePorLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 344);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGenerarDetallePorLote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Detalle por Lote ";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGenerarDetallePorLote_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGenerarDetallePorLote_FormClosed);
            this.Load += new System.EventHandler(this.Frm_GenerarDetallePorLote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar_progreso.Properties)).EndInit();
            this.monoFlat_Panel1.ResumeLayout(false);
            this.monoFlat_Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_presupuesto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.MarqueeProgressBarControl bar_progreso;
        private DevExpress.XtraEditors.LookUpEdit cbo_presupuesto;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl lb_coronometro;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private MonoFlat.MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        private MonoFlat.MonoFlat_Button btn_update;
        private MonoFlat.MonoFlat_Panel monoFlat_Panel1;
        private MonoFlat.MonoFlat_ControlBox monoFlat_ControlBox1;
    }
}