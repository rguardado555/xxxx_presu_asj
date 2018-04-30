namespace ModuloPresupuesto
{
    partial class FrmGenerarPeriodos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerarPeriodos));
            this.bar_progreso = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.cbo_presupuesto = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lb_coronometro = new DevExpress.XtraEditors.LabelControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bar_progreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_presupuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // bar_progreso
            // 
            this.bar_progreso.EditValue = "Cargando..";
            this.bar_progreso.Location = new System.Drawing.Point(2, 169);
            this.bar_progreso.Name = "bar_progreso";
            this.bar_progreso.Size = new System.Drawing.Size(296, 18);
            this.bar_progreso.TabIndex = 9;
            this.bar_progreso.Visible = false;
            // 
            // cbo_presupuesto
            // 
            this.cbo_presupuesto.Location = new System.Drawing.Point(14, 48);
            this.cbo_presupuesto.Name = "cbo_presupuesto";
            this.cbo_presupuesto.Properties.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_presupuesto.Properties.Appearance.Options.UseFont = true;
            this.cbo_presupuesto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_presupuesto.Properties.NullText = "[Seleccione..]";
            this.cbo_presupuesto.Size = new System.Drawing.Size(265, 22);
            this.cbo_presupuesto.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(101, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 15);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Presupuesto";
            // 
            // btn_update
            // 
            this.btn_update.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.ImageOptions.Image")));
            this.btn_update.Location = new System.Drawing.Point(54, 87);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(182, 33);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "Actualizar";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "67cd2d14-cb90-4bfe-9f53-543407d6fa3b";
            this.toastNotificationsManager1.ApplicationName = "ModuloPresupuesto";
            this.toastNotificationsManager1.CreateApplicationShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("b8f13174-ce27-447f-bbc8-0a01d50a20c0", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "Generar Periodos de Presupuesto", "Proceso Exitoso", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText04),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("6436515a-e246-4b15-9e4d-ef31e664b80e", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications1"))), "Generar Periodos de Presupuesto", "Error en el Proceso", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText04)});
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(8, 148);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(278, 15);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "* Este Proceso Puede Demorar de 1 a 5 Min";
            // 
            // lb_coronometro
            // 
            this.lb_coronometro.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lb_coronometro.Appearance.ForeColor = System.Drawing.Color.White;
            this.lb_coronometro.Appearance.Options.UseBackColor = true;
            this.lb_coronometro.Appearance.Options.UseForeColor = true;
            this.lb_coronometro.Location = new System.Drawing.Point(129, 122);
            this.lb_coronometro.Name = "lb_coronometro";
            this.lb_coronometro.Size = new System.Drawing.Size(20, 13);
            this.lb_coronometro.TabIndex = 17;
            this.lb_coronometro.Text = ".....";
            this.lb_coronometro.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(-9, -8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 227);
            this.textBox1.TabIndex = 87;
            // 
            // FrmGenerarPeriodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 187);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lb_coronometro);
            this.Controls.Add(this.bar_progreso);
            this.Controls.Add(this.cbo_presupuesto);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmGenerarPeriodos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                  Generar Periodos de Presupuesto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGenerarPeriodos_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGenerarPeriodos_FormClosed);
            this.Load += new System.EventHandler(this.Frm_GenerarPeriodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar_progreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_presupuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MarqueeProgressBarControl bar_progreso;
        private DevExpress.XtraEditors.LookUpEdit cbo_presupuesto;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lb_coronometro;
        private System.Windows.Forms.TextBox textBox1;
    }
}