using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using System.Threading;

namespace ModuloPresupuesto
{
    public partial class Frm_ImportarDetallePresupuesto : Form
    {

        string TIPOELIMINACION = "C";
        // SI EL TIPO ES "C" LA OPERACION DE ELIMINACION ES DEL COSTO , SI EL TIPO ES "G" LA OPERACION DE ELIMINACION ES GASTO
        string tipo,mensaje,IDITEMCOSTO_US,IDCULTIVO_US,errorinsert;
        string idempresa, idpresupuesto, idcultivo, IdVariedad, idetapa, idestructura, idtipocosto, iditemcosto, idactividadsubgru, idlaborproducto, idunidad, semana, periodo;
        int con_igv, dias_pago,CONTADOR;
        string eliminarData = "N";
        //eliminar detalle de costo
        string idpresupuesto_c, idcultivo_c, idvariedad_c, tcosto_c, icosto_C, idlote_c;

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (TIPOELIMINACION.Equals("C"))
            {



                idpresupuesto_c = "";
                idcultivo_c = "";
                idvariedad_c = "";
                tcosto_c = "";
                icosto_C = "";
                idlote_c="";

                if (cbo_presupuesto.EditValue.ToString().Equals("") && cbo_presupuesto.Text.Equals(""))
                {
                    MessageBox.Show("Debe seleccionar un presupuesto !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    idpresupuesto_c = cbo_presupuesto.EditValue.ToString();
                }
                if (cbo_cultivo.EditValue.ToString().Equals("")&& cbo_cultivo.Text.Equals(""))
                {
                    MessageBox.Show("Debe seleccionar un Cultivo !","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    idcultivo_c = cbo_cultivo.EditValue.ToString();
                }

                if (cbo_variedad.EditValue.ToString().Equals("") && cbo_variedad.Text.Equals(""))
                {
                    MessageBox.Show("Debe seleccionar un Variedad !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    idvariedad_c = cbo_variedad.EditValue.ToString();
                }

                if (cbo_tcosto.EditValue.ToString().Equals("") && cbo_tcosto.Text.Equals(""))
                {
                    MessageBox.Show("Debe seleccionar un Tipo Costo !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    tcosto_c = cbo_tcosto.EditValue.ToString();
                }
                if (cbo_icosto.EditValue.ToString().Equals("") && cbo_icosto.Text.Equals(""))
                {
                    MessageBox.Show("Debe seleccionar un Item Costo !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    icosto_C = cbo_icosto.EditValue.ToString();
                }

                if (chk_lote_delete.Checked)
                {
                    if (cbo_lote.EditValue.ToString().Equals("") && cbo_lote.Text.Equals(""))
                    {
                        MessageBox.Show("Debe seleccionar un Lote !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        idlote_c = cbo_lote.EditValue.ToString();
                    }
                }


            }
            if (TIPOELIMINACION.Equals("G"))
            {





            }
        }

        private void chk_variedad_delete_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_variedad_delete.Checked)
            {
                chk_lote_delete.Checked = false;
            }
        }

        private void chk_lote_delete_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_lote_delete.Checked)
            {
                chk_variedad_delete.Checked = false;
            }
        }

        void eliminarCosto()
        {

        }

        private void chk_eliminardata_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_eliminardata.Checked)
            {
                eliminarData = "S";
            }
            else
            {
                eliminarData = "N";
            }
        }

        void cargarpresupuesto()
        {
            cbo_presupuesto.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDPRESUPUESTO ID,DESCRIPCION PRESUPUESTO FROM P_PRESUPUESTO ORDER BY IDPRESUPUESTO ASC");
            cbo_presupuesto.Properties.ValueMember = "ID";
            cbo_presupuesto.Properties.DisplayMember = "PRESUPUESTO";


            cbo_presupuesto_gf.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDPRESUPUESTO ID,DESCRIPCION PRESUPUESTO FROM P_PRESUPUESTO ORDER BY IDPRESUPUESTO ASC");
            cbo_presupuesto_gf.Properties.ValueMember = "ID";
            cbo_presupuesto_gf.Properties.DisplayMember = "PRESUPUESTO";
        }

        private void chk_costo_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_costo.Checked==true)
            {
                chk_gastofijo.Checked = false;
                TIPOELIMINACION = "C";

                cbo_presupuesto.Enabled = true;
                cbo_cultivo.Enabled = true;
                cbo_variedad.Enabled = true;
                cbo_tcosto.Enabled = true;
                cbo_icosto.Enabled = true;
                chk_lote_delete.Enabled = true;
                chk_variedad_delete.Enabled = true;
            }
        }

        private void chk_gastofijo_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_gastofijo.Checked == true)
            {
                chk_costo.Checked = false;
                TIPOELIMINACION = "G";

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (estado.Equals("S"))
            {
                estado = "N";
                Bloquearbotones(false);
                timer1.Stop();
            }
            else
            {
                lb_progreso.Text = mensajeprogreso;
            }
        }

        decimal cantidad, costo;
        string idmoneda, idobjetivo, idsubitemcosto, idfundo, idlote,mensajeprogreso,estado;
        Thread HILO;
        public Frm_ImportarDetallePresupuesto()
        {
            InitializeComponent();
        }

        private void Frm_ImportarDetallePresupuesto_Load(object sender, EventArgs e)
        {
            txt_ruta.ReadOnly = true;
            cargarcultivo();
            cargaritemcosto();
            Bloquearbotones(false);
        }
        void cargarcultivo()
        {
            cbo_cultivo.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDCULTIVO ID , DESCRIPCION CULTIVO FROM P_CULTIVOS ORDER BY IDCULTIVO ASC");
            cbo_cultivo.Properties.ValueMember = "ID";
            cbo_cultivo.Properties.DisplayMember = "CULTIVO";
        }
        void cargar()
        {

        }
        void cargaritemcosto()
        {
            cbo_icosto.Properties.DataSource = NFunciones.TABLADATOS("SELECT IdItemCosto ID , DESCRIPCION [ITEM COSTO] FROM P_ICOSTO ORDER BY IdItemCosto ASC");
            cbo_icosto.Properties.ValueMember = "ID";
            cbo_icosto.Properties.DisplayMember = "ITEM COSTO";
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            //le agregamos un filtro para los tipos de archivos a leer en este caso XML.
            open.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx";
            if (open.ShowDialog() == DialogResult.OK && open.ToString() != " ")
            {
                //Movemos la ruta del archivo a nuestro Textbox creado para su posterior uso.
                txt_ruta.Text = open.FileName;
            }
        }

        private void btn_generarplantilla_Click(object sender, EventArgs e)
        {
            string ruta = "c:\\DATA";
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }



            if (!chk_lote.Checked && !chk_variedad.Checked && !chk_gastofijo.Checked)
            {
                MessageBox.Show("Debe seleccionar una opción !","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if (chk_lote.Checked)
            {
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("dpresupuesto_lote");
                worksheet.Cell(1, 1).Value = "IdEmpresa";
                worksheet.Cell(1, 1).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE COD: 001");
                worksheet.Cell(1, 2).Value = "idPresupuesto";
                worksheet.Cell(1, 2).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE , REVISE EN LA TABLA DE PRESUPUESTOS, FORMATO TEXTO");
                worksheet.Cell(1, 3).Value = "IDCULTIVO";
                worksheet.Cell(1, 3).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE , REVISE EN LA TABLA DE CULTIVOS, FORMATO TEXTO");
                worksheet.Cell(1, 4).Value = "IdVariedad";
                worksheet.Cell(1, 4).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE , REVISE EN LA TABLA DE VARIEDADES, FORMATO TEXTO");
                worksheet.Cell(1, 5).Value = "IdEtapa";
                worksheet.Cell(1, 6).Value = "IdEstructura";
                worksheet.Cell(1, 6).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE , REVISE EN LA TABLA DE ESTRUCTURAS SEGUN EL CULTIVO, FORMATO TEXTO");
                worksheet.Cell(1, 7).Value = "IdTipoCosto";
                worksheet.Cell(1, 7).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE , REVISE EN LA TABLA DE TIPOS DE COSTO, FORMATO TEXTO");
                worksheet.Cell(1, 8).Value = "IdItemCosto";
                worksheet.Cell(1, 8).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE , REVISE EN LA TABLA DE ITEM DE COSTO, FORMATO TEXTO");
                worksheet.Cell(1, 9).Value = "IdActividadSubGru";
                worksheet.Cell(1, 10).Value = "IdLaborProducto";
                worksheet.Cell(1, 10).Comment.SetAuthor("RGUARDADO").AddText("SE DEBE LLENAR IdActividadSubGru SI LLENA ESTE CAMPO, FORMATO TEXTO");
                worksheet.Cell(1, 11).Value = "IdUnidad";
                worksheet.Cell(1, 11).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE , REVISE EN LA TABLA DE UNIDADES, FORMATO TEXTO");
                worksheet.Cell(1, 12).Value = "con_igv";
                worksheet.Cell(1, 12).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE ,O= NO TIENE IGV ,1= TIENE IGV");
                worksheet.Cell(1, 13).Value = "Periodo";
                worksheet.Cell(1, 14).Value = "semana";
                worksheet.Cell(1, 14).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE ,DE 1 A 52 SEMANAS, FORMATO TEXTO");
                worksheet.Cell(1, 15).Value = "Cantidad";
                worksheet.Cell(1, 15).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE , FORMATO NUMERICO ##,#### CON 4 DECIMALES");
                worksheet.Cell(1, 16).Value = "Costo";
                worksheet.Cell(1, 16).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE , FORMATO NUMERICO ##,#### CON 4 DECIMALES");
                worksheet.Cell(1, 17).Value = "IdMoneda";
                worksheet.Cell(1, 17).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE ,01=SOLES,02 DOLARES - COLOCAR EN FORMATO TEXTO");
                worksheet.Cell(1, 18).Value = "dias_pago";
                worksheet.Cell(1, 19).Value = "IDOBJETIVO";
                worksheet.Cell(1, 20).Value = "IdSubItemCosto";
                worksheet.Cell(1, 20).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE , REVISE LA TABLA SUBITEMCOSTO, FORMATO TEXTO");
                worksheet.Cell(1, 21).Value = "IDFUNDO";
                worksheet.Cell(1, 21).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE , REVISE LA TABLA FUNDOS, FORMATO TEXTO");
                worksheet.Cell(1, 22).Value = "IDLOTE";
                worksheet.Cell(1, 22).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE , REVISE LA TABLA LOTES, FORMATO TEXTO");
                worksheet.Range("A1:V1").Style
         .Font.SetFontSize(12)
         .Font.SetBold(false)
         .Font.SetFontColor(XLColor.Black)
         .Fill.SetBackgroundColor(XLColor.EarthYellow);
                workbook.SaveAs("c:\\DATA\\DPRESUPUESTO_LOTE.xlsx");
                //Process.start("EXCEL.EXE","c:\\temp\\excel.xlsx");
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "EXCEL.EXE";
                startInfo.Arguments = "c:\\DATA\\DPRESUPUESTO_LOTE.xlsx";
                Process.Start(startInfo); 
            }
                if (chk_variedad.Checked)
            {
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("dpresupuesto_variedad");
                worksheet.Cell(1, 1).Value = "IdEmpresa";
                worksheet.Cell(1, 1).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE COD: 001");
                worksheet.Cell(1, 2).Value = "idPresupuesto";
                worksheet.Cell(1, 2).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE , REVISE EN LA TABLA DE PRESUPUESTOS, FORMATO TEXTO");
                worksheet.Cell(1, 3).Value = "IDCULTIVO";
                worksheet.Cell(1, 3).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE , REVISE EN LA TABLA DE CULTIVOS, FORMATO TEXTO");
                worksheet.Cell(1, 4).Value = "IdVariedad";
                worksheet.Cell(1, 4).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE , REVISE EN LA TABLA DE VARIEDADES, FORMATO TEXTO");
                worksheet.Cell(1, 5).Value = "IdEtapa";
                worksheet.Cell(1, 6).Value = "IdEstructura";
                worksheet.Cell(1, 6).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE , REVISE EN LA TABLA DE ESTRUCTURAS SEGUN EL CULTIVO, FORMATO TEXTO");
                worksheet.Cell(1, 7).Value = "IdTipoCosto";
                worksheet.Cell(1, 7).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE , REVISE EN LA TABLA DE TIPOS DE COSTO, FORMATO TEXTO");
                worksheet.Cell(1, 8).Value = "IdItemCosto";
                worksheet.Cell(1, 8).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE , REVISE EN LA TABLA DE ITEM DE COSTO, FORMATO TEXTO");
                worksheet.Cell(1, 9).Value = "IdActividadSubGru";
                worksheet.Cell(1, 10).Value = "IdLaborProducto";
                worksheet.Cell(1, 10).Comment.SetAuthor("RGUARDADO").AddText("SE DEBE LLENAR IdActividadSubGru SI LLENA ESTE CAMPO, FORMATO TEXTO");
                worksheet.Cell(1, 11).Value = "IdUnidad";
                worksheet.Cell(1, 11).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE , REVISE EN LA TABLA DE UNIDADES, FORMATO TEXTO");
                worksheet.Cell(1, 12).Value = "con_igv";
                worksheet.Cell(1, 12).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE ,O= NO TIENE IGV ,1= TIENE IGV");
                worksheet.Cell(1, 13).Value = "Periodo";
                worksheet.Cell(1, 14).Value = "semana";
                worksheet.Cell(1, 14).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE ,DE 1 A 52 SEMANAS, FORMATO TEXTO");
                worksheet.Cell(1, 15).Value = "Cantidad";
                worksheet.Cell(1, 15).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE , FORMATO NUMERICO ##,#### CON 4 DECIMALES");
                worksheet.Cell(1, 16).Value = "Costo";
                worksheet.Cell(1, 16).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE , FORMATO NUMERICO ##,#### CON 4 DECIMALES");
                worksheet.Cell(1, 17).Value = "IdMoneda";
                worksheet.Cell(1, 17).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE ,01=SOLES,02 DOLARES - COLOCAR EN FORMATO TEXTO");
                worksheet.Cell(1, 18).Value = "dias_pago";
                worksheet.Cell(1, 19).Value = "IDOBJETIVO";
                worksheet.Cell(1, 20).Value = "IdSubItemCosto";
                worksheet.Cell(1, 20).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE , REVISE LA TABLA SUBITEMCOSTO, FORMATO TEXTO");
                worksheet.Cell(1, 21).Value = "IDFUNDO";
                worksheet.Cell(1, 21).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE , REVISE LA TABLA FUNDOS, FORMATO TEXTO");
               // worksheet.Cell(1, 22).Value = "IDLOTE";
              //  worksheet.Cell(1, 22).Comment.SetAuthor("RGUARDADO").AddText("ESTE DATO ES INDISPENSABLE , REVISE LA TABLA LOTES, FORMATO TEXTO");
                worksheet.Range("A1:U1").Style
         .Font.SetFontSize(12)
         .Font.SetBold(false)
        .Font.SetFontColor(XLColor.Black)
         .Fill.SetBackgroundColor(XLColor.EarthYellow);
                workbook.SaveAs("c:\\temp\\DPRESUPUESTO_VARIEDAD.xlsx");
                //Process.start("EXCEL.EXE","c:\\temp\\excel.xlsx");
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "EXCEL.EXE";
                startInfo.Arguments = "c:\\temp\\DPRESUPUESTO_VARIEDAD.xlsx";
                Process.Start(startInfo);
            }

            if (chk_plantillagastofijo.Checked)
            {



            }
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

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            IDITEMCOSTO_US = Convert.ToString(cbo_icosto.EditValue);
            IDCULTIVO_US = Convert.ToString(cbo_cultivo.EditValue);
            mensaje = "";
            errorinsert = "";
            CONTADOR = 0;
            Thread HILO = new Thread(Procesar);
            HILO.Start();
            timer1.Start();
            estado = "N";
            Bloquearbotones(true);
        }
        private void Bloquearbotones(bool valor)
        {
            btn_update.Enabled = !valor;
            cbo_icosto.Enabled = !valor;
            cbo_cultivo.Enabled = !valor;
            chk_lote.ReadOnly = valor;
            chk_variedad.ReadOnly = valor;
            chk_eliminardata.ReadOnly = valor;
            btn_generarplantilla.Enabled = !valor;
            btn_actualizar.Enabled = !valor;
            bar_progreso.Visible = valor;
            lb_progreso.Visible = valor;
        }
        private void Procesar()
        {
            if (tipo.Equals("L"))
            {
               try
               {
                    string ext = Path.GetExtension(txt_ruta.Text);
                    string hoja = "dpresupuesto_lote";
                    DataTable dtlote = new DataTable();
                    dtlote = VariablesGenerales.ImportarExcel(txt_ruta.Text, ext, hoja);
                    if (dtlote.Rows.Count > 0)
                    {
                        if (dtlote.Columns.Count > 22 || dtlote.Columns.Count < 22)
                        {
                            MessageBox.Show(@"El archivo no es correcto , intente abrir el archivo correcto ");
                            estado = "S";
                        }
                        else
                        {
                            CONTADOR = 0;
                            foreach (DataRow row in dtlote.Rows)
                            {
                                 idempresa = row[0].ToString().Trim();
                                 idpresupuesto = row[1].ToString().Trim();
                                 idcultivo = row[2].ToString().Trim();
                                 IdVariedad= row[3].ToString().Trim();
                                 idetapa = row[4].ToString().Trim();
                                 idestructura = row[5].ToString().Trim();
                                 idtipocosto = row[6].ToString().Trim();
                                 iditemcosto = row[7].ToString().Trim();
                                 idactividadsubgru = row[8].ToString().Trim();
                                 idlaborproducto = row[9].ToString().Trim();
                                 idunidad = row[10].ToString().Trim();
                                 con_igv = Convert.ToInt32(row[11].ToString());
                                 periodo = row[12].ToString().Trim();
                                 semana = row[13].ToString().Trim();
                                 cantidad = Convert.ToDecimal(row[14].ToString());
                                 costo = Convert.ToDecimal(row[15].ToString());
                                 idmoneda = row[16].ToString().Trim();
                                 dias_pago = Convert.ToInt32( row[17].ToString());
                                 idobjetivo = row[18].ToString().Trim();
                                 idsubitemcosto = row[19].ToString().Trim();
                                 idfundo = row[20].ToString().Trim();
                                 idlote = row[21].ToString().Trim();
                                CONTADOR++;
                                string validar = ValidarxLote(idempresa,idpresupuesto,idcultivo,IdVariedad,idetapa,idestructura,idtipocosto,iditemcosto,idactividadsubgru,idlaborproducto,idunidad,con_igv,periodo,semana,cantidad,costo,idmoneda,dias_pago,idobjetivo,idsubitemcosto,idfundo,idlote,IDITEMCOSTO_US,IDCULTIVO_US);
                                mensajeprogreso = "Validando  Registro N° " + Convert.ToString(CONTADOR);
                                if (!validar.Equals("Ok"))
                                {
                                    mensaje = validar + " Registro N° " + CONTADOR;
                                }
                            }

                            if (mensaje.Equals(""))
                            {
                               if (eliminarData.Equals("S"))
                               {
                                   string pro = NFunciones.ExecuteSQL("DELETE P_DPRESUPUESTO_LOTE WHERE IdItemCosto='" + IDITEMCOSTO_US + "' AND IDCULTIVO='" + IDCULTIVO_US + "'");
                                   mensajeprogreso = !pro.Equals("Ok") ? "No se ha Podido Eliminar la Data Anterior !!" : "Se elimino la Data anterior !!";
                               }
                               
                                CONTADOR = 0;
                                foreach (DataRow row in dtlote.Rows)
                                {
                                    idempresa = row[0].ToString().Trim();
                                    idpresupuesto = row[1].ToString().Trim();
                                    idcultivo = row[2].ToString().Trim();
                                    IdVariedad = row[3].ToString().Trim();
                                    idetapa = row[4].ToString().Trim();
                                    idestructura = row[5].ToString().Trim();
                                    idtipocosto = row[6].ToString().Trim();
                                    iditemcosto = row[7].ToString().Trim();
                                    idactividadsubgru = row[8].ToString().Trim();
                                    idlaborproducto = row[9].ToString().Trim();
                                    idunidad = row[10].ToString().Trim();
                                    con_igv = Convert.ToInt32(row[11].ToString());
                                    periodo = row[12].ToString().Trim();
                                    semana = row[13].ToString().Trim();
                                    cantidad = Convert.ToDecimal(row[14].ToString());
                                    costo = Convert.ToDecimal(row[15].ToString());
                                    idmoneda = row[16].ToString().Trim();
                                    dias_pago = Convert.ToInt32(row[17].ToString());
                                    idobjetivo = row[18].ToString().Trim();
                                    idsubitemcosto = row[19].ToString().Trim();
                                    idfundo = row[20].ToString().Trim();
                                    idlote = row[21].ToString().Trim();
                                    CONTADOR++;
                                    string rpta = NFunciones.ExecuteSQL("INSERT INTO  P_DPRESUPUESTO_LOTE( IdEmpresa ,idPresupuesto ,IDCULTIVO ,IdVariedad , IdEtapa ," +
                                    "IdEstructura, IdTipoCosto, IdItemCosto, IdActividadSubGru, IdLaborProducto, IdUnidad, con_igv," +
                                    "Periodo, semana, Cantidad, Costo, IdMoneda, dias_pago, IDOBJETIVO, IdSubItemCosto, IDFUNDO, IdLote)" +
                                    "VALUES('" + idempresa + "','" + idpresupuesto + "','" + idcultivo + "','" + IdVariedad + "','" + idetapa + "','" + idestructura + "','" + idtipocosto + "','" + iditemcosto + "','" + idactividadsubgru + "','" + idlaborproducto + "','" + idunidad + "','" + con_igv + "','" + periodo + "','" + semana + "','" + cantidad + "','" + costo + "','" + idmoneda + "','" + dias_pago + "','" + idobjetivo + "','" + idsubitemcosto + "','" + idfundo + "','" + idlote + "')");
                                    mensajeprogreso = "Insertando Registro N° " + Convert.ToString(CONTADOR);
                                    //MessageBox.Show(rpta);
                                    if (!rpta.Equals("Ok"))
                                    {
                                        errorinsert = errorinsert + " " + rpta + "Registro N° " + Convert.ToString(CONTADOR) + "\n";
                                    }
                                }
                            }
                            else
                            {
                                errorinsert = errorinsert  +" " + mensaje + "\n";
                            }
                        }
                        if (errorinsert.Equals(""))
                        {
                            MessageBox.Show(@"Importando Correctamente");
                        }
                        else
                        {
                            MessageBox.Show(@"ERRORES : " +"\n" +errorinsert);
                        }
                     //   dataGridView1.DataSource = dtlote;
                    }

                    estado = "S";
                }
               catch (Exception EX)
                {
                    estado = "S";
                    MessageBox.Show(EX.Message);
                }
            }
            if (tipo.Equals("V"))
            {

                //try
                //{
                    string ext = Path.GetExtension(txt_ruta.Text);
                    string hoja = "dpresupuesto_variedad";
                    DataTable dtlote = new DataTable();
                    dtlote = VariablesGenerales.ImportarExcel(txt_ruta.Text, ext, hoja);
                    if (dtlote.Rows.Count > 0)
                    {
                        //string nrows = Convert.ToString(dtlote.Columns.Count);
                        //MessageBox.Show(nrows);
                        //if (nrows.Equals("21"))
                        //{
                        //    MessageBox.Show("El archivo no es correcto , intente abrir el archivo correcto ");
                        //    errorinsert = errorinsert + "El archivo no es el correcto";
                        //    estado = "S";
                        //}
                        //else
                        //{

                            foreach (DataRow row in dtlote.Rows)
                            {
                                idempresa = row[0].ToString().Trim();
                                idpresupuesto = row[1].ToString().Trim();
                                idcultivo = row[2].ToString().Trim();
                                IdVariedad = row[3].ToString().Trim();
                                idetapa = row[4].ToString().Trim();
                                idestructura = row[5].ToString().Trim();
                                idtipocosto = row[6].ToString().Trim();
                                iditemcosto = row[7].ToString().Trim();
                                idactividadsubgru = row[8].ToString().Trim();
                                idlaborproducto = row[9].ToString().Trim();
                                idunidad = row[10].ToString().Trim();
                                con_igv = Convert.ToInt32(row[11].ToString());
                                periodo = row[12].ToString().Trim();
                                semana = row[13].ToString().Trim();
                                cantidad = Convert.ToDecimal(row[14].ToString());
                                costo = Convert.ToDecimal(row[15].ToString());
                                idmoneda = row[16].ToString().Trim();
                                dias_pago = Convert.ToInt32(row[17].ToString());
                                idobjetivo = row[18].ToString().Trim();
                                idsubitemcosto = row[19].ToString().Trim();
                                idfundo = row[20].ToString().Trim();
                        // idlote = row[21].ToString().Trim();
                        CONTADOR++;
                      
                        string validar = Validarxvariedad(idempresa, idpresupuesto, idcultivo, IdVariedad, idetapa, idestructura, idtipocosto, iditemcosto, idactividadsubgru, idlaborproducto, idunidad, con_igv, periodo, semana, cantidad, costo, idmoneda, dias_pago, idobjetivo, idsubitemcosto, idfundo, IDITEMCOSTO_US, IDCULTIVO_US);
                        mensajeprogreso = "Validando  Registro N° " + Convert.ToString(CONTADOR);
                        if (!validar.Equals("Ok"))
                                {
                                    mensaje = validar + " Registro N° " + CONTADOR;
                                }
                            }

                            if (mensaje.Equals(""))
                            {


                        if (eliminarData.Equals("S"))
                        {
                            string pro = NFunciones.ExecuteSQL("DELETE P_DPRESUPUESTO_RG WHERE IdItemCosto='" + IDITEMCOSTO_US + "' AND IDCULTIVO='" + IDCULTIVO_US + "'");
                            if (!pro.Equals("Ok"))
                            {
                                mensajeprogreso = "No se ha Podido Eliminar la Data Anterior !!";
                            }
                            else
                            {
                                mensajeprogreso = "Se elimino la Data anterior !!";
                            }
                        }
                        CONTADOR = 0;
                                foreach (DataRow row in dtlote.Rows)
                                {
                                    idempresa = row[0].ToString().Trim();
                                    idpresupuesto = row[1].ToString().Trim();
                                    idcultivo = row[2].ToString().Trim();
                                    IdVariedad = row[3].ToString().Trim();
                                    idetapa = row[4].ToString().Trim();
                                    idestructura = row[5].ToString().Trim();
                                    idtipocosto = row[6].ToString().Trim();
                                    iditemcosto = row[7].ToString().Trim();
                                    idactividadsubgru = row[8].ToString().Trim();
                                    idlaborproducto = row[9].ToString().Trim();
                                    idunidad = row[10].ToString().Trim();
                                    con_igv = Convert.ToInt32(row[11].ToString());
                                    periodo = row[12].ToString().Trim();
                                    semana = row[13].ToString().Trim();
                                    cantidad = Convert.ToDecimal(row[14].ToString());
                                    costo = Convert.ToDecimal(row[15].ToString());
                                    idmoneda = row[16].ToString().Trim();
                                    dias_pago = Convert.ToInt32(row[17].ToString());
                                    idobjetivo = row[18].ToString().Trim();
                                    idsubitemcosto = row[19].ToString().Trim();
                                    idfundo = row[20].ToString().Trim();
                            //idlote = row[21].ToString().Trim();
                            CONTADOR++;
                            string rpta = NFunciones.ExecuteSQL("INSERT INTO  P_DPRESUPUESTO_RG( IdEmpresa ,idPresupuesto ,IDCULTIVO ,IdVariedad , IdEtapa ," +
                                    "IdEstructura, IdTipoCosto, IdItemCosto, IdActividadSubGru, IdLaborProducto, IdUnidad, con_igv," +
                                    "Periodo, semana, Cantidad, Costo, IdMoneda, dias_pago, IDOBJETIVO, IdSubItemCosto, IDFUNDO)" +
                                    "VALUES('" + idempresa + "','" + idpresupuesto + "','" + idcultivo + "','" + IdVariedad + "','" + idetapa + "','" + idestructura + "','" + idtipocosto + "','" + iditemcosto + "','" + idactividadsubgru + "','" + idlaborproducto + "','" + idunidad + "','" + con_igv + "','" + periodo + "','" + semana + "','" + cantidad + "','" + costo + "','" + idmoneda + "','" + dias_pago + "','" + idobjetivo + "','" + idsubitemcosto + "','" + idfundo + "')");
                            mensajeprogreso = "Insertando Registro N° " + Convert.ToString(CONTADOR);
                            if (!rpta.Equals("Ok"))
                                    {
                                    errorinsert = errorinsert + " " + rpta + "Registro N° " + Convert.ToString(CONTADOR) + "\n";
                                    }
                                }
                            }
                            else
                            {
                                errorinsert = errorinsert + " " + mensaje + "\n";
                            }


                        if (errorinsert.Equals(""))
                        {
                            MessageBox.Show(@"Importando Correctamente");
                        }
                        else
                        {
                            MessageBox.Show(@"ERRORES : " + "\n" + errorinsert);
                        }
                     //   dataGridView1.DataSource = dtlote;
                    }

                    estado = "S";
                //}
                //catch (Exception EX)
                //{
                //    estado = "S";
                //    MessageBox.Show(EX.Message);
                //}
            }
        }

        private static string ValidarxLote(string idempresa,string idpresupuesto, string idcultivo,string IdVariedad,string idetapa,string idestructura,string idtipocosto, string iditemcosto,string idactividadsubgru,string idlaborproducto , string idunidad , int con_igv,string periodo,string semana,decimal cantidad , decimal costo,string idmoneda,int dias_pago,string idobjetivo,string idsubitemcosto ,string idfundo, string idlote,string IDITEMCOSTO_USER, string IDCULTIVO_USER)
        {
            string valor;
            valor = "";
            DataTable dtvalidar = new DataTable();
            dtvalidar = NFunciones.TABLADATOS("EXEC SP_VALIDAR_DPRESUPUESTO_LOTE'"+idempresa+"','"+idpresupuesto+"','"+idcultivo+"','"+IdVariedad+"','"+idetapa+"','"+idestructura+"','"+idtipocosto+"','"+iditemcosto+"','"+idactividadsubgru+"','"+idlaborproducto+"','"+idunidad+"','"+con_igv+"','"+periodo+"','"+semana+"','"+cantidad+"','"+costo+"','"+idmoneda+"','"+dias_pago+"','"+idobjetivo+"','"+idsubitemcosto+"','"+idfundo+"','"+idlote+"','"+IDITEMCOSTO_USER+"','"+IDCULTIVO_USER+"'");
            if (dtvalidar.Rows.Count > 0)
            {
                valor = dtvalidar.Rows[0]["ERRORES"].ToString();
            }
            else
            {
                valor = "ERROR DE CONEXION";
            }
            return valor;
        }
        private static string Validarxvariedad(string idempresa, string idpresupuesto, string idcultivo, string IdVariedad, string idetapa, string idestructura, string idtipocosto, string iditemcosto, string idactividadsubgru, string idlaborproducto, string idunidad, int con_igv, string periodo, string semana, decimal cantidad, decimal costo, string idmoneda, int dias_pago, string idobjetivo, string idsubitemcosto, string idfundo, string IDITEMCOSTO_USER, string IDCULTIVO_USER)
        {
            string valor;
            valor = "";
            DataTable dtvalidar = new DataTable();
            dtvalidar = NFunciones.TABLADATOS("EXEC SP_VALIDAR_DPRESUPUESTO_VARIEDAD'" + idempresa + "','" + idpresupuesto + "','" + idcultivo + "','" + IdVariedad + "','" + idetapa + "','" + idestructura + "','" + idtipocosto + "','" + iditemcosto + "','" + idactividadsubgru + "','" + idlaborproducto + "','" + idunidad + "','" + con_igv + "','" + periodo + "','" + semana + "','" + cantidad + "','" + costo + "','" + idmoneda + "','" + dias_pago + "','" + idobjetivo + "','" + idsubitemcosto + "','" + idfundo + "','" + IDITEMCOSTO_USER + "','" + IDCULTIVO_USER + "'");
            if (dtvalidar.Rows.Count > 0)
            {
                valor = dtvalidar.Rows[0]["ERRORES"].ToString();
            }
            else
            {
                valor = "ERROR DE CONEXION";
            }
            return valor;
        }
    }
}
