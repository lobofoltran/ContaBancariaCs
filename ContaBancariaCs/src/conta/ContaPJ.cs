using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancariaCs.src.conta
{
    public class ContaPJ : ContaBancaria
    {
        public ContaPJ(string nome, double saldo, string numero, string tipo)
            : base(nome, saldo, numero, tipo)
        {
        }

        public override void depositar(Double valor)
        {
            Double desconto = (valor * 2) / 100;
            Double saldo = getSaldo();
            saldo += (valor - desconto);
            setSaldo(saldo);
        }

        public override void sacar(Double valor)
        {
            Double saldo = getSaldo();
            saldo = saldo - valor;
            setSaldo(saldo);
        }
    }
}
