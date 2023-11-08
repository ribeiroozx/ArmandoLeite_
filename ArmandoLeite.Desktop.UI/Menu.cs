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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            VisualizarConteudo conteudo = new VisualizarConteudo();
            conteudo.Show();
            this.Hide();
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            AdicionarConteudo conteudo = new AdicionarConteudo();
            conteudo.Show();
            this.Hide();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
