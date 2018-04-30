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
            LlegarGrilla();
        }
        void LlegarGrilla()
        {
            dtg_datos.DataSource = NFunciones.TABLASQL("Select idcobrarpagardoc ID,iddocumento+' '+serie+' '+numero DOC,idclieprov IDCLIEPROV,RAZONSOCIAL,fecha FECHA,estado IDESTADO,CASE ESTADO WHEN '0' THEN 'ANULADO' ELSE 'ACTIVADO' END ESTADO from tb_cobrarpagardoc where idempresa='"+VariablesGenerales.Empresa+"' AND TIPO='C'");

        }

        private void btn_nuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Compra ObJCompra = new Frm_Compra("","N","C");
            ObJCompra.ShowDialog();
        }

        private void dtg_datos_Click(object sender, EventArgs e)
        {

        }

        private void dtg_datos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Frm_Compra ObJCompra = new Frm_Compra(Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)), "V","C");
                ObJCompra.ShowDialog();
            }
            catch
            {

            }
        }

        private void btn_editar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Frm_Compra ObJCompra = new Frm_Compra(Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)), "E","C");
                ObJCompra.ShowDialog();
            }
            catch
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (VariablesGenerales.refrescompras.Equals("S"))
            {
                VariablesGenerales.refrescompras = "N";
                LlegarGrilla();
            }
        }

        private void btn_actualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlegarGrilla();
        }

        private void btn_eliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DialogResult rpta = MessageBox.Show("Desea Eliminar este registro ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rpta == DialogResult.Yes)
                {
 
                    DataTable tb_op = new DataTable();
               
                   tb_op = NFunciones.TABLASQL("SELECT * FROM tb_movcobrarpagardoc_drakback where idcobrarpagardoc='" + Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)) + "' and idempresa='" + VariablesGenerales.Empresa + "' and not idtransaccion='" + Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)) + "'");  

                    if (tb_op.Rows.Count > 0)
                    {
                        MessageBox.Show("No se Puede Eliminar el Documento esta Referenciado a otro Documento ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        DialogResult Result = MessageBox.Show("Esta Seguro de Eliminar el Documento", "Verificación !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Result == DialogResult.Yes)
                        {
                            string eliminarcabecera = NFunciones.ExecuteSQL("DELETE tb_cobrarpagardoc WHERE IDEMPRESA='" + VariablesGenerales.Empresa + "' AND idcobrarpagardoc='" + Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)) + "'");
                            string detalle = NFunciones.ExecuteSQL("DELETE tb_dcobrarpagardoc WHERE IDEMPRESA='" + VariablesGenerales.Empresa + "' AND idcobrarpagardoc='" + Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)) + "'");
                            string mov = NFunciones.ExecuteSQL("DELETE tb_movcobrarpagardoc_drakback WHERE IDEMPRESA='" + VariablesGenerales.Empresa + "' AND idcobrarpagardoc='" + Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)) + "' AND IDTRANSACCION='" + Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)) + "'");
                            LlegarGrilla();
                            MessageBox.Show("Se Elimino Correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            return;
                        }
                    }

                }
            }
            catch
            {
                MessageBox.Show("Elija un registro ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}