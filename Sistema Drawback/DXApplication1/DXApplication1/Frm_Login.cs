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
            Frm_MenuPrincipal ObjPrincipal = new Frm_MenuPrincipal();
            ObjPrincipal.Show();
            this.Hide();

        }
    }
}
