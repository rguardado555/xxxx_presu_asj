namespace ModuloPresupuesto
{
    partial class Frm_UpdateTipoCambio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_UpdateTipoCambio));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbo_presupuesto = new DevExpress.XtraEditors.LookUpEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bar_progreso = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.txt_tipocambio = new System.Windows.Forms.MaskedTextBox();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.chk_presupuesto = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.chk_TC = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_presupuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_progreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_presupuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_TC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(90, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 15);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tipo de Cambio";
            // 
            // btn_update
            // 
            this.btn_update.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.ImageOptions.Image")));
            this.btn_update.Location = new System.Drawing.Point(56, 210);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(182, 33);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Actualizar";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(97, 148);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 15);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Presupuesto";
            // 
            // cbo_presupuesto
            // 
            this.cbo_presupuesto.Location = new System.Drawing.Point(20, 169);
            this.cbo_presupuesto.Name = "cbo_presupuesto";
            this.cbo_presupuesto.Properties.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_presupuesto.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbo_presupuesto.Properties.Appearance.Options.UseFont = true;
            this.cbo_presupuesto.Properties.Appearance.Options.UseForeColor = true;
            this.cbo_presupuesto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_presupuesto.Properties.NullText = "[Seleccione..]";
            this.cbo_presupuesto.Size = new System.Drawing.Size(265, 22);
            this.cbo_presupuesto.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bar_progreso
            // 
            this.bar_progreso.EditValue = "Cargando..";
            this.bar_progreso.Location = new System.Drawing.Point(-11, 248);
            this.bar_progreso.Name = "bar_progreso";
            this.bar_progreso.Size = new System.Drawing.Size(311, 18);
            this.bar_progreso.TabIndex = 5;
            this.bar_progreso.Visible = false;
            // 
            // txt_tipocambio
            // 
            this.txt_tipocambio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipocambio.Location = new System.Drawing.Point(90, 47);
            this.txt_tipocambio.Mask = "#.####";
            this.txt_tipocambio.Name = "txt_tipocambio";
            this.txt_tipocambio.Size = new System.Drawing.Size(100, 23);
            this.txt_tipocambio.TabIndex = 6;
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
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("0b6276bc-ec2e-41cc-96ca-aa75f42c9765", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications3"))), "Procesar Presupuesto ERROR", "Error en el Proceso", "No se pudo Procesar el Presupuesto, consulte con soporte.", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText04)});
            // 
            // chk_presupuesto
            // 
            this.chk_presupuesto.Location = new System.Drawing.Point(56, 118);
            this.chk_presupuesto.Name = "chk_presupuesto";
            this.chk_presupuesto.Properties.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_presupuesto.Properties.Appearance.Options.UseFont = true;
            this.chk_presupuesto.Properties.Caption = "Actualizar Presupuesto ?";
            this.chk_presupuesto.Size = new System.Drawing.Size(192, 19);
            this.chk_presupuesto.TabIndex = 7;
            this.chk_presupuesto.CheckedChanged += new System.EventHandler(this.chk_presupuesto_CheckedChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Location = new System.Drawing.Point(12, 128);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(278, 76);
            this.panelControl1.TabIndex = 8;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.txt_tipocambio);
            this.panelControl2.Location = new System.Drawing.Point(7, 12);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(278, 93);
            this.panelControl2.TabIndex = 9;
            // 
            // chk_TC
            // 
            this.chk_TC.Location = new System.Drawing.Point(56, 5);
            this.chk_TC.Name = "chk_TC";
            this.chk_TC.Properties.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_TC.Properties.Appearance.Options.UseFont = true;
            this.chk_TC.Properties.Caption = "Actualizar Tipo de Cambio ?";
            this.chk_TC.Size = new System.Drawing.Size(202, 19);
            this.chk_TC.TabIndex = 10;
            this.chk_TC.CheckedChanged += new System.EventHandler(this.chk_TC_CheckedChanged);
            // 
            // Frm_UpdateTipoCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(297, 266);
            this.Controls.Add(this.chk_TC);
            this.Controls.Add(this.chk_presupuesto);
            this.Controls.Add(this.bar_progreso);
            this.Controls.Add(this.cbo_presupuesto);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_UpdateTipoCambio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                Actualizar T.C/Procesar Presupuesto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_UpdateTipoCambio_FormClosed);
            this.Load += new System.EventHandler(this.Frm_UpdateTipoCambio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_presupuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_progreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_presupuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_TC.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit cbo_presupuesto;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.MarqueeProgressBarControl bar_progreso;
        private System.Windows.Forms.MaskedTextBox txt_tipocambio;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private DevExpress.XtraEditors.CheckEdit chk_presupuesto;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.CheckEdit chk_TC;
    }
}