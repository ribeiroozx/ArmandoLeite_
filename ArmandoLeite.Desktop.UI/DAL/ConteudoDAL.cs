using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ArmandoLeite.Desktop.UI.DAL
{
    public class ConteudoDAL
    {
        #region Método Adicionar Postagens

        public int Adicionar(string titulo, string texto, string nomeEscritor, string data)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ArmandoLeite;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();
            
            SqlCommand cmd = new SqlCommand("insert into Adicionar OUTPUT inserted.idAdicionar values  ('" + titulo + "','" + texto + "','" + nomeEscritor + "','" + data + "')", conn);
            int idAdicionar = Convert.ToInt32(cmd.ExecuteScalar());

            SqlCommand cmd2 = new SqlCommand("insert into Audio values  ('" + idAdicionar +"')", conn);
            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand("insert into Fotos values  ('" + idAdicionar + "')", conn);
            cmd3.ExecuteNonQuery();

            SqlCommand cmd4 = new SqlCommand("insert into Pdf values  ('" + idAdicionar + "')", conn);
            cmd4.ExecuteNonQuery();

            SqlCommand cmd5 = new SqlCommand("insert into Videos values  ('" + idAdicionar +"')", conn);
            cmd5.ExecuteNonQuery();


            conn.Close();
            conn.Dispose();
            return idAdicionar;
            }
        }
        #endregion

    //    #region Método Deletar Postagens

    //    public void Deletar(string titulo, string texto, string nomeEscritor, string data)
    //    {
    //        SqlConnection conn = new SqlConnection(@"Data Source=FAC0539750W10-1;User ID=sa;Password=********;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    //        conn.Open();

    //        SqlCommand cmd = new SqlCommand("insert into Adicionar values ('" + titulo + "','" + texto + "','" + nomeEscritor + "','" + data + "')", conn);
    //        cmd.ExecuteNonQuery();
    //    }
    //    #endregion

    //    #region Método Buscar Postagens

    //    public void Buscar(string titulo, string texto, string nomeEscritor, string data)
    //    {
    //        SqlConnection conn = new SqlConnection(@"Data Source=FAC0539750W10-1;User ID=sa;Password=********;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    //        conn.Open();

    //        SqlCommand cmd = new SqlCommand("insert into Adicionar values ('" + titulo + "','" + texto + "','" + nomeEscritor + "','" + data + "')", conn);
    //        cmd.ExecuteNonQuery();
    //    }
    //    #endregion


    //    #region Método Atualizar Postagens

    //    public void Atualizar(string titulo, string texto, string nomeEscritor, string data)
    //    {
    //        SqlConnection conn = new SqlConnection(@"Data Source=FAC0539750W10-1;User ID=sa;Password=********;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    //        conn.Open();

    //        SqlCommand cmd = new SqlCommand("insert into Adicionar values ('" + titulo + "','" + texto + "','" + nomeEscritor + "','" + data + "')", conn);
    //        cmd.ExecuteNonQuery();
    //    }
    //    #endregion
    //}
}
