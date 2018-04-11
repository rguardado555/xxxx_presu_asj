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
namespace DXApplication1
{
    public partial class Frm_MenuPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public Frm_MenuPrincipal()
        {
            InitializeComponent();
        }
        void validarempresa()
        {
            if (VariablesGenerales.Empresa.Equals(""))
            {
                MessageBox.Show("Debe Seleccionar Empresa Primero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void btn_clieprov_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (VariablesGenerales.Empresa.Equals(""))
            {
                MessageBox.Show("Debe Seleccionar Empresa Primero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Frm_ClientesProveedores objcleprov = new Frm_ClientesProveedores();
            objcleprov.MdiParent = this;
            objcleprov.Show();
        }

        private void btn_grupopro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (VariablesGenerales.Empresa.Equals(""))
            {
                MessageBox.Show("Debe Seleccionar Empresa Primero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Frm_Grupos objgrup = new Frm_Grupos();
            objgrup.ShowDialog();
        }

        private void btn_subgrupo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (VariablesGenerales.Empresa.Equals(""))
            {
                MessageBox.Show("Debe Seleccionar Empresa Primero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Frm_SubGrupos objsubgrup = new Frm_SubGrupos();
            objsubgrup.ShowDialog();
        }

        private void btn_productos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (VariablesGenerales.Empresa.Equals(""))
            {
                MessageBox.Show("Debe Seleccionar Empresa Primero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Productos objProductos = new Productos();
            objProductos.ShowDialog();
        }

        private void btn_compras_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (VariablesGenerales.Empresa.Equals(""))
            {
                MessageBox.Show("Debe Seleccionar Empresa Primero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Frm_List_Compra objlistCompras = new Frm_List_Compra();
            objlistCompras.MdiParent = this;
            objlistCompras.Show();
        }

        private void btn_ventas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (VariablesGenerales.Empresa.Equals(""))
            {
                MessageBox.Show("Debe Seleccionar Empresa Primero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Frm_List_Ventas objlistVentas = new Frm_List_Ventas();
            objlistVentas.MdiParent = this;
            objlistVentas.Show();
        }

        private void btn_empresas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (VariablesGenerales.Empresa.Equals(""))
            {
                MessageBox.Show("Debe Seleccionar Empresa Primero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Frm_Empresa ObjEmpresa = new Frm_Empresa();
            ObjEmpresa.MdiParent = this;
            ObjEmpresa.Show();
        }

        private void Frm_MenuPrincipal_Load(object sender, EventArgs e)
        {
            llenarEmpresa();
            lb_empresaseleccionada.Caption = "EMPRESA SELECCIONADA : (Ninguna)";
           
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cbo_empresaseleccionada.Text.Equals("[Seleccionar]"))
            {
                MessageBox.Show("Seleccione Empresa Primero !!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (xtraTabbedMdiManager1.Pages.Count>0) {
                MessageBox.Show("No se Puede Cambiar Empresa , Primero Cierre todas las Ventanas !!","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            VariablesGenerales.Empresa = cbo_empresaseleccionada.EditValue.ToString();
            lb_empresaseleccionada.Caption = "EMPRESA SELECCIONADA : " + cbo_empresaseleccionada.EditValue.ToString()+ " - " + cbo_empresaseleccionada.Text.ToString();

        }
        void llenarEmpresa()
        {
            cbo_empresaseleccionada.Properties.DataSource= NFunciones.TABLASQL("select idempresa Codigo,razonsocial Empresa from tb_empresa order by idempresa asc");
            cbo_empresaseleccionada.Properties.ValueMember = "Codigo";
            cbo_empresaseleccionada.Properties.DisplayMember = "Empresa";

        }

        private void btn_duas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (VariablesGenerales.Empresa.Equals(""))
            {
                MessageBox.Show("Debe Seleccionar Empresa Primero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btn_txt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (VariablesGenerales.Empresa.Equals(""))
            {
                MessageBox.Show("Debe Seleccionar Empresa Primero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btn_rpt_saldos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (VariablesGenerales.Empresa.Equals(""))
            {
                MessageBox.Show("Debe Seleccionar Empresa Primero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_fecha.Caption = "Fecha : " + DateTime.Now.ToLongDateString() + " , Hora : " + DateTime.Now.ToShortTimeString();
        }
    }
}