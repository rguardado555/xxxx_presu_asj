using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Agricola
{
    public partial class Frm_ContenedorPersonal : Form
    {
        Form[] arrayForm = null;
        string[] arrayText = null;
        public Frm_ContenedorPersonal(string[] textos, Form[] formularios)
        {
            InitializeComponent();
            arrayText = textos;
            arrayForm = formularios;
        }

        private void Frm_ContenedorPersonal_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < arrayForm.Length; i++)
            {
                agregarTabPanelFormulario(arrayText[i], arrayForm[i]);
            }
        }
        private void agregarTabPanelFormulario(string textoTab, Form oForm)
        {
            TabPage oTabPage = new TabPage();
            Panel oPanel = new Panel();

            oTabPage.Text = textoTab;
            oTabPage.Controls.Add(oPanel);

            oPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));


            tbcFormularios.TabPages.Add(oTabPage);

            if (oPanel.Controls.Count > 0)
            {
                oPanel.Controls.RemoveAt(0);
            }

            oForm.TopLevel = false;
            oForm.FormBorderStyle = FormBorderStyle.None;
            oForm.Dock = DockStyle.Fill;
            oPanel.Controls.Add(oForm);
            oPanel.Tag = oForm;
            oForm.Show();
        }
        public void InsertarFormularioPanel(string textoTab, Form oForm)
        {
            foreach (TabPage oPage in tbcFormularios.TabPages)
            {
                if (oPage.Text == textoTab)
                {
                    foreach (Panel oPanel in oPage.Controls)
                    {
                        oForm.TopLevel = false;
                        oForm.FormBorderStyle = FormBorderStyle.None;
                        oForm.Dock = DockStyle.Fill;
                        oPanel.Controls.Add(oForm);
                        oPanel.Tag = oForm;
                        oForm.Show();
                    }
                }
            }
        }

        private void AgregarFormularioPanel(Panel oPanel, Form oForm)
        {
            if (oPanel.Controls.Count > 0)
            {
                oPanel.Controls.RemoveAt(0);
            }

            oForm.TopLevel = false;
            oForm.FormBorderStyle = FormBorderStyle.None;
            oForm.Dock = DockStyle.Fill;
            oPanel.Controls.Add(oForm);
            oPanel.Tag = oForm;
            oForm.Show();
        }


    }
}
