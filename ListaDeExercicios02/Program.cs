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
        CompararNumeroDigitadoComODaLista();
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
        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(40);
        numbers.Add(50);
        numbers.Add(60);
        numbers.Add(70);
        numbers.Add(80);
        numbers.Add(90);
        numbers.Add(100);

        int count = 0;

        Console.WriteLine("Digite um numero entre 1 e 100:"); int entrada = int.Parse(Console.ReadLine());

        if (numbers.Contains(entrada)) Console.WriteLine("Parabéns, este número está na lista!");
        count++;

        while (count < 3)
        {
            Console.WriteLine("Você errou, tente novamente:"); int numero = int.Parse(Console.ReadLine());

            if (numbers.Contains(numero)) Console.WriteLine("Parabéns, este número está na lista!");
            count++;


            if (count == 3) Console.WriteLine("Você tentou 3 vezes, acabou as chances");
        }

        Console.ReadLine();
    }
}
