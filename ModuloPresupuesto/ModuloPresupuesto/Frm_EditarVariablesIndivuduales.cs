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
using DevExpress.XtraGrid.Views.Grid;

namespace ModuloPresupuesto
{
    public partial class Frm_EditarVariablesIndivuduales : DevExpress.XtraEditors.XtraForm
    {
        private string _modo = "";
        public Frm_EditarVariablesIndivuduales()
        {
            InitializeComponent();
        }

        private void Frm_EditarMO_Load(object sender, EventArgs e)
        {
            botones(true);
            LlegarGrilla();
            llenarpresupuesto();
            llenarvariables();
            llenarfundo();
            llenarcultivo();
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
            btn_eliminadeta.Enabled = !valor;
            btn_agregardeta.Enabled = !valor;
            btn_activar.Enabled = valor;
        }
        void activartxt(bool valor)
        {
            txt_descripcion.Enabled = valor;
            cbo_presupuesto.Enabled = valor;
            cbo_variable.Enabled = valor;
            txt_sp.Enabled = valor;

            IDFUNDO.OptionsColumn.AllowEdit = valor;
            IDCULTIVO.OptionsColumn.AllowEdit = valor;
            VALOR.OptionsColumn.AllowEdit = valor;

        }
        void limpiartxt()
        {
            txt_id.Text = "";
            txt_descripcion.Text = "";
            txt_sp.Text = "";
       

        }
        void llenarpresupuesto()
        {
            cbo_presupuesto.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDPRESUPUESTO CODIGO,DESCRIPCION PRESUPUESTO FROM P_PRESUPUESTO ORDER BY IDPRESUPUESTO DESC");
            cbo_presupuesto.Properties.DisplayMember = "PRESUPUESTO";
            cbo_presupuesto.Properties.ValueMember = "CODIGO";
        }
        void llenarvariables()
        {
            cbo_variable.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDVARIABLE CODIGO,DESCRIPCION VARIABLE FROM P_PARAMETROS ORDER BY IDVARIABLE ASC");
            cbo_variable.Properties.DisplayMember = "VARIABLE";
            cbo_variable.Properties.ValueMember = "CODIGO";
        }
        void llenarfundo()
        {
            cbo_fundodetalle.DataSource = NFunciones.TABLADATOS("SELECT IDFUNDO CODIGO,DESCRIPCION FUNDO FROM P_FUNDO ORDER BY IDFUNDO ASC");
            cbo_fundodetalle.DisplayMember = "FUNDO";
            cbo_fundodetalle.ValueMember = "CODIGO";
        }
        void llenarcultivo()
        {
            cbo_cultivodetalle.DataSource = NFunciones.TABLADATOS("SELECT IDCULTIVO CODIGO,DESCRIPCION CULTIVO FROM P_CULTIVOS ORDER BY IDCULTIVO ASC");
            cbo_cultivodetalle.DisplayMember = "CULTIVO";
            cbo_cultivodetalle.ValueMember = "CODIGO";
        }

        void LlegarGrilla()
        {
           dtg_registros.DataSource = NFunciones.TABLADATOS("select P.ID,P.IDVARIEABLE,P.IDVARIEABLE +'-'+PA.DESCRIPCION VARIABLE,P.IDPRESUPUESTO,P.DESCRIPCION, CASE P.IDESTADO WHEN '0'THEN 'ANULADO' ELSE'ACTIVO' END ESTADO, P.IDESTADO,P.SP_ASIGNADO from P_PARAMETROS_ESPECIFICOS P INNER JOIN P_PARAMETROS PA ON P.IDVARIEABLE=PA.IDVARIABLE");
        }
        void LlegarGrillaDetalle(string idpadre)
        {
            dtg_detalle.DataSource=null;
            dtg_detalle.DataSource = NFunciones.TABLADATOS("SELECT D.IDFUNDO, F.DESCRIPCION FUNDO, D.IDCULTIVO, C.DESCRIPCION CULTIVO, D.IDVARIEABLE, D.VALOR FROM P_DPARAMETROS_ESPECIFICOS  D LEFT JOIN P_FUNDO F ON F.IDFUNDO = D.IDFUNDO LEFT JOIN P_CULTIVOS C ON C.IDCULTIVO = D.IDCULTIVO where d.ID='"+ idpadre + "'");
        }
        void crearid()
        {
            txt_id.Text ="R"+ DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year.ToString() + DateTime.Now.Hour.ToString() + 
                DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
        }

        private void btn_nuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            limpiartxt();
            crearid();
            botones(false);
            activartxt(true);
            _modo = "N";
            LlegarGrillaDetalle(txt_id.Text);

        }

        private void btn_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_id.Text.Equals(""))
            {
                MessageBox.Show("Debe Ingresar Id !");
                return;
            }
            if (txt_descripcion.Text.Equals(""))
            {
                MessageBox.Show("Debe Ingresar Descripción!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbo_presupuesto.Text.Equals("[Seleccionar]"))
            {
                MessageBox.Show("Debe seleccionar Presupuesto !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbo_variable.Text.Equals("[Seleccionar]"))
            {
                MessageBox.Show("Debe seleccionar Variable !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_sp.Text.Equals(""))
            {
                MessageBox.Show("Debe Ingresar SP_QUERY!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (vista_detalle.RowCount < 1)
            {
                MessageBox.Show("Debe ingresar detalle !", "Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else
            {
                for (int i = 0; i < vista_detalle.RowCount; i++)
                {
                    if (vista_detalle.GetRowCellValue(i, IDFUNDO) == null)
                    {
                        MessageBox.Show("Debe ingresar Fundo !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (vista_detalle.GetRowCellValue(i, IDCULTIVO) == null)
                    {
                        MessageBox.Show("Debe ingresar Cultivo !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (vista_detalle.GetRowCellValue(i, VALOR)==null)
                    {
                        MessageBox.Show("Debe ingresar Valor !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
              }

           

            if (_modo.Equals("N"))
            {
                DataTable TB_VERIFICACION = NFunciones.TABLADATOS("SELECT * FROM P_PARAMETROS_ESPECIFICOS WHERE IDVARIEABLE='"+cbo_variable.EditValue.ToString()+"' AND IDPRESUPUESTO='"+cbo_presupuesto.EditValue.ToString()+"' AND IDESTADO='1'");
                if (TB_VERIFICACION.Rows.Count>0)
                {
                    MessageBox.Show("Ya existe un registro para esta variable y este presupuesto !","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                
                string rpta = NFunciones.ExecuteSQL("INSERT INTO P_PARAMETROS_ESPECIFICOS(ID,IDVARIEABLE,IDESTADO,IDPRESUPUESTO,DESCRIPCION,SP_ASIGNADO)VALUES('"+txt_id.Text+"','"+cbo_variable.EditValue.ToString()+"','1','"+cbo_presupuesto.EditValue.ToString()+"','"+txt_descripcion.Text+"','"+txt_sp.Text+"')");
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
                string rpta = NFunciones.ExecuteSQL("UPDATE P_PARAMETROS_ESPECIFICOS SET DESCRIPCION='"+txt_descripcion.Text+ "',SP_ASIGNADO='" + txt_sp.Text+"' WHERE ID='"+txt_id.Text+"'");
                if (rpta.Equals("Ok"))
                {
                    LlegarGrilla();
                    botones(true);
                    activartxt(false);
                    MessageBox.Show("Actualizado Correctamente");
                }
            }
            //----- insertar detalle

            string delete = NFunciones.ExecuteSQL("DELETE P_DPARAMETROS_ESPECIFICOS where ID = '"+txt_id.Text+"'");
            
            if (vista_detalle.RowCount > 0)
            {
                for (int i=0;i< vista_detalle.RowCount;i++)
                {
                    string rpta = NFunciones.ExecuteSQL("IF NOT EXISTS (SELECT * FROM P_DPARAMETROS_ESPECIFICOS WHERE ID ='"+txt_id.Text+"' AND IDFUNDO='"+vista_detalle.GetRowCellValue(i,IDFUNDO).ToString()+ "' AND IDCULTIVO='"+ vista_detalle.GetRowCellValue(i, IDCULTIVO).ToString() + "') INSERT INTO P_DPARAMETROS_ESPECIFICOS (ID,IDFUNDO,IDCULTIVO,IDVARIEABLE,VALOR) VALUES('" + txt_id.Text+"','"+ vista_detalle.GetRowCellValue(i, IDFUNDO).ToString() + "','"+ vista_detalle.GetRowCellValue(i, IDCULTIVO).ToString() + "','"+cbo_variable.EditValue.ToString()+"','"+ vista_detalle.GetRowCellValue(i, VALOR).ToString() + "')");
                }
            }

            LlegarGrillaDetalle(txt_id.Text);
            _modo = "";
            activartxt(false);
        }

        private void btn_editar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _modo = "E";
            if (txt_id.Text.Equals(""))
            {
                MessageBox.Show("Debe Seleccionar un registro para editar!! ","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            botones(false);
            activartxt(true);
            cbo_presupuesto.Enabled = false;
            cbo_variable.Enabled = false;

        }

        private void dtg_registros_Click(object sender, EventArgs e)
        {
            if (_modo.Equals(""))
            {
                try{
                    LlegarGrillaDetalle(Convert.ToString(vista_registros.GetFocusedRowCellValue(COL_ID)));
                    txt_id.Text = Convert.ToString(vista_registros.GetFocusedRowCellValue(COL_ID));
                    cbo_variable.EditValue = Convert.ToString(vista_registros.GetFocusedRowCellValue(COL_IDVARIABLE));
                    cbo_presupuesto.EditValue = Convert.ToString(vista_registros.GetFocusedRowCellValue(COL_IDPRESUPUESTO));
                    txt_sp.Text = Convert.ToString(vista_registros.GetFocusedRowCellValue(COL_SP));
                    txt_descripcion.Text = Convert.ToString(vista_registros.GetFocusedRowCellValue(COL_DESCRIPCION));
                }
                catch { }
                
            }
        }

        private void btn_agregardeta_Click(object sender, EventArgs e)
        {
            //if (cbo_fundo.Text.Equals("[Seleccionar]"))
            //{
            //    MessageBox.Show("Debe seleccionar Fundo !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (cbo_cultivo.Text.Equals("[Seleccionar]"))
            //{
            //    MessageBox.Show("Debe seleccionar Cultivo !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (txt_valor.Text.Equals(""))
            //{
            //    MessageBox.Show("Debe Ingresar Valor !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            vista_detalle.AddNewRow();
            //vista_detalle.MoveNext();
            //vista_detalle.SetFocusedRowCellValue(cbo_fundo.EditValue.ToString(), IDFUNDO);
            //vista_detalle.SetFocusedRowCellValue(cbo_fundo.Text, FUNDO);
            //vista_detalle.SetFocusedRowCellValue(cbo_cultivo.EditValue.ToString(), IDCULTIVO);
            //vista_detalle.SetFocusedRowCellValue(cbo_cultivo.Text, CULTIVO);
            //vista_detalle.SetFocusedRowCellValue(txt_valor.Text, VALOR);
        }

        private void dtg_detalle_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_cancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            botones(true);
            LlegarGrilla();
            limpiartxt();
            _modo = "";
            activartxt(false);
        }

        private void btn_eliminadeta_Click(object sender, EventArgs e)
        {
            vista_detalle.DeleteRow(vista_detalle.FocusedRowHandle);
        }

        private void btn_activar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {






            string estado;
            if (vista_registros.GetFocusedRowCellValue(COL_IDESTADO).ToString().Equals("1"))
            {
                estado = "ANULAR";
            }
            else
            {
                estado = "ACTIVAR";
            }

            DialogResult resultado;
            resultado = MessageBox.Show("Desea "+ estado + " el registro ?","Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resultado==DialogResult.Yes)
            {

                string respuesta;
                if (vista_registros.GetFocusedRowCellValue(COL_IDESTADO).ToString().Equals("1"))
                {
                        respuesta = NFunciones.ExecuteSQL("UPDATE P_PARAMETROS_ESPECIFICOS SET IDESTADO='0' WHERE ID='" + vista_registros.GetFocusedRowCellValue(COL_ID).ToString() + "' ");
                }
                else
                {

                    DataTable TB_VERIFICACION = NFunciones.TABLADATOS("SELECT * FROM P_PARAMETROS_ESPECIFICOS WHERE IDVARIEABLE='" + vista_registros.GetFocusedRowCellValue(COL_IDVARIABLE).ToString() + "' AND IDPRESUPUESTO='" + vista_registros.GetFocusedRowCellValue(COL_IDPRESUPUESTO).ToString() + "' AND IDESTADO='1'");
                    if (TB_VERIFICACION.Rows.Count > 0)
                    {
                        MessageBox.Show("NO se Puede Activar , Ya existe un registro para esta Variable y Presupuesto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        respuesta = NFunciones.ExecuteSQL("UPDATE P_PARAMETROS_ESPECIFICOS SET IDESTADO='1' WHERE ID='" + vista_registros.GetFocusedRowCellValue(COL_ID).ToString() + "' ");
                    }
                }

                if (respuesta.Equals("Ok"))
                {
                    MessageBox.Show("Se Actualizo Correctamente ", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se Pudo Actualizar!! ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                LlegarGrilla();
            }

        }
    }
}