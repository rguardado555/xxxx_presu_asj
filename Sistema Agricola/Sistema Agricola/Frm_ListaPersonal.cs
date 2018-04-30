using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;
using System.Threading;
using System.IO;

namespace Sistema_Agricola
{
    public partial class Frm_ListaPersonal : Form
    {
        Thread hilo;
        string actualizar = "N";
        string mensaje = "N";
        int totalregistros = 0;
        int insertados = 0;
        double porcentaje;
        string error = "N";
        int porcentajeImport = 0;
        DataTable TB_PERSONAL;

        public Frm_ListaPersonal()
        {
            InitializeComponent();
        }

        private void btn_importar_Click(object sender, EventArgs e)
        {
            DialogResult rpta = MessageBox.Show("Esta seguro de importar los Trabajadores de Nisira ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.Yes)
            {
                Thread Hilo = new Thread(importacion);
                Hilo.Start();
                barra_progreso.Visible = true;
                imagen_cargando.Visible = true;
                timer1.Start();
            }
        }

        private void Frm_ListaPersonal_Load(object sender, EventArgs e)
        {
            Thread hiloGrilla = new Thread(llenarGrilla);
            imagen_cargando.Visible = true;
            hiloGrilla.Start();
            timer2.Start();

          imagen_cargando.Location =
           new Point(ClientSize.Width / 2 - imagen_cargando.Size.Width / 2,
           ClientSize.Height / 2 - imagen_cargando.Size.Height / 2);
        }

        private void importacion()
        {

            //CheckForIllegalCrossThreadCalls = false;
            try
            {
                DataTable TablaNisira = new DataTable();
                TablaNisira = NFunciones.TABLADATOSNISIRA("exec sp_executesql N'exec PERSONAL_NISRA_RG @P1 , @P2 , @P3 ',N'@P1 varchar(3),@P2 varchar(13),@P3 float','001','ADMINISTRADOR',0");
                string I = "";
                string errores = "";
                totalregistros = TablaNisira.Rows.Count;


                foreach (DataRow row in TablaNisira.Rows)
                {


                    DateTime fechanaci = Convert.ToDateTime((row["FNACIMIENTO"]));

                    DateTime time = Convert.ToDateTime((row["FNACIMIENTO"]));      // Use current time
                    string format = "dd-MM-yyyy";
                    // MessageBox.Show(row["idcodigogeneral"].ToString().ToUpper().Trim() +"-"+ row["nombres"].ToString().ToUpper().Trim() + "-" + row["ap_paterno"].ToString().ToUpper().Trim() + "-" + row["ap_materno"].ToString().ToUpper().Trim() + "-" +  row["nrodocumento"].ToString().ToUpper().Trim() + "-" + row["sexo"].ToString().ToUpper().Trim() + "-" + row["l_negra"].ToString().ToUpper().Trim() + "-" + row["PlanActual"].ToString().ToUpper().Trim() + "-" + row["cargo"].ToString().ToUpper().Trim());
                    I = NFunciones.ExecuteSQL("EXEC SP_INSERTARACTUALIZAR_PERSONALNISIRA'"+ row["idcodigogeneral"].ToString().ToUpper().Trim() + "','" + row["nombres"].ToString().ToUpper().Trim() + "','" + row["a_paterno"].ToString().ToUpper().Trim() + "','" + row["a_materno"].ToString().ToUpper().Trim() + "','" + row["nrodocumento"].ToString().ToUpper().Trim() + "','" + row["sexo"].ToString().ToUpper().Trim() + "','" + row["l_negra"].ToString().ToUpper().Trim() + "','" + row["PlanActual"].ToString().ToUpper().Trim() + "','" + row["cargo"].ToString().ToUpper().Trim()+"','" + row["estado"].ToString().ToUpper().Trim()+"','" + row["afp_dsc"].ToString().ToUpper().Trim()+"','" + row["Asig_fam"].ToString().ToUpper().Trim() + "','" + row["dsc_planilla"].ToString().ToUpper().Trim()+"','" + row["IDUBIGEO"].ToString().ToUpper().Trim() + "','" + row["DIRECCION"].ToString().ToUpper().Trim() + "','" + row["CELULAR"].ToString().ToUpper().Trim() + "','" + row["EMAIL"].ToString().ToUpper().Trim() + "','SI'");
                    insertados++;
                    totalregistros = totalregistros - 1;
                    porcentajeImport = Convert.ToInt32((totalregistros / insertados) * 100);
                    //  sub_importar.ReportProgress(100 - Convert.ToInt32((insertados / total) * 100));
                    mensaje = "Actualizando Codigo  : " + row["idcodigogeneral"].ToString().ToUpper().Trim() + " -  Faltan : " + totalregistros + "";
                    if (!I.Equals("OK"))
                    {
                        errores = "No se puedo Insertar o Actualizar : " + row["idcodigogeneral"].ToString().ToUpper().Trim() +"\n";
                    }
                }
                if (!errores.Equals(""))  
                {
                    MessageBox.Show("Proceso Terminado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Proceso Terminado Con errores", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                    string ruta = "C:\\DATA";
                    string rutaCompleta = ruta + "\\errores.txt"  ;
                    if (!Directory.Exists(ruta))
                    {
                        Directory.CreateDirectory(ruta);
                    }
                    if (File.Exists(rutaCompleta))
                    {
                        File.Delete(rutaCompleta);
                    }
                    using (StreamWriter file = new StreamWriter(rutaCompleta, true))
                    {
                        file.WriteLine(errores); 
                        file.Close();
                    }

                   
                }
                Program.estadosincronizacion = "S";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
            }
        }
        void altercoloresdatagrid(DataGridView dgv, int item)
        {
            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgv.Columns[0].HeaderCell.Style.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dgv.Columns[0].DefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dgv.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //for (int f = 1; f < item; f++)
            //{
            //    dgv.Columns[f].DefaultCellStyle.Format = "N2";
            //    dgv.Columns[f].HeaderCell.Style.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            //    dgv.Columns[f].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            //    dgv.Columns[f].DefaultCellStyle.Font = new Font("Segoe UI", 9.75F);
            //    dgv.Columns[f].DefaultCellStyle.ForeColor = Color.Black;
            //    dgv.Columns[f].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //}
        }
        void llenarGrilla()
        {
            try
            {
                TB_PERSONAL = NFunciones.TABLADATOSNISIRA("exec sp_executesql N'exec PERSONAL_NISRA_RG @P1 , @P2 , @P3 ',N'@P1 varchar(3),@P2 varchar(13),@P3 float','001','ADMINISTRADOR',0");
                Program.llenargrillapersonal = "S";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Alerta !!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
              
            }
            Program.llenargrillapersonal = "S";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.estadosincronizacion.Equals("S"))
            {
                Program.estadosincronizacion = "N";
                //barra_progreso.Visible = false;
                label3.Text = Convert.ToString(totalregistros);
                imagen_cargando.Visible = false;
                llenarGrilla();
            }
            else
            {
                //barra_progreso.Value = porcentajeImport;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Program.llenargrillapersonal.Equals("S"))
            {
                Program.llenargrillapersonal = "N";
                dtg_datos.DataSource = TB_PERSONAL;
                imagen_cargando.Visible = false;
                timer2.Stop();
            }
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ListaPersonal_ResizeEnd(object sender, EventArgs e)
        {
            imagen_cargando.Location =
           new Point(ClientSize.Width / 2 - imagen_cargando.Size.Width / 2,
           ClientSize.Height / 2 - imagen_cargando.Size.Height / 2);
        }
    }
}
