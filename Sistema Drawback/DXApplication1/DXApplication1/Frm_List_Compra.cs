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
    public partial class Frm_List_Compra : DevExpress.XtraEditors.XtraForm
    {
        public Frm_List_Compra()
        {
            InitializeComponent();
        }

        private void Frm_List_Compra_Load(object sender, EventArgs e)
        {

        }
        void LlegarGrilla()
        {
            dtg_datos.DataSource = NFunciones.TABLASQL("Select idcobrarpagardoc ID,iddocumento+' '+serie+' '+numero DOC,idclieprov IDCLIEPROV,RAZONSOCIAL,fecha FECHA,estado IDESTADO,CASE ESTADO WHEN '0' THEN 'ANULADO' ELSE 'ACTIVADO' END ESTADO from tb_cobrarpagardoc where idempresa='"+VariablesGenerales.Empresa+"'");

        }
    }
}