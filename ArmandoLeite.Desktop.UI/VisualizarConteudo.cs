using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmandoLeite.Desktop.UI.DAL
{

    public partial class VisualizarConteudo : Form
    {
        private string caminhoFoto = "";
        public DAL.ConteudoDAL conteudoDal = new DAL.ConteudoDAL();

        public VisualizarConteudo()
        {
            InitializeComponent();
        }

        public void CarregarGrid()
        {
            DAL.ConteudoDAL conteudoDAL = new DAL.ConteudoDAL();
            //conteudoDAL.Selecionarfoto(txtid.Text);
            //dataGridView1.DataSource = conteudoDAL.Selecionarfoto(txtid.Text);
            //guna2DataGridView1.DataBind();
            DataGridViewImageColumn fotoColumn = (DataGridViewImageColumn)dataGridView1.Columns["foto"];
            fotoColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.RowTemplate.Height = 100;
           

            dataGridView1.Refresh();
        }

        public void ApagarGrid(string idConteudo)
        {
            //DAL.ConteudoDAL conteudoDAL = new DAL.ConteudoDAL();
            //conteudoDAL.ApagarConteudo(txtid.Text);

        }

        //public void Atualizar(string idConteudo, string tituloConteudo, string textoConteudo, string nomeEscritorConteudo, string dataConteudo, byte[] fotoConteudo)
        public void Atualizar()
        {
            SalvarProduto();
            //DAL.ConteudoDAL conteudoDAL = new DAL.ConteudoDAL();
            //conteudoDAL.Atualizarfoto(txtid.Text,txtTitulo.Text,txtTexto.Text,txtEscritor.Text,date.Text,);

        }


        private void SalvarProduto()
        {
            int idConteudoConvertido;

            int.TryParse(txtid.Text, out idConteudoConvertido);

            conteudoDal.titulo = txtTitulo.Text;
            //conteudoDal.texto = txtTexto.Text;
            //conteudoDal.nomeEscritor = txtEscritor.Text;
            conteudoDal.data = date.Text;
            //conteudoDal.CaminhoFoto = caminhoFoto;
            conteudoDal.idConteudo = idConteudoConvertido;
            //conteudoDal.Atualizarfoto(conteudoDal, txtTitulo.Text, txtTexto.Text, txtEscritor.Text, date.Text, idConteudoConvertido);

        }





        private void guna2TileButton1_Click(object sender, EventArgs e)
        {

        }

        private void VisualizarConteudo_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupbox_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
            


        //{
        //    DAL.ConteudoDAL buscar = new DAL.ConteudoDAL();
        //    List<VisualizarConteudo> buscar1 = buscar.Selecionarfoto(txtTitulo.Text, txtTexto.Text, txtEscritor.Text, date.Text, );
        }

        //private void SelecionarFoto()
        //{
        //    conteudoDAL.titulo = txtTitulo.Text;
        //    conteudoDAL.texto = txtTexto.Text;
        //    conteudoDAL.nomeEscritor = txtEscritor.Text;
        //    conteudoDAL.data = date.Text;
        //    conteudoDAL.CaminhoFoto = caminhoFoto;
        //    conteudoDAL.Selecionarfoto();
        //}

        private void picturebox_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ApagarGrid(txtid.Text);
            MessageBox.Show("Excluido com sucesso");
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            {
                openFileDialog.Title = "Selecionar Imagem";
                openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos os Arquivos|*.*";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    caminhoFoto = openFileDialog.FileName;

                    if (caminhoFoto != "")
                    {
                        guna2PictureBox1.Load(caminhoFoto);
                    }
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu conteudo = new Menu();
            conteudo.Show();
            this.Hide();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
