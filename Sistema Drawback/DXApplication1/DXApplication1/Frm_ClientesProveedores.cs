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
    public partial class Frm_ClientesProveedores : DevExpress.XtraEditors.XtraForm
    {
        private string _modo = "";
        public Frm_ClientesProveedores()
        {
            InitializeComponent();
        }

        private void Frm_ClientesProveedores_Load(object sender, EventArgs e)
        {
            botones(true);
            LlegarGrilla();
            limpiartxt();
            activartxt(false);
            Llenartipo();
        }
        void Llenartipo()
        {
            cbo_tipo.Properties.DataSource = NFunciones.TABLASQL("SELECT IDTIPOCLIEPROV CODIGO,DESCRIPCION TIPO FROM CONF_TIPO ORDER BY IDTIPOCLIEPROV ASC");
            cbo_tipo.Properties.ValueMember = "CODIGO";
            cbo_tipo.Properties.DisplayMember = "TIPO";
        }

        void botones(bool valor)
        {
            btn_nuevo.Enabled = valor;
            btn_cancelar.Enabled = !valor;
            btn_editar.Enabled = valor;
            btn_guardar.Enabled = !valor;
            btn_eliminar.Enabled = valor;

        }
        void activartxt(bool valor)
        {
            txt_codigo.Enabled = valor;
            txt_razonsocial.Enabled = valor;
            txt_ruc.Enabled = valor;
            cbo_tipo.Enabled = valor;
        }

        private void btn_guardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_codigo.Text.Equals(""))
            {
                MessageBox.Show("Debe Ingresar Codigo de Empresa !");
                return;
            }
            if (txt_razonsocial.Text.Equals(""))
            {
                MessageBox.Show("Debe Ingresar Razon Social !");
                return;
            }
            if (txt_ruc.Text.Equals(""))
            {
                MessageBox.Show("Debe Ingresar Ruc!");
                return;
            }
            if (cbo_tipo.Text.Equals("[Seleccionar]"))
            {
                MessageBox.Show("Debe Ingresar Tipo Empresa !");
                return;
            }
         

            if (_modo.Equals("N"))
            {

                DataTable tb_table = new DataTable();
                tb_table = NFunciones.TABLASQL("select idclieprov from tb_clieprov where idclieprov='" + txt_codigo.Text + "' and idempresa='"+VariablesGenerales.Empresa+"'");
                if (tb_table.Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe el codigo ingresado debe colocar uno que nuevo !");
                    return;
                }


                string rpta = NFunciones.ExecuteSQL("insert into tb_clieprov(idempresa,idclieprov,razonsocial,ruc,tipoclieprov,estado) values('"+VariablesGenerales.Empresa+"','" + txt_codigo.Text.ToUpper() + "','" + txt_razonsocial.Text.ToUpper() + "','" + txt_ruc.Text.ToUpper() + "','" + cbo_tipo.EditValue.ToString() + "','1')");
                if (rpta.Equals("Ok"))
                {
                    LlegarGrilla();
                    botones(true);
                    activartxt(false);
                    MessageBox.Show("Guardado Correctamente");
                }
            }
            if (_modo.Equals("E"))
            {
                string rpta = NFunciones.ExecuteSQL("update tb_clieprov set razonsocial='"+txt_razonsocial.Text.ToUpper()+"',ruc='" + txt_ruc.Text.ToUpper() + "',tipoclieprov='" + cbo_tipo.EditValue.ToString() + "' where idempresa='" + VariablesGenerales.Empresa + "' and idclieprov='" + txt_codigo.Text.ToUpper() + "'");
                if (rpta.Equals("Ok"))
                {
                    LlegarGrilla();
                    botones(true);
                    activartxt(false);
                    MessageBox.Show("Actualizado Correctamente");
                }
            }

        }

        void LlegarGrilla()
        {
            dtg_datos.DataSource = NFunciones.TABLASQL("SELECT idclieprov CODIGO,razonsocial RAZONSOCIAL,RUC,tipoclieprov IDTIPO,T.DESCRIPCION TIPO,ESTADO IDESTADO,CASE ESTADO  WHEN '1' THEN 'ACTIVO' ELSE 'DESACTIVADO' END ESTADO FROM tb_clieprov c  LEFT JOIN conf_tipo t on t.IDTIPOCLIEPROV=C.tipoclieprov where c.idempresa='"+VariablesGenerales.Empresa+"'");
        }

        void limpiartxt()
        {
            txt_codigo.Text = "";
            txt_razonsocial.Text = "";
            txt_ruc.Text = "";
        }

        private void btn_nuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            limpiartxt();
            botones(false);
            activartxt(true);
            _modo = "N";
        }

        private void btn_cancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            botones(true);
            LlegarGrilla();
            limpiartxt();
            activartxt(false);
        }

        private void btn_editar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _modo = "E";
            if (txt_codigo.Text.Equals(""))
            {
                MessageBox.Show("Debe Seleccionar un registro para editar!! ");
                return;
            }
            botones(false);
            activartxt(true);
            txt_codigo.Enabled = false;
        }

        private void dtg_datos_DoubleClick(object sender, EventArgs e)
        {
          
          
        }

        private void dtg_datos_Click(object sender, EventArgs e)
        {
            try
            {
                txt_codigo.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_CODIGO));
                txt_razonsocial.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_RAZONSOCIAL));
                cbo_tipo.EditValue = Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_IDTIPO));
                txt_ruc.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(RUC));
            }
            catch
            {

            }
        }
    }
}