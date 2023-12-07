using Agenda.Model;
using Agenda1.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Agenda.Controller
{
    internal class ManipulaAgenda
    {
        public void Adicionar()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_AdicionarPessoa", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nome", Agenda.Model.Agenda.Nome);
                cmd.Parameters.AddWithValue("@fone", Agenda.Model.Agenda.Fone);
                cmd.Parameters.AddWithValue("@email", Agenda.Model.Agenda.Email);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Pessoa Cadastrada com sucesso.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Apagar()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_ApagarPessoa", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@Id", Agenda.Model.Agenda.Id);
                cn.Open();
                cmd.ExecuteReader();
                MessageBox.Show("Registro excluido com sucesso");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Atualizar()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_AtualizarPessoa", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@Id", Agenda.Model.Agenda.Id);
                cmd.Parameters.AddWithValue("@nome", Agenda.Model.Agenda.Nome);
                cmd.Parameters.AddWithValue("@fone", Agenda.Model.Agenda.Fone);
                cmd.Parameters.AddWithValue("@email", Agenda.Model.Agenda.Email);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pessoa Alterado com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agenda Não Alterada");
            }
        }

        public void BuscarCod()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscarPessoaCod", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@Id", Agenda.Model.Agenda.Id);
                cn.Open();
                var dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Agenda.Model.Agenda.Id = Convert.ToInt32(dr["Id"]);
                    Agenda.Model.Agenda.Nome = dr["nome"].ToString();
                    Agenda.Model.Agenda.Fone = dr["fone"].ToString();
                    Agenda.Model.Agenda.Email = dr["email"].ToString();
                }
                else
                {
                    Agenda.Model.Agenda.Id = 0;
                    Agenda.Model.Agenda.Email = "";
                    Agenda.Model.Agenda.Fone = "";
                    Agenda.Model.Agenda.Nome = "";
                    MessageBox.Show("Pessoa não existente, verifique o Código!");
                }
            }
            catch (Exception ex)
            {

            }
        }

        public static BindingSource BuscarNome()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_BuscarPessoaNome", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nome", Agenda.Model.Agenda.Nome);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;

        }
    }
}