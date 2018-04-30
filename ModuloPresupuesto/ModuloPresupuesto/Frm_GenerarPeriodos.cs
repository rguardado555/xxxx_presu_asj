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
    public partial class FrmGenerarPeriodos : Form
    {
        private  string _actualizar = "N";
        private int _ms, _s, _m;
        private string _ocupado = "N";
        public FrmGenerarPeriodos()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

          
            if (cbo_presupuesto.Text.Equals("[Seleccione..]"))
            {
                MessageBox.Show(@"Debe Seleccionar un presupuesto que desea Actualizar", @"Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _ocupado = "S";
            _actualizar = "N";
            Thread hilo = new Thread(Actualizardatos);
            hilo.Start();
            timer1.Start();
            cbo_presupuesto.Enabled = false;
            btn_update.Enabled = false;
            bar_progreso.Visible = true;
        }

        private void ListarPresupuestos()
        {
            cbo_presupuesto.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDPRESUPUESTO,DESCRIPCION PRESUPUESTO FROM P_PRESUPUESTO WHERE ES_GF='0'");
            cbo_presupuesto.Properties.ValueMember = "IDPRESUPUESTO";
            cbo_presupuesto.Properties.DisplayMember = "PRESUPUESTO";
        }

        private void Frm_GenerarPeriodos_Load(object sender, EventArgs e)
        {
            ListarPresupuestos();
        }

        private void FrmGenerarPeriodos_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_ocupado.Equals("S"))
            {
                MessageBox.Show(@"Estamos procesando no se puede cerrar", @"Alerta", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            else
            {
                this.Close();
            }
        }

        private void FrmGenerarPeriodos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_ocupado.Equals("S"))
            {
                MessageBox.Show(@"Estamos procesando no se puede cerrar", @"Alerta", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            else
            {
                this.Close();
            }
        }

        private void Actualizardatos()
        {
            var rpta = NFunciones.ExecuteSQL("EXEC SP_GENERA_SEMANAS'" + Convert.ToString(cbo_presupuesto.EditValue) + "' ");
            if (rpta.Equals("Ok"))
            {

                // VariablesGenerales.idalerta = "989b838b-d806-4edf-a594-e5ecb79d2512";
                //VariablesGenerales.mostraralerta = "S";
                //MessageBox.Show("Actualizado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[0]);

                _actualizar = "S";
            }
            else
            {

                toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[1]);
                // MessageBox.Show("No se puedo actualizar Correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _actualizar = "S";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_actualizar.Equals("S"))
            {
                cbo_presupuesto.Enabled = true;
                btn_update.Enabled = true;
                bar_progreso.Visible = false;
                _actualizar = "N";
                _ocupado = "N";
                timer1.Stop();
            }
            else
            {
                timer1.Interval = 10;
                _ms++;
                if (_ms == 100)
                {
                    _s++;
                    _ms = 0;
                }
                else if (_s == 60)
                {
                    _m++;
                    _s = 0;
                }
                lb_coronometro.Text = _m.ToString().PadLeft(2, '0') + @":" + _s.ToString().PadLeft(2, '0') + @":" + _ms.ToString().PadLeft(2, '0');
            }
        }
    }
}
