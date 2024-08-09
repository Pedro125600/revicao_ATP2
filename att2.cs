using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("De o seu nome :");
            string nome = Console.ReadLine();
            Console.Write("De o saldo inicial :");
            double saldo = double.Parse(Console.ReadLine());

            ContaBancaria conta = new ContaBancaria(nome, saldo);

            int resp = 0;
            while(resp != 4)
            {
                Console.WriteLine("Você deseja sacar-01 depositar-02 Exibir-03 sair-04");
                resp = int.Parse(Console.ReadLine());

                int valor = 0;

                switch (resp)
                {
                    case 1:Console.WriteLine("Quanto deseja sacar?");
                        valor = int.Parse(Console.ReadLine());
                        conta.Sacar(valor);
                        break;
                    case 2:
                        Console.WriteLine("Quanto deseja depositar?");
                        valor = int.Parse(Console.ReadLine());
                        conta.Depositar(valor);
                        break;
                    case 3:
                        Console.WriteLine($"O valor do saldo: {conta.Exibir()}");
                        break;
                }

            }




            Console.ReadLine();
        }
    }

    class ContaBancaria
    {
        private string titular;
        private double saldo;

        public string Titular
        {
            get { return titular; }
            set { this.titular = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { this.saldo = value; }
        }

        public void Depositar(double deposito)
        {
            this.saldo += deposito;
        }

        public void Sacar(double saque)
        {
            this.saldo -= saque;
        }

        public double Exibir()
        {
            return this.saldo;
        }

        public ContaBancaria(string nome , double saldo)
        {
            this.titular = nome;
            this.saldo = saldo;
        }

    }
}
