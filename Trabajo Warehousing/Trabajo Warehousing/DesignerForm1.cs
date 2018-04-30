using DevExpress.XtraBars;
using DevExpress.XtraMap;
using System;
using System.Data;
using System.Windows.Forms;

namespace Trabajo_Warehousing
{
    public partial class DesignerForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DesignerForm1()
        {
            InitializeComponent();
            dashboardDesigner.LoadDashboard(@"..\..\Dashboards\dashboard1.xml");
        }
    }
}
