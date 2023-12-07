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
    public partial class Adicionar : Form
    {
        public Adicionar()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Agenda.Model.Agenda.Nome = txb_nome.Text;
            Agenda.Model.Agenda.Fone = mtxb_telefone.Text;
            Agenda.Model.Agenda.Email = txb_email.Text;

            ManipulaAgenda manipulaAgenda = new ManipulaAgenda();
            manipulaAgenda.Adicionar();
        }
    }
}
