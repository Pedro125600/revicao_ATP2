using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att5
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo programador = new Triangulo(default, default, default);

            Console.Write("Lado 1:");
            int l1 = int.Parse(Console.ReadLine());

            Console.Write("Lado 1:");
            int l2 = int.Parse(Console.ReadLine());

            Console.Write("Lado 1:");
            int l3 = int.Parse(Console.ReadLine());

            Triangulo usuario = new Triangulo(l1,l2,l3);

            Console.WriteLine("Programador");
            Console.WriteLine($"Lado 1 : {programador.Lado1}");
            Console.WriteLine($"Lado 2 : {programador.Lado2}");
            Console.WriteLine($"Lado 3 : {programador.Lado3}");

            Console.WriteLine("usuario");
            Console.WriteLine($"Lado 1 : {usuario.Lado1}");
            Console.WriteLine($"Lado 2 : {usuario.Lado2}");
            Console.WriteLine($"Lado 3 : {usuario.Lado3}");

            Console.ReadLine();
        }
    }

    class Triangulo
    {
        private double lado1;
        private double lado2;
        private double lado3;

        public double Lado1
        {
            get { return this.lado1; }
            set { this.lado1 = value; }
        }
        public double Lado2
        {
            get { return this.lado2; }
            set { this.lado2 = value; }
        }
        public double Lado3
        {
            get { return this.lado3; }
            set { this.lado1 = value; }
        }

        public Triangulo(double l1 ,double l2,double l3)
        {
            this.lado1 = l1;
            this.lado2 = l2;
            this.lado3 = l3;
        }
    }
}
