using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalhando_com_Classes
{

    public class Aluno
    {
        public string Nome;
        public int Idade;
        public string Matricula;


        public int CalcularEmMeses()
        {
            var meses = new Aluno()
            {
                Nome = "André",
                Idade = 50,
                Matricula = "978643",
            };
            return Idade * 12;
        }
        public static void Info()
        {
            Console.WriteLine($"Nome:");
        }

        public void Executar()
        {
            var meses = new Aluno()
            {
                Nome = "André",
                Idade = 50,
                Matricula = "978643",
            };
        }
    }
}