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
    public partial class Frm_sincronizar : Form
    {
        public Frm_sincronizar()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.estadosincronizacion.Equals("S"))
            {
                Program.estadosincronizacion = "N";
                this.Close();
            }
        }
    }
}
