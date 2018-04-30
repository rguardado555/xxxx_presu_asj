using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;
namespace Sistema_Agricola
{
    public partial class Frm_Login : Form
    {
        public static string user;
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            //string autorizarIngresoReturn = AutorizarIngreso(txbUsuario.Text.Trim(), txbContraseña.Text.Trim());

            //if (autorizarIngresoReturn != string.Empty)
            //{
            //    this.DialogResult = System.Windows.Forms.DialogResult.None;
            //    MessageBox.Show(autorizarIngresoReturn);
            //}
            //else
            //{
            //    user = txbUsuario.Text.Trim();
            //    btn_ingresar.DialogResult = DialogResult.OK;
            //    this.DialogResult = System.Windows.Forms.DialogResult.OK;
            //    Frm_Principal.user2 = user;
            //}

            //if (this.DialogResult == System.Windows.Forms.DialogResult.OK)
            //{
            //    this.Close();
            //}


            btn_ingresar.DialogResult = DialogResult.OK;

        }
        public static string AutorizarIngreso(string usuario, string password)
        {
            string autorizarIngresoReturn = string.Empty;

            DataTable TB_USER = NFunciones.TABLADATOS("select * from tb_usuario where usuario='"+usuario+"' and clave='"+password+"'");
            if (TB_USER.Rows.Count==1)
            {
                autorizarIngresoReturn = "Ok";
            }
             return autorizarIngresoReturn;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
