using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ArmandoLeite.UI.WEB
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void BtnEnviar_Click1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TarefasBD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into Cadastro values('" + TextNome.Text + "', '" + Convert.ToInt32(TextIdade.Text) + "', '" + TextEndereco.Text + "')", conn);
            cmd.ExecuteNonQuery();

            System.Threading.Thread.Sleep(3000);
            Response.Redirect("WebForm2.aspx?id=10");

        }
    }
}