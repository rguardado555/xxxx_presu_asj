using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
namespace ModuloPresupuesto
{
    public partial class Frm_SubItemCosto : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public Frm_SubItemCosto()
        {
            InitializeComponent();
        }
        //Metodo mostrar mensaje de confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        //Metodo mostrar mensaje error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Frm_SubItemCosto_Load(object sender, EventArgs e)
        {

            this.HabilitarTexbox(false);
            this.Botones();
            this.llenargrilla();
            this.LlenarCombo();

        }
        void llenargrilla()
        {
            dtg_datos.DataSource = NFunciones.TABLADATOS("SELECT P.IDSUBITEMCOSTO ID ,P.DESCRIPCION,I.IdItemCosto IDICOSTO,I.DESCRIPCION ICOSTO FROM P_SUB_ICOSTO P INNER JOIN P_ICOSTO I ON I.IdItemCosto=P.IDITEMCOSTO ORDER BY P.IDSUBITEMCOSTO ASC");
        }
        void Botones()
        {

            if (this.IsNuevo || this.IsEditar)
            {
                this.HabilitarTexbox(true);
                this.btn_nuevo.Enabled = false;
                this.btn_editar.Enabled = false;
                this.btn_guardar.Enabled = true;
                this.btn_cancelar.Enabled = true;
                this.btn_exportar.Enabled = false;
                this.btn_eliminar.Enabled = false;
            }
            else
            {

                this.HabilitarTexbox(false);
                this.btn_nuevo.Enabled = true;
                this.btn_editar.Enabled = true;
                this.btn_guardar.Enabled = false;
                this.btn_cancelar.Enabled = false;
                this.btn_exportar.Enabled = true;
                this.btn_eliminar.Enabled = true;
            }


        }


        void LlenarCombo()
        {
            cbo_icosto.Properties.DataSource = NFunciones.TABLADATOS("SELECT IdItemCosto ID , DESCRIPCION FROM P_ICOSTO ORDER BY IdItemCosto ASC");
            cbo_icosto.Properties.ValueMember = "ID";
            cbo_icosto.Properties.DisplayMember = "DESCRIPCION";
        }
        private void Limpiar()
        {
            this.txt_codigo.Text = string.Empty;
            this.txt_descripcion.Text = string.Empty;
            this.cbo_icosto.SelectedText = "";

        }
        private void HabilitarTexbox(bool Valor)
        {
            this.txt_descripcion.ReadOnly = !Valor;
            this.cbo_icosto.Enabled = Valor;
        }

        private void btn_nuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Limpiar();
            DataTable dtid = new DataTable();
            try
            {
                dtid = NFunciones.TABLADATOS("EXEC SP_IDSUBICOSTO''");
                this.IsNuevo = true;
                this.IsEditar = false;
                this.Botones();
                this.HabilitarTexbox(true);
                this.txt_descripcion.Focus();
                txt_codigo.Text = dtid.Rows[0]["ID"].ToString();

            }
            catch (Exception ex)
            {
                MensajeError("Ocurrio un error " + "\n" + ex.Message);
                return;
            }
        }

        private void btn_editar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!txt_codigo.Text.Equals(""))
            {
                this.IsNuevo = false;
                this.IsEditar = true;
                this.Botones();
                this.HabilitarTexbox(true);
                this.txt_descripcion.Focus();
            }
            else
            {
                MensajeError("Debe Seleccionar Un registro");
                return;
            }
        }

        private void btn_cancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.HabilitarTexbox(false);
            this.llenargrilla();
        }

        private void btn_guardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (this.cbo_icosto.Text == "[Seleccionar..]")
                {
                    MensajeError("Falta Seleccionar Empresa");
                    return;
                }

                string rpta = "";
                if (this.txt_codigo.Text == string.Empty)
                {
                    MensajeError("Falta Ingresar Codigo");
                    return;
                }
                if (this.txt_descripcion.Text == string.Empty)
                {
                    MensajeError("Falta Ingresar Descripción");
                    return;
                }

                string codigo;
                DataTable dtid = new DataTable();


                if (this.IsNuevo)
                {
                    dtid = NFunciones.TABLADATOS("EXEC SP_IDSUBICOSTO''");
                    codigo = dtid.Rows[0]["ID"].ToString();
                    txt_codigo.Text = codigo;
                    rpta = NFunciones.ExecuteSQL("INSERT INTO P_SUB_ICOSTO(IDSUBITEMCOSTO,DESCRIPCION,IDITEMCOSTO)VALUES('"+txt_codigo.Text+"','"+txt_descripcion.Text+"','"+Convert.ToString(cbo_icosto.EditValue)+"')");
                }
                else
                {
                    rpta = NFunciones.ExecuteSQL("UPDATE P_SUB_ICOSTO SET DESCRIPCION='"+txt_descripcion.Text+"' WHERE IDSUBITEMCOSTO='"+txt_codigo.Text+"'");
                }

                if (rpta.Equals("Ok"))
                {
                    if (this.IsNuevo)
                    {
                        this.MensajeOk("Se Inserto los Datos Correctamente");

                    }
                    else
                    {
                        this.MensajeOk("Se Actualizo los Datos Correctamente");
                    }
                }
                else
                {
                    this.MensajeError(rpta);
                }

                this.IsNuevo = false;
                this.IsEditar = false;
                this.Botones();
                this.HabilitarTexbox(false);
                this.llenargrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btn_eliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.txt_codigo.Text.Equals(""))
            {
                string rpta = "";
                try
                {
                    DialogResult Opcion;
                    Opcion = MessageBox.Show("Realmente Desea Eliminar este registro", "Presupuesto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (Opcion == DialogResult.OK)
                    {

                        rpta = NFunciones.ExecuteSQL(" DELETE P_SUB_ICOSTO WHERE IDSUBITEMCOSTO='" + txt_codigo.Text + "'");
                        if (rpta.Equals("Ok"))
                        {
                            this.MensajeOk("Eliminado Correctamente");
                            this.Limpiar();
                        }
                        else
                        {
                            this.MensajeError(rpta);
                        }
                    }
                }
                catch (Exception ex)
                {
                    this.MensajeError(ex.Message + ex.StackTrace);
                }

                this.llenargrilla();
            }
        }

        private void btn_exportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtg_datos.IsPrintingAvailable)
            {
                dtg_datos.ShowPrintPreview();
            }
            else
            {
                MensajeError("Ocurrio un error , verifique ");
            }
        }

        private void dtg_datos_Click(object sender, EventArgs e)
        {
            if (!this.IsNuevo && !this.IsEditar)
            {
                txt_codigo.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(col_codigo));
                txt_descripcion.Text = Convert.ToString(vista_datos.GetFocusedRowCellValue(col_descripcion));
                cbo_icosto.EditValue = Convert.ToString(vista_datos.GetFocusedRowCellValue(col_iditemcosto));

            }
        }
    }
}
