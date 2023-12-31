﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ArmandoLeite.Desktop.UI.DAL
{
    public partial class AdicionarConteudo : Form
    {
        

        private string caminhoPdf = "";
        private string caminhoAudio = "";
        private string caminhoVideo = "";
        public DAL.ConteudoDAL conteudoDal = new DAL.ConteudoDAL();



        public AdicionarConteudo()
        {
            InitializeComponent();
        }

        private void AdicionarConteudo_Load(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {

           SalvarProduto();
            MessageBox.Show("Cadastrado com sucesso!");
        }

        private void SalvarProduto()
        {
            conteudoDal.titulo = txtTitulo.Text;
            //conteudoDal.texto = txtTexto.Text;
            //conteudoDal.nomeEscritor = txtEscritor.Text;
            conteudoDal.data = date.Text;
            conteudoDal.Semestre = comboBox1.Text;
            conteudoDal.CaminhoPdf = caminhoPdf;
            conteudoDal.CaminhoAudio = caminhoAudio;
            conteudoDal.CaminhoVideo = caminhoVideo;
            conteudoDal.AdicionarConteudo(conteudoDal);

        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            {
                openFileDialog.Title = "Selecionar Pdf";
                openFileDialog.Filter = "Arquivos de Pdf|*.pdf|Todos os Arquivos|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    caminhoPdf = openFileDialog.FileName;
                    //byte[] selectedImageData;
                    //string imagePath = openFileDialog.FileName;
                    //selectedImageData = File.ReadAllBytes(imagePath); // Armazena a imagem selecionada em uma variável de classe
                }
            }

        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            {
                openFileDialog.Title = "Selecionar Audio";
                openFileDialog.Filter = "Arquivos de audio|*.mp3;*.ogg;*.wma;*.wav|Todos os Arquivos|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    caminhoAudio = openFileDialog.FileName;
                    //byte[] selectedImageData;
                    //string imagePath = openFileDialog.FileName;
                    //selectedImageData = File.ReadAllBytes(imagePath);

                    //    // Armazena a imagem selecionada em uma variável de classe
                }
            }
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            {
                openFileDialog.Title = "Selecionar Video";
                openFileDialog.Filter = "Arquivos de Video|*.mp4;*.mkv;*.avi;*.MOV;*.FLV|Todos os Arquivos|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    caminhoVideo = openFileDialog.FileName;
                    //byte[] selectedImageData;

                    //string imagePath = openFileDialog.FileName;
                    //selectedImageData = File.ReadAllBytes(imagePath); // Armazena a imagem selecionada em uma variável de classe
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu conteudo = new Menu();
            conteudo.Show();
            this.Hide();
        }
    }
}