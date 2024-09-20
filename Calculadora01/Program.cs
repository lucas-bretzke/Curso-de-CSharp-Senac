using System;

class Program
{
    static void Main()
    {
        // Instanciar a calculadora
        Calculadora calc = new Calculadora();

        // Exemplo de uso da calculadora
        double num1 = 10;
        double num2 = 5;

        Console.WriteLine("Soma: " + calc.Somar(num1, num2));
        Console.WriteLine("Subtração: " + calc.Subtrair(num1, num2));
        Console.WriteLine("Multiplicação: " + calc.Multiplicar(num1, num2));
        Console.WriteLine("Divisão: " + calc.Dividir(num1, num2));
    }
}
