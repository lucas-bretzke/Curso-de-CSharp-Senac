using System;

namespace Trabalhando_com_Classes
{
    public class ContaBancaria
    {
        private static int _contagemContasCadastradas = 0;
        public static int ContagemContasCadastradas => _contagemContasCadastradas;
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(string titular)
        {
            Titular = titular;
            _contagemContasCadastradas++;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de depósito deve ser positivo.");
                return;
            }

            Saldo += valor;
            Console.WriteLine($"Valor de {valor} depositado. Saldo atual: {Saldo}");
        }

        public void Sacar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de saque deve ser positivo.");
                return;
            }

            if (Saldo < valor)
            {
                Console.WriteLine("Saque não realizado. Saldo insuficiente.");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado. Saldo atual: {Saldo}");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo da conta de {Titular} é: {Saldo}");
        }
    }
}
