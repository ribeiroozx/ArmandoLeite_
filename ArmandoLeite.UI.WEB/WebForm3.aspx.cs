using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ArmandoLeite.UI.WEB
{
    

    public partial class WebForm3 : System.Web.UI.Page
    {
        public string id { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEnviar_Click1(object sender, EventArgs e)
        {
            id = TextId.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TarefasBD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from Cadastro where idCadastro like '%" + id + "%'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            System.Threading.Thread.Sleep(3000);
            Response.Redirect("WebForm2.aspx?"+id+"");
        }
    }
}