using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmandoLeite.Desktop.UI
{
    public partial class AdicionarConteudo : Form
    {
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

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            {
                openFileDialog.Title = "Selecionar Imagem";
                openFileDialog.Filter = "Arquivos de Video|*.mp4;*.mkv;*.avi;*.MOV;*.FLV|Todos os Arquivos|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] selectedImageData;

                    string imagePath = openFileDialog.FileName;
                    selectedImageData = File.ReadAllBytes(imagePath); // Armazena a imagem selecionada em uma variável de classe
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            DAL.ConteudoDAL ad = new DAL.ConteudoDAL();
            ad.Adicionar(txtTitulo.Text, txtTexto.Text, txtEscritor.Text, date.Text,btnImagem.Text,btnVideo.Text,btnPdf.Text,btnAudio.Text);

        }


        private void btnImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            {
                openFileDialog.Title = "Selecionar Imagem";
                openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos os Arquivos|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] selectedImageData;

                    string imagePath = openFileDialog.FileName;
                    selectedImageData = File.ReadAllBytes(imagePath); // Armazena a imagem selecionada em uma variável de classe
                }
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            {
                openFileDialog.Title = "Selecionar Imagem";
                openFileDialog.Filter = "Arquivos de Pdf|*.pdf|Todos os Arquivos|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] selectedImageData;
                    string imagePath = openFileDialog.FileName;
                    selectedImageData = File.ReadAllBytes(imagePath); // Armazena a imagem selecionada em uma variável de classe
                }
            }

        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            {
                openFileDialog.Title = "Selecionar Imagem";
                openFileDialog.Filter = "Arquivos de audio|*.mp3;*.ogg;*.wma;*.wav|Todos os Arquivos|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] selectedImageData;
                    string imagePath = openFileDialog.FileName;
                    selectedImageData = File.ReadAllBytes(imagePath);
                 
                        // Armazena a imagem selecionada em uma variável de classe
                }
            }
        }

       
    }
}