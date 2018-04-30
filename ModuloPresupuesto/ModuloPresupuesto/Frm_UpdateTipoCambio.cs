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
    public partial class Frm_UpdateTipoCambio : Form
    {
        string actualizar="N";
        string idpresupuesto;
        decimal TC;
        public Frm_UpdateTipoCambio()
        {
            InitializeComponent();
        }

        private void Frm_UpdateTipoCambio_Load(object sender, EventArgs e)
        {
          
            DataTable DTVALOR = new DataTable();
            DTVALOR = NFunciones.TABLADATOS("SELECT VALOR FROM P_PARAMETROS where IDVARIABLE='001'");
            try
            {
                txt_tipocambio.Text = DTVALOR.Rows[0]["VALOR"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ListarPresupuestos();

            if (chk_presupuesto.Checked)
            {
                cbo_presupuesto.Enabled = true;
            }
            else
            {
                cbo_presupuesto.Enabled = false;
            }
            if (chk_TC.Checked)
            {
                txt_tipocambio.ReadOnly = false;
            }
            else
            {
                txt_tipocambio.ReadOnly = true;
            }
        }

        void ListarPresupuestos()
        {
            cbo_presupuesto.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDPRESUPUESTO,DESCRIPCION PRESUPUESTO FROM P_PRESUPUESTO WHERE ES_GF='0'");
            cbo_presupuesto.Properties.ValueMember = "IDPRESUPUESTO";
            cbo_presupuesto.Properties.DisplayMember = "PRESUPUESTO";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!chk_TC.Checked && !chk_presupuesto.Checked)
            {
                MessageBox.Show("Debe Seleccionar una Operación", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (chk_TC.Checked)
            {
                if (txt_tipocambio.Text.Equals(""))
                {
                    MessageBox.Show("Debe Agregar Valor al tipo de cambio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                TC = Convert.ToDecimal(txt_tipocambio.Text);

            }
            else
            {
                TC = 0;
            }


            if (chk_presupuesto.Checked)
            {
                if (cbo_presupuesto.Text.Equals("[Seleccione..]"))
                {
                    MessageBox.Show("Debe Seleccionar un presupuesto que desea Actualizar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                idpresupuesto = Convert.ToString(cbo_presupuesto.EditValue);

            }
            else
            {
                idpresupuesto = "";
            }


            actualizar = "N";
            timer1.Start();
            Thread HILO = new Thread(actualizardatos);
            HILO.Start();
            txt_tipocambio.ReadOnly = true;
            cbo_presupuesto.Enabled = false;
            chk_presupuesto.Enabled = false;
            chk_TC.Enabled = false;
            btn_update.Enabled = false;
            bar_progreso.Visible = true;
        }

        void actualizardatos()
        {
            if (TC>0) {
                string rptat2 = NFunciones.ExecuteSQL("UPDATE P_PARAMETROS SET VALOR='" + Convert.ToDecimal(txt_tipocambio.Text) + "' WHERE IDVARIABLE='001' ");


                if (rptat2.Equals("Ok"))
                {
                    toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[0]);
                }
                else
                {
                    toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[1]);
                }

            }
            if (!idpresupuesto.Equals(""))
            {
                try 
                {

                    DataTable tbractualiza, tbractualiza1, tbractualiza2 = new DataTable();

                    string rpta,rpta1,rpta2;
                    tbractualiza = NFunciones.TABLADATOS("EXEC ACTUALIZA_MONEDA_PRTLOTE'" + idpresupuesto + "'");
                    rpta = tbractualiza.Rows[0]["RESULTADO"].ToString();

                    tbractualiza1 = NFunciones.TABLADATOS("EXEC SP_PROCESAR_PXQ_DOL'" + idpresupuesto + "','02'");
                    tbractualiza2 = NFunciones.TABLADATOS("EXEC SP_PROCESAR_PXQ_SOL'" + idpresupuesto + "','01'");
                    MessageBox.Show(rpta +"   "+ Convert.ToString(tbractualiza1.Rows.Count) + "   " + Convert.ToString(tbractualiza2.Rows.Count));
                    if (rpta.Equals("Ok")/*&& tbractualiza1.Rows.Count>0 && tbractualiza2.Rows.Count > 0*/)
                    {

                        //MessageBox.Show("Correctamente actualizado");
                        toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[2]);
                    }
                    else
                    {
                        toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[3]);
                    }
                   // MessageBox.Show(rpta);
                   
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                   // toastNotificationsManager1.Notifications[4].Body2 = EX.Message;
                   toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[3]);
                }
            }
            
            actualizar = "S";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (actualizar.Equals("S"))
            {
                txt_tipocambio.ReadOnly = false;
                if (chk_presupuesto.Checked)
                {
                    cbo_presupuesto.Enabled = true;
                }
                else
                {
                    cbo_presupuesto.Enabled = false;
                }
                if (chk_TC.Checked)
                {
                    txt_tipocambio.ReadOnly = false;
                }
                else
                {
                    txt_tipocambio.ReadOnly = true;
                }
                chk_TC.Enabled = true;
                chk_presupuesto.Enabled = true;
                btn_update.Enabled = true;
                bar_progreso.Visible = false;
                actualizar = "N";
                timer1.Stop();
            }
        }

        private void chk_presupuesto_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_presupuesto.Checked)
            {
                cbo_presupuesto.Enabled = true;
            }
            else
            {
                cbo_presupuesto.Enabled = false;
            }
        }

        private void chk_TC_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_TC.Checked)
            {
                txt_tipocambio.ReadOnly = false;
            }
            else
            {
                txt_tipocambio.ReadOnly = true;
            }
        }

        private void Frm_UpdateTipoCambio_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
