using CapaNegocios;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class Frm_Compra : Form
    {
        string _id = "";
        string _opcion = "";
        public Frm_Compra(string id, string opcion)
        {
            InitializeComponent();
            this._id = id;
            this._opcion = opcion;
        }

        private void monoFlat_Label3_Click(object sender, EventArgs e)
        {

        }


        void llenarclienteproveedor()
        {
                cbo_clieprov.Properties.DataSource = NFunciones.TABLASQL("select idclieprov CODIGO,razonsocial PROVEEDOR from tb_clieprov where not tipoclieprov='001' and idempresa='"+VariablesGenerales.Empresa+"'");
                cbo_clieprov.Properties.ValueMember = "CODIGO";
                cbo_clieprov.Properties.DisplayMember = "PROVEEDOR";
        }

        void llenardocumentos()
        {
            cbo_documento.Properties.DataSource = NFunciones.TABLASQL("select iddocumento CODIGO,descripcion DOCUMENTO from tb_documentos order by iddocumento asc");
            cbo_documento.Properties.ValueMember = "CODIGO";
            cbo_documento.Properties.DisplayMember = "DOCUMENTO";
        }
        void llenarproductos()
        {
            cbo_productodetalle.DataSource = NFunciones.TABLASQL("select idproducto CODIGO ,descripcion PRODUCTO from tb_productos WHERE idempresa='" + VariablesGenerales.Empresa + "' ORDER BY descripcion ASC");
            cbo_productodetalle.ValueMember = "CODIGO";
            cbo_productodetalle.DisplayMember = "CODIGO";
        }

        void llenarmedida()
        {
            cbo_medida.DataSource = NFunciones.TABLASQL("select idunidad IDMEDIDA,descripcion MEDIDA from conf_unimedida");
            cbo_medida.ValueMember = "IDMEDIDA";
            cbo_medida.DisplayMember = "MEDIDA";
        }

        private void btn_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Frm_Compra_Load(object sender, EventArgs e)
        {
            llenarclienteproveedor();
            txt_idoperacion.Text = "C";
            txt_operacion.Text = "Compras";
            llenardocumentos();
            llenarproductos();
            LlegarGrilla();
            llenarmedida();

            if (_opcion.Equals("N"))
            {
                limpiartxt();
                txt_id.Text = _id;
                botones(false);
                activartxt(true);
                crearid();
                LlegarGrilla();
                _opcion = "N";
            }
            else
             {
                DataTable tb_cabecera = NFunciones.TABLASQL("select * from tb_cobrarpagardoc where idempresa='"+VariablesGenerales.Empresa+"' and idcobrarpagardoc='"+_id+"'");
                if (tb_cabecera.Rows.Count>0)
                {
                    txt_id.Text= tb_cabecera.Rows[0]["idcobrarpagardoc"].ToString();
                    cbo_clieprov.EditValue = tb_cabecera.Rows[0]["idclieprov"].ToString();
                    dtp_fechadoc.EditValue = tb_cabecera.Rows[0]["fecha"].ToString();
                    dtp_fechaoperacion.EditValue = tb_cabecera.Rows[0]["fechaoperacion"].ToString();
                    cbo_documento.EditValue = tb_cabecera.Rows[0]["iddocumento"].ToString();
                    txt_serie.Text= tb_cabecera.Rows[0]["serie"].ToString();
                    txt_numero.Text = tb_cabecera.Rows[0]["numero"].ToString();
                    txt_operacion.Text = tb_cabecera.Rows[0]["tipo"].ToString();
                    LlegarGrilla();
                }

                DataTable tb_table = new DataTable();
                tb_table = NFunciones.TABLASQL("select * from tb_docreferencia where idempresa='" + VariablesGenerales.Empresa + "' and idorigen='" + txt_id.Text + "'");
                if (tb_table.Rows.Count > 0)
                {
                    MessageBox.Show("Este Registro Esta relacionado con otros Registro, No se puede realizar la operación !");
                    return;
                }
                     else
                {
                        botones(false);
                        activartxt(true);
                        _opcion = "E";
            }
                

            }
            vista_datos.Columns["TOTAL"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "SUBTOTAL", "Sub Total:  {0:n4}");
            vista_datos.Columns["TOTAL"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "IMPUESTO", "Impuesto:  {0:n4}");
            vista_datos.Columns["TOTAL"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "TOTAL", "TOTAL:  {0:n4}");

        }
        void botones(bool valor)
        {
            btn_nuevo.Enabled = valor;
            btn_cancelar.Enabled = !valor;
            btn_editar.Enabled = valor;
            btn_guardar.Enabled = !valor;
            btn_eliminar.Enabled = valor;
            btn_addDetalle.Enabled = !valor;
            btn_deleteDetalle.Enabled = !valor;
            btn_exit.Enabled = valor;
        }
        void activartxt(bool valor)
        {
            txt_numero.Enabled = valor;
            txt_serie .Enabled = valor;
            cbo_clieprov.Enabled = valor;
            cbo_documento.Enabled = valor;
            dtp_fechadoc.Enabled = valor;

            COL_CANTIDAD.OptionsColumn.AllowEdit = valor;
            COL_PRECIOUNIT.OptionsColumn.AllowEdit = valor;
            COL_IMP.OptionsColumn.AllowEdit = valor;
            COL_IDPRODUCTO.OptionsColumn.AllowEdit = valor;
        }
        void limpiartxt()
        {
           txt_id.Text = "";
           cbo_clieprov.EditValue = "";
           cbo_documento.EditValue = "";
            txt_serie.Text = "";
            txt_numero.Text = "";
            dtp_fechadoc.EditValue = DateTime.Now.ToShortDateString();
            dtp_fechaoperacion.EditValue = DateTime.Now.ToShortDateString();
            dtg_datos.DataSource = null;
        }

        void crearid()
        {
            txt_id.Text = "C" + DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year.ToString() + DateTime.Now.Hour.ToString() +
                DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString()+VariablesGenerales.Empresa;
        }

        void LlegarGrilla()
        {
            dtg_datos.DataSource = NFunciones.TABLASQL("select item ITEM,idproducto IDPRODUCTO,descripcion PRODUCTO,idunidad IDMEDIDA,cantidad CANTIDAD,cantidad * preciounit  SUBTOTAL,porc_imp IMP, (cantidad* preciounit *porc_imp)AS IMPUESTO,preciounit PRECIOUNIT,preciototal  TOTAL from tb_dcobrarpagardoc where idcobrarpagardoc='"+txt_id.Text+"' and idempresa='"+VariablesGenerales.Empresa+"' order by item asc");
        }

        private void btn_addDetalle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!_opcion.Equals(""))
            {
                vista_datos.AddNewRow();
            }
        }

        private void vista_datos_ShownEditor(object sender, EventArgs e)
        {
            //ColumnView view = (ColumnView)sender;
            //if (view.FocusedColumn.FieldName == "IDMEDIDA")
            //{
            //    LookUpEdit editor = (LookUpEdit)view.ActiveEditor;
            //    //MessageBox.Show(Convert.ToString(view.GetFocusedRowCellValue("IDPRODUCTO")));
            //    editor.Properties.DataSource = NFunciones.TABLASQL("SELECT p.idunidad AS IDMEDIDA,u.descripcion AS MEDIDA FROM tb_productos p inner join conf_unimedida u on u.idunidad=p.idunidad WHERE p.idproducto='" + Convert.ToString(view.GetFocusedRowCellValue("IDPRODUCTO")) + "' and p.idempresa='" + VariablesGenerales.Empresa + "'");
            //    editor.Properties.ValueMember = "IDMEDIDA";
            //    editor.Properties.DisplayMember = "MEDIDA";
            //   // DataTable tb_medida = NFunciones.TABLASQL("SELECT p.idunidad AS IDMEDIDA FROM tb_productos p inner join conf_unimedida u on u.idunidad=p.idunidad WHERE p.idproducto='" + Convert.ToString(view.GetFocusedRowCellValue("IDPRODUCTO")) + "' and p.idempresa='" + VariablesGenerales.Empresa + "'");
            //   //editor.Properties.ValueMember = tb_medida.Rows[0]["IDMEDIDA"].ToString();
            //   //view.GetFocusedRowCellValue.("IDMEDIDA")="";
            //   //string IDMEDIDA = Convert.ToString(view.GetFocusedRowCellValue("IdItemCosto"));

            //}


        }

        private void cbo_productodetalle_EditValueChanged(object sender, EventArgs e)
        {


        }

        private void cbo_productodetalle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void vista_datos_ColumnChanged(object sender, EventArgs e)
        {
      
        }

        private void vista_datos_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            
        }

        private void vista_datos_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;
            try
            {
                if (e.Column.FieldName == "CANTIDAD")
            {
                    if (Convert.ToString(view.GetFocusedRowCellValue("CANTIDAD")) == "")
                    {
                        vista_datos.SetFocusedRowCellValue(vista_datos.Columns["CANTIDAD"], 0);
                    }

                    if (Convert.ToString(view.GetFocusedRowCellValue("PRECIOUNIT")) == "")
                    {
                        vista_datos.SetFocusedRowCellValue(vista_datos.Columns["PRECIOUNIT"], 0);
                    }

                    if (Convert.ToString(view.GetFocusedRowCellValue("IMP")) == "")
                    {
                        vista_datos.SetFocusedRowCellValue(vista_datos.Columns["IMP"], 0);
                    }

                    if (Convert.ToString(view.GetFocusedRowCellValue("IMPUESTO")) == "")
                    {
                        vista_datos.SetFocusedRowCellValue(vista_datos.Columns["IMPUESTO"], 0);
                    }


                decimal cantidad = Convert.ToDecimal(view.GetFocusedRowCellValue("CANTIDAD"));
                decimal preciounit = Convert.ToDecimal(view.GetFocusedRowCellValue("PRECIOUNIT"));
                vista_datos.SetFocusedRowCellValue(vista_datos.Columns["SUBTOTAL"], cantidad * preciounit);

                    decimal IMP;

                    decimal porc = Convert.ToDecimal(view.GetFocusedRowCellValue("IMP"));

                    if (porc > 0)
                    {
                        vista_datos.SetFocusedRowCellValue(vista_datos.Columns["IMPUESTO"], (cantidad * preciounit) * (porc / 100));
                    }
                    else
                    {
                        vista_datos.SetFocusedRowCellValue(vista_datos.Columns["IMPUESTO"], 0);

                    }

                    if (Convert.ToDecimal(vista_datos.GetFocusedRowCellValue(COL_IMPUESTO)) > 0)
                    {

                        IMP = Convert.ToDecimal(view.GetFocusedRowCellValue("IMPUESTO"));
                    }
                    else
                    {
                        IMP = 0;
                    }
                    vista_datos.SetFocusedRowCellValue(vista_datos.Columns["TOTAL"], (cantidad * preciounit) + IMP);


                }
                if (e.Column.FieldName == "IDPRODUCTO")
                {
                    DataTable tb_medida = NFunciones.TABLASQL("SELECT p.idunidad AS IDMEDIDA FROM tb_productos p inner join conf_unimedida u on u.idunidad=p.idunidad WHERE p.idproducto='" + Convert.ToString(vista_datos.GetFocusedRowCellValue("IDPRODUCTO")) + "' and p.idempresa='" + VariablesGenerales.Empresa + "'");
                    vista_datos.SetFocusedRowCellValue(COL_MEDIDA, tb_medida.Rows[0]["IDMEDIDA"].ToString());

                    DataTable tb_producto = NFunciones.TABLASQL("select descripcion PRODUCTO from tb_productos where idempresa='"+VariablesGenerales.Empresa+"' and idproducto='" + Convert.ToString(vista_datos.GetFocusedRowCellValue("IDPRODUCTO")) + "'");
                    vista_datos.SetFocusedRowCellValue(COL_PRODUCTO, tb_producto.Rows[0]["PRODUCTO"].ToString());

                }

             if (e.Column.FieldName == "PRECIOUNIT")
            {
                    if (Convert.ToString(view.GetFocusedRowCellValue("PRECIOUNIT")) == "")
                    {
                        vista_datos.SetFocusedRowCellValue(vista_datos.Columns["PRECIOUNIT"], 0);
                    }

                    if (Convert.ToString(view.GetFocusedRowCellValue("IMP")) == "")
                    {
                        vista_datos.SetFocusedRowCellValue(vista_datos.Columns["IMP"], 0);
                    }

                    if (Convert.ToString(view.GetFocusedRowCellValue("IMPUESTO")) == "")
                    {
                        vista_datos.SetFocusedRowCellValue(vista_datos.Columns["IMPUESTO"], 0);
                    }

                 decimal IMP;
                 decimal cantidad = Convert.ToDecimal(view.GetFocusedRowCellValue("CANTIDAD"));
                 decimal preciounit = Convert.ToDecimal(view.GetFocusedRowCellValue("PRECIOUNIT"));
                 vista_datos.SetFocusedRowCellValue(vista_datos.Columns["SUBTOTAL"], cantidad * preciounit);


                    decimal porc = Convert.ToDecimal(view.GetFocusedRowCellValue("IMP"));

                    if (porc > 0)
                    {
                        vista_datos.SetFocusedRowCellValue(vista_datos.Columns["IMPUESTO"], (cantidad * preciounit) * (porc / 100));
                    }
                    else
                    {
                        vista_datos.SetFocusedRowCellValue(vista_datos.Columns["IMPUESTO"], 0);
                       
                    }



                    if (Convert.ToDecimal(vista_datos.GetFocusedRowCellValue(COL_IMPUESTO)) > 0)
                    {

                        IMP = Convert.ToDecimal(view.GetFocusedRowCellValue("IMPUESTO"));
                    }
                    else
                    {
                        IMP = 0;
                    }
                    vista_datos.SetFocusedRowCellValue(vista_datos.Columns["TOTAL"], (cantidad * preciounit) + IMP);

                }

                if (e.Column.FieldName == "IMP")
                {
                    if (Convert.ToString(view.GetFocusedRowCellValue("IMP"))=="")
                    {
                        vista_datos.SetFocusedRowCellValue(vista_datos.Columns["IMP"], 0);
                    }
                    decimal cantidad = Convert.ToDecimal(view.GetFocusedRowCellValue("CANTIDAD"));
                    decimal preciounit = Convert.ToDecimal(view.GetFocusedRowCellValue("PRECIOUNIT"));
                    decimal porc = Convert.ToDecimal(view.GetFocusedRowCellValue("IMP"));
               
                    if (porc>0)
                    {
                        vista_datos.SetFocusedRowCellValue(vista_datos.Columns["IMPUESTO"], (cantidad * preciounit) * (porc / 100));
                        decimal IMP = Convert.ToDecimal(view.GetFocusedRowCellValue("IMPUESTO"));
                        vista_datos.SetFocusedRowCellValue(vista_datos.Columns["TOTAL"], (cantidad * preciounit) + IMP);
                    }
                    else
                    {
                        vista_datos.SetFocusedRowCellValue(vista_datos.Columns["IMPUESTO"], 0);
                        decimal IMP = 0;
                        vista_datos.SetFocusedRowCellValue(vista_datos.Columns["TOTAL"], (cantidad * preciounit) + IMP);
                    }
                }
            }

            catch
            {

            }
        }

        private void vista_datos_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void cbo_productodetalle_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void vista_datos_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {


        }

        private void btn_guardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // validar que todos los campos esten llenos 

            if (txt_id.Text.Equals(""))
            {
                MessageBox.Show("Debe Ingresar ID","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (cbo_clieprov.Text.Equals("[Seleccione]") || cbo_clieprov.Text.Equals(""))
            {
                MessageBox.Show("Debe Ingresar Proveedor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbo_documento.Text.Equals("[Seleccione]") || cbo_documento.Text.Equals(""))
            {
                MessageBox.Show("Debe Ingresar Proveedor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_serie.Text.Equals(""))
            {
                MessageBox.Show("Debe Ingresar Serie", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_numero.Text.Equals(""))
            {
                MessageBox.Show("Debe Ingresar Numero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (vista_datos.RowCount < 1)
            {
                MessageBox.Show("Debe ingresar detalle !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                vista_datos.SetFocusedRowCellValue(COL_ITEM, 1);
                for (int i = 0; i < vista_datos.RowCount-1; i++)
                {
                    vista_datos.SetRowCellValue(i,"ITEM",i);
                }

                    for (int i = 0; i < vista_datos.RowCount; i++)
                    {
                    if (vista_datos.GetRowCellValue(i, COL_IDPRODUCTO).ToString().Equals("") || vista_datos.GetRowCellValue(i, COL_IDPRODUCTO).ToString().Equals("[Seleccionar]"))
                    {
                        MessageBox.Show("Debe ingresar Codigo de Producto !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (vista_datos.GetRowCellValue(i, COL_PRODUCTO).ToString().Equals("") )
                    {
                        MessageBox.Show("Debe ingresar  Producto !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (vista_datos.GetRowCellValue(i, COL_CANTIDAD).ToString().Equals("")|| Convert.ToDouble( vista_datos.GetRowCellValue(i, COL_CANTIDAD))<=0 )
                    {
                        MessageBox.Show("Debe ingresar  Cantidad !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (vista_datos.GetRowCellValue(i, COL_PRECIOUNIT).ToString().Equals("") || Convert.ToDouble(vista_datos.GetRowCellValue(i, COL_PRECIOUNIT)) <= 0)
                    {
                        MessageBox.Show("Debe ingresar Precio Unitario !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if ( Convert.ToDouble(vista_datos.GetRowCellValue(i, COL_IMP)) <= 0)
                    {
                        vista_datos.SetFocusedRowCellValue(COL_IMP, 0);
                    }


                }
            }
         //--------validado

            if (_opcion.Equals("N"))
            {
                string mensaje="";
                string cabecera = NFunciones.ExecuteSQL("insert into tb_cobrarpagardoc(idcobrarpagardoc,idempresa,iddocumento,serie,numero,idclieprov,fecha,fechaoperacion,razonsocial,estado,tipo)values('"+txt_id.Text+"','"+VariablesGenerales.Empresa+"','"+cbo_documento.EditValue.ToString()+"','"+txt_serie.Text+"','"+txt_numero.Text+"','"+cbo_clieprov.EditValue.ToString()+"','"+Convert.ToDateTime(dtp_fechadoc.EditValue)+"','"+ Convert.ToDateTime(dtp_fechaoperacion.EditValue) + "','"+cbo_clieprov.Text.ToUpper()+"','1','"+txt_idoperacion.Text+"')");
                if (cabecera.Equals("Ok"))
                {
                    for (int i = 0; i < vista_datos.RowCount; i++)
                    {
                        int item = i + 1;
                        string detalle = NFunciones.ExecuteSQL("insert into tb_dcobrarpagardoc (idempresa,idcobrarpagardoc,item,idproducto,descripcion,idunidad,cantidad,porc_imp,imp,preciounit,preciototal) values('"+VariablesGenerales.Empresa+"','"+txt_id.Text+"','"+ item + "','"+ vista_datos.GetRowCellValue(i, COL_IDPRODUCTO).ToString() + "','" + vista_datos.GetRowCellValue(i, COL_PRODUCTO).ToString() + "','" + vista_datos.GetRowCellValue(i, COL_MEDIDA).ToString() + "','" + Convert.ToDecimal( vista_datos.GetRowCellValue(i, COL_CANTIDAD)) + "','" + Convert.ToDecimal(vista_datos.GetRowCellValue(i, COL_IMP)) + "','" + Convert.ToDecimal(vista_datos.GetRowCellValue(i, COL_IMPUESTO)) + "','" + Convert.ToDecimal(vista_datos.GetRowCellValue(i, COL_PRECIOUNIT)) + "','" + Convert.ToDecimal(vista_datos.GetRowCellValue(i, COL_TOTAL)) + "')");
                    }
                    MessageBox.Show("Guardado Correctamente");

                    botones(true);
                    LlegarGrilla();
                    activartxt(false);
                }
                else
                {
                    MessageBox.Show("Error al Guardar");
                    return;
                }
            }
            if (_opcion.Equals("E"))
            {
                string rpta = NFunciones.ExecuteSQL("");
                if (rpta.Equals("Ok"))
                {
                    LlegarGrilla();

                    MessageBox.Show("Actualizado Correctamente");
                }
            }


            _opcion = "";
        }

        private void btn_editar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable tb_table = new DataTable();
            tb_table = NFunciones.TABLASQL("select * from tb_docreferencia where idempresa='" + VariablesGenerales.Empresa + "' and idorigen='" + txt_id.Text + "'");
            if (tb_table.Rows.Count > 0)
            {
                MessageBox.Show("Este Registro Esta relacionado con otros Registro, No se puede realizar la operación !");
                return;
            }
            else
            {
                botones(false);
                activartxt(true);
                _opcion = "E";
            }
        }

        private void btn_nuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            limpiartxt();
            botones(false);
            activartxt(true);
            crearid();
            LlegarGrilla();
            _opcion = "N";

        }

        private void btn_deleteDetalle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                vista_datos.DeleteRow(vista_datos.FocusedRowHandle);
            }
            catch { }
        }
    }
}
