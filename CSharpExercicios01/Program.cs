using System;


class Program
{
    static void Main()
    {
        //SomaDeNumerosPares(5, 10);
        //DiferencaEntreNumeros(5, 10);
        //DividindoEMultiplicando(5, 11);
        //RestoDaDivisaoPor2(10, 3);
        //AtribuirValorDigitado();
        //AtribuiValorEValorDigitado();
        //AtribuiValorESubtraiPeloValorDigitado();


        //VerificaSePodeEntrarNaFesta("João");
        //TreinandoSwitch("Ana");
    }

    static void SomaDeNumerosPares(int n1, int n2)
    {
        Console.WriteLine($"A soma de {n1} + {n2} é = {n1 + n2}");
    }

    static void DiferencaEntreNumeros(int n1, int n2)
    {
        Console.WriteLine($"A diferença entre {n1} e {n2} é = {n1 % n2}");
    }

    static void DividindoEMultiplicando(double n1, double n2)
    {
        Console.WriteLine($"A multiplicação de {n1} por {n2} é = {n1 * n2}");
        Console.WriteLine($"A divisão de {n1} por {n2} é = {n1 / n2}");
    }

    static void RestoDaDivisaoPor2(int n1, int n2)
    {
        Console.WriteLine($"O resto de {n1} dividido por {n2} é = {n1 % n2}");
    }

    static void AtribuirValorDigitado()
    {
        int num1 = 1;
        Console.Write("Digite um número: ");
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine($"Variavel inteira {num1} + {input} = {num1 + input}");
    }

    static void AtribuiValorEValorDigitado()
    {
        int num1 = 1;
        int num2 = 5;

        Console.Write("Digite um número: "); int input = int.Parse(Console.ReadLine());

        Console.WriteLine($"{num1} + {num2} + {input} = {num1 + num2 + input}");
    }

    static void AtribuiValorESubtraiPeloValorDigitado()
    {
        int n1 = 5;
        int n2 = 5;
        int soma = n1 + n2;

        Console.Write("Digite um número: "); int input = int.Parse(Console.ReadLine());
        Console.WriteLine($"{n1} + {n2} - {input} é = {soma - input}");
    }

    static void teste()
    {
        Console.Write("Digite um número: "); int input = int.Parse(Console.ReadLine());

    }


    static void VerificaSePodeEntrarNaFesta(string name)
    {
        string lista = "Ana, maria, João";

        Console.WriteLine(lista.Contains(name) ? $"Pode entrar {name}" : $"Desculpe {name}, seu nome não está na lista");
    }

    static void TreinandoSwitch(string name)
    {

        Console.Write("Digite o nome do mês: ");
        string mes = Console.ReadLine();

        // Conjunto de meses com 31 dias
        HashSet<string> names = new HashSet<string>
        {
            ""
        };


        switch (name = "l")
        {
            case valor1:
                Console.WriteLine("Pode entrar");
                break;
            case valor2:
                Console.WriteLine("Pode entrar");
                break;
            case valor3:
                Console.WriteLine("Pode entrar");
                break;
        }
    }


}
