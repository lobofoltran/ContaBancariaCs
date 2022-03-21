using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Programa1
{
	static void Main(string[] args)
	{
		ContaBancaria conta1 = new ContaPF("João da Silva", 800.00, "123456", "PF");

		conta1.depositar(100.0);
		System.Console.WriteLine("Deposito");
		System.Console.WriteLine();
		conta1.detalhes();
	}
}

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

	public void sacar(Double valor)
	{
		this.saldo -= valor;
	}

	public void depositar(Double valor)
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

public class ContaPF : ContaBancaria
{
	private int saquesDisponiveis = 0;

    public ContaPF(string nome, double saldo, string numero, string tipo) : base(nome, saldo, numero, tipo)
    {
	}

    public new void depositar(Double valor)
	{
		Double desconto = (valor * 1) / 100;
		Double saldo = getSaldo();
		saldo += (valor - desconto);
		setSaldo(saldo);
	}

	public new void sacar(Double valor)
	{	
		Double desconto = 0.00;
		if (valor > getSaldo())
		{
			System.Console.WriteLine("Conta PF não pode ficar com saldo negativo!");
			return;
		}
		saquesDisponiveis++;
		if (this.saquesDisponiveis > 3)
		{
			desconto = (valor * 1) / 100;
		}
		Double saldo = getSaldo();
		saldo = saldo - (valor - desconto);
		setSaldo(saldo);
	}
}
