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
        //private string caminhoFoto = "";
        //public DAL.ConteudoDAL conteudoDAL = new DAL.ConteudoDAL();

        public VisualizarConteudo()
        {
            InitializeComponent();
        }

        public void CarregarGrid()
        {
            DAL.ConteudoDAL conteudoDAL = new DAL.ConteudoDAL();
            guna2DataGridView1.DataSource = conteudoDAL.Selecionarfoto(txtid.Text);
            //guna2DataGridView1.DataBind();
            DataGridViewImageColumn fotoColumn = (DataGridViewImageColumn)guna2DataGridView1.Columns["foto"];
            fotoColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            guna2DataGridView1.Refresh();
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
    }
}
