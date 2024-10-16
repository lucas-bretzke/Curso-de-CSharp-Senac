using System;
using Trabalhando_com_Classes;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa();
            pessoa.Executar();

            var aluno = new Aluno();
            aluno.Executar();

            var contaBancaria = new ContaBancaria("Fulano");
            contaBancaria.ExibirSaldo();

        }
    }
}
