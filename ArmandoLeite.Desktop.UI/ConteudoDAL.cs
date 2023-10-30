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

        public void Adicionar(string titulo, string texto, string nomeEscritor, string data)
        {
            //using (OpenFileDialog openFileDialog = new OpenFileDialog())
            //{
            //    openFileDialog.Title = "Selecionar Imagem";
            //    openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*bmp|Todos os Arquivos";


            //    if (openFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        byte[] selectedImageData;
            //        string imagePath = openFileDialog.FileName;
            //        selectedImageData = File.ReadAllBytes(imagePath);//Armazena a imagem selecionada 
            //    }

                SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ArmandoLeite;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                conn.Open();

                SqlCommand cmd = new SqlCommand("insert into Adicionar values ('" + titulo + "','" + texto + "','" + nomeEscritor + "','" + data + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
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
