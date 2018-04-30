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
    public partial class Frm_ProcesarReportes : Form
    {
        string _idpresupuesto,estado;


        public Frm_ProcesarReportes()
        {
            InitializeComponent();
        }

        private void Frm_ProcesarReportes_Load(object sender, EventArgs e)
        {
            ListarPresupuestos();
        }

        private void ListarPresupuestos()
        {
            cbo_presupuesto.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDPRESUPUESTO,DESCRIPCION PRESUPUESTO FROM P_PRESUPUESTO WHERE ES_GF='0'");
            cbo_presupuesto.Properties.ValueMember = "IDPRESUPUESTO";
            cbo_presupuesto.Properties.DisplayMember = "PRESUPUESTO";
        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(cbo_presupuesto.Text).Equals("[Seleccionar..]"))
            {
                MessageBox.Show(@"Debe Seleccionar un Presupuesto !", @"Alerta !", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            else
            {
                _idpresupuesto = Convert.ToString(cbo_presupuesto.EditValue);
            }

            cbo_presupuesto.Enabled = false;
            btn_procesar.Enabled = false;
            bar_progreso.Visible = true;
            estado = "N";
            Thread hilo = new Thread(procesar);
            hilo.Start();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (estado.Equals("S"))
            {
                estado = "N";
                cbo_presupuesto.Enabled = true;
                btn_procesar.Enabled = true;
                bar_progreso.Visible = false;
                MessageBox.Show("Se termino de Procesar");
                timer1.Stop();

            }
        }

        void procesar()
        {
          
            DataTable _dtresultado;
            _dtresultado = NFunciones.TABLADATOS("EXEC SP_PROCESAR_PXQ '" + _idpresupuesto + "'");
            string rpta = NFunciones.ExecuteSQL("EXEC SP_CALCULAR_PYG'" + _idpresupuesto + "'");
            estado = "S";
        }
    }
}
