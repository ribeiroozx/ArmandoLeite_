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

        public int Adicionar(string titulo, string texto, string nomeEscritor, string data, string selectedFoto, string selectedFotoName, string selectedPDF, string selectedVideo, string selectedAudio)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539750W10-1;Initial Catalog=ArmandoLeite;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into Conteudo OUTPUT inserted.idConteudo  values  ('" + titulo + "','" + texto + "','" + nomeEscritor + "','" + data + "')", conn);
            int idConteudo = Convert.ToInt32(cmd.ExecuteScalar());



            //if (selectedImageData != null)
            //{
            //    string selectedImageName = "NomeDaImagem"; // Substitua "NomeDaImagem" pelo nome real da imagem.

            //    if (!string.IsNullOrEmpty(selectedImageName))
            //    {

            //        // Se uma imagem foi selecionada, salve-a no banco de dados
            //        SaveImageToDatabase(selectedImageData);
            //        MessageBox.Show("Imagem salva no banco de dados com sucesso.");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Nenhuma imagem selecionada. Use o botão 'Selecionar Imagem' primeiro.");
            //    }
            //}













            SqlCommand cmd2 = new SqlCommand("insert into audio values  ('" + idConteudo + "','" + selectedAudio + "')", conn);
            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand("insert into Fotos values  ('" + idConteudo + "', '" + selectedFoto + "')", conn);
                cmd3.ExecuteNonQuery();

            SqlCommand cmd4 = new SqlCommand("insert into Pdf values  ('" + idConteudo + "', '" + selectedPDF + "')", conn);
            cmd4.ExecuteNonQuery();

            SqlCommand cmd5 = new SqlCommand("insert into Videos values  ('" + idConteudo + "', '" + selectedVideo + "')", conn);
            cmd5.ExecuteNonQuery();
            conn.Close();
                conn.Dispose();
                return idConteudo;
        }
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
