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
    public partial class Apagar : Form
    {
        public Apagar()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Agenda.Model.Agenda.Id = Convert.ToInt32(tbx_IdBuscar.Text);
            ManipulaAgenda manipulaAgenda = new ManipulaAgenda();
            manipulaAgenda.BuscarCod();

            tbx_Nome.Text = Agenda.Model.Agenda.Nome;
            tbx_Email.Text = Agenda.Model.Agenda.Email;
            tbx_Celular.Text = Agenda.Model.Agenda.Fone;
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            ManipulaAgenda manipulaAgenda = new ManipulaAgenda();
            manipulaAgenda.Apagar();
            tbx_IdBuscar.Text = "";
            tbx_Celular.Text = "";
            tbx_Nome.Text = "";
            tbx_Email.Text = "";
        }
    }
}
