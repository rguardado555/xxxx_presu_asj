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
using DevExpress.Utils.OAuth.Provider;
using ClosedXML.Excel;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace ModuloPresupuesto
{
    public partial class Frm_DescargarDeta : Form
    {
        string tipo,IDPRESUPUESTO,ESTADO;
        DataTable DTRESULT = new DataTable();
        public Frm_DescargarDeta()
        {
            InitializeComponent();
        }

        private void Frm_DescargarDeta_Load(object sender, EventArgs e)
        {
            ListarPresupuestos();
        }
        void ListarPresupuestos()
        {
            cbo_presupuesto.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDPRESUPUESTO,DESCRIPCION PRESUPUESTO FROM P_PRESUPUESTO WHERE ES_GF='0'");
            cbo_presupuesto.Properties.ValueMember = "IDPRESUPUESTO";
            cbo_presupuesto.Properties.DisplayMember = "PRESUPUESTO";
        }

        private void chk_variedad_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_variedad.Checked)
            {
                tipo = "V";
                COL_LOTE.Visible = false;
                chk_lote.Checked = false;
            }
        }

        private void chk_lote_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_lote.Checked)
            {
                tipo = "L";
                COL_LOTE.Visible = true;
                chk_variedad.Checked = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ESTADO.Equals("S"))
            {
                ESTADO = "N";
                cbo_presupuesto.Enabled = true;
                chk_lote.ReadOnly = false;
                chk_variedad.ReadOnly = false;
                btn_generarplantilla.Enabled = true;
                bar_progreso.Visible = false;
                dtg_datos.DataSource = DTRESULT;




                string RUTA = "c:\\DATA\\DETALLE.xlsx";
                dtg_datos.ExportToXlsx(RUTA);
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "EXCEL.EXE";
                startInfo.Arguments = RUTA;
                Process.Start(startInfo);
                timer1.Stop();
            }
            else
            {
                lb_correlativo.Text = DTRESULT.Rows.Count.ToString() + " "+ FuncionesExtras.mensajeexport;

            }
        }

        private void btn_generarplantilla_Click(object sender, EventArgs e)
        {
            if (cbo_presupuesto.Text.Equals("[Seleccione..]"))
            {
                MessageBox.Show("Debe Seleccionar un presupuesto que desea Actualizar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            IDPRESUPUESTO = Convert.ToString(cbo_presupuesto.EditValue);

            ESTADO = "N";
            Thread HILO = new Thread(descargardata);
            HILO.Start();
            timer1.Start();
            cbo_presupuesto.Enabled = false;
            chk_lote.ReadOnly = true;
            chk_variedad.ReadOnly = true;
            btn_generarplantilla.Enabled = false;
            bar_progreso.Visible = true;
        }
        void descargardata()
        {

            try
            {
                DTRESULT = NFunciones.TABLADATOS("SELECT * FROM P_PROCESADO_DPRESUPUESTO_RG WHERE IDPRESUPUESTO='" + IDPRESUPUESTO + "'");
                DataSet ds = new DataSet();
               
                //ds.Tables.Add(DTRESULT);
                //Console.WriteLine("dataset completo");

                //string RUTA = "c:\\DATA\\xxxxx.xlsx";
                //Console.WriteLine("funcion excel");
                //FuncionesExtras obj = new FuncionesExtras();
                //obj.ExportDataSetToExcel(ds, RUTA);


            }
            catch (Exception EX)
            {
                MessageBox.Show("Se produjo un error : "+EX,"Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            
            }
            ESTADO = "S";
        }
    }
}
