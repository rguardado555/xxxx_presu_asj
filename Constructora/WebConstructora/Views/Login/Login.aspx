<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebConstructora.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>Sistema Constructora</title><meta charset="UTF-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1.0" />
		<link rel="stylesheet" href="../../css/bootstrap.min.css" />
		<link rel="stylesheet" href="../../css/bootstrap-responsive.min.css" />
        <link rel="stylesheet" href="../../css/matrix-login.css" />
        <link href="font-awesome/css/font-awesome.css" rel="stylesheet" />
       <link href="../../css/sweetalert.css" rel="stylesheet" />
	   <link href='http://fonts.googleapis.com/css?family=Open+Sans:400,700,800' rel='stylesheet' type='text/css'/>
       <script src="../../js/sweetalert.min.js" type="text/javascript"></script>

</head>
<body>
        <div id="loginbox" >            
            <form id="form1"  runat="server" class="form-vertical">
				 <div class="control-group normal_text"> <h3><img src="../../img/logo.png" alt="Logo" /></h3></div>
                <div class="control-group">
                    <div class="controls">
                        <div class="main_input_box">
                            <span class="add-on bg_lg"><i class="icon-user"> </i></span><asp:TextBox ID="txtUser" runat="server"  placeholder="Ingrese Usuario"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="control-group">
                    <div class="controls">
                        <div class="main_input_box">
                            <span class="add-on bg_ly"><i class="icon-lock"></i></span><asp:TextBox ID="txtPass" runat="server" placeholder="Ingrese Clave"  type="password"></asp:TextBox>
                        </div>
                    </div>
                </div>
               <div class="control-group">
                    <div class="controls">
                            <asp:CheckBox ID="chkRecordar" runat="server" Text="Recordarme ?"  CssClass="checkbox"/>
                    </div>
                </div>
                <div class="form-actions">
                    <span class="pull-right"><asp:Button ID="btnAcceder" runat="server" Text="Acceder"  class="btn btn-success" OnClick="btnAcceder_Click"/></span>
                </div>
            </form>
        </div>
</body>
</html>
