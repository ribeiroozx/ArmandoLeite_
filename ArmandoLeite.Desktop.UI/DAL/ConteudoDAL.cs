using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace ArmandoLeite.Desktop.UI.DAL
{
    public class ConteudoDAL
    {
        #region Método Adicionar Postagens

        public int IdAdicionar { get; set; }
        public string titulo { get; set; }
        public string nomeEscritor { get; set; }
        public string texto { get; set; }
        public string data { get; set; }
        public byte[] ByteFoto { get; set; }
        public string CaminhoFoto { get; set; }
        //public byte[] selectedPDF { get; set; }
        //public string caminhoPDF { get; set; }
        //public byte[] selectedVideo { get; set; }
        //public string caminhoVideo { get; set; }
        //public byte[] selectedAudio { get; set; }
        //public string caminhoAudio { get; set; }

        //Adicionar 
        public void Salvarfoto(ConteudoDAL conteudoDAL)
        {
            byte[] Foto = GetFoto(conteudoDAL.CaminhoFoto);
            //SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BibliotecaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            //conn.Open();
            ////SqlCommand cmd = new SqlCommand("insert into Conteudo values  ('" + titulo + "','" + texto + "','" + nomeEscritor + "','" + data + "','" + selectedFoto + "')", conn);
            ////cmd.ExecuteNonQuery();
            ///

            var sql = "INSERT INTO Conteudo (titulo, texto, nomeEscritor, data, foto) VALUES (@tituloConteudo, @textoConteudo, @nomeEscritorConteudo, @dataConteudo, @fotoConteudo)";

            using (var con = new SqlConnection(@"Data Source=FAC0539750W10-1;Initial Catalog=ArmandoLeite;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                con.Open();
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@tituloConteudo", conteudoDAL.titulo);
                    cmd.Parameters.AddWithValue("@textoConteudo", conteudoDAL.texto);
                    cmd.Parameters.AddWithValue("@nomeEscritorConteudo", conteudoDAL.nomeEscritor);
                    cmd.Parameters.AddWithValue("@dataConteudo", conteudoDAL.data);
                    cmd.Parameters.Add("@fotoConteudo", System.Data.SqlDbType.Image, Foto.Length).Value = Foto;
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private byte[] GetFoto(string caminhoFoto)
        {
            byte[] foto;
            using (var stream = new FileStream(caminhoFoto, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    foto = reader.ReadBytes((int)stream.Length);
                }
            }
            return foto;
        }

        public int idConteudo { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string NomeEscritor { get; set; }
        public string dataTime { get; set; }
        public byte[] foto { get; set; }


        //Selecionar
        public void Selecionarfoto(string idConteudo)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539750W10-1;Initial Catalog=ArmandoLeite;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select *from Conteudo where idConteudo='" + idConteudo + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                ConteudoDAL conteudoDAL = new ConteudoDAL();
                conteudoDAL.idConteudo = (int)dr["idConteudo"];
                conteudoDAL.Titulo = dr["Titulo"].ToString();
                conteudoDAL.Texto = dr["Texto"].ToString();
                conteudoDAL.NomeEscritor = dr["NomeEscritor"].ToString();
                conteudoDAL.dataTime = dr["data"].ToString();
                conteudoDAL.foto = (byte[])dr["foto"];
            }
        }
    }
}



            //SqlCommand cmd2 = new SqlCommand("insert into Audio values  ('" + idSalvarfoto + "','asdasd', '" + selectedAudio + "','GETDATE()')", conn);
            //cmd2.ExecuteNonQuery();

            //SqlCommand cmd3 = new SqlCommand("insert into Fotos values  ('" + idSalvarfoto + "', '" + selectedFoto + "')", conn);
            //cmd3.ExecuteNonQuery();

            //SqlCommand cmd4 = new SqlCommand("insert into Pdf values  ('" + idSalvarfoto + "', '" + selectedPDF + "')", conn);
            //cmd4.ExecuteNonQuery();

            //SqlCommand cmd5 = new SqlCommand("insert into Videos values  ('" + idSalvarfoto + "', '" + selectedVideo + "')", conn);
            //cmd5.ExecuteNonQuery();
            //conn.Close();
            //conn.Dispose();
            //return idSalvarfoto;


        //private byte[] GetFoto(string caminhoFoto)
        //{
        //    byte[] foto;
        //    using (var stream = new FileStream(caminhoFoto, FileMode.Open, FileAccess.Read))
        //    {
        //        using (var reader = new BinaryReader(stream))
        //        {
        //            foto = reader.ReadBytes((int)stream.Length);
        //        }
        //    }
        //    return foto;
        //}
               
        //public int Adicionar(string titulo, string texto, string nomeEscritor, string data, byte[] selectedFoto, byte[] selectedPDF, byte[] selectedVideo, byte[] selectedAudio)
        //{

        //    SqlConnection conn = new SqlConnection(@"Data Source=FAC0539750W10-1;Initial Catalog=ArmandoLeite;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //    conn.Open();

        //    SqlCommand cmd = new SqlCommand("insert into Conteudo OUTPUT inserted.idConteudo values  ('" + titulo + "','" + texto + "','" + nomeEscritor + "','" + data +"')", conn);
            
        //    int idAdicionar = Convert.ToInt32(cmd.ExecuteScalar());

        //    SqlCommand cmd2 = new SqlCommand("insert into Audio values  ('" + idAdicionar + "','asdasd', '" + selectedAudio + "','GETDATE()')", conn);
        //    cmd2.ExecuteNonQuery();

        //    SqlCommand cmd3 = new SqlCommand("insert into Fotos values  ('" + idAdicionar + "', '" + selectedFoto + "')", conn);
        //    cmd3.ExecuteNonQuery();

        //    SqlCommand cmd4 = new SqlCommand("insert into Pdf values  ('" + idAdicionar + "', '" + selectedPDF + "')", conn);
        //    cmd4.ExecuteNonQuery();

        //    SqlCommand cmd5 = new SqlCommand("insert into Videos values  ('" + idAdicionar + "', '" + selectedVideo + "')", conn);
        //    cmd5.ExecuteNonQuery();
        //    conn.Close();
        //    conn.Dispose();
        //    return idAdicionar;
        //}

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
