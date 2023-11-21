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


        private void ValidarCamposBrancos(string nome, int idade, string endereco)
        {
           string script = "alert('Cadastrado com sucesso');";
           ClientScript.RegisterStartupScript(this.GetType(), "Popup", script, true);

        }


        protected void BtnEnviar_Click(object sender, EventArgs e)
        {

            ValidarCamposBrancos(TxtNome.Text, Convert.ToInt32(TxtIdade.Text), TxtEndereco.Text);
        }
    }
}

       