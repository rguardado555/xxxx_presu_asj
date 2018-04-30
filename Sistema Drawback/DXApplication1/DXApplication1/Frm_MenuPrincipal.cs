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
            Frm_lista_ventas objlistVentas = new Frm_lista_ventas();
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
            lb_empresaseleccionada.Caption = "EMPRESA SELECCIONADA : " + VariablesGenerales.Nombreempresa;
           
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          

        }
       void manejarfondo()
        {
            if (xtraTabbedMdiManager1.Pages.Count>0)
            {
                panel_contenedor.Visible = false;
            }
            else
            {
                panel_contenedor.Visible = true;
            }
        }

        private void btn_duas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (VariablesGenerales.Empresa.Equals(""))
            {
                MessageBox.Show("Debe Seleccionar Empresa Primero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Frm_Lista_Duas ObJDuas = new Frm_Lista_Duas();
                ObJDuas.MdiParent = this;
                ObJDuas.Show();

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
            else
            {
                Frm_ReporteFacturasPendientes Objrepor = new Frm_ReporteFacturasPendientes();
                Objrepor.MdiParent = this;
                Objrepor.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_fecha.Caption = "Fecha : " + DateTime.Now.ToLongDateString() + " , Hora : " + DateTime.Now.ToShortTimeString();
        }

        private void xtraTabbedMdiManager1_PageAdded(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            manejarfondo();
        }

        private void xtraTabbedMdiManager1_PageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            manejarfondo();
        }
    }
}