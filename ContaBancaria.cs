using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

public class ContaPJ : ContaBancaria
{
    public ContaPJ(string nome, double saldo, string numero, string tipo) : base(nome, saldo, numero, tipo)
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

public class ContaPF : ContaBancaria
{
	private int saquesDisponiveis = 0;

	public ContaPF(string nome, double saldo, string numero, string tipo) : base(nome, saldo, numero, tipo)
	{
	}

	public override void depositar(Double valor)
	{
		Double desconto = (valor * 1) / 100;
		Double saldo = getSaldo();
		saldo += (valor - desconto);
		setSaldo(saldo);
	}

	public override void sacar(Double valor)
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


public class ContaPR : ContaBancaria
{
	private int saquesDisponiveis = 0;

	public ContaPR(string nome, double saldo, string numero, string tipo, string porte) : base(nome, saldo, numero, tipo)
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
