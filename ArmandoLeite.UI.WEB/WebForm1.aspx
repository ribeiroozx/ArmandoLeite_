﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ArmandoLeite.UI.WEB.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<%--<asp:ValidationSummary ID="ValidationSummary2" runat="server" HeaderText="Erros de Validação" ForeColor="red" DisplayMode="BulletList"/>--%>

    <div class="mb-2"> 
        <h2>Bem-Vindo</h2>
        <h4>Cadastro</h4>
    </div>

    <div class="mb-2">
        <h4>Nome:</h4>
        <asp:TextBox ID="TxtNome" runat ="server" />
<%--        <asp:RequiredFieldValidator ID="ValidadorCampoNome" runat="server" ErrorMessage="Campo Nome em branco" ForeColor="white" ControlToValidate="TxtNome"></asp:RequiredFieldValidator>--%>
    </div>

    <div class="mb-2">
        <h4>Idade:</h4>
        <asp:TextBox ID="TxtIdade" runat ="server" />
<%--        <asp:RequiredFieldValidator ID="ValidadorCampoIdade" runat="server" ErrorMessage="Campo Idade em branco" ForeColor="white" ControlToValidate="TxtIdade"></asp:RequiredFieldValidator>--%>
    </div>

    <div class="mb-2">
        <h4>Endereço:</h4>
        <asp:TextBox ID="TxtEndereco" runat ="server" />
<%--        <asp:RequiredFieldValidator ID="ValidadorCampoEndereco" runat="server" ErrorMessage="Campo Endereço em branco" ForeColor="white" ControlToValidate="TxtEndereco"></asp:RequiredFieldValidator>--%>
    </div>
   
    <div class="mb-2">
        <asp:Button ID="BtnEnviar" Text="Enviar" runat="server" OnClick="BtnEnviar_Click" />
   </div>
    
    <script>
        $(document).ready(function ()
        {
            $("#BtnEnvia").click(function ()
            {
                // Carregar conteúdo da página.html no elemento com ID "conteudo"
                $("#conteudo").load("pagina.html", function (response, status, xhr) {
                    if (status == "error") {
                        alert("Erro ao carregar o conteúdo.");
                    }
                });
            });
        });
    </script>

        

</asp:Content>
