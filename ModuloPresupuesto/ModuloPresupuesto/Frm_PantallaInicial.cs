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
    public partial class Frm_PantallaInicial : Form
    {
        public Frm_PantallaInicial()
        {
            InitializeComponent();
        }

        private void btn_menuprincipal_Click(object sender, EventArgs e)
        {
            Frm_MenuOperacionesPresupuesto objFrmMenuOperaciones = new Frm_MenuOperacionesPresupuesto();
            objFrmMenuOperaciones.Show();
            this.Hide();
        }
    }
}
