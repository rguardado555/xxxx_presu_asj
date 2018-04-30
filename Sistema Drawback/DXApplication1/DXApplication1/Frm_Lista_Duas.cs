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
using CapaNegocios;
using System.IO;
using System.Diagnostics;

namespace DXApplication1
{
    public partial class Frm_Lista_Duas : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Lista_Duas()
        {
            InitializeComponent();
        }

        private void btn_nuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Duas Objduas = new Frm_Duas("","N");
            Objduas.Show();
        }

        private void Frm_Lista_Duas_Load(object sender, EventArgs e)
        {
            LlegarGrilla();
        }

        void LlegarGrilla()
        {
            dtg_datos.DataSource = NFunciones.TABLASQL("SELECT D.iddua ID , 'DUA - '+D.ndua DUA,D.fecha FECHA, CASE ISNULL(D.TXT,0) WHEN 0 THEN 'SIN GENERAR TXT' ELSE 'TXT YA GENERADO' END ESTADO,D.importerecuperacion FOB,C.iddocumento+' '+C.serie+' '+C.numero REF  FROM tb_dua D LEFT JOIN  tb_cobrarpagardoc C ON C.idempresa=D.idempresa AND C.idcobrarpagardoc=D.idcobrarpagardoc WHERE D.idempresa='"+VariablesGenerales.Empresa+"'");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (VariablesGenerales.refduas.Equals("S"))
            {
                VariablesGenerales.refduas = "N";
                LlegarGrilla();
            }
        }

        private void dtg_datos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Frm_Duas ObJduas = new Frm_Duas(Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)), "V");
                ObJduas.ShowDialog();
            }
            catch
            {

            }
        }

        private void btn_editar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void btn_eliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            try
            {
                DialogResult rpta = MessageBox.Show("Desea Eliminar este registro ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rpta == DialogResult.Yes)
                {
                    DataTable tbdua = NFunciones.TABLASQL("SELECT * FROM TB_DUA WHERE IDDUA='" + Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)) + "' AND IDEMPRESA='" + VariablesGenerales.Empresa + "'");
                    string cabecera = NFunciones.ExecuteSQL("delete tb_dua where iddua='" + Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)) + "'and idempresa='" + VariablesGenerales.Empresa + "'");

                    string referencia = NFunciones.ExecuteSQL("delete tb_docreferencia where idempresa='" + VariablesGenerales.Empresa + "' and iddestino='" + Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)) + "'");
                    // insertar exportacion
                    string exportacion = NFunciones.ExecuteSQL("update tb_dcobrarpagardoc set idref='NULL' where idcobrarpagardoc='" + tbdua.Rows[0]["idcobrarpagardoc"].ToString() + "'");
                    //insertar insumos
                    string deleteinsumos = NFunciones.ExecuteSQL("delete tb_movcobrarpagardoc_drakback where idtransaccion='" + Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)) + "' and idempresa='" + VariablesGenerales.Empresa + "'");
                    VariablesGenerales.refduas = "S";
                    MessageBox.Show("Dua eliminada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Elija un registro ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           
        }

        private void btn_txt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string texto = Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID))+ Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_DOCUMENTO)) + ".txt" ;
                string ruta = "c:\\DATA";
                string rutaCompleta = ruta+"\\"+texto;
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                if (File.Exists(rutaCompleta))
                {
                    File.Delete(rutaCompleta);
                }

                DataTable tb_cabecera = NFunciones.TABLASQL("SELECT 0 INDICADOR,E.codigo_aduanas ADUANA,YEAR(D.fecha)ANOP,D.ndua DUA,D.regimen REGIMEN,1 SERIE,D.importerecuperacion FOB,'N' PRODUCCION FROM tb_dua D INNER JOIN tb_empresa E ON D.idempresa=E.idempresa INNER JOIN tb_cobrarpagardoc C ON C.idempresa=E.idempresa AND C.idcobrarpagardoc=D.idcobrarpagardoc WHERE D.idempresa='001' AND D.IDDUA='"+ Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)) + "'");
                DataTable tb_exportacion = NFunciones.TABLASQL("SELECT 1 INDICADOR,'00' FACTURA,C.ruc RUC,T.serie SERIE,T.numero NUMERO,SUBSTRING(CONVERT(NVARCHAR(8),T.fecha,112),7,2)+SUBSTRING(CONVERT(NVARCHAR(8),T.fecha,112),5,2)+SUBSTRING(CONVERT(NVARCHAR(8),T.fecha,112),1,4) FECHA, RIGHT('000' + Ltrim(Rtrim(D.item)),3)  ITEM,D.cantidad CANT,D.cantidad CANT_SERIE,D.idunidad MEDIDA,D.descripcion MERCADERIA FROM tb_cobrarpagardoc T  INNER JOIN tb_clieprov C ON C.idempresa=T.idempresa AND T.idclieprov=C.idclieprov INNER JOIN tb_dcobrarpagardoc D ON D.idcobrarpagardoc=T.idcobrarpagardoc AND D.idempresa=T.idempresa WHERE T.idcobrarpagardoc IN (SELECT idorigen FROM tb_docreferencia WHERE iddestino='"+ Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)) + "' AND idempresa='"+VariablesGenerales.Empresa+"')");
                DataTable tb_insumos = NFunciones.TABLASQL("EXEC SP_DETALLE_DAM'"+ Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)) + "'");

                if (tb_cabecera.Rows.Count==1)
                {

                    string cabecera = tb_cabecera.Rows[0]["INDICADOR"].ToString()+"|";
                    cabecera = cabecera + tb_cabecera.Rows[0]["ADUANA"].ToString() + "|";
                    cabecera = cabecera + tb_cabecera.Rows[0]["ANOP"].ToString() + "|";
                    cabecera = cabecera + tb_cabecera.Rows[0]["DUA"].ToString() + "|";
                    cabecera = cabecera + tb_cabecera.Rows[0]["REGIMEN"].ToString() + "|";
                    cabecera = cabecera + tb_cabecera.Rows[0]["SERIE"].ToString() + "|";
                    cabecera = cabecera + tb_cabecera.Rows[0]["FOB"].ToString() + "|";
                    cabecera = cabecera + tb_cabecera.Rows[0]["PRODUCCION"].ToString() ;
                    using (StreamWriter file = new StreamWriter(rutaCompleta, true))
                    {
                        file.WriteLine(cabecera); //se agrega información al documento
                       
                        foreach (DataRow row in tb_exportacion.Rows)
                        {
                            string exportacion = row["INDICADOR"].ToString().ToUpper().Trim() + "|"+ row["FACTURA"].ToString().ToUpper().Trim() + "|"+row["RUC"].ToString().ToUpper().Trim() + "|"+ row["SERIE"].ToString().ToUpper().Trim() + "|"+ row["NUMERO"].ToString().ToUpper().Trim() + "|"+ row["FECHA"].ToString().ToUpper().Trim() + "|"+ row["ITEM"].ToString().ToUpper().Trim() + "|"+ row["CANT"].ToString().ToUpper().Trim() + "|"+ row["CANT_SERIE"].ToString().ToUpper().Trim() + "|"+ row["MEDIDA"].ToString().ToUpper().Trim() + "|"+ row["MERCADERIA"].ToString().ToUpper().Trim() ;
                            file.WriteLine(exportacion); //se agrega información al documento
                        }
                        foreach (DataRow row in tb_insumos.Rows)
                        {
                            string exportacion = row["INDICADOR"].ToString().ToUpper().Trim() + "|" + row["MODALIDAD"].ToString().ToUpper().Trim() + "|" + row["RUC"].ToString().ToUpper().Trim() + "|" + row["SERIEDOC"].ToString().ToUpper().Trim() + "|" + row["NUMERODOC"].ToString().ToUpper().Trim() + "|" + row["FECHADOC"].ToString().ToUpper().Trim() + "|" + row["ITEM"].ToString().ToUpper().Trim() + "|" + row["CANTIDADTOTAL"].ToString().ToUpper().Trim() + "|" + row["CANTIDAEXPORTABLE"].ToString().ToUpper().Trim() + "|" + row["UNIDADMEDIDA"].ToString().ToUpper().Trim() + "|" + row["DESCRIPCIONMERCADERIA"].ToString().ToUpper().Trim() + "|" + "|" + "|" + "|" + row["DESCRIPCIONMERCADERIA"].ToString().ToUpper().Trim() + "|" + row["ADUANA"].ToString().ToUpper().Trim() + "|" + row["ANOEXPOR"].ToString().ToUpper().Trim() + "|" + row["DAM"].ToString().ToUpper().Trim() + "|" + row["REGIMEN"].ToString().ToUpper().Trim() + "|" + row["SERIE"].ToString().ToUpper().Trim();
                            file.WriteLine(exportacion); //se agrega información al documento
                        }
                        file.Close();






                        string afirmatxt = NFunciones.ExecuteSQL("update tb_dua set TXT='1' where iddua='" + Convert.ToString(vista_datos.GetFocusedRowCellValue(COL_ID)) + "' and idempresa='"+VariablesGenerales.Empresa+"'");
                        LlegarGrilla();
                        DialogResult Result = MessageBox.Show("El archivo se Guardo Correctamente en :"+rutaCompleta+"\n"+"Desea Abrirlo ?","Información",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

                        if (Result==DialogResult.Yes)
                        {
                            ProcessStartInfo psi = new ProcessStartInfo("notepad.exe", rutaCompleta);
                            Process p = Process.Start(psi);
                        }
                    }

                }
            }
            catch
            {
                MessageBox.Show("Elija un registro ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


       }
    }
}