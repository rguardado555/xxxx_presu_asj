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
    public partial class Productos : DevExpress.XtraEditors.XtraForm
    {
        private string _modo = "";
        private string _idgrupo = "";
        private string _idsubgrupo = "";
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            botones(true);
            LlegarGrilla();
            limpiartxt();
            activartxt(false);
            llenargrupo();
            llenarMedida();
        }
        void limpiartxt()
        {
            txt_codigo.Text = "";
            txt_razonsocial.Text = "";
        }
        private void btn_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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
          
            txt_razonsocial.Enabled = valor;
            cbo_grupo.Enabled = valor;
            cbo_subgrupo.Enabled = valor;
            cbo_medida.Enabled = valor;
        }
        void llenargrupo()
        {
            cbo_grupo.Properties.DataSource = NFunciones.TABLASQL("select idgrupopro CODIGO,descripcion GRUPO from tb_grupopro where idempresa='" + VariablesGenerales.Empresa + "' ORDER BY idgrupopro ASC");
            cbo_grupo.Properties.ValueMember = "CODIGO";
            cbo_grupo.Properties.DisplayMember = "GRUPO";
        }
        void llenarsubgrupo(string idgrupo)
        {
            cbo_subgrupo.Properties.DataSource = NFunciones.TABLASQL("SELECT idsubgrupopro CODIGO,descripcion SUBGRUPO FROM tb_subgrupo WHERE idgrupopro='"+idgrupo+"' AND idempresa='"+VariablesGenerales.Empresa+"'");
            cbo_subgrupo.Properties.ValueMember = "CODIGO";
            cbo_subgrupo.Properties.DisplayMember = "SUBGRUPO";
        }
        void llenarMedida()
        {
            cbo_medida.Properties.DataSource = NFunciones.TABLASQL("select idunidad CODIGO,descripcion UNIDAD_MONEDA from conf_unimedida");
            cbo_medida.Properties.ValueMember = "CODIGO";
            cbo_medida.Properties.DisplayMember = "UNIDAD_MONEDA";
        }

        private void cbo_subgrupo_EditValueChanged(object sender, EventArgs e)
        {
            
           
        }

        private void cbo_grupo_EditValueChanged(object sender, EventArgs e)
        {
            llenarsubgrupo(cbo_grupo.EditValue.ToString());
          
            if (_modo.Equals("N"))
            {
                _idgrupo = cbo_grupo.EditValue.ToString();
                txt_codigo.Text = _idgrupo + _idsubgrupo;
            }
        }

        private void btn_nuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            limpiartxt();
            crearid();
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
            if (cbo_grupo.Text.Equals("[Seleccionar]"))
            {
                MessageBox.Show("Debe seleccionar Grupo !");
                return;
            }
            if (cbo_subgrupo.Text.Equals("[Seleccionar]"))
            {
                MessageBox.Show("Debe seleccionar SubGrupo !");
                return;
            }
            if (cbo_medida.Text.Equals("[Seleccionar]"))
            {
                MessageBox.Show("Debe seleccionar Grupo !");
                return;
            }


            if (_modo.Equals("N"))
            {

                DataTable tb_table = new DataTable();
                tb_table = NFunciones.TABLASQL("SELECT idproducto FROM tb_productos WHERE idempresa='"+VariablesGenerales.Empresa+"' AND idgrupopro='"+cbo_grupo.EditValue.ToString()+"' AND idsubgrupopro='"+cbo_subgrupo.EditValue.ToString()+"'");
                if (tb_table.Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe el codigo ingresado debe colocar uno que nuevo !");
                    return;
                }


                string rpta = NFunciones.ExecuteSQL("insert into tb_productos(idempresa,idproducto,idgrupopro,idsubgrupopro,descripcion,idunidad,estado) values('"+VariablesGenerales.Empresa+"','"+txt_codigo.Text+"','"+cbo_grupo.EditValue.ToString()+"','"+cbo_subgrupo.EditValue.ToString()+"','"+txt_razonsocial.Text.ToUpper()+"','"+cbo_medida.EditValue.ToString()+"','1')");
                if (rpta.Equals("Ok"))
                {
                    LlegarGrilla();
                    botones(true);
                    activartxt(false);
                    _modo = "";
                    MessageBox.Show("Guardado Correctamente");
                }
            }
            if (_modo.Equals("E"))
            {
                string rpta = NFunciones.ExecuteSQL("update tb_productos set descripcion='"+txt_razonsocial.Text.ToUpper()+"',idgrupopro='"+cbo_grupo.EditValue.ToString()+"',idsubgrupopro='"+cbo_subgrupo.EditValue.ToString()+"' where idempresa='"+VariablesGenerales.Empresa+"' and idproducto='"+txt_codigo.Text+"'");
                if (rpta.Equals("Ok"))
                {
                    _modo = "";
                    LlegarGrilla();
                    botones(true);
                    activartxt(false);
                    MessageBox.Show("Actualizado Correctamente");
                }
            }

        }
        void LlegarGrilla()
        {
            dtg_datos.DataSource = NFunciones.TABLASQL("SELECT p.idproducto CODIGO,p.idgrupopro IDGRUPO,g.descripcion GRUPO,p.idsubgrupopro IDSUBGRUPO,s.descripcion SUBGRUPO,p.descripcion PRODUCTO,p.idunidad IDMEDIDA,u.descripcion MEDIDA FROM tb_productos p  inner join tb_grupopro g on g.idempresa=p.idempresa and g.idgrupopro=p.idgrupopro inner join tb_subgrupo s on s.idempresa=p.idempresa and s.idgrupopro=g.idgrupopro and s.idsubgrupopro=p.idsubgrupopro INNER JOIN conf_unimedida u on u.idunidad=p.idunidad WHERE p.idempresa='" + VariablesGenerales.Empresa+"'");
        }

        private void btn_cancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            botones(true);
            LlegarGrilla();
            limpiartxt();
            _modo = "";
            activartxt(false);
        }
        void crearid()
        {
            txt_codigo.Text = "P" + DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year.ToString() + DateTime.Now.Hour.ToString() +
                DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
        }

        private void dtg_datos_Click(object sender, EventArgs e)
        {
            if (_modo.Equals(""))
            {
                try
                {
                    txt_codigo.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_CODIGO));
                    txt_razonsocial.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_PRODUCTO));
                    cbo_grupo.EditValue = Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_IDGRUPO));
                    cbo_subgrupo.EditValue = Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_IDSUBGRUPO));
                    cbo_medida.EditValue = Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_IDMEDIDA));
                }
                catch
                {

                }

            }
        }
    }
}