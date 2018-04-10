using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Frm_Compra : Form
    {
        string _id = "";
        string _opcion = "";
        public Frm_Compra(string id, string opcion)
        {
            InitializeComponent();
            this._id = id;
            this._opcion = opcion;
        }

        private void monoFlat_Label3_Click(object sender, EventArgs e)
        {

        }

        private void Frm_cobrarpagardoc_Load(object sender, EventArgs e)
        {

            llenarclienteproveedor();
            txt_idoperacion.Text = "C";
            txt_operacion.Text = "Compras";
            llenarclienteproveedor();
            llenarproductos();

            if (_opcion.Equals("N"))
            {
                dtp_fechaoperacion.EditValue = DateTime.Now.ToShortDateString();

            }
        }
        void llenarclienteproveedor()
        {
                cbo_clieprov.Properties.DataSource = NFunciones.TABLASQL("select idclieprov CODIGO,razonsocial PROVEEDOR from tb_clieprov where not tipoclieprov='001' and idempresa='"+VariablesGenerales.Empresa+"'");
                cbo_clieprov.Properties.ValueMember = "CODIGO";
                cbo_clieprov.Properties.DisplayMember = "PROVEEDOR";
        }

        void llenardocumentos()
        {
            cbo_documento.Properties.DataSource = NFunciones.TABLASQL("select idclieprov CODIGO,razonsocial PROVEEDOR from tb_clieprov where not tipoclieprov='001' and idempresa='" + VariablesGenerales.Empresa + "'");
            cbo_documento.Properties.ValueMember = "CODIGO";
            cbo_documento.Properties.DisplayMember = "PROVEEDOR";
        }
        void llenarproductos()
        {
                cbo_producto.Properties.DataSource = NFunciones.TABLASQL("select idproducto CODIGO ,descripcion PRODUCTO from tb_productos WHERE idempresa='" + VariablesGenerales.Empresa + "' ORDER BY descripcion ASC");
                cbo_producto.Properties.ValueMember = "";
                cbo_producto.Properties.DisplayMember = "";
        }



        private void btn_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
