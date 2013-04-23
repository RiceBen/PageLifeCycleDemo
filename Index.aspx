<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PageLifeCycleDemo.Index" %>
<%@ Register TagPrefix="uc" TagName="UserControl1" Src="~/UserControl1.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="button1" runat="server" Text="Firstbutton" 
                        OnInit="button1_Init"
                        OnLoad="button1_Load"
                        OnPreRender="button1_PreRender"
                        OnUnload="button1_Unload" />
            <uc:UserControl1 ID="uc1" runat="server" Visible="true" />
            <asp:Button ID="button2" runat="server" Text="Secondbutton" 
                        OnInit="button2_Init"
                        OnLoad="button2_Load"
                        OnPreRender="button2_PreRender"
                        OnUnload="button2_Unload" />
        </div>
    </form>
</body>
</html>
