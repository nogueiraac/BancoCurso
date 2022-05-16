using System;
using System.Globalization;

namespace BancoCurso {
    class Program {
        static void Main(string[] args) {
            Conta conta;

            Console.Write("Digite o número da conta: ");
            int numero = Int32.Parse(Console.ReadLine());

            Console.Write("Digite o titular da conta: ");
            string titular = Console.ReadLine();
            
            Console.Write("Haverá depóstio inicial (s/n) ? ");
            char respostaSaldo = char.Parse(Console.ReadLine());

            if (respostaSaldo == 's' || respostaSaldo == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numero, titular, saldoInicial);
            } else {
                conta = new Conta(numero, titular);
            }

            Console.WriteLine("\nDados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

        }
    }
}
