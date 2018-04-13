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
    public partial class Frm_lista_ventas : DevExpress.XtraEditors.XtraForm
    {
        public Frm_lista_ventas()
        {
            InitializeComponent();
        }

        private void Frm_lista_ventas_Load(object sender, EventArgs e)
        {
            LlegarGrilla();

        }

        void LlegarGrilla()
        {
            dtg_datos.DataSource = NFunciones.TABLASQL("Select idcobrarpagardoc ID,iddocumento+' '+serie+' '+numero DOC,idclieprov IDCLIEPROV,RAZONSOCIAL,fecha FECHA,estado IDESTADO,CASE ESTADO WHEN '0' THEN 'ANULADO' ELSE 'ACTIVADO' END ESTADO from tb_cobrarpagardoc where idempresa='" + VariablesGenerales.Empresa + "' AND TIPO='V'");

        }

        private void btn_nuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Compra ObJCompra = new Frm_Compra("", "N", "V");
            ObJCompra.ShowDialog();
        }

        private void btn_editar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Frm_Compra ObJCompra = new Frm_Compra(Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)), "E", "V");
                ObJCompra.ShowDialog();
            }
            catch
            {

            }
        }

        private void dtg_datos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Frm_Compra ObJCompra = new Frm_Compra(Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)), "V", "C");
                ObJCompra.ShowDialog();
            }
            catch
            {

            }
        }
    }
}