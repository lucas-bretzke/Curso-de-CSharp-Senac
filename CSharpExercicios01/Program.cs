using System;
using System.Collections.Generic;


class Subject
{
    public string Name { get; set; }
    public string Note { get; set; }
}


class Program
{
    static void Main()
    {
        //NotasDosAlunos();
        //CriandoLista();

        //SomaDeNumerosPares(5, 10);
        //DiferencaEntreNumeros(5, 10);
        //DividindoEMultiplicando(5, 11);
        //RestoDaDivisaoPor2(10, 3);
        //AtribuirValorDigitado();
        //AtribuiValorEValorDigitado();
        //AtribuiValorESubtraiPeloValorDigitado();


        //VerificaSePodeEntrarNaFesta("João");
        //TreinandoSwitch("Ana");
        //LidandoComFor();
        //ImprimindoTabuadaDoValorDigitado();
        ImprimirMaiorEMenorNumero();
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

    //IONCONPLETO
    static void teste()
    {
        Console.Write("Digite um número: "); int input = int.Parse(Console.ReadLine());

    }


    static void VerificaSePodeEntrarNaFesta(string name)
    {
        string lista = "Ana, maria, João";

        Console.WriteLine(lista.Contains(name) ? $"Pode entrar {name}" : $"Desculpe {name}, seu nome não está na lista");
    }

    //INCONCLUIDO
    //static void TreinandoSwitch(string name)
    //{

    //    Console.Write("Digite o nome do mês: ");
    //    string mes = Console.ReadLine();

    //    // Conjunto de meses com 31 dias
    //    HashSet<string> names = new HashSet<string>
    //    {
    //        ""
    //    };


    //    switch (name = "l")
    //    {
    //        case valor1:
    //            Console.WriteLine("Pode entrar");
    //            break;
    //        case valor2:
    //            Console.WriteLine("Pode entrar");
    //            break;
    //        case valor3:
    //            Console.WriteLine("Pode entrar");
    //            break;
    //    }
    //}


    //Exercicios aula 2

    //INCONCLUIDO
    //static void NotasDosAlunos()
    //{
    //    List<Subject> subjects = new List<Subject>();

    //    while (subjects.Count < 3)
    //    {
    //        Console.WriteLine("Qual o nome do aluno?: ");
    //        string nome = Console.ReadLine();

    //        Console.WriteLine($"Qual a nota do {nome}?: ");
    //        double nota;

    //        // Valida a entrada da nota
    //        while (!double.TryParse(Console.ReadLine(), out nota))
    //        {
    //            Console.WriteLine("Por favor, insira uma nota válida:");
    //        }

    //        subjects.Add(new Subject { Name = nome, Note = nota });
    //    }

    //    // Exibir as notas
    //    Console.WriteLine("Notas:");
    //    foreach (var subject in subjects)
    //    {
    //        Console.WriteLine($"Nome: {subject.Name}, Nota: {subject.Note}");
    //    }
    //}


    static void LidandoComFor()
    {
        string[] alunos = { "Lucas", "Valentinba", "Fulano" };

        foreach (string aluno in alunos)
        {
            Console.WriteLine(aluno);
        }

        Console.WriteLine("Pressione Enter para sair...");
        Console.ReadLine(); // Espera o usuário pressionar Enter
    }


    static void ImprimindoTabuadaDoValorDigitado()
    {

        Console.Write("Digite um número para ver a tabuada: "); int input = int.Parse(Console.ReadLine());

        for (var i = 1; i < 11; i++)
        {
            Console.WriteLine($"{input} x {i} = {input * i}");
        }

        Console.WriteLine("Pressione Enter para sair...");
        Console.ReadLine();
    }

    static void ImprimirMaiorEMenorNumero()
    {
        List<int> numeros = new List<int>();

        while (true)
        {
            Console.Write("Digite um número (ou 'Ok' para parar): ");
            string input = Console.ReadLine();

            if (input == "Ok") break;

            if (int.TryParse(input, out int numero))
                numeros.Add(numero);
            else
                Console.WriteLine("Entrada inválida. Por favor, digite um número.");
        }

        if (numeros.Any())
        {
            Console.WriteLine($"Menor número: {numeros.Min()}");
            Console.WriteLine($"Maior número: {numeros.Max()}");
        }
        else
        {
            Console.WriteLine("Nenhum número válido foi inserido.");
        }

        Console.WriteLine("Números digitados: " + string.Join(", ", numeros));

        Console.WriteLine("\nPressione Enter para finalizar..."); Console.ReadLine();

    }
}