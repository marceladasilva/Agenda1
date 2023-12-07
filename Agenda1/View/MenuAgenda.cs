using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda1.View
{
    public partial class MenuAgenda : Form
    {
        public MenuAgenda()
        {
            InitializeComponent();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adicionar adicionar = new Adicionar();
            adicionar.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alterar alterar = new Alterar();
            alterar.Show();

        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apagar apagar = new Apagar();
            apagar.Show();
        }

        private void buscarCodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarCod buscarcod = new BuscarCod();
            buscarcod.Show();
        }

        private void buscarNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarNome buscarNome = new BuscarNome();
            buscarNome.Show();
        }
    }
}

