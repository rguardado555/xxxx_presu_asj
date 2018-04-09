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

        private void btn_clieprov_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_ClientesProveedores objcleprov = new Frm_ClientesProveedores();
            objcleprov.MdiParent = this;
            objcleprov.Show();
        }

        private void btn_grupopro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Grupos objgrup = new Frm_Grupos();
            objgrup.ShowDialog();
        }

        private void btn_subgrupo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_SubGrupos objsubgrup = new Frm_SubGrupos();
            objsubgrup.ShowDialog();
        }

        private void btn_productos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Productos objProductos = new Productos();
            objProductos.ShowDialog();
        }

        private void btn_compras_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_List_Compra objlistCompras = new Frm_List_Compra();
            objlistCompras.MdiParent = this;
            objlistCompras.Show();
        }

        private void btn_ventas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_List_Ventas objlistVentas = new Frm_List_Ventas();
            objlistVentas.MdiParent = this;
            objlistVentas.Show();
        }

        private void btn_empresas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Empresa ObjEmpresa = new Frm_Empresa();
            ObjEmpresa.MdiParent = this;
            ObjEmpresa.Show();
        }

        private void Frm_MenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        void llenarEmpresa()
        {
           //cbo_empresas.Edit.= NFunciones.TABLASQL("select idempresa Codigo,razonsocial Empresa from tb_empresa order by idempresa asc");
        }
    }
}