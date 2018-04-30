namespace DXApplication1
{
    partial class Frm_ImporVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ImporVentas));
            this.txt_ruta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_actualizar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_generarplantilla = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cerrar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ruta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ruta
            // 
            this.txt_ruta.Location = new System.Drawing.Point(115, 31);
            this.txt_ruta.Name = "txt_ruta";
            this.txt_ruta.Properties.ReadOnly = true;
            this.txt_ruta.Size = new System.Drawing.Size(401, 20);
            this.txt_ruta.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(0, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(109, 15);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Ruta de Archivo :";
            // 
            // btn_update
            // 
            this.btn_update.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.ImageOptions.Image")));
            this.btn_update.Location = new System.Drawing.Point(522, 29);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(98, 21);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Ruta";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.Appearance.Options.UseFont = true;
            this.btn_actualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.ImageOptions.Image")));
            this.btn_actualizar.Location = new System.Drawing.Point(406, 105);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(208, 42);
            this.btn_actualizar.TabIndex = 13;
            this.btn_actualizar.Text = "Comenzar Importación";
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_generarplantilla
            // 
            this.btn_generarplantilla.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generarplantilla.Appearance.Options.UseFont = true;
            this.btn_generarplantilla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_generarplantilla.ImageOptions.Image")));
            this.btn_generarplantilla.Location = new System.Drawing.Point(115, 57);
            this.btn_generarplantilla.Name = "btn_generarplantilla";
            this.btn_generarplantilla.Size = new System.Drawing.Size(160, 32);
            this.btn_generarplantilla.TabIndex = 14;
            this.btn_generarplantilla.Text = "Generar Formato";
            this.btn_generarplantilla.Click += new System.EventHandler(this.btn_generarplantilla_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.Appearance.Options.UseFont = true;
            this.btn_cerrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.ImageOptions.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(596, -2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(24, 25);
            this.btn_cerrar.TabIndex = 15;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Frm_ImporVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 152);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_generarplantilla);
            this.Controls.Add(this.txt_ruta);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_actualizar);
            this.Name = "Frm_ImporVentas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar ventas desde Excel";
            ((System.ComponentModel.ISupportInitialize)(this.txt_ruta.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_ruta;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton btn_actualizar;
        private DevExpress.XtraEditors.SimpleButton btn_generarplantilla;
        private DevExpress.XtraEditors.SimpleButton btn_cerrar;
    }
}