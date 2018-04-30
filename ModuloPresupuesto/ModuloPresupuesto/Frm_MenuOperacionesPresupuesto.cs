using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloPresupuesto
{
    public partial class Frm_MenuOperacionesPresupuesto : Form
    {
        public Frm_MenuOperacionesPresupuesto()
        {
            InitializeComponent();
            menuStrip1.Renderer = new TestColorTable();
        }

        private void Frm_MenuOperaciones_Load(object sender, EventArgs e)
        {
        mostrartab();

         }

        public class TestColorTable : ToolStripProfessionalRenderer
        {
            protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
            {
                base.OnRenderToolStripBackground(e);

                using (var b = new LinearGradientBrush(e.AffectedBounds,
                    clsColor.clrVerBG_White, clsColor.clrVerBG_GrayBlue, LinearGradientMode.Vertical))
                {
                    using (var shadow = new SolidBrush(clsColor.clrVerBG_Shadow))
                    {
                        var rect = new Rectangle(0, e.ToolStrip.Height - 2, e.ToolStrip.Width, 1);
                        e.Graphics.FillRectangle(b, e.AffectedBounds);
                        e.Graphics.FillRectangle(shadow, rect);
                    }
                }
            }

            // Render button selected and pressed state
            protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
            {
                base.OnRenderButtonBackground(e);
                var rectBorder = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);
                var rect = new Rectangle(1, 1, e.Item.Width - 2, e.Item.Height - 2);

                if (e.Item.Selected == true || (e.Item as ToolStripButton).Checked)
                {
                    using (var b = new LinearGradientBrush(rect, clsColor.clrToolstripBtnGrad_White,
                        clsColor.clrToolstripBtnGrad_Blue, LinearGradientMode.Vertical))
                    {
                        using (var b2 = new SolidBrush(clsColor.clrToolstripBtn_Border))
                        {
                            e.Graphics.FillRectangle(b2, rectBorder);
                            e.Graphics.FillRectangle(b, rect);
                        }
                    }
                }
                if (e.Item.Pressed)
                {
                    using (var b = new LinearGradientBrush(rect, clsColor.clrToolstripBtnGrad_White_Pressed,
                        clsColor.clrToolstripBtnGrad_Blue_Pressed, LinearGradientMode.Vertical))
                    {
                        using (var b2 = new SolidBrush(clsColor.clrToolstripBtn_Border))
                        {
                            e.Graphics.FillRectangle(b2, rectBorder);
                            e.Graphics.FillRectangle(b, rect);
                        }
                    }
                }
            }

        }
        private void panel_contenedor_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_op_Click(object sender, EventArgs e)
        {
 
        }

        private void AgregarForm(Form Obj)
        {
            int index = this.indexTab(Tab_contenedor, Obj);
            if (index>=0)
            {
                Tab_contenedor.TabIndex = index;
            }
            TabPage tabPage = new TabPage {Text = Obj.Text};
            //tabPage.BorderStyle=BorderStyle.Fixed3D;
            Tab_contenedor.TabPages.Add(tabPage);
            Obj.FormBorderStyle = FormBorderStyle.None;
            Obj.TopLevel = false;
            Obj.Dock=DockStyle.Fill;
            Obj.Parent = tabPage;
            Obj.Show();
            Tab_contenedor.SelectedTab=tabPage;
            mostrartab();
        }

        private int indexTab(TabControl tabform,Form obj)
        {
            for (int i = 0;i< tabform.TabCount;i++)
            {
                if (tabform.TabPages[i].Text.Trim() == obj.Text.Trim())
                
                    return i;
            }
            return -1;

        }
        

        private void btn_re_Click(object sender, EventArgs e)
        {
  

        }

        private void mostrartab()
        {
            if (Tab_contenedor.TabPages.Count > 0)
            {
                Tab_contenedor.Visible = true;
                btn_cerrarPestaña.Visible = true;
            }
            else
            {
                Tab_contenedor.Visible = false;
                btn_cerrarPestaña.Visible = false;
            }
        }
        private void lotesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_rpt_PXQ_Click(object sender, EventArgs e)
        {
            rpt_PxQ2 ObJpxq2 = new rpt_PxQ2();
            AgregarForm(ObJpxq2);
        }

        private void btn_cerrarPestaña_Click(object sender, EventArgs e)
        {
            TabPage current_tab = Tab_contenedor.SelectedTab;
            Tab_contenedor.TabPages.Remove(current_tab);
            mostrartab();
        }

        private void btn_rpt_PYG_Click(object sender, EventArgs e)
        {
            Rpt_PYG objPyg= new Rpt_PYG();
            AgregarForm(objPyg);
        }

        private void btn_op_generadetallelote_Click(object sender, EventArgs e)
        {
            FrmGenerarDetallePorLote Objdetalleporlote = new FrmGenerarDetallePorLote();
            Objdetalleporlote.ShowDialog();

        }
    }
}
