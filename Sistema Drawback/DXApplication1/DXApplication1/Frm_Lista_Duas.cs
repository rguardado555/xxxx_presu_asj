using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DXApplication1
{
    public partial class Frm_Lista_Duas : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Lista_Duas()
        {
            InitializeComponent();
        }

        private void btn_nuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Duas Objduas = new Frm_Duas("","N");
            Objduas.Show();
        }

        private void Frm_Lista_Duas_Load(object sender, EventArgs e)
        {

        }
    }
}