using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Deployment.Application;
using System.Net;

namespace Sistema_Agricola
{
    public partial class Frm_Principal : Form
    {
        private static Form oContenedorForm = null;
        private static Form oContenedorReporte = null;
        private static Form oContenedorOpciones = null;
        private ToolStripLabel toolStripLabel2;
        private string usuario1 = string.Empty;
        public static string user2;

        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            this.Hide();

            Frm_Login logon = new Frm_Login();
            logon.ShowDialog();

            if (logon.DialogResult != DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                usuario1 = Frm_Login.user;
                this.Show();
            }

        }
      //public  void Panelfondo()
      //  {
      //      if (Application.OpenForms.Count>0)
      //      {
      //          panel_principal.Visible = false;
      //      }
      //  }

        private void TrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FORMULARIOS			
            var oVarListaPersonal = Application.OpenForms.OfType<Frm_ListaPersonal>().FirstOrDefault();
            Frm_ListaPersonal oFormularioLstPersonal = oVarListaPersonal ?? new Frm_ListaPersonal();
            oFormularioLstPersonal.ControlBox = false;
            oFormularioLstPersonal.ShowIcon = false;
            oFormularioLstPersonal.MaximizeBox = false;
            oFormularioLstPersonal.MinimizeBox = false;

            var oVarEditPersonal = Application.OpenForms.OfType<Frm_Edit_personal>().FirstOrDefault();
            Frm_Edit_personal oFormularioeditpersonal = oVarEditPersonal ?? new Frm_Edit_personal();
            oFormularioeditpersonal.ControlBox = false;
            oFormularioeditpersonal.ShowIcon = false;
            oFormularioeditpersonal.MaximizeBox = false;
            oFormularioeditpersonal.MinimizeBox = false;

            var oVarGrupoEvluaciones = Application.OpenForms.OfType<Frm_GruposdeEvaluacion>().FirstOrDefault();
            Frm_GruposdeEvaluacion oFormularioGrupoEvaluaciones= oVarGrupoEvluaciones ?? new Frm_GruposdeEvaluacion();
            oFormularioGrupoEvaluaciones.ControlBox = false;
            oFormularioGrupoEvaluaciones.ShowIcon = false;
            oFormularioGrupoEvaluaciones.MaximizeBox = false;
            oFormularioGrupoEvaluaciones.MinimizeBox = false;

            Form[] arrayFormularios = new Form[3];
            string[] arrayTextosForm = new string[3];

            Array.Clear(arrayFormularios, 0, 2);

            arrayFormularios.SetValue(oFormularioLstPersonal, 0);
            arrayFormularios.SetValue(oFormularioeditpersonal, 1);
            arrayFormularios.SetValue(oFormularioeditpersonal, 2);

            arrayTextosForm.SetValue("Lista de Personal", 0);
            arrayTextosForm.SetValue("Formulario Personal", 1);
            arrayTextosForm.SetValue("Lista de Variables de Evaluacion", 2);


            if (oContenedorForm != null)
            {
                oContenedorForm.Visible = false;
            }
            if (oContenedorReporte != null)
            {
                oContenedorReporte.Visible = false;
            }
            if (oContenedorOpciones != null)
            {
                oContenedorOpciones.Visible = false;
            }

            oContenedorForm = new Frm_ContenedorPersonal(arrayTextosForm, arrayFormularios);
            oContenedorForm.Visible = false;

            MessageBox.Show("Se cargó el Módulo de Trabajador correctamente", "Sistema Agricola", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            formulariosToolStripMenuItem.Enabled = true;

        }

        private void formulariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oContenedorForm != null)
            {
               
                WindowsForm.ShowMdi(oContenedorForm, Program.oFormPrincipal);
            }
        }
    }
}
public class WindowsForm
{
    public static void ShowMdi(Form oForm, Form oMdiParent)
    {
        oForm.MdiParent = oMdiParent;
        oForm.Show();
        oForm.FormBorderStyle = FormBorderStyle.None;
        oForm.ControlBox = false;
        oForm.MaximizeBox = false;
        oForm.MinimizeBox = false;
        oForm.ShowIcon = false;
        oForm.Text = string.Empty;
        oForm.Dock = DockStyle.Fill;
        oForm.Select();

    }
}
