namespace Sistema_Agricola
{
    partial class Frm_ContenedorPersonal
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
            this.tbcFormularios = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // tbcFormularios
            // 
            this.tbcFormularios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcFormularios.Location = new System.Drawing.Point(1, 1);
            this.tbcFormularios.Name = "tbcFormularios";
            this.tbcFormularios.SelectedIndex = 0;
            this.tbcFormularios.Size = new System.Drawing.Size(830, 516);
            this.tbcFormularios.TabIndex = 1;
            // 
            // Frm_ContenedorPersonal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(830, 520);
            this.Controls.Add(this.tbcFormularios);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ContenedorPersonal";
            this.Text = "Frm_ContenedorPersonal";
            this.Load += new System.EventHandler(this.Frm_ContenedorPersonal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcFormularios;
    }
}