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

namespace ModuloPresupuesto
{
    public partial class Frm_Variables : DevExpress.XtraEditors.XtraForm
    {
        private string _modo = "";
        public Frm_Variables()
        {
            InitializeComponent();
        }

        private void Frm_Variables_Load(object sender, EventArgs e)
        {
            botones(true);
            LlegarGrilla();
            limpiartxt();
            activartxt(false);
            _modo = "";
        }
        void botones(bool valor)
        {
            btn_nuevo.Enabled = valor;
            btn_cancelar.Enabled = !valor;
            btn_editar.Enabled = valor;
            btn_guardar.Enabled = !valor;
            btn_eliminar.Enabled = valor;
            btn_exit.Enabled = valor;
        }
        void activartxt(bool valor)
        {
            txt_codigo.Enabled = valor;
            txt_descripcion.Enabled = valor;
            txt_valor.Enabled = valor;
            txt_sp.Enabled = valor;
        }

        private void btn_guardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_codigo.Text.Equals(""))
            {
                MessageBox.Show("Debe Ingresar Codigo !");
                return;
            }
            if (txt_descripcion.Text.Equals(""))
            {
                MessageBox.Show("Debe Ingresar Descripcion  !");
                return;
            }
            //if (txt_valor.Text.Equals(""))
            //{
            //    MessageBox.Show("Debe Ingresar Valor  !");
            //    return;
            //}
            //if (txt_sp.Text.Equals(""))
            //{
            //    MessageBox.Show("Debe Ingresar SP Asignado  !");
            //    return;
            //}


            if (_modo.Equals("N"))
            {

                DataTable tb_table = new DataTable();
                tb_table = NFunciones.TABLADATOS("SELECT * FROM P_PARAMETROS WHERE IDVARIABLE='"+txt_codigo.Text+"'");
                if (tb_table.Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe el codigo ingresado debe colocar uno que nuevo !");
                    return;
                }


                string rpta = NFunciones.ExecuteSQL("INSERT INTO P_PARAMETROS (IDEMPRESA,IDVARIABLE,DESCRIPCION,VALOR,SP_ASIGNADO)VALUES('001','" + txt_codigo.Text+"','"+txt_descripcion.Text+"','"+txt_valor.Text+"','"+txt_sp.Text+"')");
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
                string rpta = NFunciones.ExecuteSQL("UPDATE P_PARAMETROS SET DESCRIPCION='"+txt_descripcion.Text+"',VALOR='"+txt_valor.Text+ "', SP_ASIGNADO='"+txt_sp.Text+"' WHERE IDVARIABLE='"+txt_codigo.Text+"'");
                if (rpta.Equals("Ok"))
                {
                    LlegarGrilla();
                    botones(true);
                    activartxt(false);
                    MessageBox.Show("Actualizado Correctamente");
                }
            }
            _modo = "";
        }

        void LlegarGrilla()
        {
            dtg_datos.DataSource = NFunciones.TABLADATOS("SELECT IDVARIABLE,DESCRIPCION,VALOR,SP_ASIGNADO FROM P_PARAMETROS ORDER BY IDVARIABLE ASC");
        }

        void limpiartxt()
        {
            txt_codigo.Text = "";
            txt_descripcion.Text = "";
            txt_valor.Text = "";
            txt_sp.Text = "";
        }

        private void btn_nuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            limpiartxt();
            botones(false);
            activartxt(true);
            _modo = "N";
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

        private void btn_cancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            botones(true);
            LlegarGrilla();
            limpiartxt();
            activartxt(false);
        }

        private void btn_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void dtg_datos_Click(object sender, EventArgs e)
        {
            if (_modo.Equals(""))
            {
                try
                {
                    txt_codigo.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_IDVARIABLE));
                    txt_descripcion.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_DESCRIPCION));
                    txt_valor.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_VALOR));
                    txt_sp.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_SP));
                }
                catch
                {

                }
            }

        }
    }
}