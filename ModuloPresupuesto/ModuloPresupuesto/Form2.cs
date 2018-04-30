using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.CodeParser;

namespace ModuloPresupuesto
{
    public partial class Frm_Principal : Form
    {

        private Random r;
        private static int i;
      
        public Frm_Principal()
        {
            InitializeComponent();
        }

      
        private void procesosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void monoFlat_ThemeContainer1_Click(object sender, EventArgs e)
        {

        }

        private void tileNavPane1_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (e.Element.Name == "btn_procesarpresupuesto")
            {
                Frm_Etapas objEtapas = new Frm_Etapas();
               
            };
        }

   

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void tab_form_ControlRemoved(object sender, ControlEventArgs e)
        {
         
        }
    }
}
