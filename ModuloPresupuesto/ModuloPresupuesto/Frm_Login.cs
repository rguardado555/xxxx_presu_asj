using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloPresupuesto
{
    public partial class Frm_Login : Form
    {
        private int cont=0;
        private int opac = 100;

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Frm_MenuPrincipal objFrmPantallaInicial = new Frm_MenuPrincipal();
            objFrmPantallaInicial.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
