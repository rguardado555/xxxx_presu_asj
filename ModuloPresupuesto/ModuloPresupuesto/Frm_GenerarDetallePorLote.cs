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
    public partial class FrmGenerarDetallePorLote : Form
    {
        private string _actualizar = "N";
        private string _idpresupuesto;
        private int _ms, _s, _m;
        private string _ocupado = "N";
        public FrmGenerarDetallePorLote()
        {
            InitializeComponent();
        }

        private void Frm_GenerarDetallePorLote_Load(object sender, EventArgs e)
        {
            ListarPresupuestos();
        }

        private void ListarPresupuestos()
        {
            cbo_presupuesto.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDPRESUPUESTO,DESCRIPCION PRESUPUESTO FROM P_PRESUPUESTO WHERE ES_GF='0'");
            cbo_presupuesto.Properties.ValueMember = "IDPRESUPUESTO";
            cbo_presupuesto.Properties.DisplayMember = "PRESUPUESTO";
        }

        private void Actualizardatos()
        {
            if (!_idpresupuesto.Equals(""))
            {
                try
                {
                    string rpta;
                    rpta = NFunciones.ExecuteSQL("EXEC SP_GENERAR_RPTXLOTE'" + _idpresupuesto + "'");
                    toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[2]);
                }
                catch
                {
                    toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[2]);
                }
            }

            _actualizar = "S";
        }

        private void FrmGenerarDetallePorLote_FormClosed(object sender, FormClosedEventArgs e)
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

        private void FrmGenerarDetallePorLote_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_ocupado.Equals("S"))
            {
                MessageBox.Show(@"Estamos procesando no se puede cerrar", @"Alerta", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            if (cbo_presupuesto.Text.Equals("[Seleccione..]"))
            {
                MessageBox.Show(@"Debe Seleccionar un Presupuesto que desea Actualizar", @"Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _idpresupuesto = Convert.ToString(cbo_presupuesto.EditValue);
            _m = 0;
            _ms = 0;
            _s = 0;
            _ocupado = "S";
            lb_coronometro.Visible = true;
            _actualizar = "N";
            timer1.Start();
            Thread hilo = new Thread(Actualizardatos);
            hilo.Start();
            cbo_presupuesto.Enabled = false;
            btn_update.Enabled = false;
            bar_progreso.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_actualizar.Equals("S"))
            {
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

        private void btn_update_Click(object sender, EventArgs e)
        {
           
                if (cbo_presupuesto.Text.Equals("[Seleccione..]"))
                {
                    MessageBox.Show(@"Debe Seleccionar un Presupuesto que desea Actualizar", @"Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _idpresupuesto = Convert.ToString(cbo_presupuesto.EditValue);
            _m = 0;
            _ms = 0;
            _s = 0;
            _ocupado = "S";
            lb_coronometro.Visible = true;
            _actualizar = "N";
            timer1.Start();
            Thread hilo = new Thread(Actualizardatos);
            hilo.Start();
            cbo_presupuesto.Enabled = false;
            btn_update.Enabled = false;
            bar_progreso.Visible = true;
        }
    }
}
