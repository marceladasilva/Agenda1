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
    public partial class BuscarCod : Form
    {
        public BuscarCod()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bnt_Buscar_Click(object sender, EventArgs e)
        {
            Agenda.Model.Agenda.Id = Convert.ToInt32(txb_IdBuscar.Text);
            ManipulaAgenda manipulaAgenda = new ManipulaAgenda();
            manipulaAgenda.BuscarCod();

            txb_Nome.Text = Agenda.Model.Agenda.Nome;
            txb_Email.Text = Agenda.Model.Agenda.Email;
            txb_Celular.Text = Agenda.Model.Agenda.Fone;
        }
    }
}
