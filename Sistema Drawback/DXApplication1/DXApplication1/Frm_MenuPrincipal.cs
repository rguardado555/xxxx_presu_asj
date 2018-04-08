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
    }
}