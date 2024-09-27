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
        //DeclararVariavelAtribuirValorEMultiplicarPorValorDigitado();
        //DeclararVariavelEMultiplicarPeloValorDigitado();
        //VerificaNumerosIguais();
        //VerificaNumerosDiferentes();
        //VerificaSePrimeiroNumeroEMaiorQueOSegundo();
        //VerificaSePrimeiroNumeroEMenorQueOSegundo();
        //VerificaSePrimeiroNumeroEMaiorOuIgualAoOSegundo();
        //VerificaSeAmbosSaoMaioresQueZero();
        //VerificaSeAmbosOuAlgumEMaioresQueZero();
        //VerificaIdade();
        //VerificaNumeroPar();
        VerificaNumeroMaiorQueZero();

        //VerificaSePodeEntrarNaFesta("João");
        //PosicaoDoNomeNoAlfabeto();
        //LidandoComFor();
        //ImprimindoTabuadaDoValorDigitado();
        //ImprimirMaiorEMenorNumero();
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

        Console.WriteLine("Precione Enter para finalizar");
        Console.ReadLine();
    }

    static void DeclararVariavelAtribuirValorEMultiplicarPorValorDigitado()
    {
        int n1 = 5;
        int n2 = 5;

        Console.Write("Digite um número: "); int input = int.Parse(Console.ReadLine());
        Console.WriteLine($"{n1} + {n2} x {input} é = {(n1 + n2) * input}");

        Console.WriteLine("Precione Enter para finalizar");
        Console.ReadLine();

    }

    static void DeclararVariavelEMultiplicarPeloValorDigitado()
    {
        int n1 = 10;

        Console.Write($"Digite um número para ser dividido por {n1}: "); int input = int.Parse(Console.ReadLine());
        Console.WriteLine($"{n1} / {input} é = {n1 / input}");

        Console.WriteLine("Precione Enter para finalizar");
        Console.ReadLine();

    }


    // Operadores Relacionais

    static void VerificaNumerosIguais()
    {
        Console.WriteLine("Digite um numero: "); int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um numero: "); int n2 = int.Parse(Console.ReadLine());

        string res = n1 == n2 ? "São iguais" : "São diferentes";

        Console.WriteLine(res);
        Console.ReadLine();
    }

    static void VerificaNumerosDiferentes()
    {
        Console.WriteLine("Digite um numero: "); int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um numero: "); int n2 = int.Parse(Console.ReadLine());

        string res = n1 != n2 ? "São diferentes" : "São iguais";

        Console.WriteLine(res);
        Console.ReadLine();
    }

    static void VerificaSePrimeiroNumeroEMaiorQueOSegundo()
    {
        Console.WriteLine("Digite um numero: "); int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um numero: "); int n2 = int.Parse(Console.ReadLine());

        string res = n1 > n2 ? "O primeiro numero digitado é maior" : "O primeiro numero digitado é menor";

        Console.WriteLine(res);
        Console.ReadLine();
    }

    static void VerificaSePrimeiroNumeroEMenorQueOSegundo()
    {
        Console.WriteLine("Digite um numero: "); int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um numero: "); int n2 = int.Parse(Console.ReadLine());

        string res = n1 < n2 ? "O primeiro numero digitado é menor" : "O primeiro numero digitado é maior";

        Console.WriteLine(res);
        Console.ReadLine();
    }

    static void VerificaSePrimeiroNumeroEMaiorOuIgualAoOSegundo()
    {
        Console.WriteLine("Digite um numero: "); int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um numero: "); int n2 = int.Parse(Console.ReadLine());

        string res = n1 >= n2 ? "O primeiro numero digitado é Maior ou igual" : "O primeiro numero digitado é menor";

        Console.WriteLine(res);
        Console.ReadLine();
    }


    // Operadores Lógicos

    static void VerificaSeAmbosSaoMaioresQueZero()
    {
        Console.WriteLine("Digite um numero: "); int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um numero: "); int n2 = int.Parse(Console.ReadLine());

        string res = (n1 > 0 && n2 > 0) ? "Ambos são maior que zero" : "Ambos ou algum não é maior que zero";

        Console.WriteLine(res);
        Console.ReadLine();
    }

    static void VerificaSeAmbosOuAlgumEMaioresQueZero()
    {
        Console.WriteLine("Digite um numero: "); int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um numero: "); int n2 = int.Parse(Console.ReadLine());

        string res = (n1 > 0 || n2 > 0) ? "Ambos ou algum deles é maior que zero" : "Nenhum deles é maior que zero";

        Console.WriteLine(res);
        Console.ReadLine();
    }


    // Operadores Ternários

    static void VerificaIdade()
    {
        Console.WriteLine("Digite sua idade: "); int idade = int.Parse(Console.ReadLine());

        string res = idade >= 18 ? "É maior de idade" : "É menor de idade";

        Console.WriteLine(res);
        Console.ReadLine();
    }

    static void VerificaNumeroPar()
    {
        Console.WriteLine("Digite um numero: "); int n1 = int.Parse(Console.ReadLine());

        string res = n1 % 2 == 0 ? "É Par" : "É Impar";

        Console.WriteLine(res);
        Console.ReadLine();
    }

    static void VerificaNumeroMaiorQueZero()
    {
        Console.WriteLine("Digite um numero: "); int n1 = int.Parse(Console.ReadLine());

        string res = n1 > 0 ? "Positivo, é maior que zero" : n1 == 0 ? "É zero" : "Negativo, é menor que zero";

        Console.WriteLine(res);
        Console.ReadLine();
    }


    // Exercicios a parte 

    static void VerificaSePodeEntrarNaFesta(string name)
    {
        List<string> lista = new List<string>();
        lista.Add("Ana");
        lista.Add("Maria");
        lista.Add("João");

        Console.WriteLine(lista.Contains(name) ? $"Pode entrar {name}" : $"Desculpe {name}, seu nome não está na lista");

        Console.ReadLine();
    }

    static void PosicaoDoNomeNoAlfabeto()
    {
        Console.Write("Digite um nome: ");
        string name = Console.ReadLine();

        // Usando operador ternário
        string resultado = char.ToUpper(name[0]) <= 'H' ? "Está entre A e H" :
            char.ToUpper(name[0]) <= 's' ? "Está entre I e S" : "Está entre T e Z";

        Console.WriteLine($"{name}: {resultado}");

        // Usando switch case
        switch (char.ToUpper(name[0]))
        {
            case >= 'A' and <= 'H':
                Console.WriteLine("Está entre A e H");
                break;
            case >= 'I' and <= 'S':
                Console.WriteLine("Está entre I e S");
                break;
            case >= 'T' and <= 'Z':
                Console.WriteLine("Está entre T e Z");
                break;
            default:
                Console.WriteLine("Caractere inválido.");
                break;
        }

        Console.ReadLine();


    }


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