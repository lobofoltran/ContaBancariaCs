using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancariaCs.src.conta
{
    public class ContaBancaria
    {
        private String nome;
        private Double saldo;
        private String numero;
        private String tipo;
        private String porte;

        public ContaBancaria(String nome, Double saldo, String numero, String tipo)
        {
            this.nome = nome;
            this.saldo = saldo;
            this.numero = numero;
            this.tipo = tipo;
        }

        public String getNome()
        {
            return nome;
        }

        public Double getSaldo()
        {
            return saldo;
        }

        protected void setSaldo(Double saldo)
        {
            this.saldo = saldo;
        }

        public String getNumero()
        {
            return numero;
        }

        public String getTipo()
        {
            return tipo;
        }

        public String getPorte()
        {
            return porte;
        }

        protected String setPorte(String porte)
        {
            this.porte = porte;
            return this.porte;
        }

        public virtual void sacar(Double valor)
        {
            this.saldo -= valor;
        }

        public virtual void depositar(Double valor)
        {
            Double taxa = 0.01;
            if (this.tipo.Equals("PJ"))
            {
                taxa = 0.02;
            }
            Double desconto = valor * taxa;
            this.saldo += (valor - desconto);
        }

        public void detalhes()
        {
            System.Console.WriteLine("Conta: " + this.getNumero());
            System.Console.WriteLine("Titular: " + this.getNome());
            System.Console.WriteLine("Tipo: " + this.getTipo());
            System.Console.WriteLine("Saldo: " + this.getSaldo());
            if (porte != null)
            {
                System.Console.WriteLine("Porte: " + this.getPorte());
            }
        }

    }
}
