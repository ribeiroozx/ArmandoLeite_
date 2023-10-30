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
    public partial class Teste : Form
    {
        public Teste()
        {
            InitializeComponent();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            DAL.ConteudoDAL conteudoDAL = new DAL.ConteudoDAL();
            conteudoDAL.Adicionar(txtTitulo.Text,txtTexto.Text,txtEscritor.Text,date.Text);
        }
    }
}
