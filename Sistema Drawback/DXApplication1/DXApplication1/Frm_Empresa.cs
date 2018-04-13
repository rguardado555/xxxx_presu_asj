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
using System.Data.SqlClient;
using CapaNegocios;

namespace DXApplication1
{
    public partial class Frm_Empresa : DevExpress.XtraEditors.XtraForm
    {

        private string _modo = "";
        public Frm_Empresa()
        {
            InitializeComponent();
        }

        private void Frm_Empresa_Load(object sender, EventArgs e)
        {
            botones(true);
            LlegarGrilla();
            limpiartxt();
            activartxt(false);
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
            txt_codempresa.Enabled=valor;
            txt_razonsocial.Enabled = valor;
            txt_ruc.Enabled = valor;
            txt_direccion.Enabled = valor;
            txt_email.Enabled = valor;
            txt_telefono.Enabled = valor;
            txt_tcambio.Enabled = valor;
            txt_codigoaduanas.Enabled = valor;
            txt_regimen.Enabled = valor;
            txt_porc_drawback.Enabled = valor;
        }

        private void btn_guardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_codempresa.Text.Equals(""))
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
            if (txt_direccion.Text.Equals(""))
            {
                MessageBox.Show("Debe Ingresar Dirección !");
                return;
            }
            if (txt_razonsocial.Text.Equals(""))
            {
                MessageBox.Show("Debe Ingresar Razon Social !");
                return;
            }
            if (txt_tcambio.Text.Equals(""))
            {
                MessageBox.Show("Debe Ingresar Tipo de Cambio !");
                return;
            }
            if (txt_codigoaduanas.Text.Equals(""))
            {
                MessageBox.Show("Debe Ingresar Codigo Aduanas !");
                return;
            }
            if (txt_regimen.Text.Equals(""))
            {
                MessageBox.Show("Debe Ingresar Codigo de Regimen !");
                return;
            }




            if (_modo.Equals("N"))
            {

                DataTable tb_table = new DataTable();
                tb_table = NFunciones.TABLASQL("select idempresa from tb_empresa where idempresa='" + txt_codempresa.Text + "'");
                if (tb_table.Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe el codigo ingresado debe colocar uno que nuevo !");
                    return;
                }


                string rpta = NFunciones.ExecuteSQL("insert into tb_empresa (idempresa,razonsocial,direccion,telef,email,ruc,TC,codigo_aduanas,regimen,porc_drawback) values('" + txt_codempresa.Text.ToUpper() + "','" + txt_razonsocial.Text.ToUpper() + "','" + txt_direccion.Text.ToUpper() + "','" + txt_telefono.Text.ToUpper() + "','" + txt_email.Text.ToUpper() + "','" + txt_ruc.Text.ToUpper() + "','" + txt_tcambio.Text.ToUpper() + "','" + txt_codigoaduanas.Text.ToUpper() + "','" + txt_regimen.Text.ToUpper() + "','"+txt_porc_drawback.Text+"')");
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
                string rpta = NFunciones.ExecuteSQL("UPDATE tb_empresa SET razonsocial='"+txt_razonsocial.Text.ToUpper()+"',direccion='"+txt_direccion.Text.ToUpper()+"',telef='"+txt_telefono.Text.ToUpper()+"',email='"+txt_email.Text.ToUpper()+"',ruc='"+txt_ruc.Text.ToUpper()+ "',TC='"+txt_tcambio.Text+ "',codigo_aduanas='"+txt_codigoaduanas.Text+ "', regimen='"+txt_regimen.Text+ "',porc_drawback='"+txt_porc_drawback.Text+"'   WHERE idempresa='" + txt_codempresa.Text+"'");
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
            dtg_datos.DataSource = NFunciones.TABLASQL("SELECT IDEMPRESA,RAZONSOCIAL,DIRECCION,telef TELEFONO,email EMAIL,RUC,TC,codigo_aduanas CODIGOADUANAS,regimen CODIGOREGIMEN,porc_drawback  FROM tb_empresa ORDER BY idempresa ASC");
        }
       
        void limpiartxt()
        {
            txt_codempresa.Text = "";
            txt_razonsocial.Text = "";
            txt_ruc.Text = "";
            txt_direccion.Text = "";
            txt_email.Text = "";
            txt_telefono.Text = "";
            txt_tcambio.Text = "";
            txt_codigoaduanas.Text = "";
            txt_regimen.Text = "";
            txt_porc_drawback.Text = "";
        }


        private void btn_nuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            limpiartxt();
            botones(false);
            activartxt(true);
            _modo = "N";
        }

        private void dtg_datos_Click(object sender, EventArgs e)
        {

        }

        private void dtg_datos_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                txt_codempresa.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(col_codigo));
                txt_razonsocial.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(col_razonsocial));
                txt_direccion.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(col_direccion));
                txt_ruc.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(col_ruc));
                txt_telefono.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(col_telefono));
                txt_email.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(col_email));
                txt_tcambio.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(col_tc));
                txt_codigoaduanas.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(col_codigoaduanas));
                txt_regimen.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(col_codregimen));
                txt_porc_drawback.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(col_porcDrawBack));
            }
            catch
            {

            }
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
            if (txt_codempresa.Text.Equals(""))
            {
                MessageBox.Show("Debe Seleccionar un registro para editar!! ");
                return;
            }
            botones(false);
            activartxt(true);
            txt_codempresa.Enabled = false;
        }
    }
}