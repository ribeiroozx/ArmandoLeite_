<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ArmandoLeite.UI.WEB.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet"> 
    <div class="container mt-3">
        <h2>Login</h2>
        <div class="mb-3 mt-3">
            <label for="email">Email:</label>
            <input type="email" class="form-control" id="email" placeholder="Enter email" runat="server" name="email">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="CAMPO EM BRANCO!!!" ControlToValidate="email" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />&nbsp;
        </div>
        <div class="mb-3">
            <label for="pwd">Senha:</label>
            <input type="password" class="form-control" id="senha" placeholder="Enter password" runat="server" name="pswd">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="CAMPO EM BRANCO!!!" ControlToValidate="senha" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <br />
        <br />
        <button type="submit" class="btn btn-primary">Entrar</button>
    </div>
</asp:Content>
