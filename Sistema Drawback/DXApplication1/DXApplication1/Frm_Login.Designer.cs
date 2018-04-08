namespace DXApplication1
{
    partial class Frm_Login
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
            this.monoFlat_ThemeContainer1 = new MonoFlat.MonoFlat_ThemeContainer();
            this.monoFlat_HeaderLabel3 = new MonoFlat.MonoFlat_HeaderLabel();
            this.monoFlat_ControlBox1 = new MonoFlat.MonoFlat_ControlBox();
            this.btn_acceder = new MonoFlat.MonoFlat_ButtonBlue();
            this.txt_clave = new MonoFlat.MonoFlat_TextBox();
            this.txt_usuario = new MonoFlat.MonoFlat_TextBox();
            this.monoFlat_HeaderLabel2 = new MonoFlat.MonoFlat_HeaderLabel();
            this.monoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            this.monoFlat_ThemeContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_HeaderLabel3);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_ControlBox1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.btn_acceder);
            this.monoFlat_ThemeContainer1.Controls.Add(this.txt_clave);
            this.monoFlat_ThemeContainer1.Controls.Add(this.txt_usuario);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_HeaderLabel2);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_HeaderLabel1);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = true;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(271, 373);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.monoFlat_ThemeContainer1.TabIndex = 0;
            // 
            // monoFlat_HeaderLabel3
            // 
            this.monoFlat_HeaderLabel3.AutoSize = true;
            this.monoFlat_HeaderLabel3.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_HeaderLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel3.Location = new System.Drawing.Point(27, 70);
            this.monoFlat_HeaderLabel3.Name = "monoFlat_HeaderLabel3";
            this.monoFlat_HeaderLabel3.Size = new System.Drawing.Size(225, 21);
            this.monoFlat_HeaderLabel3.TabIndex = 6;
            this.monoFlat_HeaderLabel3.Text = "Sistema WarSoft - DrawBack";
            // 
            // monoFlat_ControlBox1
            // 
            this.monoFlat_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_ControlBox1.EnableHoverHighlight = false;
            this.monoFlat_ControlBox1.EnableMaximizeButton = true;
            this.monoFlat_ControlBox1.EnableMinimizeButton = true;
            this.monoFlat_ControlBox1.Location = new System.Drawing.Point(159, 15);
            this.monoFlat_ControlBox1.Name = "monoFlat_ControlBox1";
            this.monoFlat_ControlBox1.Size = new System.Drawing.Size(100, 25);
            this.monoFlat_ControlBox1.TabIndex = 5;
            this.monoFlat_ControlBox1.Text = "monoFlat_ControlBox1";
            // 
            // btn_acceder
            // 
            this.btn_acceder.BackColor = System.Drawing.Color.Transparent;
            this.btn_acceder.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_acceder.Image = null;
            this.btn_acceder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_acceder.Location = new System.Drawing.Point(69, 308);
            this.btn_acceder.Name = "btn_acceder";
            this.btn_acceder.Size = new System.Drawing.Size(118, 41);
            this.btn_acceder.TabIndex = 4;
            this.btn_acceder.Text = "Acceder";
            this.btn_acceder.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_acceder.Click += new System.EventHandler(this.btn_acceder_Click);
            // 
            // txt_clave
            // 
            this.txt_clave.BackColor = System.Drawing.Color.Transparent;
            this.txt_clave.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_clave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_clave.Image = null;
            this.txt_clave.Location = new System.Drawing.Point(31, 237);
            this.txt_clave.MaxLength = 32767;
            this.txt_clave.Multiline = false;
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.ReadOnly = false;
            this.txt_clave.Size = new System.Drawing.Size(204, 41);
            this.txt_clave.TabIndex = 3;
            this.txt_clave.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_clave.UseSystemPasswordChar = false;
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.Transparent;
            this.txt_usuario.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txt_usuario.Image = null;
            this.txt_usuario.Location = new System.Drawing.Point(31, 170);
            this.txt_usuario.MaxLength = 32767;
            this.txt_usuario.Multiline = false;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.ReadOnly = false;
            this.txt_usuario.Size = new System.Drawing.Size(204, 41);
            this.txt_usuario.TabIndex = 2;
            this.txt_usuario.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_usuario.UseSystemPasswordChar = false;
            // 
            // monoFlat_HeaderLabel2
            // 
            this.monoFlat_HeaderLabel2.AutoSize = true;
            this.monoFlat_HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.monoFlat_HeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel2.Location = new System.Drawing.Point(27, 214);
            this.monoFlat_HeaderLabel2.Name = "monoFlat_HeaderLabel2";
            this.monoFlat_HeaderLabel2.Size = new System.Drawing.Size(46, 20);
            this.monoFlat_HeaderLabel2.TabIndex = 1;
            this.monoFlat_HeaderLabel2.Text = "Clave";
            // 
            // monoFlat_HeaderLabel1
            // 
            this.monoFlat_HeaderLabel1.AutoSize = true;
            this.monoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.monoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel1.Location = new System.Drawing.Point(27, 147);
            this.monoFlat_HeaderLabel1.Name = "monoFlat_HeaderLabel1";
            this.monoFlat_HeaderLabel1.Size = new System.Drawing.Size(63, 20);
            this.monoFlat_HeaderLabel1.TabIndex = 0;
            this.monoFlat_HeaderLabel1.Text = "Usuario";
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 373);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            this.monoFlat_ThemeContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        private MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel1;
        private MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel3;
        private MonoFlat.MonoFlat_ControlBox monoFlat_ControlBox1;
        private MonoFlat.MonoFlat_ButtonBlue btn_acceder;
        private MonoFlat.MonoFlat_TextBox txt_clave;
        private MonoFlat.MonoFlat_TextBox txt_usuario;
        private MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel2;
    }
}