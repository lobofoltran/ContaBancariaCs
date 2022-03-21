using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancariaCs.src.conta
{
    public class ContaPR : ContaBancaria
    {
        private int saquesDisponiveis = 0;

        public ContaPR(string nome, double saldo, string numero, string tipo, string porte)
            : base(nome, saldo, numero, tipo)
        {
            setPorte(porte);
        }

        public override void depositar(Double valor)
        {
            Double desconto = 0.00;
            if (valor < 1000)
            {
                desconto = (valor * 0.8) / 100;
            }
            Double saldo = getSaldo();
            saldo += (valor - desconto);
            setSaldo(saldo);
        }

        public override void sacar(Double valor)
        {
            Double desconto = 0.00;
            if (valor > getSaldo())
            {
                System.Console.WriteLine("Conta PR não pode ficar com saldo negativo!");
                return;
            }
            saquesDisponiveis++;
            if (this.saquesDisponiveis > 3)
            {
                desconto = (valor * 1.5) / 100;
            }
            Double saldo = getSaldo();
            saldo = saldo - (valor - desconto);
            setSaldo(saldo);
            return;
        }
    }
}
