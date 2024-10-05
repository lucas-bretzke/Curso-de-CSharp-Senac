using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;


class Program
{
    static void Main()
    {
        //CheckIfNumberIsOddOrEven();
        //CheckUserAge();
        //DisplayDayOfTheWeek();
        //SumNumbersInArray();
        //PrintSmallestAndLargestNumber();
        //DisplayListOfNames();
        //InputNamesWithUnknownLength();
        //CompareEnteredNumberWithList();
        //CalculateFactorialOfNumber();
        //DisplayMultiplicationTable();
        //SumPositiveNumbers();
        //CountEvenNumbers();
        //PrintNamesList();
        BankSystem();
    }

    // Instrução IF
    static void CheckIfNumberIsOddOrEven()
    {
        Console.WriteLine("Digite um numero: "); int number = int.Parse(Console.ReadLine());


        if (number % 2 == 0)
        {
            Console.WriteLine("Número é Par");
        }
        else
        {
            Console.WriteLine("Número é Impar");
        }
    }

    static void CheckUserAge()
    {
        Console.WriteLine("Digite um numero: "); int age = int.Parse(Console.ReadLine());


        if (age < 18 || age > 60)
        {
            Console.WriteLine("Entrada barrada por normas de segurança");
        }
        else
        {
            Console.WriteLine("Pode entrar!");
        }

    }

    // Instrução Switch
    static void DisplayDayOfTheWeek()
    {
        Console.WriteLine("Digite um número entre 1 e 7: ");
        int day;

        if (int.TryParse(Console.ReadLine(), out day))
        {
            switch (day)
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
    static void SumNumbersInArray()
    {
        int[] array = new int[5];
        int number;
        int count = 0;

        while (count < 5)
        {
            Console.WriteLine("Digite um número: ");

            if (int.TryParse(Console.ReadLine(), out number))
            {
                array[count] = number;
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

    static void PrintSmallestAndLargestNumber()
    {
        int[] array = new int[10];
        int number;
        int count = 0;
        int smallestNumber = int.MaxValue;
        int largestNumber = int.MinValue;

        while (count < 10)
        {
            Console.WriteLine("Digite um número: ");

            if (int.TryParse(Console.ReadLine(), out number))
            {
                array[count] = number;
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
            if (num > largestNumber) largestNumber = num;
            if (num < smallestNumber) smallestNumber = num;
        }

        Console.WriteLine($"Menor numero:{smallestNumber}");
        Console.WriteLine($"Maior numero:{largestNumber}");
        Console.ReadLine();
    }

    static void DisplayListOfNames()
    {
        string[] names = new string[5];
        int index = 0;

        while (index < names.Length)
        {
            Console.WriteLine("Digite um nome: "); string name = Console.ReadLine();
            names[index] = name;
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
    static void InputNamesWithUnknownLength()
    {
        List<string> names = new List<string>();
        bool stopProgram = false;

        Console.WriteLine("Digite um nome:"); string prohibited = Console.ReadLine();
        names.Add(prohibited);

        while (!stopProgram)
        {
            Console.WriteLine("Digite umm nome\nou Ok para finalizar:"); string name = Console.ReadLine();

            if (name == "Ok")
            {
                stopProgram = true;
            }
            else
            {
                names.Add(name);
            }

        }

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

    }


    static void CompareEnteredNumberWithList()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        int count = 0;
        bool numberFound = false;

        while (count < 3 && !numberFound)
        {
            Console.WriteLine("Digite um número entre 1 e 100:");
            int prohibited;

            while (!int.TryParse(Console.ReadLine(), out prohibited))
            {
                Console.WriteLine("Por favor, digite um número válido entre 1 e 100:");
            }

            if (numbers.Contains(prohibited))
            {
                Console.Clear();
                Console.WriteLine("Parabéns, este número está na lista!");
                numberFound = true;
            }
            else
            {
                count++;
                Console.WriteLine("Você errou, tente novamente.");
                Console.WriteLine($"Tentativa {count} de 3.");
            }
        }

        if (!numberFound)
        {
            Console.WriteLine("Você tentou 3 vezes, acabou as chances.");
        }

        Console.ReadLine();
    }

    // Instrução For
    static void CalculateFactorialOfNumber()
    {
        {
            Console.WriteLine("Digite um número inteiro positivo:");
            int number;


            while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
            {
                Console.WriteLine("Por favor, digite um número inteiro positivo:");
            }

            int factorial = 1;

            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"O fatorial de {number} é {factorial}.");
            Console.ReadLine();
        }
    }

    static void DisplayMultiplicationTable()
    {
        {
            Console.WriteLine("Digite um número inteiro: ");
            int number;


            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Por favor, digite um número inteiro: ");
            }


            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"{i} x {number} = {i * number}");
            }


            Console.ReadLine();
        }
    }

    // Introdução While
    static void SumPositiveNumbers()
    {
        int sum = 0;
        int number = 0;

        while (number >= 0)
        {
            Console.WriteLine("Digite um número - ou um número negativo para parar: ");

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Digite um número inteiro: ");
            }

            if (number >= 0) sum += number;
        }

        Console.WriteLine($"A soma dos números positivos é: {sum}");
        Console.ReadLine();
    }

    static void CountEvenNumbers()
    {
        int evenNumbers = 0;
        int number = -1;

        while (number != 0)
        {
            Console.WriteLine("Digite um número ou 0 para parar: ");

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Digite um número inteiro: ");
            }

            if (number != 0 && number % 2 == 0) evenNumbers++;
        }

        Console.WriteLine($"A quantidade de números pares inseridos é: {evenNumbers}");
        Console.ReadLine();

    }

    // Instrução Foreach

    static void PrintNamesList()
    {
        List<string> names = new List<string> { "Lucas", "Maria", "João", "Ana", "Pedro" };

        Console.WriteLine("Lista de nomes:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        Console.ReadLine();

    }

    //Instrução Do-While

    static void BankSystem()
    {
        bool @continue = true;
        decimal balance = 0;
        int attempt = 0;


        while (attempt < 3 && !ValidatePassword())
        {
            attempt++;
            Console.Clear();
            Console.WriteLine("Senha incorreta. Tente novamente.");
            Console.WriteLine($"Tentativa {attempt} de 3");
        }


        if (attempt >= 3)
        {
            Console.WriteLine("Número máximo de tentativas alcançado. O programa será encerrado.");
            return;
        }


        while (@continue)
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

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    checkBalance(balance);
                    break;
                case "2":
                    balance = MakeDeposit(balance);
                    break;
                case "3":
                    balance = MakeWithdrawal(balance);
                    break;
                case "4":
                    @continue = false;
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            if (@continue)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

    static bool ValidatePassword()
    {
        string password = "333333";
        string input;

        Console.Write("Informe sua senha: ");
        input = Console.ReadLine();

        return input == password;
    }

    static void checkBalance(decimal balance)
    {
        Console.Clear();
        Console.WriteLine($"Seu saldo atual é: R$ {balance:F2}");
    }

    static decimal MakeDeposit(decimal balance)
    {
        Console.Clear();
        Console.Write("Digite o valor para depósito: ");
        decimal deposit;

        while (!decimal.TryParse(Console.ReadLine(), out deposit) || deposit <= 0)
        {
            Console.WriteLine("Por favor, insira um valor válido para depósito.");
        }

        balance += deposit;
        Console.WriteLine($"Depósito realizado com sucesso! Seu novo saldo é: R$ {balance:F2}");
        return balance;
    }

    static decimal MakeWithdrawal(decimal balance)
    {
        Console.Clear();
        Console.Write("Digite o valor para saque: ");
        decimal sake;

        while (!decimal.TryParse(Console.ReadLine(), out sake) || sake <= 0)
        {
            Console.WriteLine("Por favor, insira um valor válido para saque.");
        }

        if (sake > balance)
        {
            Console.WriteLine("Saldo insuficiente.");
        }
        else
        {
            balance -= sake;
            Console.WriteLine($"Saque realizado com sucesso! Novo saldo: R$ {balance:F2}");
        }

        return balance;
    }


}
