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
    public partial class Frm_SubGrupos : DevExpress.XtraEditors.XtraForm
    {
        private string _modo = "";
        public Frm_SubGrupos()
        {
            InitializeComponent();
        }

        private void btn_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Frm_SubGrupos_Load(object sender, EventArgs e)
        {
            botones(true);
            LlegarGrilla();
            limpiartxt();
            activartxt(false);
            llenargrupo();

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
            cbo_grupo.Enabled = valor;
        }

        private void btn_guardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cbo_grupo.Text.Equals("[Seleccionar]"))
            {
                MessageBox.Show("Debe seleccionar Grupo !");
                return;
            }
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
                tb_table = NFunciones.TABLASQL("SELECT * FROM tb_subgrupo WHERE idempresa='"+VariablesGenerales.Empresa+"' AND idgrupopro='"+txt_codigo.Text+"'");
                if (tb_table.Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe el codigo ingresado debe colocar uno que nuevo !");
                    return;
                }


                string rpta = NFunciones.ExecuteSQL("insert into tb_subgrupo(idempresa,idsubgrupopro,idgrupopro,descripcion,estado) values('"+VariablesGenerales.Empresa+"','"+txt_codigo.Text+"','"+cbo_grupo.EditValue.ToString()+"','"+txt_razonsocial.Text+"','1')");
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
                string rpta = NFunciones.ExecuteSQL("update tb_subgrupo set descripcion='"+txt_razonsocial.Text+"' where idempresa='"+VariablesGenerales.Empresa+"' and idgrupopro='"+cbo_grupo.EditValue.ToString()+"'");
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
            dtg_datos.DataSource = NFunciones.TABLASQL("select S.idgrupopro IDGRUPO,G.descripcion GRUPO,S.idsubgrupopro CODIGO,S.descripcion SUBGRUPO from tb_subgrupo S  INNER JOIN tb_grupopro G ON G.idgrupopro=S.idgrupopro AND S.idempresa=G.idempresa where S.idempresa='"+VariablesGenerales.Empresa+"' ORDER BY S.idgrupopro,S.idsubgrupopro ASC");
        }
        void llenargrupo()
        {
            cbo_grupo.Properties.DataSource = NFunciones.TABLASQL("select idgrupopro CODIGO,descripcion DESCRIPCION from tb_grupopro where idempresa='"+VariablesGenerales.Empresa+"' ORDER BY idgrupopro ASC");
            cbo_grupo.Properties.ValueMember = "CODIGO";
            cbo_grupo.Properties.DisplayMember = "DESCRIPCION";
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

        private void dtg_datos_Click(object sender, EventArgs e)
        {
            try
            {
                txt_codigo.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_CODIGO));
                txt_razonsocial.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_SUBGRUPO));
                cbo_grupo.EditValue = Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_IDGRUPO));

            }
            catch
            {

            }
        }
    }
}