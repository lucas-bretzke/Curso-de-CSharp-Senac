using System;

public class Calculadora
{
    public static void Calcular()
    {
        Console.Write("Digite o primeiro valor: ");
        int value1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual operação deseja fazer?");
        Console.WriteLine("1- Adicionar");
        Console.WriteLine("2- Subtrair");
        Console.WriteLine("3- Multiplicar");
        Console.WriteLine("4- Dividir \n");

        int input = int.Parse(Console.ReadLine());

        char operadorDigitado = '+';
        double resultado = 0; // Usar double para divisão


        if (input == 1) operadorDigitado = '+';
        if (input == 2) operadorDigitado = '-';
        if (input == 3) operadorDigitado = '*';
        if (input == 4) operadorDigitado = '/';

        Console.Write("Digite o segundo valor: ");
        int value2 = int.Parse(Console.ReadLine());

        switch (operadorDigitado)
        {
            case '+':
                resultado = value1 + value2;
                break;
            case '-':
                resultado = value1 - value2;
                break;
            case '*':
                resultado = value1 * value2;
                break;
            case '/':
                if (value2 != 0)
                {
                    resultado = (double)value1 / value2; //O double neste caso serve para mostrar as casas decimais 
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida!");
                    return;
                }
                break;
        }

        Console.WriteLine($"{value1} {operadorDigitado} {value2} = {resultado}");
    }


}
