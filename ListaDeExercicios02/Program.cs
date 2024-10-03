using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;


class Program
{
    static void Main()
    {
        //NumeroImparOuPar();
        //VerificaIdade();
        //DiaDaSemana();
        //SomaDeNumerosDoArray();
        //ImprimeMenorEmaiorNumero();
        //exibirListaDeNomes();
        //ListaDeNomesDeTamanhoIndeterminado();
        //CompararNumeroDigitadoComODaLista();
        //CalcularFatorialDoNumero();
        //ExibirTabuada();
        //SomarNumerosPositivos();
        //ContarNumerosPares();
        //ImprimirListaDeNomes();
        SistemaDeBanco();
    }

    // Instrução IF
    static void NumeroImparOuPar()
    {
        Console.WriteLine("Digite um numero: "); int numero = int.Parse(Console.ReadLine());


        if (numero % 2 == 0)
        {
            Console.WriteLine("Número é Par");
        }
        else
        {
            Console.WriteLine("Número é Impar");
        }
    }

    static void VerificaIdade()
    {
        Console.WriteLine("Digite um numero: "); int idade = int.Parse(Console.ReadLine());


        if (idade < 18 || idade > 60)
        {
            Console.WriteLine("Entrada barrada por normas de segurança");
        }
        else
        {
            Console.WriteLine("Pode entrar!");
        }

    }

    // Instrução Switch
    static void DiaDaSemana()
    {
        Console.WriteLine("Digite um número entre 1 e 7: ");
        int dia;

        if (int.TryParse(Console.ReadLine(), out dia))
        {
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 2:
                    Console.WriteLine("Terça-feira");
                    break;
                case 3:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 4:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 5:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Número inválido. Por favor, digite um número entre 1 e 7.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
        }

        Console.ReadLine();
    }

    // Arrays
    static void SomaDeNumerosDoArray()
    {
        int[] array = new int[5];
        int numero;
        int count = 0;

        while (count < 5)
        {
            Console.WriteLine("Digite um número: ");

            if (int.TryParse(Console.ReadLine(), out numero))
            {
                array[count] = numero;
                count++;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
            }
        }

        Console.WriteLine("Números digitados:");
        foreach (int num in array)
        {
            Console.WriteLine(num);
        }

        Console.ReadLine();
    }

    static void ImprimeMenorEmaiorNumero()
    {
        int[] array = new int[10];
        int numero;
        int count = 0;
        int menorNumero = int.MaxValue;
        int maiorNumero = int.MinValue;

        while (count < 10)
        {
            Console.WriteLine("Digite um número: ");

            if (int.TryParse(Console.ReadLine(), out numero))
            {
                array[count] = numero;
                count++;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
            }
        }

        Console.WriteLine("Números digitados:");
        foreach (int num in array)
        {
            if (num > maiorNumero) maiorNumero = num;
            if (num < menorNumero) menorNumero = num;
        }

        Console.WriteLine($"Menor numero:{menorNumero}");
        Console.WriteLine($"Maior numero:{maiorNumero}");
        Console.ReadLine();
    }

    static void exibirListaDeNomes()
    {
        string[] names = new string[5];
        int index = 0;

        while (index < names.Length)
        {
            Console.WriteLine("Digite um nome: "); string nome = Console.ReadLine();
            names[index] = nome;
            index++;
        }

        Console.WriteLine("Nomes inseridos:");
        for (int i = names.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(names[i]);
        }

        Console.ReadLine();
    }

    // Listas
    static void ListaDeNomesDeTamanhoIndeterminado()
    {
        List<string> names = new List<string>();
        bool pararPrograma = false;

        Console.WriteLine("Digite um nome:"); string entrada = Console.ReadLine();
        names.Add(entrada);

        while (!pararPrograma)
        {
            Console.WriteLine("Digite umm nome\nou Ok para finalizar:"); string nome = Console.ReadLine();

            if (nome == "Ok")
            {
                pararPrograma = true;
            }
            else
            {
                names.Add(nome);
            }

        }

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

    }


    static void CompararNumeroDigitadoComODaLista()
    {
        List<int> numeros = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        int count = 0;
        bool numeroEncontrado = false;

        while (count < 3 && !numeroEncontrado)
        {
            Console.WriteLine("Digite um número entre 1 e 100:");
            int entrada;

            while (!int.TryParse(Console.ReadLine(), out entrada))
            {
                Console.WriteLine("Por favor, digite um número válido entre 1 e 100:");
            }

            if (numeros.Contains(entrada))
            {
                Console.Clear();
                Console.WriteLine("Parabéns, este número está na lista!");
                numeroEncontrado = true;
            }
            else
            {
                count++;
                Console.WriteLine("Você errou, tente novamente.");
                Console.WriteLine($"Tentativa {count} de 3.");
            }
        }

        if (!numeroEncontrado)
        {
            Console.WriteLine("Você tentou 3 vezes, acabou as chances.");
        }

        Console.ReadLine();
    }

    // Instrução For
    static void CalcularFatorialDoNumero()
    {
        {
            Console.WriteLine("Digite um número inteiro positivo:");
            int numero;


            while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
            {
                Console.WriteLine("Por favor, digite um número inteiro positivo:");
            }

            int fatorial = 1;

            for (int i = 2; i <= numero; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine($"O fatorial de {numero} é {fatorial}.");
            Console.ReadLine();
        }
    }

    static void ExibirTabuada()
    {
        {
            Console.WriteLine("Digite um número inteiro: ");
            int numero;


            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Por favor, digite um número inteiro: ");
            }


            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine($"{i} x {numero} = {i * numero}");
            }


            Console.ReadLine();
        }
    }

    // Introdução While
    static void SomarNumerosPositivos()
    {
        int soma = 0;
        int numero = 0;

        while (numero >= 0)
        {
            Console.WriteLine("Digite um número - ou um número negativo para parar: ");

            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Digite um número inteiro: ");
            }

            if (numero >= 0) soma += numero;
        }

        Console.WriteLine($"A soma dos números positivos é: {soma}");
        Console.ReadLine();
    }

    static void ContarNumerosPares()
    {
        int numerosPares = 0;
        int numero = -1;

        while (numero != 0)
        {
            Console.WriteLine("Digite um número ou 0 para parar: ");

            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Digite um número inteiro: ");
            }

            if (numero != 0 && numero % 2 == 0) numerosPares++;
        }

        Console.WriteLine($"A quantidade de números pares inseridos é: {numerosPares}");
        Console.ReadLine();

    }

    // Instrução Foreach

    static void ImprimirListaDeNomes()
    {
        List<string> nomes = new List<string> { "Lucas", "Maria", "João", "Ana", "Pedro" };

        Console.WriteLine("Lista de nomes:");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
        Console.ReadLine();

    }

    //Instrução Do-While

    static void SistemaDeBanco()
    {
        bool continuar = true;
        decimal saldo = 0;

        while (continuar)
        {
            // Exibir o menu
            Console.Clear();
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1. Consultar saldo");
            Console.WriteLine("2. Realizar depósito");
            Console.WriteLine("3. Realizar saque");
            Console.WriteLine("4. Sair");
            Console.WriteLine("================");
            Console.Write("Escolha uma opção: ");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    ConsultarSaldo(saldo);
                    break;
                case "2":
                    saldo = RealizarDeposito(saldo);
                    break;
                case "3":
                    saldo = RealizarSaque(saldo);
                    break;
                case "4":
                    continuar = false;
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            if (continuar)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

    static void ConsultarSaldo(decimal saldo)
    {
        Console.Clear();
        Console.WriteLine($"Seu saldo atual é: R$ {saldo:F2}");
    }

    static decimal RealizarDeposito(decimal saldo)
    {
        Console.Clear();
        Console.Write("Digite o valor para depósito: ");
        decimal deposito;

        while (!decimal.TryParse(Console.ReadLine(), out deposito) || deposito <= 0)
        {
            Console.WriteLine("Por favor, insira um valor válido para depósito.");
        }

        saldo += deposito;
        Console.WriteLine($"Depósito realizado com sucesso! Seu novo saldo é: R$ {saldo:F2}");
        return saldo;
    }

    static decimal RealizarSaque(decimal saldo)
    {
        Console.Clear();
        Console.Write("Digite o valor para saque: ");
        decimal saque;

        while (!decimal.TryParse(Console.ReadLine(), out saque) || saque <= 0)
        {
            Console.WriteLine("Por favor, insira um valor válido para saque.");
        }

        if (saque > saldo)
        {
            Console.WriteLine("Saldo insuficiente.");
        }
        else
        {
            saldo -= saque;
            Console.WriteLine($"Saque realizado com sucesso! Novo saldo: R$ {saldo:F2}");
        }

        return saldo;
    }


}
