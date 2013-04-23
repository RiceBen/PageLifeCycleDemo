<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControl1.ascx.cs" Inherits="PageLifeCycleDemo.UserControl1" %>
<asp:TextBox ID="ucTextBox1" runat="server" 
             OnInit="ucTextBox1_Init"
             OnLoad="ucTextBox1_Load"
             OnPreRender="ucTextBox1_PreRender"
             OnUnload="ucTextBox1_Unload"></asp:TextBox>