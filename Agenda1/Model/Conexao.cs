using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda1.Model
{
    internal class Conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marcela.tsilva4\source\repos\Agenda1\Agenda1\BancoDeDados\AgendaFinal.mdf;Integrated Security=True";
        }
    }
}
