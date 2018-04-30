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
    public partial class Frm_Edit_personal : Form
    {
        public Frm_Edit_personal()
        {
            InitializeComponent();
        }

        private void Frm_Edit_personal_Load(object sender, EventArgs e)
        {
            contenedor_principal.Location =
            new Point(ClientSize.Width / 2 - contenedor_principal.Size.Width / 2,
            ClientSize.Height / 2 - contenedor_principal.Size.Height / 2);
        }
    }
}
