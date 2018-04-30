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
    public partial class Frm_EditDetallePresupuesto : Form
    {
        string tipo, idpresupuesto;
        DataTable tbresult = new DataTable();

        public Frm_EditDetallePresupuesto()
        {
            InitializeComponent();
        }

        private void chk_variedad_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_variedad.Checked)
            {
                tipo = "V";
                chk_lote.Checked = false;
            }
        }

        private void chk_lote_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_lote.Checked)
            {
                tipo = "L";
                chk_variedad.Checked = false;
            }
        }

        private void Frm_EditDetallePresupuesto_Load(object sender, EventArgs e)
        {
            ListarPresupuestos();
        }
        void ListarPresupuestos()
        {
            cbo_presupuesto.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDPRESUPUESTO,DESCRIPCION PRESUPUESTO FROM P_PRESUPUESTO WHERE ES_GF='0'");
            cbo_presupuesto.Properties.ValueMember = "IDPRESUPUESTO";
            cbo_presupuesto.Properties.DisplayMember = "PRESUPUESTO";
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (cbo_presupuesto.Text.Equals("[Seleccione..]"))
            {
                MessageBox.Show("Debe Seleccionar un Presupuesto que desea Actualizar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            idpresupuesto = Convert.ToString(cbo_presupuesto.EditValue);
            data();
        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            if (txt_filtro.Text!="")
            {
                dtg_datos.CurrentCell = null;
                foreach(DataGridViewRow r in dtg_datos.Rows)
                {
                    r.Visible = false;
                }
                foreach(DataGridViewRow r in dtg_datos.Rows)
                {
                    foreach(DataGridViewCell c in r.Cells)
                    {

                        if (c.Value.ToString().ToUpper().IndexOf(txt_filtro.Text.ToUpper())==0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                dtg_datos.DataSource = tbresult;
            }
        }

        void data()
        {
            if (tipo.Equals("V"))
            {
                tbresult = NFunciones.TABLADATOS("SELECT * FROM P_DPRESUPUESTO_RG WHERE IDPRESUPUESTO='"+idpresupuesto+"'");
            }
            if (tipo.Equals("L"))
            {
                tbresult = NFunciones.TABLADATOS("SELECT * FROM P_DPRESUPUESTO_LOTE WHERE IDPRESUPUESTO='" + idpresupuesto + "'");
            }
            dtg_datos.DataSource = tbresult;
            

        }
    }
}
