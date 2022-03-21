using ContaBancariaCs.src.conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancariaCs
{
    public class Programa1
    {
        static void Main(string[] args)
        {
            ContaBancaria conta1 = new ContaPJ("João da Silva", 500.00, "123456", "PJ");

            System.Console.WriteLine("-------- Conta PJ --------");
            System.Console.WriteLine();
            conta1.detalhes();

            conta1.depositar(100.0);
            System.Console.WriteLine();
            System.Console.WriteLine("Deposito");
            System.Console.WriteLine("Saldo: " + conta1.getSaldo());

            conta1.sacar(100.0);
            System.Console.WriteLine();
            System.Console.WriteLine("Saque 1");
            System.Console.WriteLine("Saldo: " + conta1.getSaldo());

            conta1.sacar(100.0);
            System.Console.WriteLine();
            System.Console.WriteLine("Saque 2");
            System.Console.WriteLine("Saldo: " + conta1.getSaldo());

            conta1.sacar(100.0);
            System.Console.WriteLine();
            System.Console.WriteLine("Saque 3");
            System.Console.WriteLine("Saldo: " + conta1.getSaldo());

            conta1.sacar(100.0);
            System.Console.WriteLine();
            System.Console.WriteLine("Saque 4");
            System.Console.WriteLine("Saldo: " + conta1.getSaldo());

            ContaBancaria conta2 = new ContaPF("João da Silva", 500.00, "123456", "PF");

            System.Console.WriteLine();
            System.Console.WriteLine("-------- Conta PF --------");
            System.Console.WriteLine();
            conta2.detalhes();

            conta2.depositar(100.0);
            System.Console.WriteLine();
            System.Console.WriteLine("Deposito");
            System.Console.WriteLine("Saldo: " + conta2.getSaldo());

            conta2.sacar(100.0);
            System.Console.WriteLine();
            System.Console.WriteLine("Saque 1");
            System.Console.WriteLine("Saldo: " + conta2.getSaldo());

            conta2.sacar(100.0);
            System.Console.WriteLine();
            System.Console.WriteLine("Saque 2");
            System.Console.WriteLine("Saldo: " + conta2.getSaldo());

            conta2.sacar(100.0);
            System.Console.WriteLine();
            System.Console.WriteLine("Saque 3");
            System.Console.WriteLine("Saldo: " + conta2.getSaldo());

            conta2.sacar(100.0);
            System.Console.WriteLine();
            System.Console.WriteLine("Saque 4");
            System.Console.WriteLine("Saldo: " + conta2.getSaldo());

            ContaBancaria conta3 = new ContaPR("João da Silva", 500.00, "123456", "PR", "Grande");

            System.Console.WriteLine();
            System.Console.WriteLine("-------- Conta PR --------");
            System.Console.WriteLine();
            conta3.detalhes();

            conta3.depositar(100.0);
            System.Console.WriteLine();
            System.Console.WriteLine("Deposito");
            System.Console.WriteLine("Saldo: " + conta3.getSaldo());

            conta3.sacar(100.0);
            System.Console.WriteLine();
            System.Console.WriteLine("Saque 1");
            System.Console.WriteLine("Saldo: " + conta3.getSaldo());

            conta3.sacar(100.0);
            System.Console.WriteLine();
            System.Console.WriteLine("Saque 2");
            System.Console.WriteLine("Saldo: " + conta3.getSaldo());

            conta3.sacar(100.0);
            System.Console.WriteLine();
            System.Console.WriteLine("Saque 3");
            System.Console.WriteLine("Saldo: " + conta3.getSaldo());

            conta3.sacar(100.0);
            System.Console.WriteLine();
            System.Console.WriteLine("Saque 4");
            System.Console.WriteLine("Saldo: " + conta3.getSaldo());
            System.Console.WriteLine();

            System.Console.WriteLine("Porte: " + conta3.getPorte());
            System.Console.WriteLine();
        }
    }
}
