using ExercicioAula60FazendoJunto02;
using System;
using System.Globalization;

namespace MyApp // ExercicioAula60FazendoJunto02
{
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            ContaBancaria conta;

            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial(s / n) ? ");
            char teste = char.Parse(Console.ReadLine());

            if (teste == 's' || teste == 'S') {
                Console.Write("Digite o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CI);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Digite um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CI);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Digite um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CI);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);



        }
    }
}

