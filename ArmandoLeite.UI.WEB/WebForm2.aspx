<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ArmandoLeite.UI.WEB.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div id="resultado"></div>
    
    <button id="btnRequisicao">Fazer Requisição AJAX</button>

    <script src="https://code.jquery.com/jquery-3.6.4.min.js"></script>
    <script>
        $(document).ready(function() {
            $("#btnRequisicao").click(function() {
                // Fazer uma requisição AJAX usando jQuery
                $.ajax({
                    url: "exemplo.php",
                    type: "GET",
                    success: function(data) {
                        // Atualizar o conteúdo da div com a resposta do servidor
                        $("#resultado").html(data);
                    },
                    error: function() {
                        alert("Erro na requisição AJAX");
                    }
                });
            });
        });
    </script>

        </div>
    </form>
</body>
</html>
