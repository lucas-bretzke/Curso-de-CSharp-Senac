using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuHelloWorld
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int QuantidadeEstoque;

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEstoque = quantidade;
        }

        public static string FormatarValor(double valor)
        {
            //return valor.ToString("C");
            return "R$ " + valor.ToString("N");
        }

        public void AtualizarEstoque(int quantidade)
        {
            QuantidadeEstoque = quantidade;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Dados do produto");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: {Preco}");
            Console.WriteLine($"Quantidade em estoque: {QuantidadeEstoque}");
        }
    }

    public class ContaBancaria
    {
        private static int _QtdContas = 0;
        // public int QtdContas { get => _QtdContas; }
        public static int QtdContas
        {
            get
            {
                return _QtdContas;
            }
        }

        public string Titular;
        public double Saldo;

        public ContaBancaria()
        {
            _QtdContas++;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Valor de {valor} depositado!");
        }

        public void Sacar(double valor)
        {
            if (Saldo < valor)
            {
                Console.WriteLine("Saque não realizado!");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine("Saque realizado!");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Sua conta possui o saldo de {Saldo}");
        }
    }

    public class Carro
    {
        public const int PORCENTAGEM_RESERVA = 20;

        public string Modelo;
        public int Ano;
        public int TanqueLimite;
        public int TanqueAtual;

        // ctor + TAB
        public Carro()
        {

        }

        public Carro(string Modelo)
        {
            this.Modelo = Modelo;
        }

        public Carro(string modelo, int ano)
        {
            Modelo = modelo;
            Ano = ano;
        }

        public void Info()
        {
            Console.WriteLine($"Carro de modelo {Modelo} e ano {Ano}");
        }

        public bool Reserva()
        {
            var porcentagemLimite = (TanqueLimite / 100) * PORCENTAGEM_RESERVA;
            Console.WriteLine("Dados do tanque:");
            Console.WriteLine($"20%: {porcentagemLimite}");
            Console.WriteLine($"Atual: {TanqueAtual}");

            return TanqueAtual < porcentagemLimite;
        }
    }

    public class Mamifero
    {
        public string Nome;
        public string NomeCientifico;
        public int Idade;

        public void Info()
        {
            Console.WriteLine($"Os dados do animal são:");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Nome científico: {NomeCientifico}");
            Console.WriteLine($"Idade: {Idade}");
        }

        public void Respirar()
        {
            Console.WriteLine("O animal está respirando");
        }
    }

    public class Livro
    {
        public string Nome;
        public string Autor;
    }

    public class Calculadora
    {
        public decimal Somar(decimal valor1, decimal valor2)
        {
            return valor1 + valor2;
        }

        public decimal Subtrair(decimal valor1, decimal valor2)
        {
            return valor1 - valor2;
        }
    }

    public class Pessoa
    {
        private static int _ContagemPessoasCadastradas = 0;
        public static int ContagemPessoasCadastradas { get => _ContagemPessoasCadastradas; }

        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa()
        {
            _ContagemPessoasCadastradas++;
        }
    }





    public class Product
    {
        private string nome;
        private decimal preco;

        public Product(string name, decimal price)
        {
            nome = name;
            Price = price;
        }

        public string Name { get; set; }

        public decimal Price
        {
            get => preco;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), "O preço não pode ser negativo.");
                preco = value;
            }
        }

        public void AlterarNome(string newName)
        {
            Name = newName;
        }

        public void AlterarPreco(decimal newPrice)
        {
            Price = newPrice;
        }

        public string MostrarDetalhes()
        {
            return $"Nome do produto: {nome}, Preço: ${preco:F2}";
        }




        public static void Encapsulamento()
        {
            Product product = new Product("Laptop", 999.99m);
            Console.WriteLine(product.MostrarDetalhes());

            product.AlterarNome("Laptop Gamer");
            product.AlterarPreco(1299.99m);
            Console.WriteLine(product.MostrarDetalhes());

            try
            {
                product.AlterarPreco(-500m); // This should raise an error
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public class Veiculo
    {
        public int Velocidade { get; set; }

        public void Mover()
        {
            Console.WriteLine("O veiculo está se movendo");
        }
    }


    public class Carro2 : Veiculo
    {
        public int QtdPortas { get; set; }

        public void Buzinar()
        {
            Console.WriteLine("BHEEE");
        }
    }



    public class Animal
    {
        protected string Som {get; set;}

        public void EmitirSom()
        {
            Console.WriteLine($"Som do animal: {Som}");
        }
    }


    public class Gato : Animal
    {
      public Gato()
        {
            Som = "MIAU";
        }
    }

     public class Cachorro : Animal
    {
        public Cachorro()
        {
            Som = "AUAU";
         }
    }




    public class Executor
    {
        public static void Executar()
        {
            //// Construção usando construtor padrão
            //var carro1 = new Carro();
            //carro1.Modelo = "Clio";
            //carro1.Ano = 1995;
            //carro1.TanqueLimite = 100;
            //carro1.TanqueAtual = 21;

            //// Construção usando construtor padrão + construtor de objetos C#
            //var carro2 = new Carro()
            //{
            //    Modelo = "HB20",
            //    Ano = 2022,
            //    TanqueLimite = 100,
            //    TanqueAtual = 9,
            //};

            //var carro3 = new Carro("Fusca", 1976);

            //var carro4 = new Carro("Gol");

            //carro1.Info();
            //Console.WriteLine(string.Empty);
            //carro2.Info();
            //Console.WriteLine(string.Empty);
            //carro3.Info();
            //Console.WriteLine(string.Empty);
            //carro4.Info();


            ////Console.WriteLine($"Carro de modelo {carro.Modelo} e ano {carro.Ano}");
            //Console.WriteLine($"O carro {(carro.Reserva() ? "SIM" : "NÃO")} está na reserva!");

            //var cachorro = new Mamifero();
            //cachorro.Nome = "Pedrinho";
            //cachorro.NomeCientifico = "Cachorrus";
            //cachorro.Idade = 6;

            //cachorro.Info();
            //cachorro.Respirar();

            //var livro = new Livro();
            //livro.Nome = "Senhor dos anéis";
            //livro.Autor = "Token";

            //var calc = new Calculadora();
            //Console.WriteLine(calc.Somar(256, 64));

            //Console.WriteLine($"Existem {Pessoa.ContagemPessoasCadastradas} pessoas cadastradas no sistema!");

            //var p1 = new Pessoa()
            //{
            //    Nome = "João",
            //    Idade = 18,
            //};

            //var p2 = new Pessoa()
            //{
            //    Nome = "Mario",
            //    Idade = 16,
            //};

            //var p3 = new Pessoa()
            //{
            //    Nome = "Maria",
            //    Idade = 23,
            //};

            //p1 = new Pessoa();
            //p1 = new Pessoa();
            //p1 = new Pessoa();
            //p1 = new Pessoa();
            //p1 = new Pessoa();

            //Console.WriteLine($"Existem {Pessoa.ContagemPessoasCadastradas} pessoas cadastradas no sistema!");

            //var c1 = new ContaBancaria();
            //var c2 = new ContaBancaria();
            //var c3 = new ContaBancaria();

            //Console.WriteLine($"Existem {ContaBancaria.QtdContas} contas cadastradas no sistema!");

            //var p1 = new Produto();
            //p1.Preco = 1568.24;

            //Console.WriteLine(Produto.FormatarValor(p1.Preco));


            /////
            //Product.Encapsulamento();

            //var carro = new Carro2();
            //carro.Mover();
            //carro.Buzinar();


            var gato = new Gato();
            gato.EmitirSom();
            
            var cachorro = new Cachorro();
            cachorro.EmitirSom();

        }
    }
}
