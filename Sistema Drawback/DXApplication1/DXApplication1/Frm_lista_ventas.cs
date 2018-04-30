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
            dtg_datos.DataSource = NFunciones.TABLASQL("Select c.idcobrarpagardoc ID,c.iddocumento+' '+c.serie+' '+c.numero DOC,c.idclieprov IDCLIEPROV,c.RAZONSOCIAL,c.fecha FECHA,estado IDESTADO,'' ESTADO,d.iddestino REF from tb_cobrarpagardoc c  left join tb_docreferencia d on d.idorigen=c.idcobrarpagardoc where c.idempresa='"+VariablesGenerales.Empresa+"' AND c.TIPO='V'");

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
                Frm_Compra ObJCompra = new Frm_Compra(Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)), "V", "V");
                ObJCompra.ShowDialog();
            }
            catch
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (VariablesGenerales.refresventas.Equals("S"))
            {
                VariablesGenerales.refresventas = "N";
                LlegarGrilla();
            }
        }

        private void btn_eliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_eliminar_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DialogResult rpta = MessageBox.Show("Desea Eliminar este registro ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rpta == DialogResult.Yes)
                {
                    DataTable tb_op = new DataTable();

                    tb_op = NFunciones.TABLASQL("select * from tb_docreferencia where idempresa='" + VariablesGenerales.Empresa + "' and idorigen='" + Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)) + "'");

                    if (tb_op.Rows.Count > 0)
                    {
                        MessageBox.Show("No se Puede Eliminar el Documento esta Referenciado a otro Documento ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                            string eliminarcabecera = NFunciones.ExecuteSQL("DELETE tb_cobrarpagardoc WHERE IDEMPRESA='" + VariablesGenerales.Empresa + "' AND idcobrarpagardoc='" + Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)) + "'");
                            string detalle = NFunciones.ExecuteSQL("DELETE tb_dcobrarpagardoc WHERE IDEMPRESA='" + VariablesGenerales.Empresa + "' AND idcobrarpagardoc='" + Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)) + "'");
                            string mov = NFunciones.ExecuteSQL("DELETE tb_movcobrarpagardoc_drakback WHERE IDEMPRESA='" + VariablesGenerales.Empresa + "' AND idcobrarpagardoc='" + Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)) + "' AND IDTRANSACCION='" + Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)) + "'");
                            LlegarGrilla();
                            MessageBox.Show("Se Elimino Correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }

                }
            }
            catch
            {
                MessageBox.Show("Elija un registro ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btn_importarventas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_ImporVentas ObjImpoVentas = new Frm_ImporVentas();
            ObjImpoVentas.ShowDialog();
        }
    }
}