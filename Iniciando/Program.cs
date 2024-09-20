using System;


class Program
{
    static void Main()
    {
        //VerificarNumero()

        string arrayDeNumeros = "1,2,3,4,5,6,7,8,9,10";
        //ImprimirNumerosPares(arrayDeNumeros);
        //VerificaNumeroPrimo();
        //Aula3DataTime();
        Operadores();
    }

    static void VerificarNumero()
    {
        // Solicita ao usuário para inserir um número
        Console.Write("Digite um número: ");
        string input = Console.ReadLine();



        // Converte a entrada do usuário para um número inteiro
        int numero;
        bool sucesso = int.TryParse(input, out numero); // O 'out' é usado para armazenar o valor convertido se a conversão for bem-sucedida



        if (sucesso)
        {
            // Verifica se o número é positivo, negativo ou zero
            if (numero > 0)
            {
                Console.WriteLine("O número é positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O número é negativo.");
            }
            else
            {
                Console.WriteLine("O número é zero.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
        }
    }
    static void ImprimirNumerosPares(string args)
    {
        // Cria uma lista de inteiros para armazenar os números
        List<int> lista = new List<int>();



        // Split para dividir a string com base na vírgula
        string[] numeros = args.Split(',');



        // Processa cada número da string
        foreach (string numStr in numeros) //foreach é utilizado para percorrer cada item dentro de um array
        {
            // Tenta converter cada string para inteiro
            int num;
            if (int.TryParse(numStr, out num) && num % 2 == 0)
            {
                lista.Add(num);
            }
        }



        // Exibe a quantidade de números pares
        Console.WriteLine($"Quantidade de números pares: {lista.Count}");



        // Exibe cada número par com seu índice
        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine($"Item: {i}, Valor: {lista[i]}");
        }
    }
    static void VerificaNumeroPrimo()
    {
        Console.WriteLine("Digite um número:");
        int numero = int.Parse(Console.ReadLine());




        if (numero <= 1)
        {
            Console.WriteLine("Não é primo!");
        }
        else
        {
            bool isPrimo = true;



            // Verifica se o número é divisível por algum número entre 2 e a raiz quadrada do número
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    isPrimo = false;
                    break;
                }
            }



            Console.WriteLine(isPrimo ? "É primo!" : "Não é primo!");
        }



        Console.WriteLine("Fim do código!");
    }
    static void Aula3DataTime()
    {
        string myString = "name";
        bool myBool = false;
        int myNumber = 1;
        List<string> lista = new List<string>();
        string[] array = { "" };
        object tipo1 = new { };

        Console.Write("Qual seu dia de nacsimento?");
        int dia = int.Parse(Console.ReadLine());


        Console.Write("Qual seu ano nacsimento?");
        int mes = int.Parse(Console.ReadLine());


        Console.Write("Qual seu mês nacsimento?");
        int ano = int.Parse(Console.ReadLine());


        var data = new DateTime(ano, mes, dia);
        Console.WriteLine(data.ToString());
    }
    static void Operadores()
    {
        int valor = 10;

        Console.WriteLine(valor);
        valor += 12;

        Console.WriteLine(valor);
        valor -= 2;

        Console.WriteLine(valor);
        valor *= 10;

        Console.WriteLine(valor);
        valor /= 2;

        Console.WriteLine(valor);

        valor %= 150;

        Console.WriteLine(valor++);
        Console.WriteLine(valor);
        Console.WriteLine(++valor);
    }
}
