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
    public partial class Frm_cobrarpagardoc : Form
    {
        public Frm_cobrarpagardoc()
        {
            InitializeComponent();
        }

        private void monoFlat_Label3_Click(object sender, EventArgs e)
        {

        }

        private void Frm_cobrarpagardoc_Load(object sender, EventArgs e)
        {
            llenarclienteproveedor();

        }
        void llenarclienteproveedor()
        {
            if (VariablesGenerales.tipooperacion.Equals("C"))
            {
                cbo_clieprov.Properties.DataSource = NFunciones.TABLASQL("select idclieprov CODIGO,razonsocial PROVEEDOR from tb_clieprov where not tipoclieprov='001' and idempresa='"+VariablesGenerales.Empresa+"'");
                cbo_clieprov.Properties.ValueMember = "CODIGO";
                cbo_clieprov.Properties.DisplayMember = "PROVEEDOR";
            }
            if (VariablesGenerales.tipooperacion.Equals("V"))
            {
                cbo_clieprov.Properties.DataSource = NFunciones.TABLASQL("select idclieprov CODIGO,razonsocial PROVEEDOR from tb_clieprov where tipoclieprov='001' and idempresa='" + VariablesGenerales.Empresa + "'");
                cbo_clieprov.Properties.ValueMember = "CODIGO";
                cbo_clieprov.Properties.DisplayMember = "PROVEEDOR";
            }
           
        }
        void llenarproductos()
        {

            if (VariablesGenerales.tipooperacion.Equals("C"))
            {
                cbo_producto.Properties.DataSource = NFunciones.TABLASQL("select idproducto CODIGO ,descripcion PRODUCTO from tb_productos WHERE idempresa='" + VariablesGenerales.Empresa + "' ORDER BY descripcion ASC");
                cbo_producto.Properties.ValueMember = "";
                cbo_producto.Properties.DisplayMember = "";

            }

        }
    }
}
