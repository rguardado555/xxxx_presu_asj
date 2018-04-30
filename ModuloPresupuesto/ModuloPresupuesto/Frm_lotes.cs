using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
namespace ModuloPresupuesto
{
    public partial class Frm_lotes : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public Frm_lotes()
        {
            InitializeComponent();
        }
        //Metodo mostrar mensaje de confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        //Metodo mostrar mensaje error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Presupuesto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Frm_lotes_Load(object sender, EventArgs e)
        {
            llenargrilla();
            LlenarComboConsumidor();
            LlenarComboEmpresa();
            LlenarComboGerente();
            LlenarComboSubGerente();
            LlenarComboAdministrador();
            LlenarComboCultivo();
            LlenarComboParcela();
            llenarmes(cbo_mesplantacion);
            Botones();

        }
        void llenarmes(DevExpress.XtraEditors.LookUpEdit cbo)
        {
            DataTable tdmes = new DataTable();
            DataColumn column;


            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "NRO";
            tdmes.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "MES";
            tdmes.Columns.Add(column);


            DataColumn[] primarykey = new DataColumn[1];
            primarykey[0] = tdmes.Columns["NRO"];
            tdmes.PrimaryKey = primarykey;


            DataRow row1 = tdmes.NewRow();
            row1["NRO"] = "01";
            row1["MES"] = "Enero";
            tdmes.Rows.Add(row1);

            DataRow row2 = tdmes.NewRow();
            row2["NRO"] = "02";
            row2["MES"] = "Febrero";
            tdmes.Rows.Add(row2);

            DataRow row3 = tdmes.NewRow();
            row3["NRO"] = "03";
            row3["MES"] = "Marzo";
            tdmes.Rows.Add(row3);

            DataRow row4 = tdmes.NewRow();
            row4["NRO"] = "04";
            row4["MES"] = "Abril";
            tdmes.Rows.Add(row4);

            DataRow row5 = tdmes.NewRow();
            row5["NRO"] = "05";
            row5["MES"] = "Mayo";
            tdmes.Rows.Add(row5);

            DataRow row6 = tdmes.NewRow();
            row6["NRO"] = "06";
            row6["MES"] = "Junio";
            tdmes.Rows.Add(row6);

            DataRow row7 = tdmes.NewRow();
            row7["NRO"] = "07";
            row7["MES"] = "Julio";
            tdmes.Rows.Add(row7);

            DataRow row8 = tdmes.NewRow();
            row8["NRO"] = "08";
            row8["MES"] = "Agosto";
            tdmes.Rows.Add(row8);

            DataRow row9 = tdmes.NewRow();
            row9["NRO"] = "09";
            row9["MES"] = "Septiembre";
            tdmes.Rows.Add(row9);

            DataRow row10 = tdmes.NewRow();
            row10["NRO"] = "10";
            row10["MES"] = "Octubre";
            tdmes.Rows.Add(row10);

            DataRow row11 = tdmes.NewRow();
            row11["NRO"] = "11";
            row11["MES"] = "Noviembre";
            tdmes.Rows.Add(row11);

            DataRow row12 = tdmes.NewRow();
            row12["NRO"] = "12";
            row12["MES"] = "Diciembre";
            tdmes.Rows.Add(row12);


            cbo.Properties.DataSource = tdmes;
            cbo.Properties.ValueMember = "NRO";
            cbo.Properties.DisplayMember = "MES";

        }
        void llenargrilla()
        {
            dtg_datos.DataSource = NFunciones.TABLADATOS("SELECT L.IdLote ID,L.Descripción LOTE,P.Idparcela IDPARCELA,P.Descripcion PARCELA,F.IDFUNDO,F.DESCRIPCION FUNDO,L.Ccosto,CO.DESCRIPCION CONSUMIDOR,L.Mes,L.Año_plantacion,L.Plantas_ha,L.Plantas_totales,L.Plantas_buenas, L.Plantas_debiles,L.Plantas_Chantadas,L.Plantas_recalce,L.Plantas_rebajadas,L.Plantas_muertas,L.idgerente,L.idsubgerente,L.idadministrador,L.IDCULTIVO,C.DESCRIPCION CULTIVO,L.IDVARIEDAD,VC.DESCRIPCION VARIEDAD,L.HA FROM P_LOTE L  INNER JOIN P_EMPRESA E ON E.IDEMPRESA=L.IdEmpresa  INNER JOIN P_PARCELAS P ON P.Idparcela=L.Idparcela  INNER JOIN P_FUNDO F ON F.IDFUNDO=P.IDFUNDO LEFT JOIN P_CONSUMIDOR CO ON CO.IDCONSUMIDOR=L.Ccosto  LEFT JOIN P_CULTIVOS C ON C.IDCULTIVO=L.IDCULTIVO LEFT JOIN P_VARIEDADES_CULTIVOS VC ON VC.IDCULTIVO=L.IDCULTIVO AND VC.IDVARIEDAD=L.IDVARIEDAD ORDER BY L.IdLote ASC");
        }
        void llenaretapa()
        {
            dtg_etapas.DataSource = NFunciones.TABLADATOS("");
        }
        void Botones()
        {

            if (this.IsNuevo || this.IsEditar)
            {
                this.HabilitarTexbox(true);
                this.btn_nuevo.Enabled = false;
                this.btn_editar.Enabled = false;
                this.btn_guardar.Enabled = true;
                this.btn_cancelar.Enabled = true;
                this.btn_exportar.Enabled = false;
                this.btn_eliminar.Enabled = false;
            }
            else
            {

                this.HabilitarTexbox(false);
                this.btn_nuevo.Enabled = true;
                this.btn_editar.Enabled = true;
                this.btn_guardar.Enabled = false;
                this.btn_cancelar.Enabled = false;
                this.btn_exportar.Enabled = true;
                this.btn_eliminar.Enabled = true;
            }

        }

        void LlenarComboEmpresa()
        {
            cbo_empresa.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDEMPRESA ID , DESCRIPCION FROM P_EMPRESA");
            cbo_empresa.Properties.ValueMember = "ID";
            cbo_empresa.Properties.DisplayMember = "DESCRIPCION";
        }
        void LlenarComboConsumidor()
        {
            cbo_consumidor.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDCONSUMIDOR ID,DESCRIPCION FROM P_CONSUMIDOR WHERE ESTADO=1 ORDER BY JERARQUIA ASC");
            cbo_consumidor.Properties.ValueMember = "ID";
            cbo_consumidor.Properties.DisplayMember = "DESCRIPCION";
        }
        void LlenarComboGerente()
        {
            cbo_gerente.Properties.DataSource = NFunciones.TABLADATOS("SELECT IdResponsable ID,Nombre DESCRIPCION FROM P_RESPONSABLES ORDER BY IdResponsable ASC");
            cbo_gerente.Properties.ValueMember = "ID";
            cbo_gerente.Properties.DisplayMember = "DESCRIPCION";
        }
        void LlenarComboSubGerente()
        {
            cbo_subgerente.Properties.DataSource = NFunciones.TABLADATOS("SELECT IdResponsable ID,Nombre DESCRIPCION FROM P_RESPONSABLES ORDER BY IdResponsable ASC");
            cbo_subgerente.Properties.ValueMember = "ID";
            cbo_subgerente.Properties.DisplayMember = "DESCRIPCION";
        }
        void LlenarComboAdministrador()
        {
            cbo_administrador.Properties.DataSource = NFunciones.TABLADATOS("SELECT IdResponsable ID,Nombre DESCRIPCION FROM P_RESPONSABLES ORDER BY IdResponsable ASC");
            cbo_administrador.Properties.ValueMember = "ID";
            cbo_administrador.Properties.DisplayMember = "DESCRIPCION";
        }
        void LlenarComboParcela()
        {
            cbo_parcela.Properties.DataSource = NFunciones.TABLADATOS("SELECT Idparcela ID, Descripcion DESCRIPCION FROM P_PARCELAS ORDER BY Idparcela ASC");
            cbo_parcela.Properties.ValueMember = "ID";
            cbo_parcela.Properties.DisplayMember = "DESCRIPCION";
        }

        void LlenarComboCultivo()
        {
            cbo_cultivo.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDCULTIVO ID,DESCRIPCION FROM P_CULTIVOS ORDER BY IDCULTIVO ASC");
            cbo_cultivo.Properties.ValueMember = "ID";
            cbo_cultivo.Properties.DisplayMember = "DESCRIPCION";
        }
        void LlenarComboVariedad(string cultivo)
        {
            cbo_variedad.Properties.DataSource = NFunciones.TABLADATOS("SELECT IDVARIEDAD ID,DESCRIPCION FROM P_VARIEDADES_CULTIVOS WHERE IDCULTIVO='"+cultivo+"' ORDER BY IDVARIEDAD ASC");
            cbo_variedad.Properties.ValueMember = "ID";
            cbo_variedad.Properties.DisplayMember = "DESCRIPCION";
        }

        private void Limpiar()
        {
            this.txt_codigo.Text = string.Empty;
            this.txt_descripcion.Text = string.Empty;
            this.cbo_empresa.SelectedText = "";


        }
        private void HabilitarTexbox(bool Valor)
        {
            this.txt_descripcion.ReadOnly = !Valor;
            this.cbo_empresa.Enabled = Valor;
        }

        private void cbo_cultivo_EditValueChanged(object sender, EventArgs e)
        {
            LlenarComboVariedad(Convert.ToString(cbo_cultivo.EditValue));
        }

        private void dtg_datos_Click(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            vista_etapas.AddNewRow();
            
        }
    }
}
