using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArmandoLeite.UI.WEB
{


    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string novo = Request.QueryString["id"];

            // Fazer algo com o valor do parâmetro
            if (!string.IsNullOrEmpty(novo))
            {
                // Faça o que precisa com o valor do parâmetro
                Response.Write("Id:" + novo);
            }
            else
            {
                Response.Write("Parâmetro id não fornecido na URL.");
            }
        }
    }
}