using System;

public class Calculadora
{
    public double Somar(double a, double b)
    {
        return a + b;
    }

    public double Subtrair(double a, double b)
    {
        return a - b;
    }

    public double Multiplicar(double a, double b)
    {
        return a * b;
    }

    public double Dividir(double a, double b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            Console.WriteLine("Erro: Divisão por zero!");
            return double.NaN; // Retorna "Não é um número" em caso de divisão por zero.
        }
    }
}
