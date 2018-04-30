using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using ClosedXML.Excel;
using System.Diagnostics;
using System.Data.OleDb;
using CapaNegocios;

namespace DXApplication1
{
    public partial class Frm_ImporVentas : DevExpress.XtraEditors.XtraForm
    {
        string estado="";
        DataTable dtlote = new DataTable();
        public Frm_ImporVentas()
        {
            InitializeComponent();
        }

        private void btn_generarplantilla_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = "c:\\DATA";
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("ImportarVentas");

                worksheet.Cell(1, 1).Value = "IDEMPRESA";
                worksheet.Cell(1, 1).Comment.SetAuthor("WARSOFT").AddText("INGRESE EL CODIGO DE LA EMPRESA TODOS LOS DIGITOS");
                worksheet.Cell(1, 2).Value = "IDDOCUMENTO";
                worksheet.Cell(1, 2).Comment.SetAuthor("WARSOFT").AddText("INGRESE EL CODIGO DE DOCUMENTO EJEMPLO FACTURA : FAC");
                worksheet.Cell(1, 3).Value = "SERIE";
                worksheet.Cell(1, 3).Comment.SetAuthor("WARSOFT").AddText("INGRESE SERIE DEL DOCUMENTO, SE ACEPTA 4 DIGITOS");
                worksheet.Cell(1, 4).Value = "NUMERO";
                worksheet.Cell(1, 4).Comment.SetAuthor("WARSOFT").AddText("INGRESE NUMERO DE DOCUMENTO , SE ACEPTA 7 DIGITOS");
                worksheet.Cell(1, 5).Value = "CODCLIENTE";
                worksheet.Cell(1, 5).Comment.SetAuthor("WARSOFT").AddText("CODIGO DE CLIENTE REGISTRADO EN EL SISTEMA");
                worksheet.Cell(1, 6).Value = "FECHA";
                worksheet.Cell(1, 6).Comment.SetAuthor("WARSOFT").AddText("FECHA DEL DOCUMENTO CON FORMATO (AAAAMMDD)");
                worksheet.Cell(1, 7).Value = "IDMONEDA";
                worksheet.Cell(1, 7).Comment.SetAuthor("WARSOFT").AddText("CODIGO DE MONEDA SOLES : 01, DOLARES : 02");
                worksheet.Cell(1, 8).Value = "TC";
                worksheet.Cell(1, 8).Comment.SetAuthor("WARSOFT").AddText("TIPO DE CAMBIO DE LA OPERACION");
                worksheet.Cell(1, 9).Value = "ITEM";
                worksheet.Cell(1, 9).Comment.SetAuthor("WARSOFT").AddText("ITEM CORRELATIVO DEL DETALLE");
                worksheet.Cell(1, 10).Value = "CODPRODUCTO";
                worksheet.Cell(1, 10).Comment.SetAuthor("WARSOFT").AddText("CODIGO DEL PRODUCTO");
                worksheet.Cell(1, 11).Value = "CANTIDAD";
                worksheet.Cell(1, 11).Comment.SetAuthor("WARSOFT").AddText("INGRESE LA CANTIDAD VENDIDA");
                worksheet.Cell(1, 12).Value = "PORC_IMP";
                worksheet.Cell(1, 12).Comment.SetAuthor("WARSOFT").AddText("% DE IMPUESTO SI HUBIERA , SINO DEJAR CON CERO (0)");
                worksheet.Cell(1, 13).Value = "PRECIOUNIT";
                worksheet.Cell(1, 13).Comment.SetAuthor("WARSOFT").AddText("PRECIO UNITARIO DEL PRODUCTO");
             
                worksheet.Range("A1:O1").Style
      .Font.SetFontSize(12)
      .Font.SetBold(false)
      .Font.SetFontColor(XLColor.Black)
      .Fill.SetBackgroundColor(XLColor.EarthYellow);
        workbook.SaveAs("c:\\DATA\\PLANTILLA_VENTAS.xlsx");
       ProcessStartInfo startInfo = new ProcessStartInfo();
       startInfo.FileName = "EXCEL.EXE";
       startInfo.Arguments = "c:\\DATA\\PLANTILLA_VENTAS.xlsx";
        Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            //le agregamos un filtro para los tipos de archivos a leer en este caso XML.
            open.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx";
            if (open.ShowDialog() == DialogResult.OK && open.ToString() != " ")
            {
                txt_ruta.Text = open.FileName;
            }
        }

        public static DataTable ImportarExcel(string FilePath, string ext, string hoja)
        {
            string connectionString = "";
            if (ext == ".xls")
            {   //de Excel 97-03
                connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = " + FilePath + "; Extended Properties = 'Excel 8.0;HDR={1}'";
            }
            else if (ext == ".xlsx")
            {    //de Excel 07 para adelante
                connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = " + FilePath + "; Extended Properties = 'Excel 8.0;HDR={1}'";
            }
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand oconn = new OleDbCommand("Select * From [" + hoja + "$]", con);
            con.Open();

            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            DataTable data = new DataTable();
            sda.Fill(data);

            return data;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string ext = Path.GetExtension(txt_ruta.Text);
                string hoja = "ImportarVentas";
                dtlote = ImportarExcel(txt_ruta.Text, ext, hoja);

                if (dtlote.Rows.Count>0)
                {

                    if (dtlote.Columns.Count > 13 || dtlote.Columns.Count < 13)
                    {
                        MessageBox.Show(@"El archivo no es correcto , intente abrir el archivo correcto ");
                        estado = "S";
                    }
                    else
                    {
                       
                        //
                        string errores="";
                        int contador = 0;
                        string ruta = "c:\\DATA";
                        string rutaCompleta = ruta + "\\" +"Errores.txt";
                        if (!Directory.Exists(ruta))
                        {
                            Directory.CreateDirectory(ruta);
                        }

                        if (File.Exists(rutaCompleta))
                        {
                            File.Delete(rutaCompleta);
                        }

                        foreach (DataRow row in dtlote.Rows)
                        {
                            contador++;
                            if (row[0].ToString().Length < 3 || row[0].ToString().Length > 3)
                            {
                                errores = "Debe Tener 3 digitos "+"\n";
                            }
                            DataTable dtemp = NFunciones.TABLASQL("select * from tb_empresa where idempresa='"+ row[0].ToString() + "'");
                            if (dtemp.Rows.Count == 0)
                            {
                                errores = "No Existe la Empresa "+ "\n";
                            }

                            DataTable dtDOC = NFunciones.TABLASQL("SELECT * FROM TB_DOCUMENTOS WHERE iddocumento='"+ row[1].ToString() + "'");

                            if (dtDOC.Rows.Count==0)
                            {
                                errores = "No Existe el documento"+ "\n";
                            }
                            if (row[2].ToString().Length < 4 || row[2].ToString().Length > 4)
                            {
                                errores = "Debe Tener 4 digitos : serie "+ "\n";
                                MessageBox.Show(row[2].ToString());
                            }

                            if (row[3].ToString().Length < 7 || row[3].ToString().Length > 7)
                            {
                                errores = "Debe Tener 7 digitos : Numero"+ "\n";
                            }
                            DataTable dtclieprv = NFunciones.TABLASQL("select * from tb_clieprov where idclieprov='"+ row[4].ToString() + "' and idempresa='"+ row[0].ToString() + "' and tipoclieprov in ('001','003')");
                            if (dtemp.Rows.Count == 0)
                            {
                                errores = "No Existe la Codigo de Cliente "+ "\n"; 
                            }
                            if (string.IsNullOrEmpty(row[5].ToString()))
                            {
                                errores = "Debe ingresar fecha : idempresa " + "\n";
                            }

                            //moneda
                            DataTable dtidmoneda = NFunciones.TABLASQL("select * from tb_moneda where idmoneda='"+ row[6].ToString() + "'");
                            if (dtidmoneda.Rows.Count == 0)
                            {
                                errores = "No Existe el moneda " + "\n";
                            }
                            //tc
                            if (string.IsNullOrEmpty(row[7].ToString()))
                            {
                                errores = "Debe ingresar : T.C " + "\n";
                            }
                            if (Convert.ToDouble(row[7].ToString())<1)
                            {
                                errores = "Debe ingresar : T.C " + "\n";
                            }
                            //producto

                            DataTable dtproduc = NFunciones.TABLASQL("select * from tb_productos where idproducto='"+ row[9].ToString() + "' and idempresa='"+ row[0].ToString() + "'");
                            if (dtproduc.Rows.Count == 0)
                            {
                                errores = "No Existe el Producto " + "\n";
                            }
                            //cantidad
                            if (string.IsNullOrEmpty(row[10].ToString()))
                            {
                                errores = "Debe ingresar : Cantidad " + "\n";
  
                            }
                            if (Convert.ToDouble(row[10].ToString()) < 0)
                            {
                                errores = "Debe ingresar : Cantidad " + "\n";
         
                            }

                            if (Convert.ToDouble(row[12].ToString()) < 0)
                            {
                                errores = "Debe ingresar : Precio Unitario"+ "\n";
                               
                            }
                            DataTable dtventas = NFunciones.TABLASQL("SELECT * FROM tb_cobrarpagardoc where iddocumento='"+ row[1].ToString() + "' and serie='" + row[2].ToString() + "' and numero='" + row[3].ToString() + "' and idclieprov='" + row[4].ToString() + "' and idempresa='" + row[0].ToString() + "'");
                            if (dtventas.Rows.Count > 0)
                            {
                                errores = "Ya existe el documento : "+  row[1].ToString()+" "+  row[2].ToString()+"-"+  row[3].ToString() + "\n";
                            }

                        }

                        if (!errores.Equals(""))
                        {
                            using (StreamWriter file = new StreamWriter(rutaCompleta, true))
                            {
                                file.WriteLine("Lista de Errores encontrados , Revisar !!! - WARSOFT SOLUCIONES INFORMATICAS");
                                file.WriteLine(errores);
                                file.Close();
                                ProcessStartInfo psi = new ProcessStartInfo("notepad.exe", rutaCompleta);
                                Process p = Process.Start(psi);
                            }
                        }else
                        {
                            Insertando();
                            
                        }

                   }

                }
            }
            catch (Exception ex)
            {

            }
        }

        void Insertando()
        {
            //VARIABLES A SUBIR 
            //cabecera
            string iidcobrarpagardoc, idempresa, iddocumento, serie, numero, idclieprov, razonsocial, estado, tipo, idmoneda;
            DateTime fecha;
            //detalle
            string idempresa_det, idcobrarpagar_det, item, idproducto_det, descripcion_det, idunidad_det;
            double cantidad_det, porc_imp, imp, precio_unit, preciototal, tc;
            string error = "";
            int correlativo = 0;
            foreach (DataRow row in dtlote.Rows)
            {

                
                correlativo = correlativo + 1;
                string id = "V" + DateTime.Now.Date.Day.ToString() + DateTime.Now.Date.Month.ToString() + DateTime.Now.Date.Year.ToString() + DateTime.Now.Hour.ToString() +
                DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + VariablesGenerales.Empresa+Convert.ToString(correlativo);
                string rpta = NFunciones.ExecuteSQL("EXEC INSERT_VENTAS '" + id + "','"+VariablesGenerales.Empresa+"','"+row[1].ToString()+"','"+ row[2].ToString() + "','"+ row[3].ToString() + "','"+ row[4].ToString() + "','"+ row[5].ToString() + "','"+ row[6].ToString() + "','"+ row[7].ToString() + "','"+ row[9].ToString() + "','"+ row[10].ToString() + "','"+ row[12].ToString() + "'");
                if (!rpta.Equals("Ok"))
                {
                    error = "Error de registro :"+ row[1].ToString()+" "+ row[2].ToString()+"-"+ row[3].ToString()+"\n";
                }
            }
            if (!string.IsNullOrEmpty(error))

                MessageBox.Show("Tiene los siguientes errores :" + error);
            else
                MessageBox.Show("Importado Correctamente");
        }
    }
}