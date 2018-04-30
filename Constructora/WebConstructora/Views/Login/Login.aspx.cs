using System;


namespace WebConstructora
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script>swal('Buen Trabajo!', 'Se realizo el proceso con exito!', 'success')</script>");
        }

        protected void btnAcceder_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string stmensaje = string.Empty;
            //    if (string.IsNullOrEmpty(txtUser.Text)) stmensaje += "Ingrese Usuario,";
            //    if (string.IsNullOrEmpty(txtPass.Text)) stmensaje += "Ingrese Clave,";


            //    if (!string.IsNullOrEmpty(stmensaje)) throw new Exception(stmensaje.TrimEnd(','));

            //}
            //catch(Exception ex)
            //{
                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('Error!', 'si sale error', 'Error') </script>");
            //}
        }
    }
}