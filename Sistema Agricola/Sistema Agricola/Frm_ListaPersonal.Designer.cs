namespace Sistema_Agricola
{
    partial class Frm_ListaPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListaPersonal));
            this.dtg_datos = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CARGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLANILLA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NISIRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UBIGUEO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_filtro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_filtro = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_importar = new System.Windows.Forms.Button();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.barra_progreso = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.imagen_cargando = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_cargando)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_datos
            // 
            this.dtg_datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.NOMBRE,
            this.CARGO,
            this.PLANILLA,
            this.ESTADO,
            this.NISIRA,
            this.TELEFONO,
            this.DIRECCION,
            this.UBIGUEO});
            this.dtg_datos.Location = new System.Drawing.Point(3, 74);
            this.dtg_datos.Name = "dtg_datos";
            this.dtg_datos.Size = new System.Drawing.Size(984, 452);
            this.dtg_datos.TabIndex = 0;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "IdCodigoGeneral";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "Nombres";
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // CARGO
            // 
            this.CARGO.DataPropertyName = "CARGO";
            this.CARGO.HeaderText = "CARGO";
            this.CARGO.Name = "CARGO";
            // 
            // PLANILLA
            // 
            this.PLANILLA.DataPropertyName = "PLANILLA";
            this.PLANILLA.HeaderText = "PLANILLA";
            this.PLANILLA.Name = "PLANILLA";
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            // 
            // NISIRA
            // 
            this.NISIRA.DataPropertyName = "NISIRA";
            this.NISIRA.HeaderText = "NISIRA";
            this.NISIRA.Name = "NISIRA";
            // 
            // TELEFONO
            // 
            this.TELEFONO.DataPropertyName = "TELEFONO";
            this.TELEFONO.HeaderText = "TELEFONO";
            this.TELEFONO.Name = "TELEFONO";
            // 
            // DIRECCION
            // 
            this.DIRECCION.DataPropertyName = "DIRECCION";
            this.DIRECCION.HeaderText = "DIRECCION";
            this.DIRECCION.Name = "DIRECCION";
            // 
            // UBIGUEO
            // 
            this.UBIGUEO.DataPropertyName = "IDUBIGEO";
            this.UBIGUEO.HeaderText = "UBIGUEO";
            this.UBIGUEO.Name = "UBIGUEO";
            // 
            // cbo_filtro
            // 
            this.cbo_filtro.FormattingEnabled = true;
            this.cbo_filtro.Location = new System.Drawing.Point(83, 48);
            this.cbo_filtro.Name = "cbo_filtro";
            this.cbo_filtro.Size = new System.Drawing.Size(162, 21);
            this.cbo_filtro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Filtro ";
            // 
            // txt_filtro
            // 
            this.txt_filtro.Location = new System.Drawing.Point(253, 48);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(276, 20);
            this.txt_filtro.TabIndex = 3;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.Image")));
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.Location = new System.Drawing.Point(537, 45);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(141, 23);
            this.btn_Buscar.TabIndex = 4;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista de Trabajadores";
            // 
            // btn_importar
            // 
            this.btn_importar.Image = ((System.Drawing.Image)(resources.GetObject("btn_importar.Image")));
            this.btn_importar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_importar.Location = new System.Drawing.Point(684, 46);
            this.btn_importar.Name = "btn_importar";
            this.btn_importar.Size = new System.Drawing.Size(141, 23);
            this.btn_importar.TabIndex = 6;
            this.btn_importar.Text = "Sincroniza";
            this.btn_importar.UseVisualStyleBackColor = true;
            this.btn_importar.Click += new System.EventHandler(this.btn_importar_Click);
            // 
            // btn_exportar
            // 
            this.btn_exportar.Image = ((System.Drawing.Image)(resources.GetObject("btn_exportar.Image")));
            this.btn_exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exportar.Location = new System.Drawing.Point(831, 46);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(141, 23);
            this.btn_exportar.TabIndex = 7;
            this.btn_exportar.Text = "Exportar";
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // barra_progreso
            // 
            this.barra_progreso.Location = new System.Drawing.Point(3, 528);
            this.barra_progreso.Name = "barra_progreso";
            this.barra_progreso.Size = new System.Drawing.Size(984, 23);
            this.barra_progreso.TabIndex = 8;
            this.barra_progreso.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // imagen_cargando
            // 
            this.imagen_cargando.Image = ((System.Drawing.Image)(resources.GetObject("imagen_cargando.Image")));
            this.imagen_cargando.Location = new System.Drawing.Point(430, 220);
            this.imagen_cargando.Name = "imagen_cargando";
            this.imagen_cargando.Size = new System.Drawing.Size(117, 97);
            this.imagen_cargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen_cargando.TabIndex = 9;
            this.imagen_cargando.TabStop = false;
            this.imagen_cargando.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // Frm_ListaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 550);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imagen_cargando);
            this.Controls.Add(this.barra_progreso);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.btn_importar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_filtro);
            this.Controls.Add(this.dtg_datos);
            this.Name = "Frm_ListaPersonal";
            this.Text = "Frm_ListaPersonal";
            this.Load += new System.EventHandler(this.Frm_ListaPersonal_Load);
            this.ResizeEnd += new System.EventHandler(this.Frm_ListaPersonal_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_cargando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_datos;
        private System.Windows.Forms.ComboBox cbo_filtro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_filtro;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_importar;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.ProgressBar barra_progreso;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLANILLA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NISIRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn UBIGUEO;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox imagen_cargando;
        private System.Windows.Forms.Label label3;
    }
}