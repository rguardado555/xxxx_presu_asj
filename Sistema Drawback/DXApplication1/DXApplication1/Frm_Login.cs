using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_acceder_Click(object sender, EventArgs e)
        {

            if (cbo_empresaseleccionada.Text.Equals("[Seleccionar]"))
            {
                MessageBox.Show("Seleccione Empresa Primero !!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                VariablesGenerales.Empresa = cbo_empresaseleccionada.EditValue.ToString();
                VariablesGenerales.Nombreempresa = "EMPRESA SELECCIONADA : " + cbo_empresaseleccionada.EditValue.ToString() + " - " + cbo_empresaseleccionada.Text.ToString();
                Frm_MenuPrincipal ObjPrincipal = new Frm_MenuPrincipal();
                ObjPrincipal.Show();
                this.Hide();
            }


        }
        void llenarEmpresa()
        {
            cbo_empresaseleccionada.Properties.DataSource = NFunciones.TABLASQL("select idempresa Codigo,razonsocial Empresa from tb_empresa order by idempresa asc");
            cbo_empresaseleccionada.Properties.ValueMember = "Codigo";
            cbo_empresaseleccionada.Properties.DisplayMember = "Empresa";

        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            llenarEmpresa();
        }
    }
}
