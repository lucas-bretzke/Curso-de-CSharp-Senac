using System;

namespace Trabalhando_com_Classes
{
    public class Pessoa
    {
        private static int _contagemPessoasCadastradas = 0;
        public static int ContagemPessoasCadastradas => _contagemPessoasCadastradas;

        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa()
        {
            _contagemPessoasCadastradas++;
        }

        public void Executar()
        {
            var p1 = new Pessoa()
            {
                Nome = "Lucas",
                Idade = 18,
            };   
            
            var p10 = new Pessoa()
            {
                Nome = "Fulano",
                Idade = 18,
            };

            var p2 = new Pessoa();
            var p3 = new Pessoa();
            var p4 = new Pessoa();
            var p5 = new Pessoa();
            var p6 = new Pessoa();
            var p = new Pessoa();

            Console.WriteLine($"Quantidade de pessoas cadastradas: {ContagemPessoasCadastradas}");
        }
    }
}
