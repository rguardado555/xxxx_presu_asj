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
                botones(true);

            }
            if (tipo.Equals("E"))
            {
              
            }
            if (tipo.Equals("V"))
            {
                try
                {
                    txt_tc.Enabled = false;
                    txt_dua.Enabled = false;
                    dtp_fechaoperacion.Enabled = false;
                    DataTable tb_cabecera = NFunciones.TABLASQL("SELECT * FROM tb_dua WHERE idempresa='" + VariablesGenerales.Empresa + "' AND iddua='" + id + "'");
                    if (tb_cabecera.Rows.Count > 0)
                    {
                        botones(false);
                        txt_tc.Text = tb_cabecera.Rows[0]["TC"].ToString();
                        txt_regimen.Text = tb_cabecera.Rows[0]["regimen"].ToString();
                        txt_aduanas.Text = tb_cabecera.Rows[0]["codigo_aduanas"].ToString();
                        txt_porc_drawback.Text = tb_cabecera.Rows[0]["porc_drawback"].ToString();
                        dtp_fechaoperacion.EditValue = tb_cabecera.Rows[0]["fecha"].ToString();
                        txt_dua.Text = tb_cabecera.Rows[0]["ndua"].ToString();
                        txt_ncajas.Text = tb_cabecera.Rows[0]["ncajas"].ToString();
                        txt_importetotal.Text = tb_cabecera.Rows[0]["importetotal"].ToString();
                        string idrefexportacion = tb_cabecera.Rows[0]["idcobrarpagardoc"].ToString();
                        // agregar detalleexpoertacion
                        dtg_exportaciones.DataSource = NFunciones.TABLASQL("SELECT c.idcobrarpagardoc ID,d.idproducto IDPRODUCTO,d.descripcion PRODUCTO,d.cantidad CANTIDAD,d.idunidad UNIDAD FROM tb_cobrarpagardoc c inner join tb_dcobrarpagardoc d on c.idcobrarpagardoc=d.idcobrarpagardoc and c.idempresa=d.idempresa WHERE c.idempresa='" + VariablesGenerales.Empresa + "' AND c.idcobrarpagardoc='" + idrefexportacion + "'");
                        //agregar detalle insumos
                        Program.detalleinsumos = NFunciones.TABLASQL("select m.idcobrarpagardoc ID,C.iddocumento+' '+C.serie+' - '+C.numero DOCUMENTO,C.idclieprov IDPROVEEDOR,C.razonsocial PROVEEDOR, m.idproducto IDPRODUCTO,m.descripcion PRODUCTO,m.idunidad UNIDAD,m.CANTIDAD from tb_movcobrarpagardoc_drakback m  INNER JOIN tb_cobrarpagardoc c on c.idcobrarpagardoc=m.idcobrarpagardoc and c.idempresa=m.idempresa where M.idtransaccion='" + id + "' and M.idempresa='" + VariablesGenerales.Empresa + "'");
                        dtg_insumos.DataSource = Program.detalleinsumos;
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un problema , no se pudio cargar la información!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Ocurrio un problema , no se pudio cargar la información!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
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
                
                //dtg_exportaciones.DataSource = NFunciones.TABLASQL("SELECT c.idcobrarpagardoc ID,d.idproducto IDPRODUCTO,d.descripcion PRODUCTO,d.cantidad CANTIDAD,d.idunidad UNIDAD FROM tb_cobrarpagardoc c inner join tb_dcobrarpagardoc d on c.idcobrarpagardoc=d.idcobrarpagardoc and c.idempresa=d.idempresa WHERE c.idempresa='"+VariablesGenerales.Empresa+"' AND c.idcobrarpagardoc='"+cbo_exportaciones.EditValue.ToString()+"'");
                dtg_exportaciones.DataSource = NFunciones.TABLASQL("SELECT c.idcobrarpagardoc ID,d.idproducto IDPRODUCTO,d.descripcion PRODUCTO,d.cantidad CANTIDAD,d.idunidad UNIDAD FROM tb_cobrarpagardoc c inner join tb_dcobrarpagardoc d on c.idcobrarpagardoc=d.idcobrarpagardoc and c.idempresa=d.idempresa WHERE c.idempresa='" + VariablesGenerales.Empresa + "' AND c.idcobrarpagardoc='" + cbo_exportaciones.EditValue.ToString() + "'");
                DataTable tb = NFunciones.TABLASQL("SELECT SUM(preciototal) TOTAL,sum(CANTIDAD) CAJAS  FROM tb_dcobrarpagardoc WHERE idempresa='" + VariablesGenerales.Empresa + "' AND idcobrarpagardoc='" + cbo_exportaciones.EditValue.ToString() + "'");
                if (tb.Rows.Count > 0)
                {
                    txt_importetotal.Text = tb.Rows[0]["TOTAL"].ToString();
                    txt_ncajas.Text = tb.Rows[0]["CAJAS"].ToString();
                }

            }
            //if (vista_exportaciones.RowCount>0)
            //{
            //    cbo_exportaciones.Enabled = false;
            //}
            //else
            //{
            //    cbo_exportaciones.Enabled = true;
            //}
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
            DataTable tb_empresa = NFunciones.TABLASQL("SELECT * FROM TB_EMPRESA WHERE IDEMPRESA='" + VariablesGenerales.Empresa + "'");
            txt_tc.Text = tb_empresa.Rows[0]["TC"].ToString();
            txt_regimen.Text = tb_empresa.Rows[0]["regimen"].ToString();
            txt_aduanas.Text = tb_empresa.Rows[0]["codigo_aduanas"].ToString();
            txt_porc_drawback.Text = tb_empresa.Rows[0]["porc_drawback"].ToString();
            dtp_fechaoperacion.EditValue = DateTime.Now.ToShortDateString();
            llenarExportacion();
            crearid();
            botones(true);
            dtg_exportaciones.DataSource = null;
            dtg_insumos.DataSource = null;
            Program.detalleinsumos = null;

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
            //if( vista_exportaciones.RowCount > 0)
            //{
            //    btn_agregarexportacion.Enabled = false;
            //}
          

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
            if (vista_exportaciones.RowCount <= 0)
            {
                MessageBox.Show("Debe Agregar Exportación !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (tipo.Equals("N"))
            {

                string cabecera = NFunciones.ExecuteSQL("insert into tb_dua(idempresa,iddua,ndua,tc,codigo_aduanas,porc_drawback,importerecuperacion,importetotal,regimen,fecha,idcobrarpagardoc,ncajas) values('" + VariablesGenerales.Empresa+"','"+txt_iddua.Text+"','"+txt_dua.Text+"','"+txt_tc.Text+"','"+txt_aduanas.Text+"','"+txt_porc_drawback.Text+"','"+txt_totaldrawback.Text+"','"+ txt_importetotal.Text+"','"+txt_regimen.Text+ "',Convert(DATE,'" + dtp_fechaoperacion.Text + "',103),'" + cbo_exportaciones.EditValue.ToString() + "','"+txt_ncajas.Text+"') ");
                string referencia = NFunciones.ExecuteSQL("insert into tb_docreferencia (idempresa,idorigen,iddestino) values ('" + VariablesGenerales.Empresa + "','" + cbo_exportaciones.EditValue.ToString() +"','"+txt_iddua.Text+"')");

                if (cabecera.Equals("Ok"))
                {
                    // insertar exportacion
                    string exportacion = NFunciones.ExecuteSQL("update tb_dcobrarpagardoc set idref='"+txt_iddua.Text+"' where idcobrarpagardoc='"+cbo_exportaciones.EditValue.ToString()+"'");
                    //insertar insumos

                    for (int i = 0; i < vista_insumos.RowCount; i++)
                    {
                       string insumos = NFunciones.ExecuteSQL(" insert into tb_movcobrarpagardoc_drakback(idempresa,idtransaccion,idproducto,descripcion,cantidad,factor,idcobrarpagardoc,idunidad,item)values('"+VariablesGenerales.Empresa+"','" + txt_iddua.Text + "','"+ vista_insumos.GetRowCellValue(i, COL_IDPRODUCTOIN).ToString() + "','"+ vista_insumos.GetRowCellValue(i, COL_PRODUCTOIN).ToString() + "','"+ vista_insumos.GetRowCellValue(i, COL_CANTIDAD).ToString() + "','-1','"+ vista_insumos.GetRowCellValue(i, COL_IDIN).ToString() + "','"+vista_insumos.GetRowCellValue(i, COL_UNIDADIN).ToString()+"','"+vista_insumos.GetRowCellValue(i,COL_ITEM).ToString()+"')");

                    }
                    MessageBox.Show("Guardado Correctamnete !");
                    txt_dua.ReadOnly = true;
                    txt_tc.ReadOnly = true;
                    dtp_fechaoperacion.ReadOnly = true;
                    Program.detalleinsumos = null;
                    botones(false);
                    VariablesGenerales.refduas = "S";
                }
            }

            if (tipo.Equals("E"))
            {

                string cabecera = NFunciones.ExecuteSQL("update tb_dua set ndua='"+txt_dua.Text+"',tc='"+txt_tc.Text+"',codigo_aduanas='"+txt_aduanas.Text+"',porc_drawback='"+txt_porc_drawback.Text+ "',fecha=convert(date,'" + dtp_fechaoperacion.Text + "',103),importerecuperacion='"+txt_totaldrawback.Text+"',importetotal='"+txt_importetotal.Text+"','"+txt_regimen.Text+ "' ,idcobrarpagardoc='" + cbo_exportaciones.EditValue.ToString() + "',ncajas='"+txt_ncajas.Text+"'   where iddua='" + txt_iddua.Text+"' and idempresa='"+VariablesGenerales.Empresa+"') ");
                string referencia = NFunciones.ExecuteSQL("update tb_docreferencia set idorigen='" + cbo_exportaciones.EditValue.ToString() + "' where idempresa='" + VariablesGenerales.Empresa+"' and iddestino='"+txt_iddua.Text+"'");
                {
                    // insertar exportacion
                    string exportacion = NFunciones.ExecuteSQL("update tb_dcobrarpagardoc set idref='" + txt_iddua.Text + "' where idcobrarpagardoc='" + cbo_exportaciones.EditValue.ToString() + "'");
                    //insertar insumos
                    string deleteinsumos = NFunciones.ExecuteSQL("delete tb_movcobrarpagardoc_drakback where idtransaccion='"+txt_iddua.Text+"' and idempresa='"+VariablesGenerales.Empresa+"'");
                    for (int i = 0; i < vista_insumos.RowCount; i++)
                    {
                        string insumos = NFunciones.ExecuteSQL("insert into tb_movcobrarpagardoc_drakback(idempresa,idtransaccion,idproducto,descripcion,cantidad,factor,idcobrarpagardoc,idunidad,item)values('"+VariablesGenerales.Empresa+"','" + txt_iddua.Text + "','" + vista_insumos.GetRowCellValue(i, COL_IDPRODUCTOIN).ToString() + "','" + vista_insumos.GetRowCellValue(i, COL_PRODUCTOIN).ToString() + "','" + vista_insumos.GetRowCellValue(i, COL_CANTIDAD).ToString() + "','-1','" + vista_insumos.GetRowCellValue(i, COL_IDIN).ToString() + "','" + vista_insumos.GetRowCellValue(i, COL_UNIDADIN).ToString() + "','"+vista_insumos.GetRowCellValue(i,COL_ITEM).ToString()+"')");
                    }
                    Program.detalleinsumos = null;
                    MessageBox.Show("Actualizado Correctamente !");
                    txt_dua.ReadOnly = true;
                    txt_tc.ReadOnly = true;
                    dtp_fechaoperacion.ReadOnly = true;
                    botones(false);
                    VariablesGenerales.refduas = "S";
                }
              }

        }

       private void txt_importetotal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_totaldrawback.Text = Convert.ToString(Convert.ToDouble(txt_importetotal.Text) * Convert.ToDouble(txt_porc_drawback.Text));
            }
            catch
            {
                txt_totaldrawback.Text = "0.0";
            }
           
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

        private void btn_editar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        tipo = "E";
        botones(true);

        }
        void botones(bool valor)
        {
            btn_nuevo.Enabled = !valor;
            btn_cancelar.Enabled = valor;
            btn_editar.Enabled = !valor;
            btn_guardar.Enabled = valor;
            btn_eliminar.Enabled = !valor;
            btn_exit.Enabled = !valor;




            btn_agregarcompra.Visible = valor;
            btn_deletecompra.Visible = valor;
            btn_agregarexportacion.Visible = valor;
            btn_deleteexportacion.Visible = valor;
            cbo_exportaciones.Visible = valor;

        }

        private void btn_eliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult rpta = MessageBox.Show("Desea Eliminar este registro ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rpta == DialogResult.Yes)
            {
                DataTable tbdua = NFunciones.TABLASQL("SELECT * FROM TB_DUA WHERE IDDUA='" + id + "' AND IDEMPRESA='" + VariablesGenerales.Empresa + "'");
                string cabecera = NFunciones.ExecuteSQL("delete tb_dua where iddua='" + id + "'and idempresa='" + VariablesGenerales.Empresa + "'");

                string referencia = NFunciones.ExecuteSQL("delete tb_docreferencia where idempresa='" + VariablesGenerales.Empresa + "' and iddestino='" +id + "'");
                // insertar exportacion
                string exportacion = NFunciones.ExecuteSQL("update tb_dcobrarpagardoc set idref='NULL' where idcobrarpagardoc='" + tbdua.Rows[0]["idcobrarpagardoc"].ToString() + "'");
                //insertar insumos
                string deleteinsumos = NFunciones.ExecuteSQL("delete tb_movcobrarpagardoc_drakback where idtransaccion='" + id + "' and idempresa='" + VariablesGenerales.Empresa + "'");
                Program.detalleinsumos = null;
                VariablesGenerales.refduas = "S";
                MessageBox.Show("Dua eliminada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btn_cancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.detalleinsumos = null;
            this.Close();
        }
    }
}