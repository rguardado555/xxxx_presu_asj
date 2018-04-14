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
using CapaNegocios;


namespace DXApplication1
{
    public partial class Frm_Duas : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Duas()
        {
            InitializeComponent();
        }

        private void Frm_Ventas_Load(object sender, EventArgs e)
        {

        }
        void llenarCompras()
        {
            cbo_docexportacion.Properties.DataSource = NFunciones.TABLASQL(" ");

        }
    }
}