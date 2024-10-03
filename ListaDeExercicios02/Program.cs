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
        CalcularFatorialDoNumero();
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

            // Validação de entrada para garantir que seja um número inteiro positivo
            while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
            {
                Console.WriteLine("Por favor, digite um número inteiro positivo:");
            }

            // Inicializa o fatorial como 1, já que o fatorial de 0 e 1 é 1
            int fatorial = 1;

            // Calcula o fatorial usando um loop for
            for (int i = 2; i <= numero; i++)
            {
                fatorial *= i;
            }

            // Exibe o resultado
            Console.WriteLine($"O fatorial de {numero} é {fatorial}.");
            Console.ReadLine();
        }
    }
}
