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
using System.Threading;
namespace ModuloPresupuesto
{
    public partial class Rpt_xLote : Form
    {
        DataTable tbresumen;
        string PROCESADO = "N";
        string errores = "";
        public Rpt_xLote()
        {
            InitializeComponent();
        }

        private void Rpt_xLote_Load(object sender, EventArgs e)
        {
            ListarPresupuestos();
            chk_parcela.Checked = true;
            chk_fundo.Checked = true;
        }
        void ListarPresupuestos()
        {
            cbo_presupuesto.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDPRESUPUESTO, DESCRIPCION FROM P_PRESUPUESTO ");
            cbo_presupuesto.Properties.ValueMember = "IDPRESUPUESTO";
            cbo_presupuesto.Properties.DisplayMember = "DESCRIPCION";
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            PROCESADO = "N";
            errores = "";
            if (cbo_presupuesto.Text.Equals("[Seleccionar..]"))
            {
                MessageBox.Show("Seleccione un Presupuesto para Consultar","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            barra_progreso.Visible = true;
            Thread HILO = new Thread(procesando);
            HILO.Start();
            timer1.Start();

        }
        void procesando()
        {
            try
            {
                tbresumen = NFunciones.TABLADATOS("EXEC SP_GENERAR_RPTXLOTE'" + Convert.ToString(cbo_presupuesto.EditValue) + "'");
                PROCESADO = "S";
            }
            catch (Exception ex)
            {
                errores = ex.Message;
                PROCESADO = "S";
              
            }
           
        }
        private void chk_fundo_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_fundo.Checked)
            {
                COL_FUNDO.Visible = true;
            }
            else
            {
                COL_FUNDO.Visible = false;
            }
        }

        private void chk_parcela_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_parcela.Checked)
            {
                COL_PARCELA.Visible = true;
            }else
            {
                COL_PARCELA.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PROCESADO.Equals("S"))
            {

                pvt_datos.DataSource = tbresumen;
                PROCESADO = "N";
                if (!errores.Equals(""))
                {
                    MessageBox.Show(errores, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                barra_progreso.Visible = false;
                timer1.Stop();
            }
        }
    }
}
