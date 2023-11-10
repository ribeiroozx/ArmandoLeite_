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
    public partial class VisualizarConteudo : Form
    {
        private string caminhoFoto = "";
        public DAL.ConteudoDAL conteudoDAL = new DAL.ConteudoDAL();
        
        public VisualizarConteudo()
        {
            InitializeComponent();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
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
            DAL.ConteudoDAL busca = new DAL.ConteudoDAL();
            busca.Selecionarfoto(txtid.Text);

            SelecionarFoto();

        //{
        //    DAL.ConteudoDAL buscar = new DAL.ConteudoDAL();
        //    List<VisualizarConteudo> buscar1 = buscar.Selecionarfoto(txtTitulo.Text, txtTexto.Text, txtEscritor.Text, date.Text, );
        }

        private void SelecionarFoto()
        {
            conteudoDAL.titulo = txtTitulo.Text;
            conteudoDAL.texto = txtTexto.Text;
            conteudoDAL.nomeEscritor = txtEscritor.Text;
            conteudoDAL.data = date.Text;
            conteudoDAL.CaminhoFoto = caminhoFoto;
            conteudoDAL.Selecionarfoto();
        }

        private void picturebox_Click(object sender, EventArgs e)
        {

        }
    }
}
