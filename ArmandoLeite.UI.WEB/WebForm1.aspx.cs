using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArmandoLeite.UI.WEB
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static bool ValidarCampos(string Nome, string Idade, string Endereco)
        {
            // Aqui você pode adicionar lógica para validar os campos no lado do servidor
            // Retorna verdadeiro se os campos são válidos, falso caso contrário
            return !string.IsNullOrEmpty(Nome) && !string.IsNullOrEmpty(Idade) && !string.IsNullOrEmpty(Endereco);
        }


        protected void BtnEnviar_Click(object sender, EventArgs e)
        {

            ValidarCampos(TxtNome.Text, (TxtIdade.Text), TxtEndereco.Text);
        }
    }
}

       