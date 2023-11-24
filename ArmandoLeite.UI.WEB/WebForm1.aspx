<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ArmandoLeite.UI.WEB.WebForm1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.2/dist/js/bootstrap.min.js"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.2/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/ [email protected]/dist/umd/popper.min.js" ></script>
    <link href="https://cdn.jsdelivr.net/npm/ [email protected]/dist/css/popper.min.css" rel="stylesheet" />
    <script src="Scripts/MicrosoftAjax.js" type="text/javascript"></script>
    <script src="Scripts/MicrosoftAjaxWebForms.js" type="text/javascript"></script>
    <script src="Scripts/MicrosoftAjaxWebForms.debug.js" type="text/javascript"></script>
    <script src="Scripts/AjaxControlToolkit/ExtenderBase/BaseScripts.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
            <Scripts>
                <asp:ScriptReference Name="MsAjaxBundle" />
                <asp:ScriptReference Name="WebForms.js" Path="~/Scripts/WebForms/WebForms.js" />
                <asp:ScriptReference Name="WebUIValidation.js" Path="~/Scripts/WebForms/WebUIValidation.js" />
                <asp:ScriptReference Name="MenuStandards.js" Path="~/Scripts/WebForms/MenuStandards.js" />
            </Scripts>
        </asp:ToolkitScriptManager>

        Data:
        <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
        <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtDate"></asp:CalendarExtender>

        <!-- Outros elementos da sua página -->
    </div>

</asp:Content>
