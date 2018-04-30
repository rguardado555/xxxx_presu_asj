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
    public partial class Frm_Grupos : DevExpress.XtraEditors.XtraForm
    {
        private string _modo = "";
        public Frm_Grupos()
        {
            InitializeComponent();
        }

        private void dtg_datos_Click(object sender, EventArgs e)
        {
            try
            {
                txt_codigo.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_CODIGO));
                txt_razonsocial.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_GRUPO));
               
            }
            catch
            {

            }
        }

        private void btn_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Frm_Grupos_Load(object sender, EventArgs e)
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
            btn_exit.Enabled = valor;
        }
        void activartxt(bool valor)
        {
            txt_codigo.Enabled = valor;
            txt_razonsocial.Enabled = valor;
        }

        private void btn_guardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_codigo.Text.Equals(""))
            {
                MessageBox.Show("Debe Ingresar Codigo !");
                return;
            }
            if (txt_razonsocial.Text.Equals(""))
            {
                MessageBox.Show("Debe Ingresar Descripcion de Grupo !");
                return;
            }

            if (_modo.Equals("N"))
            {

                DataTable tb_table = new DataTable();
                tb_table = NFunciones.TABLASQL("select idgrupopro from tb_grupopro where idgrupopro='" + txt_codigo.Text + "' and idempresa='"+VariablesGenerales.Empresa+"'");
                if (tb_table.Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe el codigo ingresado debe colocar uno que nuevo !");
                    return;
                }


                string rpta = NFunciones.ExecuteSQL("INSERT INTO tb_grupopro (idempresa,idgrupopro,descripcion,estado) VALUES('"+VariablesGenerales.Empresa+"','"+txt_codigo.Text+"','"+txt_razonsocial.Text+"','1')");
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
                string rpta = NFunciones.ExecuteSQL("update tb_grupopro set descripcion='"+txt_razonsocial.Text+"' where idempresa='"+VariablesGenerales.Empresa+"' and idgrupopro='"+txt_codigo.Text+"'");
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
            dtg_datos.DataSource = NFunciones.TABLASQL("select idgrupopro CODIGO,descripcion GRUPO from tb_grupopro where idempresa='"+VariablesGenerales.Empresa+"' ORDER BY idgrupopro ASC");
        }

        void limpiartxt()
        {
            txt_codigo.Text = "";
            txt_razonsocial.Text = "";
          
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

        private void btn_eliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable validar = NFunciones.TABLASQL("select * from tb_dcobrarpagardoc d inner join tb_productos p on p.idproducto=d.idproducto and p.idempresa=d.idempresa where p.idempresa='" + VariablesGenerales.Empresa + "' and p.idgrupopro='" + txt_codigo.Text + "'");

            if (validar.Rows.Count > 0)
            {
                MessageBox.Show("No se Puede Eliminar Ya que esta registrado en productos con movimiento !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult respuesta = MessageBox.Show("Esta Seguro de eliminar el registro ?", "Confimación", MessageBoxButtons.OK, MessageBoxIcon.Question);

                if (respuesta == DialogResult.OK)
                {
                    string delete = NFunciones.ExecuteSQL("delete tb_grupopro where idempresa='" + VariablesGenerales.Empresa + "' and idgrupopro='" + txt_codigo.Text + "'");
                    if (delete.Equals("Ok"))
                    {
                        MessageBox.Show("Registro Eliminado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlegarGrilla();
                        limpiartxt();
                    }
                    else
                    {
                        MessageBox.Show("No se puedo realizar la Operacion  !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

            }
        }
    }
}