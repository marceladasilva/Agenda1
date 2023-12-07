using Agenda.Controller;
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
    public partial class BuscarNome : Form
    {
        public BuscarNome()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Agenda.Model.Agenda.Nome = tbx_nomebuscar.Text;
            ManipulaAgenda manipulaAgenda = new ManipulaAgenda();
            ManipulaAgenda.BuscarNome();

            Agenda.Model.Agenda.Nome = tbx_nomebuscar.Text;
            dataGridView1.DataSource = ManipulaAgenda.BuscarNome();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderCell.Value = "Id";
            dataGridView1.Columns[5].HeaderCell.Value = "Nome";
            dataGridView1.Columns[6].HeaderCell.Value = "Celular";
            dataGridView1.Columns[7].HeaderCell.Value = "Email";
        }

        private void btn_Buscar_Click_1(object sender, EventArgs e)
        {
            Agenda.Model.Agenda.Nome = tbx_nomebuscar.Text;
            ManipulaAgenda manipulaAgenda = new ManipulaAgenda();
            ManipulaAgenda.BuscarNome();

            Agenda.Model.Agenda.Nome = tbx_nomebuscar.Text;
            dataGridView1.DataSource = ManipulaAgenda.BuscarNome();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderCell.Value = "Id";
            dataGridView1.Columns[5].HeaderCell.Value = "Nome";
            dataGridView1.Columns[6].HeaderCell.Value = "Celular";
            dataGridView1.Columns[7].HeaderCell.Value = "Email";
        }
    }
}
