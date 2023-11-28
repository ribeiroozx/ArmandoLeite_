<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ArmandoLeite.UI.WEB.WebForm1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager runat="server"></asp:ScriptManager>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>

        <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
        <asp:TextBox ID="TextNome" runat="server"></asp:TextBox>


        <asp:Label ID="Label2" runat="server" Text="Idade"></asp:Label>
        <asp:TextBox ID="TextIdade" runat="server"></asp:TextBox>


        <asp:Label ID="Label3" runat="server" Text="Endereço"></asp:Label>
        <asp:TextBox ID="TextEndereco" runat="server"></asp:TextBox>


        <asp:Button ID="BtnEnviar" runat="server" Text="Enviar" OnClick="BtnEnviar_Click1" />

        <asp:Label ID="Mensagem" runat="server" Text="Cadastro Concluido" Visible="False"></asp:Label>

        <asp:UpdateProgress ID="UpdateProgress1" runat="server">
            <ProgressTemplate>
                <img src="imagens/PUskErp.gif" />
            </ProgressTemplate>
        </asp:UpdateProgress>
    </ContentTemplate>
    </asp:UpdatePanel>







</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="ContentPlaceHolder2">
    <style type="text/css">
        .auto-style2 {
            width: 383px;
            height: 480px;
        }
    </style>
</asp:Content>

