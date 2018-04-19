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
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace DXApplication1
{
    public partial class Frm_Duas : DevExpress.XtraEditors.XtraForm
    {
        string id;
        string tipo;
        public Frm_Duas(string _id,string _tipo )
        {
            InitializeComponent();
            this.id = _id;
            this.tipo = _tipo;
        }

        private void Frm_Ventas_Load(object sender, EventArgs e)
        {
            if (tipo.Equals("N"))
            {
                DataTable tb_empresa = NFunciones.TABLASQL("SELECT * FROM TB_EMPRESA WHERE IDEMPRESA='" + VariablesGenerales.Empresa + "'");
                txt_tc.Text = tb_empresa.Rows[0]["TC"].ToString();
                txt_regimen.Text = tb_empresa.Rows[0]["regimen"].ToString();
                txt_aduanas.Text = tb_empresa.Rows[0]["codigo_aduanas"].ToString();
                txt_porc_drawback.Text = tb_empresa.Rows[0]["porc_drawback"].ToString();
                dtp_fechaoperacion.EditValue = DateTime.Now.ToShortDateString();
                llenarExportacion();
                crearid();
            }
            if (tipo.Equals("E"))
            {


            }
            if (tipo.Equals("V"))
            {


            }
        }
        private void btn_agregarexportacion_Click(object sender, EventArgs e)
        {
            if (vista_exportaciones.RowCount>0)
            {
                DialogResult result = MessageBox.Show("Esta Seguro de que Cambiar el detalle ?","Alerta",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result==DialogResult.Yes)
                {
                    dtg_exportaciones.DataSource = NFunciones.TABLASQL("SELECT c.idcobrarpagardoc ID,d.idproducto IDPRODUCTO,d.descripcion PRODUCTO,d.cantidad CANTIDAD,d.idunidad UNIDAD FROM tb_cobrarpagardoc c inner join tb_dcobrarpagardoc d on c.idcobrarpagardoc=d.idcobrarpagardoc and c.idempresa=d.idempresa WHERE c.idempresa='" + VariablesGenerales.Empresa + "' AND c.idcobrarpagardoc='" + cbo_exportaciones.EditValue.ToString() + "'");
                    DataTable tb = NFunciones.TABLASQL("SELECT SUM(preciototal) TOTAL,sum(CANTIDAD) CAJAS FROM tb_dcobrarpagardoc WHERE idempresa='"+VariablesGenerales.Empresa+"' AND idcobrarpagardoc='"+ cbo_exportaciones.EditValue.ToString() + "'");
                    if (tb.Rows.Count>0)
                    {
                        txt_importetotal.Text = tb.Rows[0]["TOTAL"].ToString();
                        txt_ncajas.Text = tb.Rows[0]["CAJAS"].ToString();
                    }

                }
                else
                {
                    return;
                }
            }
            else
            {
                
                dtg_exportaciones.DataSource = NFunciones.TABLASQL("SELECT c.idcobrarpagardoc ID,d.idproducto IDPRODUCTO,d.descripcion PRODUCTO,d.cantidad CANTIDAD,d.idunidad UNIDAD FROM tb_cobrarpagardoc c inner join tb_dcobrarpagardoc d on c.idcobrarpagardoc=d.idcobrarpagardoc and c.idempresa=d.idempresa WHERE c.idempresa='"+VariablesGenerales.Empresa+"' AND c.idcobrarpagardoc='"+cbo_exportaciones.EditValue.ToString()+"'");
                dtg_exportaciones.DataSource = NFunciones.TABLASQL("SELECT c.idcobrarpagardoc ID,d.idproducto IDPRODUCTO,d.descripcion PRODUCTO,d.cantidad CANTIDAD,d.idunidad UNIDAD FROM tb_cobrarpagardoc c inner join tb_dcobrarpagardoc d on c.idcobrarpagardoc=d.idcobrarpagardoc and c.idempresa=d.idempresa WHERE c.idempresa='" + VariablesGenerales.Empresa + "' AND c.idcobrarpagardoc='" + cbo_exportaciones.EditValue.ToString() + "'");
                DataTable tb = NFunciones.TABLASQL("SELECT SUM(preciototal) TOTAL,sum(CANTIDAD) CAJAS  FROM tb_dcobrarpagardoc WHERE idempresa='" + VariablesGenerales.Empresa + "' AND idcobrarpagardoc='" + cbo_exportaciones.EditValue.ToString() + "'");
                if (tb.Rows.Count > 0)
                {
                    txt_importetotal.Text = tb.Rows[0]["TOTAL"].ToString();
                    txt_ncajas.Text = tb.Rows[0]["CAJAS"].ToString();
                }

            }
            if (vista_exportaciones.RowCount>0)
            {
                cbo_exportaciones.Enabled = false;
            }
            else
            {
                cbo_exportaciones.Enabled = true;
            }
        }
        void llenarExportacion()
        {
            cbo_exportaciones.Properties.DataSource = NFunciones.TABLASQL("SELECT d.idcobrarpagardoc CODIGO,D.iddocumento+' '+D.serie+'-'+D.numero+'----'+CONVERT(NVARCHAR(10), D.fecha,103) OPERACION FROM tb_cobrarpagardoc  D where d.tipo='V'  AND d.idempresa='" + VariablesGenerales.Empresa+ "' AND NOT d.idcobrarpagardoc IN (SELECT idorigen FROM tb_docreferencia where idempresa='" + VariablesGenerales.Empresa+"') ORDER BY D.fecha ASC");
            cbo_exportaciones.Properties.ValueMember = "CODIGO";
            cbo_exportaciones.Properties.DisplayMember = "OPERACION";

        }

        private void btn_nuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tipo = "N";
            crearid();
        }

        private void btn_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        void crearid()
        {
            txt_iddua.Text = "da" + DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year.ToString() + DateTime.Now.Hour.ToString() +
                DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + VariablesGenerales.Empresa;
        }

        private void btn_agregarcompra_Click(object sender, EventArgs e)
        {
            Frm_ListadoInsumos ObjInsumos = new Frm_ListadoInsumos();
            ObjInsumos.ShowDialog();
        }

        private void Frm_Duas_Activated(object sender, EventArgs e)
        {
            if (tipo.Equals("N"))
            {
                dtg_insumos.DataSource = Program.detalleinsumos;
            }
            if( vista_exportaciones.RowCount > 0)
            {
                btn_agregarexportacion.Enabled = false;
            }
          

        }

        private void btn_guardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_dua.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar el Numero de DUA !","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if (txt_tc.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar Tipo de Cambio !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txt_regimen.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar Codigo de Regimen !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_aduanas.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar Codigo Aduanas !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txt_porc_drawback.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar Porcentaje DrawBack !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (vista_insumos.RowCount <= 0)
            {
                MessageBox.Show("Debe Agregar Insumos !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tipo.Equals("N"))
            {

                string cabecera = NFunciones.ExecuteSQL("insert into tb_dua(idempresa,iddua,ndua,tc,codigo_aduanas,porc_drawback,importerecuperacion,importetotal,regimen,fecha,idcobrarpagardoct) values('" + VariablesGenerales.Empresa+"','"+txt_iddua.Text+"','"+txt_dua.Text+"','"+txt_tc.Text+"','"+txt_aduanas.Text+"','"+txt_porc_drawback.Text+"','"+txt_totaldrawback.Text+"','"+ txt_importetotal.Text+"','"+txt_regimen.Text+ "',Convert(DATE,'" + dtp_fechaoperacion.Text + "',103),'" + cbo_exportaciones.EditValue.ToString() + "') ");
                string referencia = NFunciones.ExecuteSQL("insert into tb_docreferencia (idempresa,idorigen,iddestino) values ('" + VariablesGenerales.Empresa + "','" + cbo_exportaciones.EditValue.ToString() +"','"+txt_iddua.Text+"')");

                if (cabecera.Equals("Ok"))
                {
                    // insertar exportacion
                    string exportacion = NFunciones.ExecuteSQL("update tb_dcobrarpagardoc set idref='"+txt_iddua.Text+"' where idcobrarpagardoc='"+cbo_exportaciones.EditValue.ToString()+"'");
                    //insertar insumos

                    for (int i = 0; i < vista_insumos.RowCount; i++)
                    {
                       string insumos = NFunciones.ExecuteSQL(" insert into tb_movcobrarpagardoc_drakback(idempresa,idtransaccion,idproducto,descripcion,cantidad,factor,idcobrarpagardoc,idunidad)values('"+VariablesGenerales.Empresa+"','" + txt_iddua.Text + "','"+ vista_insumos.GetRowCellValue(i, COL_IDPRODUCTOIN).ToString() + "','"+ vista_insumos.GetRowCellValue(i, COL_PRODUCTOIN).ToString() + "','"+ vista_insumos.GetRowCellValue(i, COL_CANTIDAD).ToString() + "','-1','"+ vista_insumos.GetRowCellValue(i, COL_IDIN).ToString() + "','"+vista_insumos.GetRowCellValue(i, COL_UNIDADIN).ToString()+"')");

                    }
                    MessageBox.Show("Guardado Correctamnete !");

                }
            }
            if (tipo.Equals("E"))
            {

                string cabecera = NFunciones.ExecuteSQL("update tb_dua set ndua='"+txt_dua.Text+"',tc='"+txt_tc.Text+"',codigo_aduanas='"+txt_aduanas.Text+"',porc_drawback='"+txt_porc_drawback.Text+ "',fecha=convert(date,'" + dtp_fechaoperacion.Text + "',103),importerecuperacion='"+txt_totaldrawback.Text+"',importetotal='"+txt_importetotal.Text+"','"+txt_regimen.Text+ "' ,idcobrarpagardoc='" + cbo_exportaciones.EditValue.ToString() + "'   where iddua='" + txt_iddua.Text+"' and idempresa='"+VariablesGenerales.Empresa+"') ");
                string referencia = NFunciones.ExecuteSQL("update tb_docreferencia set idorigen='" + cbo_exportaciones.EditValue.ToString() + "' where idempresa='" + VariablesGenerales.Empresa+"' and iddestino='"+txt_iddua.Text+"'");
                {
                    // insertar exportacion
                    string exportacion = NFunciones.ExecuteSQL("update tb_dcobrarpagardoc set idref='" + txt_iddua.Text + "' where idcobrarpagardoc='" + cbo_exportaciones.EditValue.ToString() + "'");

                    //insertar insumos
                    string deleteinsumos = NFunciones.ExecuteSQL("delete tb_movcobrarpagardoc_drakback where idtransaccion='"+txt_iddua.Text+"' and idempresa='"+VariablesGenerales.Empresa+"'");
                    for (int i = 0; i < vista_insumos.RowCount; i++)
                    {
                        string insumos = NFunciones.ExecuteSQL("insert into tb_movcobrarpagardoc_drakback(idempresa,idtransaccion,idproducto,descripcion,cantidad,factor,idcobrarpagardoc,idunidad)values('"+VariablesGenerales.Empresa+"','" + txt_iddua.Text + "','" + vista_insumos.GetRowCellValue(i, COL_IDPRODUCTOIN).ToString() + "','" + vista_insumos.GetRowCellValue(i, COL_PRODUCTOIN).ToString() + "','" + vista_insumos.GetRowCellValue(i, COL_CANTIDAD).ToString() + "','-1','" + vista_insumos.GetRowCellValue(i, COL_IDIN).ToString() + "','" + vista_insumos.GetRowCellValue(i, COL_UNIDADIN).ToString() + "')");
                    }
                    MessageBox.Show("Actualizado Correctamente !");

                }

              }

            }

        private void txt_importetotal_EditValueChanged(object sender, EventArgs e)
        {
            txt_totaldrawback.Text =Convert.ToString(Convert.ToDouble(txt_importetotal.Text) * Convert.ToDouble(txt_porc_drawback.Text));
        }

        private void btn_deleteexportacion_Click(object sender, EventArgs e)
        {
            dtg_exportaciones.DataSource = null;
            if (vista_exportaciones.RowCount > 0)
            {
                cbo_exportaciones.Enabled = false;
               
            }
            else
            {
                cbo_exportaciones.Enabled = true;
                txt_importetotal.Text = "";
                txt_totaldrawback.Text = "";
            }
        }
    }
}