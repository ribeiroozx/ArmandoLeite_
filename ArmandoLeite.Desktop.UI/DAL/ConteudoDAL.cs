﻿using System;
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

        public int idConteudo { get; set; }
        public string titulo { get; set; }
        public string data { get; set; }
        public string CaminhoPdf { get; set; }
        public byte[] pdf { get; set; }
        public string Semestre { get; set; }

        //public byte[] selectedPDF { get; set; }
        //public string caminhoPDF { get; set; }
        //public byte[] selectedVideo { get; set; }
        //public string caminhoVideo { get; set; }
        //public byte[] selectedAudio { get; set; }
        //public string caminhoAudio { get; set; }

        //Adicionar 
        public int Salvarfoto(ConteudoDAL conteudoDAL)
        {
            //byte[] Foto = GetFoto(conteudoDAL.CaminhoFoto);
            //SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BibliotecaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("insert into Conteudo values  ('" + titulo + "','" + texto + "','" + nomeEscritor + "','" + data + "','" + selectedFoto + "')", conn);
            //cmd.ExecuteNonQuery();




            //var sql = "INSERT INTO Conteudo  (Titulo, Texto, NomeEscritor, data) OUTPUT inserted.idConteudo VALUES (@titulo, @texto, @nomeEscritor, @data)";

            //var sql2 = "INSERT INTO Foto (DadoFoto,'" + idConteudo + "') VALUES (@Dadofoto,@idConteudo)";

            //using (var con = new SqlConnection(@"Data Source=FAC0539750W10-1;Initial Catalog=ArmandoLeite;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            //{
            //    con.Open();
            //    using (var cmd = new SqlCommand(sql, con))
            //    {
            //        cmd.Parameters.AddWithValue("@titulo", conteudoDAL.titulo);
            //        cmd.Parameters.AddWithValue("@texto", conteudoDAL.texto);
            //        cmd.Parameters.AddWithValue("@nomeEscritor", conteudoDAL.nomeEscritor);
            //        cmd.Parameters.AddWithValue("@data", conteudoDAL.data);
            //        //cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image, Foto.Length).Value = Foto;
            //        idConteudo = Convert.ToInt32(cmd.ExecuteScalar());


            //        using (var cmd2 = new SqlCommand(sql2, con))
            //        {
            //            cmd2.Parameters.Add("@Dadofoto", System.Data.SqlDbType.Image, Foto.Length).Value = Foto;
            //            cmd2.Parameters.AddWithValue("@idConteudo", idConteudo);
            //            cmd2.ExecuteNonQuery();

            //        }
            //    }
            //    return idConteudo;
            //}
            byte[] Pdf = GetPdf(conteudoDAL.CaminhoPdf);

            var sql = "INSERT INTO Conteudo (Titulo,Semestre, data) OUTPUT inserted.idConteudo VALUES (@titulo, @Semestre, @data)";
            var sql2 = "INSERT INTO Pdf (DadoPdf, FkConteudo) VALUES (@DadoPdf, @idConteudo)";

            using (var con = new SqlConnection(@"Data Source=FAC0539750W10-1;Initial Catalog=ArmandoLeite;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                con.Open();

                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@titulo", conteudoDAL.titulo);
                    cmd.Parameters.AddWithValue("@data", conteudoDAL.data);
                    cmd.Parameters.AddWithValue("@Semestre", conteudoDAL.Semestre);

                    // ExecuteScalar retorna o valor da cláusula OUTPUT
                    int idConteudo = Convert.ToInt32(cmd.ExecuteScalar());

                    using (var cmd2 = new SqlCommand(sql2, con))
                    {
                        cmd2.Parameters.Add("@DadoPdf", System.Data.SqlDbType.VarBinary, Pdf.Length).Value = Pdf;
                        cmd2.Parameters.AddWithValue("@idConteudo", idConteudo);
                        cmd2.ExecuteNonQuery();
                    }

                    return idConteudo;
                }
            }
        }

        private byte[] GetPdf(string caminhoPdf)
        {
            byte[] pdf;
            using (var stream = new FileStream(caminhoPdf, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    pdf = reader.ReadBytes((int)stream.Length);
                }
            }
            return pdf;
        }




        //Selecionar
        //public List<ConteudoDAL> Selecionarfoto(string idConteudo)
        //{
        //    SqlConnection conn = new SqlConnection(@"Data Source=FAC0539750W10-1;Initial Catalog=ArmandoLeite;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //    conn.Open();


        //    SqlCommand cmd = new SqlCommand("select *from Conteudo where idConteudo='" + idConteudo + "'", conn);

        //    SqlDataReader dr = cmd.ExecuteReader();
        //    List<ConteudoDAL> usuarioDals = new List<ConteudoDAL>();


        //    while (dr.Read())
        //    {
        //        ConteudoDAL conteudo = new ConteudoDAL();
        //        conteudo.idConteudo = dr.GetInt32(dr.GetOrdinal("idConteudo"));
        //        conteudo.titulo = dr.GetString(dr.GetOrdinal("Titulo"));
        //        conteudo.texto = dr.GetString(dr.GetOrdinal("Texto"));
        //        conteudo.nomeEscritor = dr.GetString(dr.GetOrdinal("NomeEscritor"));
        //        conteudo.data = dr.GetString(dr.GetOrdinal("data"));

        //        if (dr["DadoFoto"] != DBNull.Value)
        //        {
        //            conteudo.foto = (byte[])dr["DadoFoto"];
        //        }

        //        usuarioDals.Add(conteudo);
        //    }
        //    dr.Close();
        //    return usuarioDals;
        //}
        //public List<ConteudoDAL> Selecionarfoto(string idConteudo)
        //{
        //    SqlConnection conn = new SqlConnection(@"Data Source=FAC0539750W10-1;Initial Catalog=ArmandoLeite;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //    conn.Open();

        //    string sql = "SELECT Conteudo.*, Foto.DadoFoto " +
        //                 "FROM Conteudo " +
        //                 "INNER JOIN Foto ON Conteudo.idConteudo = Foto.FkConteudo " +
        //                 "WHERE Conteudo.idConteudo = '" + idConteudo + "'";


        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    cmd.Parameters.AddWithValue("@idConteudo", idConteudo);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    List<ConteudoDAL> usuarioDals = new List<ConteudoDAL>();

        //    while (dr.Read())
        //    {
        //        ConteudoDAL conteudo = new ConteudoDAL();
        //        conteudo.idConteudo = dr.GetInt32(dr.GetOrdinal("idConteudo"));
        //        conteudo.titulo = dr.GetString(dr.GetOrdinal("Titulo"));
        //        conteudo.data = dr.GetString(dr.GetOrdinal("data"));

        //        if (dr["DadoFoto"] != DBNull.Value)
        //        {
        //            conteudo.Pdf = (byte[])dr["DadoPdf"];
        //        }

        //        usuarioDals.Add(conteudo);
        //    }

        //    dr.Close();
        //    return usuarioDals;
        //}


        //Apagar
        public void Apagarfoto(string idConteudo)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539750W10-1;Initial Catalog=ArmandoLeite;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();

            SqlCommand cmd = new SqlCommand("delete from Conteudo where idConteudo=" + idConteudo, conn);
            cmd.ExecuteNonQuery();
        }
    }
}

    //    //Atualizar
    //    public void Atualizarfoto(ConteudoDAL conteudoDAL, string titulo, string texto, string nomeEscritor, string data, int idConteudo)
    //    {
    //        byte[] Foto = GetFoto(conteudoDAL.CaminhoFoto);
    //        var sql = "UPDATE Conteudo SET Titulo = @Titulo, Texto = @Texto, NomeEscritor = @NomeEscritor, data = @data, foto = @foto WHERE idConteudo = @idConteudo";

    //        using (var con = new SqlConnection(@"Data Source=FAC0539750W10-1;Initial Catalog=ArmandoLeite;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
    //        {

    //            con.Open();
    //            using (var cmd = new SqlCommand(sql, con))
    //            {

    //                cmd.Parameters.AddWithValue("@Titulo", titulo);
    //                cmd.Parameters.AddWithValue("@data", data);
    //                cmd.Parameters.AddWithValue("@idConteudo", idConteudo);
    //                cmd.Parameters.AddWithValue("@foto", Foto);
    //                cmd.ExecuteNonQuery();
    //            }





    //        }
    //    }
    //}
    #endregion











//            if (dr.Read())
//            {
//                ConteudoDAL conteudoDAL = new ConteudoDAL();
//                conteudoDAL.idConteudo = (int)dr["idConteudo"];
//                conteudoDAL.Titulo = dr["Titulo"].ToString();
//                conteudoDAL.Texto = dr["Texto"].ToString();
//                conteudoDAL.NomeEscritor = dr["NomeEscritor"].ToString();
//                conteudoDAL.dataTime = dr["data"].ToString();
//                conteudoDAL.foto = (byte[])dr["foto"];
//            }
//            return usuarioDals;
//        }
//    }
//}
//    }
//}



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

//#endregion

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
