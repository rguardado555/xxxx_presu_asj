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
    public partial class Frm_ListadoInsumos : DevExpress.XtraEditors.XtraForm
    {
        public Frm_ListadoInsumos()
        {
            InitializeComponent();
        }

        private void Frm_ListadoInsumos_Load(object sender, EventArgs e)
        {
            llenarInsumos();
        }
        void llenarInsumos()
        {
            dtg_insumos.DataSource = NFunciones.TABLASQL("SELECT X.idcobrarpagardoc ID,C.iddocumento+' '+C.serie+' - '+C.numero DOCUMENTO,C.idclieprov IDPROVEEDOR,C.razonsocial PROVEEDOR,X.idproducto IDPRODUCTO,X.descripcion PRODUCTO,X.idunidad UNIDAD,X.stock CANTIDAD,0 SOLICITADA,X.ITEM FROM (SELECT SUM(cantidad*factor) stock,idcobrarpagardoc,idproducto,descripcion,idunidad,item FROM tb_movcobrarpagardoc_drakback M where SUBSTRING(idcobrarpagardoc,1,1)='C' AND idempresa='" + VariablesGenerales.Empresa+ "' group by idcobrarpagardoc,idproducto,descripcion,idunidad,item)X INNER JOIN tb_cobrarpagardoc C ON X.idcobrarpagardoc=C.idcobrarpagardoc WHERE X.stock>0 AND C.idempresa='" + VariablesGenerales.Empresa+"'");
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (vista_insumos.RowCount>0)
            {
                int cantidad=0;
                for (int i = 0; i < vista_insumos.RowCount ; i++)
                {
                    if (vista_insumos.GetRowCellValue(i, COL_SOLICITADA).ToString().Equals(""))
                    {
                        MessageBox.Show("Debe ingresar  Cantidad o Cero , no puede dejar vació la cantidad solicitada !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if( Convert.ToDouble(vista_insumos.GetRowCellValue(i, COL_SOLICITADA).ToString())>Convert.ToDouble(vista_insumos.GetRowCellValue(i, COL_CANTIDAD).ToString()))
                    {
                        MessageBox.Show("No hay estoy suficiente , revise  !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (Convert.ToDouble(vista_insumos.GetRowCellValue(i, COL_SOLICITADA))>0)
                    {
                        cantidad = cantidad + 1;
                    }

                }
                if (cantidad>0)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID", typeof(string));
                    dt.Columns.Add("DOCUMENTO", typeof(string));
                    dt.Columns.Add("IDPROVEEDOR", typeof(string));
                    dt.Columns.Add("PROVEEDOR", typeof(string));
                    dt.Columns.Add("IDPRODUCTO", typeof(string));
                    dt.Columns.Add("PRODUCTO", typeof(string));
                    dt.Columns.Add("UNIDAD", typeof(string));
                    dt.Columns.Add("CANTIDAD", typeof(decimal));
                    dt.Columns.Add("ITEM", typeof(string));

                    for (int i = 0; i < vista_insumos.RowCount ; i++)
                    {
                        if (Convert.ToDouble(vista_insumos.GetRowCellValue(i, COL_SOLICITADA)) > 0)
                        {
                            DataRow row = dt.NewRow();
                            row["ID"] =vista_insumos.GetRowCellValue(i,COL_ID).ToString();
                            row["DOCUMENTO"] = vista_insumos.GetRowCellValue(i, COL_DOCUMENTO).ToString();
                            row["IDPROVEEDOR"] = vista_insumos.GetRowCellValue(i, COL_IDPROVEEDOR).ToString();
                            row["PROVEEDOR"] = vista_insumos.GetRowCellValue(i, COL_PROVEEDOR).ToString();
                            row["IDPRODUCTO"] = vista_insumos.GetRowCellValue(i, COL_IDPRODUCTO).ToString();
                            row["PRODUCTO"] = vista_insumos.GetRowCellValue(i, COL_PRODUCTO).ToString();
                            row["UNIDAD"] = vista_insumos.GetRowCellValue(i, COL_UNIDAD).ToString();
                            row["CANTIDAD"] = Convert.ToDouble(vista_insumos.GetRowCellValue(i, COL_SOLICITADA));
                            row["ITEM"] = vista_insumos.GetRowCellValue(i, COL_ITEM);
                            dt.Rows.Add(row);
                        }
                      }

                    Program.detalleinsumos = dt;
                    this.Close();
                    }
                else
                {
                    MessageBox.Show("No tiene Cantidad  : " + Convert.ToString(cantidad), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {

            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}